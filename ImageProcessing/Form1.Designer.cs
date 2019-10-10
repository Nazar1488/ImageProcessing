namespace ImageProcessing
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.blueColorLabel = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.greenColorLabel = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.redColorLabel = new System.Windows.Forms.Label();
            this.blueColorRadio = new System.Windows.Forms.RadioButton();
            this.greenColorRadio = new System.Windows.Forms.RadioButton();
            this.redColorRadio = new System.Windows.Forms.RadioButton();
            this.allColorsRadio = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.imageSizeAfterLabel = new System.Windows.Forms.Label();
            this.imageSizeLabel = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.findDiffBtn = new System.Windows.Forms.Button();
            this.secondDiffComboBox = new System.Windows.Forms.ComboBox();
            this.firstDiffComboBox = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.saveAsComboBox = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.saveAsBmpBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.writingTime = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.encodingTime = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.decodingTime = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.readingTime = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.progressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox.Location = new System.Drawing.Point(458, 47);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(500, 500);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(970, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.toolStripSeparator,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripMenuItem.Image")));
            this.openToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.openToolStripMenuItem.Text = "&Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.OpenToolStripMenuItem_Click);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(143, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "image";
            this.openFileDialog.Filter = "bmp(*.bmp)|*.bmp";
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.FileName = "image";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.groupBox5);
            this.panel1.Controls.Add(this.groupBox4);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(12, 47);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(440, 500);
            this.panel1.TabIndex = 2;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.Location = new System.Drawing.Point(263, 65);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(38, 16);
            this.label14.TabIndex = 20;
            this.label14.Text = "Blue:";
            // 
            // blueColorLabel
            // 
            this.blueColorLabel.AutoSize = true;
            this.blueColorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.blueColorLabel.Location = new System.Drawing.Point(317, 66);
            this.blueColorLabel.Name = "blueColorLabel";
            this.blueColorLabel.Size = new System.Drawing.Size(15, 16);
            this.blueColorLabel.TabIndex = 21;
            this.blueColorLabel.Text = "0";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(263, 42);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(48, 16);
            this.label12.TabIndex = 18;
            this.label12.Text = "Green:";
            // 
            // greenColorLabel
            // 
            this.greenColorLabel.AutoSize = true;
            this.greenColorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.greenColorLabel.Location = new System.Drawing.Point(317, 42);
            this.greenColorLabel.Name = "greenColorLabel";
            this.greenColorLabel.Size = new System.Drawing.Size(15, 16);
            this.greenColorLabel.TabIndex = 19;
            this.greenColorLabel.Text = "0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(263, 19);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(37, 16);
            this.label11.TabIndex = 13;
            this.label11.Text = "Red:";
            // 
            // redColorLabel
            // 
            this.redColorLabel.AutoSize = true;
            this.redColorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.redColorLabel.Location = new System.Drawing.Point(317, 20);
            this.redColorLabel.Name = "redColorLabel";
            this.redColorLabel.Size = new System.Drawing.Size(15, 16);
            this.redColorLabel.TabIndex = 14;
            this.redColorLabel.Text = "0";
            // 
            // blueColorRadio
            // 
            this.blueColorRadio.AutoSize = true;
            this.blueColorRadio.Location = new System.Drawing.Point(16, 88);
            this.blueColorRadio.Name = "blueColorRadio";
            this.blueColorRadio.Size = new System.Drawing.Size(46, 17);
            this.blueColorRadio.TabIndex = 17;
            this.blueColorRadio.TabStop = true;
            this.blueColorRadio.Text = "Blue";
            this.blueColorRadio.UseVisualStyleBackColor = true;
            // 
            // greenColorRadio
            // 
            this.greenColorRadio.AutoSize = true;
            this.greenColorRadio.Location = new System.Drawing.Point(16, 65);
            this.greenColorRadio.Name = "greenColorRadio";
            this.greenColorRadio.Size = new System.Drawing.Size(54, 17);
            this.greenColorRadio.TabIndex = 16;
            this.greenColorRadio.TabStop = true;
            this.greenColorRadio.Text = "Green";
            this.greenColorRadio.UseVisualStyleBackColor = true;
            // 
            // redColorRadio
            // 
            this.redColorRadio.AutoSize = true;
            this.redColorRadio.BackColor = System.Drawing.SystemColors.Control;
            this.redColorRadio.Location = new System.Drawing.Point(17, 42);
            this.redColorRadio.Name = "redColorRadio";
            this.redColorRadio.Size = new System.Drawing.Size(45, 17);
            this.redColorRadio.TabIndex = 15;
            this.redColorRadio.TabStop = true;
            this.redColorRadio.Text = "Red";
            this.redColorRadio.UseVisualStyleBackColor = false;
            // 
            // allColorsRadio
            // 
            this.allColorsRadio.AutoSize = true;
            this.allColorsRadio.Checked = true;
            this.allColorsRadio.Location = new System.Drawing.Point(17, 19);
            this.allColorsRadio.Name = "allColorsRadio";
            this.allColorsRadio.Size = new System.Drawing.Size(36, 17);
            this.allColorsRadio.TabIndex = 14;
            this.allColorsRadio.TabStop = true;
            this.allColorsRadio.Text = "All";
            this.allColorsRadio.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(39, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Before compession:";
            // 
            // imageSizeAfterLabel
            // 
            this.imageSizeAfterLabel.AutoSize = true;
            this.imageSizeAfterLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.imageSizeAfterLabel.Location = new System.Drawing.Point(173, 65);
            this.imageSizeAfterLabel.Name = "imageSizeAfterLabel";
            this.imageSizeAfterLabel.Size = new System.Drawing.Size(33, 16);
            this.imageSizeAfterLabel.TabIndex = 16;
            this.imageSizeAfterLabel.Text = "0 kb";
            // 
            // imageSizeLabel
            // 
            this.imageSizeLabel.AutoSize = true;
            this.imageSizeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.imageSizeLabel.Location = new System.Drawing.Point(173, 35);
            this.imageSizeLabel.Name = "imageSizeLabel";
            this.imageSizeLabel.Size = new System.Drawing.Size(33, 16);
            this.imageSizeLabel.TabIndex = 1;
            this.imageSizeLabel.Text = "0 kb";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(48, 65);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(119, 16);
            this.label10.TabIndex = 15;
            this.label10.Text = "After compression:";
            // 
            // findDiffBtn
            // 
            this.findDiffBtn.Enabled = false;
            this.findDiffBtn.Location = new System.Drawing.Point(343, 70);
            this.findDiffBtn.Name = "findDiffBtn";
            this.findDiffBtn.Size = new System.Drawing.Size(78, 28);
            this.findDiffBtn.TabIndex = 27;
            this.findDiffBtn.Text = "Start";
            this.findDiffBtn.UseVisualStyleBackColor = true;
            this.findDiffBtn.Click += new System.EventHandler(this.findDiffBtn_Click);
            // 
            // secondDiffComboBox
            // 
            this.secondDiffComboBox.FormattingEnabled = true;
            this.secondDiffComboBox.Location = new System.Drawing.Point(212, 75);
            this.secondDiffComboBox.Name = "secondDiffComboBox";
            this.secondDiffComboBox.Size = new System.Drawing.Size(121, 21);
            this.secondDiffComboBox.TabIndex = 26;
            // 
            // firstDiffComboBox
            // 
            this.firstDiffComboBox.FormattingEnabled = true;
            this.firstDiffComboBox.Location = new System.Drawing.Point(85, 75);
            this.firstDiffComboBox.Name = "firstDiffComboBox";
            this.firstDiffComboBox.Size = new System.Drawing.Size(121, 21);
            this.firstDiffComboBox.TabIndex = 25;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label16.Location = new System.Drawing.Point(7, 76);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(72, 16);
            this.label16.TabIndex = 24;
            this.label16.Text = "Difference:";
            // 
            // saveAsComboBox
            // 
            this.saveAsComboBox.FormattingEnabled = true;
            this.saveAsComboBox.Location = new System.Drawing.Point(82, 30);
            this.saveAsComboBox.Name = "saveAsComboBox";
            this.saveAsComboBox.Size = new System.Drawing.Size(121, 21);
            this.saveAsComboBox.TabIndex = 23;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label15.Location = new System.Drawing.Point(18, 31);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(61, 16);
            this.label15.TabIndex = 22;
            this.label15.Text = "Save as:";
            // 
            // saveAsBmpBtn
            // 
            this.saveAsBmpBtn.Enabled = false;
            this.saveAsBmpBtn.Location = new System.Drawing.Point(209, 25);
            this.saveAsBmpBtn.Name = "saveAsBmpBtn";
            this.saveAsBmpBtn.Size = new System.Drawing.Size(121, 28);
            this.saveAsBmpBtn.TabIndex = 2;
            this.saveAsBmpBtn.Text = "Save";
            this.saveAsBmpBtn.UseVisualStyleBackColor = true;
            this.saveAsBmpBtn.Click += new System.EventHandler(this.saveAsBmpBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(6, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "Writing:";
            // 
            // writingTime
            // 
            this.writingTime.AutoSize = true;
            this.writingTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.writingTime.Location = new System.Drawing.Point(75, 63);
            this.writingTime.Name = "writingTime";
            this.writingTime.Size = new System.Drawing.Size(36, 16);
            this.writingTime.TabIndex = 12;
            this.writingTime.Text = "0 ms";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(232, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Encoding:";
            // 
            // encodingTime
            // 
            this.encodingTime.AutoSize = true;
            this.encodingTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.encodingTime.Location = new System.Drawing.Point(306, 27);
            this.encodingTime.Name = "encodingTime";
            this.encodingTime.Size = new System.Drawing.Size(36, 16);
            this.encodingTime.TabIndex = 10;
            this.encodingTime.Text = "0 ms";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(232, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 16);
            this.label6.TabIndex = 7;
            this.label6.Text = "Decoding:";
            // 
            // decodingTime
            // 
            this.decodingTime.AutoSize = true;
            this.decodingTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.decodingTime.Location = new System.Drawing.Point(306, 63);
            this.decodingTime.Name = "decodingTime";
            this.decodingTime.Size = new System.Drawing.Size(36, 16);
            this.decodingTime.TabIndex = 8;
            this.decodingTime.Text = "0 ms";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(6, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Reading:";
            // 
            // readingTime
            // 
            this.readingTime.AutoSize = true;
            this.readingTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.readingTime.Location = new System.Drawing.Point(75, 27);
            this.readingTime.Name = "readingTime";
            this.readingTime.Size = new System.Drawing.Size(36, 16);
            this.readingTime.TabIndex = 6;
            this.readingTime.Text = "0 ms";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.progressBar});
            this.statusStrip1.Location = new System.Drawing.Point(0, 551);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(970, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // progressBar
            // 
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(950, 16);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.findDiffBtn);
            this.groupBox1.Controls.Add(this.secondDiffComboBox);
            this.groupBox1.Controls.Add(this.saveAsBmpBtn);
            this.groupBox1.Controls.Add(this.firstDiffComboBox);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.saveAsComboBox);
            this.groupBox1.Location = new System.Drawing.Point(6, 143);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(427, 125);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Operations";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Location = new System.Drawing.Point(6, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(427, 134);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Info";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.imageSizeLabel);
            this.groupBox3.Controls.Add(this.imageSizeAfterLabel);
            this.groupBox3.Location = new System.Drawing.Point(80, 8);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(265, 116);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Size";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.panel5);
            this.groupBox4.Controls.Add(this.panel4);
            this.groupBox4.Controls.Add(this.panel3);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.blueColorLabel);
            this.groupBox4.Controls.Add(this.allColorsRadio);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.redColorRadio);
            this.groupBox4.Controls.Add(this.greenColorLabel);
            this.groupBox4.Controls.Add(this.greenColorRadio);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.blueColorRadio);
            this.groupBox4.Controls.Add(this.redColorLabel);
            this.groupBox4.Location = new System.Drawing.Point(10, 274);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(423, 118);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Diffrenece info";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Red;
            this.panel3.Location = new System.Drawing.Point(237, 15);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(20, 20);
            this.panel3.TabIndex = 22;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Blue;
            this.panel4.Location = new System.Drawing.Point(237, 62);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(20, 20);
            this.panel4.TabIndex = 23;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Green;
            this.panel5.Location = new System.Drawing.Point(237, 38);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(20, 20);
            this.panel5.TabIndex = 24;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label2);
            this.groupBox5.Controls.Add(this.readingTime);
            this.groupBox5.Controls.Add(this.writingTime);
            this.groupBox5.Controls.Add(this.label3);
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.Controls.Add(this.decodingTime);
            this.groupBox5.Controls.Add(this.encodingTime);
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Location = new System.Drawing.Point(10, 398);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(417, 95);
            this.groupBox5.TabIndex = 13;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Operations time";
            // 
            // backgroundWorker
            // 
            this.backgroundWorker.WorkerReportsProgress = true;
            this.backgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_DoWork);
            this.backgroundWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker_ProgressChanged);
            this.backgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker_RunWorkerCompleted);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(970, 573);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Image Processing";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button saveAsBmpBtn;
        private System.Windows.Forms.Label readingTime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label imageSizeLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label writingTime;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label encodingTime;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label decodingTime;
        private System.Windows.Forms.Label imageSizeAfterLabel;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripProgressBar progressBar;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label blueColorLabel;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label greenColorLabel;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label redColorLabel;
        private System.Windows.Forms.RadioButton blueColorRadio;
        private System.Windows.Forms.RadioButton greenColorRadio;
        private System.Windows.Forms.RadioButton redColorRadio;
        private System.Windows.Forms.RadioButton allColorsRadio;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox saveAsComboBox;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button findDiffBtn;
        private System.Windows.Forms.ComboBox secondDiffComboBox;
        private System.Windows.Forms.ComboBox firstDiffComboBox;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.ComponentModel.BackgroundWorker backgroundWorker;
    }
}

