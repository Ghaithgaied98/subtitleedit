﻿
namespace Nikse.SubtitleEdit.Forms
{
    sealed partial class GenerateVideo
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
            this.components = new System.ComponentModel.Container();
            this.panelColor = new System.Windows.Forms.Panel();
            this.buttonColor = new System.Windows.Forms.Button();
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.labelDuration = new System.Windows.Forms.Label();
            this.numericUpDownWidth = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownHeight = new System.Windows.Forms.NumericUpDown();
            this.labelResolution = new System.Windows.Forms.Label();
            this.labelX = new System.Windows.Forms.Label();
            this.groupBoxBackground = new System.Windows.Forms.GroupBox();
            this.radioButtonColor = new System.Windows.Forms.RadioButton();
            this.radioButtonCheckeredImage = new System.Windows.Forms.RadioButton();
            this.numericUpDownDurationMinutes = new System.Windows.Forms.NumericUpDown();
            this.labelPleaseWait = new System.Windows.Forms.Label();
            this.labelFrameRate = new System.Windows.Forms.Label();
            this.comboBoxFrameRate = new System.Windows.Forms.ComboBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.labelProgress = new System.Windows.Forms.Label();
            this.contextMenuStripRes = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.x2160ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uHD3840x2160ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.k2048x1080ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dCI2KScope2048x858ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dCI2KFlat1998x1080ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.p1920x1080ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.x1080ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.p1280x720ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.x720ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.p848x480ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pAL720x576ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nTSC720x480ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.x352ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.x272ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonVideoChooseStandardRes = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHeight)).BeginInit();
            this.groupBoxBackground.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDurationMinutes)).BeginInit();
            this.contextMenuStripRes.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelColor
            // 
            this.panelColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelColor.Location = new System.Drawing.Point(169, 81);
            this.panelColor.Name = "panelColor";
            this.panelColor.Size = new System.Drawing.Size(21, 20);
            this.panelColor.TabIndex = 11;
            this.panelColor.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseClick);
            // 
            // buttonColor
            // 
            this.buttonColor.Location = new System.Drawing.Point(42, 80);
            this.buttonColor.Name = "buttonColor";
            this.buttonColor.Size = new System.Drawing.Size(121, 23);
            this.buttonColor.TabIndex = 10;
            this.buttonColor.Text = "Color";
            this.buttonColor.UseVisualStyleBackColor = true;
            this.buttonColor.Click += new System.EventHandler(this.buttonColor_Click);
            // 
            // buttonOK
            // 
            this.buttonOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOK.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonOK.Location = new System.Drawing.Point(499, 155);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(121, 23);
            this.buttonOK.TabIndex = 20;
            this.buttonOK.Text = "Generate";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonCancel.Location = new System.Drawing.Point(626, 155);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 21;
            this.buttonCancel.Text = "C&ancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar1.Location = new System.Drawing.Point(12, 155);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(481, 10);
            this.progressBar1.TabIndex = 8;
            this.progressBar1.Visible = false;
            // 
            // labelDuration
            // 
            this.labelDuration.AutoSize = true;
            this.labelDuration.Location = new System.Drawing.Point(12, 29);
            this.labelDuration.Name = "labelDuration";
            this.labelDuration.Size = new System.Drawing.Size(97, 13);
            this.labelDuration.TabIndex = 0;
            this.labelDuration.Text = "Duration in minutes";
            // 
            // numericUpDownWidth
            // 
            this.numericUpDownWidth.Increment = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDownWidth.Location = new System.Drawing.Point(165, 56);
            this.numericUpDownWidth.Maximum = new decimal(new int[] {
            50000,
            0,
            0,
            0});
            this.numericUpDownWidth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownWidth.Name = "numericUpDownWidth";
            this.numericUpDownWidth.Size = new System.Drawing.Size(64, 20);
            this.numericUpDownWidth.TabIndex = 3;
            this.numericUpDownWidth.Value = new decimal(new int[] {
            1280,
            0,
            0,
            0});
            this.numericUpDownWidth.ValueChanged += new System.EventHandler(this.numericUpDownWidth_ValueChanged);
            // 
            // numericUpDownHeight
            // 
            this.numericUpDownHeight.Increment = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDownHeight.Location = new System.Drawing.Point(253, 56);
            this.numericUpDownHeight.Maximum = new decimal(new int[] {
            50000,
            0,
            0,
            0});
            this.numericUpDownHeight.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownHeight.Name = "numericUpDownHeight";
            this.numericUpDownHeight.Size = new System.Drawing.Size(64, 20);
            this.numericUpDownHeight.TabIndex = 5;
            this.numericUpDownHeight.Value = new decimal(new int[] {
            720,
            0,
            0,
            0});
            this.numericUpDownHeight.ValueChanged += new System.EventHandler(this.numericUpDownHeight_ValueChanged);
            // 
            // labelResolution
            // 
            this.labelResolution.AutoSize = true;
            this.labelResolution.Location = new System.Drawing.Point(12, 58);
            this.labelResolution.Name = "labelResolution";
            this.labelResolution.Size = new System.Drawing.Size(57, 13);
            this.labelResolution.TabIndex = 2;
            this.labelResolution.Text = "Resolution";
            // 
            // labelX
            // 
            this.labelX.AutoSize = true;
            this.labelX.Location = new System.Drawing.Point(235, 58);
            this.labelX.Name = "labelX";
            this.labelX.Size = new System.Drawing.Size(12, 13);
            this.labelX.TabIndex = 4;
            this.labelX.Text = "x";
            // 
            // groupBoxBackground
            // 
            this.groupBoxBackground.Controls.Add(this.radioButtonColor);
            this.groupBoxBackground.Controls.Add(this.radioButtonCheckeredImage);
            this.groupBoxBackground.Controls.Add(this.buttonColor);
            this.groupBoxBackground.Controls.Add(this.panelColor);
            this.groupBoxBackground.Location = new System.Drawing.Point(387, 12);
            this.groupBoxBackground.Name = "groupBoxBackground";
            this.groupBoxBackground.Size = new System.Drawing.Size(314, 118);
            this.groupBoxBackground.TabIndex = 7;
            this.groupBoxBackground.TabStop = false;
            this.groupBoxBackground.Text = "Background";
            // 
            // radioButtonColor
            // 
            this.radioButtonColor.AutoSize = true;
            this.radioButtonColor.Location = new System.Drawing.Point(18, 57);
            this.radioButtonColor.Name = "radioButtonColor";
            this.radioButtonColor.Size = new System.Drawing.Size(74, 17);
            this.radioButtonColor.TabIndex = 9;
            this.radioButtonColor.Text = "Solid color";
            this.radioButtonColor.UseVisualStyleBackColor = true;
            // 
            // radioButtonCheckeredImage
            // 
            this.radioButtonCheckeredImage.AutoSize = true;
            this.radioButtonCheckeredImage.Checked = true;
            this.radioButtonCheckeredImage.Location = new System.Drawing.Point(18, 34);
            this.radioButtonCheckeredImage.Name = "radioButtonCheckeredImage";
            this.radioButtonCheckeredImage.Size = new System.Drawing.Size(108, 17);
            this.radioButtonCheckeredImage.TabIndex = 8;
            this.radioButtonCheckeredImage.TabStop = true;
            this.radioButtonCheckeredImage.Text = "Checkered image";
            this.radioButtonCheckeredImage.UseVisualStyleBackColor = true;
            // 
            // numericUpDownDurationMinutes
            // 
            this.numericUpDownDurationMinutes.Location = new System.Drawing.Point(165, 30);
            this.numericUpDownDurationMinutes.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownDurationMinutes.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownDurationMinutes.Name = "numericUpDownDurationMinutes";
            this.numericUpDownDurationMinutes.Size = new System.Drawing.Size(64, 20);
            this.numericUpDownDurationMinutes.TabIndex = 1;
            this.numericUpDownDurationMinutes.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // labelPleaseWait
            // 
            this.labelPleaseWait.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelPleaseWait.AutoSize = true;
            this.labelPleaseWait.Location = new System.Drawing.Point(12, 135);
            this.labelPleaseWait.Name = "labelPleaseWait";
            this.labelPleaseWait.Size = new System.Drawing.Size(70, 13);
            this.labelPleaseWait.TabIndex = 7;
            this.labelPleaseWait.Text = "Please wait...";
            // 
            // labelFrameRate
            // 
            this.labelFrameRate.AutoSize = true;
            this.labelFrameRate.Location = new System.Drawing.Point(12, 83);
            this.labelFrameRate.Name = "labelFrameRate";
            this.labelFrameRate.Size = new System.Drawing.Size(57, 13);
            this.labelFrameRate.TabIndex = 11;
            this.labelFrameRate.Text = "Frame rate";
            // 
            // comboBoxFrameRate
            // 
            this.comboBoxFrameRate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFrameRate.FormattingEnabled = true;
            this.comboBoxFrameRate.Location = new System.Drawing.Point(165, 83);
            this.comboBoxFrameRate.Name = "comboBoxFrameRate";
            this.comboBoxFrameRate.Size = new System.Drawing.Size(121, 21);
            this.comboBoxFrameRate.TabIndex = 6;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // labelProgress
            // 
            this.labelProgress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelProgress.AutoSize = true;
            this.labelProgress.Location = new System.Drawing.Point(12, 168);
            this.labelProgress.Name = "labelProgress";
            this.labelProgress.Size = new System.Drawing.Size(88, 13);
            this.labelProgress.TabIndex = 30;
            this.labelProgress.Text = "Remaining time...";
            // 
            // contextMenuStripRes
            // 
            this.contextMenuStripRes.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.x2160ToolStripMenuItem,
            this.uHD3840x2160ToolStripMenuItem,
            this.k2048x1080ToolStripMenuItem,
            this.dCI2KScope2048x858ToolStripMenuItem,
            this.dCI2KFlat1998x1080ToolStripMenuItem,
            this.p1920x1080ToolStripMenuItem,
            this.x1080ToolStripMenuItem,
            this.p1280x720ToolStripMenuItem,
            this.x720ToolStripMenuItem,
            this.p848x480ToolStripMenuItem,
            this.pAL720x576ToolStripMenuItem,
            this.nTSC720x480ToolStripMenuItem,
            this.x352ToolStripMenuItem,
            this.x272ToolStripMenuItem});
            this.contextMenuStripRes.Name = "contextMenuStripRes";
            this.contextMenuStripRes.Size = new System.Drawing.Size(204, 334);
            // 
            // x2160ToolStripMenuItem
            // 
            this.x2160ToolStripMenuItem.Name = "x2160ToolStripMenuItem";
            this.x2160ToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.x2160ToolStripMenuItem.Text = "4K (4096x2160)";
            this.x2160ToolStripMenuItem.Click += new System.EventHandler(this.ResolutionPickClick);
            // 
            // uHD3840x2160ToolStripMenuItem
            // 
            this.uHD3840x2160ToolStripMenuItem.Name = "uHD3840x2160ToolStripMenuItem";
            this.uHD3840x2160ToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.uHD3840x2160ToolStripMenuItem.Text = "UHD (3840x2160)";
            this.uHD3840x2160ToolStripMenuItem.Click += new System.EventHandler(this.ResolutionPickClick);
            // 
            // k2048x1080ToolStripMenuItem
            // 
            this.k2048x1080ToolStripMenuItem.Name = "k2048x1080ToolStripMenuItem";
            this.k2048x1080ToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.k2048x1080ToolStripMenuItem.Text = "2K (2048x1080)";
            this.k2048x1080ToolStripMenuItem.Click += new System.EventHandler(this.ResolutionPickClick);
            // 
            // dCI2KScope2048x858ToolStripMenuItem
            // 
            this.dCI2KScope2048x858ToolStripMenuItem.Name = "dCI2KScope2048x858ToolStripMenuItem";
            this.dCI2KScope2048x858ToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.dCI2KScope2048x858ToolStripMenuItem.Text = "DCI 2K Scope (2048x858)";
            this.dCI2KScope2048x858ToolStripMenuItem.Click += new System.EventHandler(this.ResolutionPickClick);
            // 
            // dCI2KFlat1998x1080ToolStripMenuItem
            // 
            this.dCI2KFlat1998x1080ToolStripMenuItem.Name = "dCI2KFlat1998x1080ToolStripMenuItem";
            this.dCI2KFlat1998x1080ToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.dCI2KFlat1998x1080ToolStripMenuItem.Text = "DCI 2K Flat (1998x1080)";
            this.dCI2KFlat1998x1080ToolStripMenuItem.Click += new System.EventHandler(this.ResolutionPickClick);
            // 
            // p1920x1080ToolStripMenuItem
            // 
            this.p1920x1080ToolStripMenuItem.Name = "p1920x1080ToolStripMenuItem";
            this.p1920x1080ToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.p1920x1080ToolStripMenuItem.Text = "1080p (1920x1080)";
            this.p1920x1080ToolStripMenuItem.Click += new System.EventHandler(this.ResolutionPickClick);
            // 
            // x1080ToolStripMenuItem
            // 
            this.x1080ToolStripMenuItem.Name = "x1080ToolStripMenuItem";
            this.x1080ToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.x1080ToolStripMenuItem.Text = "1440x1080";
            this.x1080ToolStripMenuItem.Click += new System.EventHandler(this.ResolutionPickClick);
            // 
            // p1280x720ToolStripMenuItem
            // 
            this.p1280x720ToolStripMenuItem.Name = "p1280x720ToolStripMenuItem";
            this.p1280x720ToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.p1280x720ToolStripMenuItem.Text = "720p (1280x720)";
            this.p1280x720ToolStripMenuItem.Click += new System.EventHandler(this.ResolutionPickClick);
            // 
            // x720ToolStripMenuItem
            // 
            this.x720ToolStripMenuItem.Name = "x720ToolStripMenuItem";
            this.x720ToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.x720ToolStripMenuItem.Text = "960x720";
            this.x720ToolStripMenuItem.Click += new System.EventHandler(this.ResolutionPickClick);
            // 
            // p848x480ToolStripMenuItem
            // 
            this.p848x480ToolStripMenuItem.Name = "p848x480ToolStripMenuItem";
            this.p848x480ToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.p848x480ToolStripMenuItem.Text = "480p (848x480)";
            this.p848x480ToolStripMenuItem.Click += new System.EventHandler(this.ResolutionPickClick);
            // 
            // pAL720x576ToolStripMenuItem
            // 
            this.pAL720x576ToolStripMenuItem.Name = "pAL720x576ToolStripMenuItem";
            this.pAL720x576ToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.pAL720x576ToolStripMenuItem.Text = "PAL (720x576)";
            this.pAL720x576ToolStripMenuItem.Click += new System.EventHandler(this.ResolutionPickClick);
            // 
            // nTSC720x480ToolStripMenuItem
            // 
            this.nTSC720x480ToolStripMenuItem.Name = "nTSC720x480ToolStripMenuItem";
            this.nTSC720x480ToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.nTSC720x480ToolStripMenuItem.Text = "NTSC (720x480)";
            this.nTSC720x480ToolStripMenuItem.Click += new System.EventHandler(this.ResolutionPickClick);
            // 
            // x352ToolStripMenuItem
            // 
            this.x352ToolStripMenuItem.Name = "x352ToolStripMenuItem";
            this.x352ToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.x352ToolStripMenuItem.Text = "640x352";
            this.x352ToolStripMenuItem.Click += new System.EventHandler(this.ResolutionPickClick);
            // 
            // x272ToolStripMenuItem
            // 
            this.x272ToolStripMenuItem.Name = "x272ToolStripMenuItem";
            this.x272ToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.x272ToolStripMenuItem.Text = "640x272";
            this.x272ToolStripMenuItem.Click += new System.EventHandler(this.ResolutionPickClick);
            // 
            // buttonVideoChooseStandardRes
            // 
            this.buttonVideoChooseStandardRes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonVideoChooseStandardRes.Location = new System.Drawing.Point(323, 56);
            this.buttonVideoChooseStandardRes.Name = "buttonVideoChooseStandardRes";
            this.buttonVideoChooseStandardRes.Size = new System.Drawing.Size(27, 23);
            this.buttonVideoChooseStandardRes.TabIndex = 32;
            this.buttonVideoChooseStandardRes.Text = "...";
            this.buttonVideoChooseStandardRes.UseVisualStyleBackColor = true;
            this.buttonVideoChooseStandardRes.Click += new System.EventHandler(this.buttonVideoChooseStandardRes_Click);
            // 
            // GenerateVideo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 190);
            this.Controls.Add(this.buttonVideoChooseStandardRes);
            this.Controls.Add(this.labelProgress);
            this.Controls.Add(this.comboBoxFrameRate);
            this.Controls.Add(this.labelFrameRate);
            this.Controls.Add(this.labelPleaseWait);
            this.Controls.Add(this.numericUpDownDurationMinutes);
            this.Controls.Add(this.groupBoxBackground);
            this.Controls.Add(this.labelX);
            this.Controls.Add(this.labelResolution);
            this.Controls.Add(this.numericUpDownHeight);
            this.Controls.Add(this.numericUpDownWidth);
            this.Controls.Add(this.labelDuration);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.buttonCancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GenerateVideo";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "GenerateVideo";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GenerateVideo_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHeight)).EndInit();
            this.groupBoxBackground.ResumeLayout(false);
            this.groupBoxBackground.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDurationMinutes)).EndInit();
            this.contextMenuStripRes.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panelColor;
        private System.Windows.Forms.Button buttonColor;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label labelDuration;
        private System.Windows.Forms.NumericUpDown numericUpDownWidth;
        private System.Windows.Forms.NumericUpDown numericUpDownHeight;
        private System.Windows.Forms.Label labelResolution;
        private System.Windows.Forms.Label labelX;
        private System.Windows.Forms.GroupBox groupBoxBackground;
        private System.Windows.Forms.RadioButton radioButtonColor;
        private System.Windows.Forms.RadioButton radioButtonCheckeredImage;
        private System.Windows.Forms.NumericUpDown numericUpDownDurationMinutes;
        private System.Windows.Forms.Label labelPleaseWait;
        private System.Windows.Forms.Label labelFrameRate;
        private System.Windows.Forms.ComboBox comboBoxFrameRate;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label labelProgress;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripRes;
        private System.Windows.Forms.ToolStripMenuItem x2160ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uHD3840x2160ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem k2048x1080ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dCI2KScope2048x858ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dCI2KFlat1998x1080ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem p1920x1080ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem x1080ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem p1280x720ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem x720ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem p848x480ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pAL720x576ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nTSC720x480ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem x352ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem x272ToolStripMenuItem;
        private System.Windows.Forms.Button buttonVideoChooseStandardRes;
    }
}