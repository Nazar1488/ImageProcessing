using System;
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

        public Form1()
        {
            InitializeComponent();
        }

        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                var file = new FileInfo(openFileDialog.FileName);
                image = Image.FromFile(openFileDialog.FileName);
                imageSizeLabel.Text = $@"{file.Length / 1024} kb";
                pictureBox.Image = image;
            }
        }

        private void SaveAsBmpBtn_Click(object sender, EventArgs e)
        {
            saveFileDialog.Filter = @"bmp(*.bmp)|*.bmp";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                var encoderParameters = new EncoderParameters(1)
                {
                    Param = new[]
                    {
                        new EncoderParameter(Encoder.Compression, (long) EncoderValue.CompressionRle)
                    }
                };

                var stopwatch = new Stopwatch();
                stopwatch.Start();
                image.Save(saveFileDialog.FileName, GetEncoderInfo("image/bmp"), encoderParameters);
                stopwatch.Stop();
                writingTime.Text = stopwatch.Elapsed.Milliseconds + @" ms";

                stopwatch.Restart();
                bmpImage = Image.FromFile(saveFileDialog.FileName);
                stopwatch.Stop();
                readingTime.Text = stopwatch.Elapsed.Milliseconds + @" ms";

                stopwatch.Restart();
                var bitmapEncodedImage = (Bitmap) image;
                stopwatch.Stop();
                encodingTime.Text = stopwatch.Elapsed.Milliseconds + @" ms";

                imageSizeAfterLabel.Text = new FileInfo(saveFileDialog.FileName).Length / 1024 + @" kb";

                if (bmpImage != null && tiffImage != null) bmpDiffTiffBtn.Enabled = true;

                if (bmpImage != null && jpegImage != null) bmpDiffJpegBtn.Enabled = true;
            }
        }

        private void SaveAsTiffBtn_Click(object sender, EventArgs e)
        {
            saveFileDialog.Filter = @"tif(*.tif)|*.tif";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                var encoderParameters = new EncoderParameters(1)
                {
                    Param = new[]
                    {
                        new EncoderParameter(Encoder.Compression, (long) EncoderValue.CompressionLZW)
                    }
                };

                var stopwatch = new Stopwatch();
                stopwatch.Start();
                image.Save(saveFileDialog.FileName, ImageFormat.Tiff);
                stopwatch.Stop();
                writingTime.Text = stopwatch.Elapsed.Milliseconds + @" ms";

                stopwatch.Restart();
                tiffImage = Image.FromFile(saveFileDialog.FileName);
                stopwatch.Stop();
                readingTime.Text = stopwatch.Elapsed.Milliseconds + @" ms";

                stopwatch.Restart();
                var bitmapEncodedImage = (Bitmap) image;
                stopwatch.Stop();
                encodingTime.Text = stopwatch.Elapsed.Milliseconds + @" ms";

                imageSizeAfterLabel.Text = new FileInfo(saveFileDialog.FileName).Length / 1024 + @" kb";

                if (bmpImage != null && tiffImage != null) bmpDiffTiffBtn.Enabled = true;

                if (jpegImage != null && tiffImage != null) tiffDiffJpegBtn.Enabled = true;
            }
        }

        private void SaveAsJpegBtn_Click(object sender, EventArgs e)
        {
            saveFileDialog.Filter = @"jpeg(*.jpeg)|*.jpeg";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                var encoderParameters = new EncoderParameters(1)
                {
                    Param = new[]
                    {
                        new EncoderParameter(Encoder.Compression, (long) EncoderValue.CompressionLZW)
                    }
                };

                var stopwatch = new Stopwatch();
                stopwatch.Start();
                image.Save(saveFileDialog.FileName, ImageFormat.Jpeg);
                stopwatch.Stop();
                writingTime.Text = stopwatch.Elapsed.Milliseconds + @" ms";

                stopwatch.Restart();
                jpegImage = Image.FromFile(saveFileDialog.FileName);
                stopwatch.Stop();
                readingTime.Text = stopwatch.Elapsed.Milliseconds + @" ms";

                stopwatch.Restart();
                var bitmapEncodedImage = (Bitmap) image;
                stopwatch.Stop();
                encodingTime.Text = stopwatch.Elapsed.Milliseconds + @" ms";

                imageSizeAfterLabel.Text = new FileInfo(saveFileDialog.FileName).Length / 1024 + @" kb";

                if (jpegImage != null && bmpImage != null) bmpDiffJpegBtn.Enabled = true;

                if (jpegImage != null && tiffImage != null) tiffDiffJpegBtn.Enabled = true;
            }
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
            image = Image.FromHbitmap(diff.GetHbitmap());
            redColorLabel.Text = rgbColor.R.ToString();
            greenColorLabel.Text = rgbColor.G.ToString();
            blueColorLabel.Text = rgbColor.B.ToString();
            pictureBox.Image = image;
        }

        private static ImageCodecInfo GetEncoderInfo(string mimeType)
        {
            return ImageCodecInfo.GetImageEncoders().FirstOrDefault(t => t.MimeType == mimeType);
        }

        private void BmpDiffTiffBtn_Click(object sender, EventArgs e)
        {
            ImagesDifferenceAsync(bmpImage, tiffImage);
        }

        private void BmpDiffJpegBtn_Click(object sender, EventArgs e)
        {
            ImagesDifferenceAsync(bmpImage, jpegImage);
        }

        private void TiffDiffJpegBtn_Click(object sender, EventArgs e)
        {
            ImagesDifferenceAsync(tiffImage, jpegImage);
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}