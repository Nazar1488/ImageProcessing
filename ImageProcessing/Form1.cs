using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageProcessing
{
    public partial class Form1 : Form
    {
        private Image image;
        private Image bmpImage;
        private Image tiffImage;
        private Image jpegImage;
        private RGB rgb;
        private Bitmap diff;

        public Form1()
        {
            InitializeComponent();
            saveAsComboBox.DataSource = Enum.GetValues(typeof(Formats));
            firstDiffComboBox.DataSource = Enum.GetValues(typeof(Formats));
            secondDiffComboBox.DataSource = Enum.GetValues(typeof(Formats));
        }

        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                var file = new FileInfo(openFileDialog.FileName);
                image = Image.FromFile(openFileDialog.FileName);
                imageSizeLabel.Text = $@"{file.Length / 1024} kb";
                pictureBox.Image = image;
                saveAsBmpBtn.Enabled = true;
                findDiffBtn.Enabled = true;
                bmpImage = null;
                tiffImage = null;
                jpegImage = null;
            }
        }

        private void saveAsBmpBtn_Click(object sender, EventArgs e)
        {
            switch (saveAsComboBox.SelectedItem)
            {
                case Formats.JPEG:
                    SaveAs("jpeg(*.jpeg)|*.jpeg", "image/jpeg", EncoderValue.CompressionNone, Formats.JPEG);
                    break;
                case Formats.BMP:
                    SaveAs("bmp(*.bmp)|*.bmp", "image/tiff", EncoderValue.CompressionRle, Formats.BMP);
                    break;
                case Formats.TIFF:
                    SaveAs("tiff(*.tiff)|*.tiff", "image/tiff", EncoderValue.CompressionLZW, Formats.TIFF);
                    break;
                default:
                    return;
            }
        }

        private void SaveAs(string filter, string encoder, EncoderValue encoderValue, Formats format)
        {
            saveFileDialog.Filter = filter;
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                var encoderParameters = new EncoderParameters(1)
                {
                    Param = new[]
                    {
                        new EncoderParameter(Encoder.Compression, (long) encoderValue)
                    }
                };

                var stopwatch = new Stopwatch();
                stopwatch.Start();
                var stream = new FileStream(saveFileDialog.FileName, FileMode.Create);
                stopwatch.Stop();
                writingTime.Text = stopwatch.Elapsed.TotalMilliseconds + @" ms";

                stopwatch.Restart();
                image.Save(stream, GetEncoderInfo(encoder), encoderParameters);
                stopwatch.Stop();
                encodingTime.Text = stopwatch.Elapsed.TotalMilliseconds + @" ms";

                stream.Dispose();

                stopwatch.Restart();
                switch (format)
                {
                    case Formats.BMP:
                        bmpImage = Image.FromFile(saveFileDialog.FileName);
                        break;
                    case Formats.JPEG:
                        jpegImage = Image.FromFile(saveFileDialog.FileName);
                        break;
                    case Formats.TIFF:
                        tiffImage = Image.FromFile(saveFileDialog.FileName);
                        break;
                    default:
                        return;
                }

                stopwatch.Stop();
                readingTime.Text = stopwatch.Elapsed.TotalMilliseconds + @" ms";

                stopwatch.Restart();
                image.Save("test.bmp", GetEncoderInfo("image/bmp"), new EncoderParameters(1)
                {
                    Param = new[]
                    {
                        new EncoderParameter(Encoder.Compression, (long) EncoderValue.CompressionNone)
                    }
                });

                stopwatch.Stop();
                decodingTime.Text = stopwatch.Elapsed.TotalMilliseconds + @" ms";

                imageSizeAfterLabel.Text = new FileInfo(saveFileDialog.FileName).Length / 1024 + @" kb";
            }
        }

        private void findDiffBtn_Click(object sender, EventArgs e)
        {
            Image first;
            Image second;

            switch (firstDiffComboBox.SelectedItem)
            {
                case Formats.Original:
                    first = image;
                    break;
                case Formats.JPEG:
                    first = jpegImage;
                    break;
                case Formats.BMP:
                    first = bmpImage;
                    break;
                case Formats.TIFF:
                    first = tiffImage;
                    break;
                default:
                    return;
            }

            switch (secondDiffComboBox.SelectedItem)
            {
                case Formats.Original:
                    second = image;
                    break;
                case Formats.JPEG:
                    second = jpegImage;
                    break;
                case Formats.BMP:
                    second = bmpImage;
                    break;
                case Formats.TIFF:
                    second = tiffImage;
                    break;
                default:
                    return;
            }

            if (first == null || second == null)
            {
                MessageBox.Show("Convert to specified format first", "Info", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                return;
            }

            backgroundWorker.RunWorkerAsync(new[] {first, second});
        }

        private async void ImagesDifferenceAsync(Image firstImage, Image secondImage)
        {
            var width = firstImage.Width;
            var height = firstImage.Height;
            var first = (Bitmap) firstImage;
            var second = (Bitmap) secondImage;
            var diff = new Bitmap(width, height);
            var rgbColor = new RGB();
            await Task.Run(() =>
            {
                const int multiplier = 6;
                for (var i = 0; i < width; ++i)
                for (var j = 0; j < height; ++j)
                {
                    var r = allColorsRadio.Checked || redColorRadio.Checked
                        ? Math.Abs(first.GetPixel(i, j).R - second.GetPixel(i, j).R)
                        : 0;
                    var g = allColorsRadio.Checked || greenColorRadio.Checked
                        ? Math.Abs(first.GetPixel(i, j).G - second.GetPixel(i, j).G)
                        : 0;
                    var b = allColorsRadio.Checked || blueColorRadio.Checked
                        ? Math.Abs(first.GetPixel(i, j).B - second.GetPixel(i, j).B)
                        : 0;
                    rgbColor.Append(r, g, b);
                    r *= multiplier;
                    g *= multiplier;
                    b *= multiplier;
                    r = r > 255 ? 255 : r;
                    g = g > 255 ? 255 : g;
                    b = b > 255 ? 255 : b;
                    diff.SetPixel(i, j, Color.FromArgb(byte.MaxValue, r, g, b));
                }
            });

            rgb = rgbColor;
            this.diff = diff;
        }

        private static ImageCodecInfo GetEncoderInfo(string mimeType)
        {
            return ImageCodecInfo.GetImageEncoders().FirstOrDefault(t => t.MimeType == mimeType);
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void backgroundWorker_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            var images = (Image[])e.Argument;
            var width = images[0].Width;
            var height = images[1].Height;
            var first = (Bitmap)images[0];
            var second = (Bitmap)images[1];
            var diff = new Bitmap(width, height);
            var rgbColor = new RGB();
            const int multiplier = 6;
            for (var i = 0; i < width; ++i)
            for (var j = 0; j < height; ++j)
            {
                var r = allColorsRadio.Checked || redColorRadio.Checked
                    ? Math.Abs(first.GetPixel(i, j).R - second.GetPixel(i, j).R)
                    : 0;
                var g = allColorsRadio.Checked || greenColorRadio.Checked
                    ? Math.Abs(first.GetPixel(i, j).G - second.GetPixel(i, j).G)
                    : 0;
                var b = allColorsRadio.Checked || blueColorRadio.Checked
                    ? Math.Abs(first.GetPixel(i, j).B - second.GetPixel(i, j).B)
                    : 0;
                rgbColor.Append(r, g, b);
                r *= multiplier;
                g *= multiplier;
                b *= multiplier;
                r = r > 255 ? 255 : r;
                g = g > 255 ? 255 : g;
                b = b > 255 ? 255 : b;
                diff.SetPixel(i, j, Color.FromArgb(byte.MaxValue, r, g, b));
                backgroundWorker.ReportProgress(i * 100 / width);
            }

            rgb = rgbColor;
            this.diff = diff;
            backgroundWorker.ReportProgress(100);
        }

        private void backgroundWorker_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            redColorLabel.Text = rgb.R.ToString();
            greenColorLabel.Text = rgb.G.ToString();
            blueColorLabel.Text = rgb.B.ToString();
            pictureBox.Image = Image.FromHbitmap(diff.GetHbitmap());
            MessageBox.Show("Completed!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void backgroundWorker_ProgressChanged(object sender, System.ComponentModel.ProgressChangedEventArgs e)
        {
            progressBar.Value = e.ProgressPercentage;
        }
    }
}