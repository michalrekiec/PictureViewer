namespace PictureViewer
{
    partial class Main
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
            this.fbdSelectPicture = new System.Windows.Forms.FolderBrowserDialog();
            this.btnAddPicture = new System.Windows.Forms.Button();
            this.cbSlideShow = new System.Windows.Forms.CheckBox();
            this.nudSlideChangeTime = new System.Windows.Forms.NumericUpDown();
            this.lblChange1 = new System.Windows.Forms.Label();
            this.lblChange2 = new System.Windows.Forms.Label();
            this.btnEditPictures = new System.Windows.Forms.Button();
            this.pbViewer = new System.Windows.Forms.PictureBox();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.lbPictureNumber = new System.Windows.Forms.Label();
            this.timerSlideShow = new System.Windows.Forms.Timer(this.components);
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudSlideChangeTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbViewer)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddPicture
            // 
            this.btnAddPicture.BackColor = System.Drawing.Color.Lime;
            this.btnAddPicture.Location = new System.Drawing.Point(25, 21);
            this.btnAddPicture.Name = "btnAddPicture";
            this.btnAddPicture.Size = new System.Drawing.Size(118, 23);
            this.btnAddPicture.TabIndex = 0;
            this.btnAddPicture.Text = "Dodaj obrazek";
            this.btnAddPicture.UseVisualStyleBackColor = false;
            this.btnAddPicture.Click += new System.EventHandler(this.btnAddPicture_Click);
            // 
            // cbSlideShow
            // 
            this.cbSlideShow.AutoSize = true;
            this.cbSlideShow.Location = new System.Drawing.Point(298, 25);
            this.cbSlideShow.Name = "cbSlideShow";
            this.cbSlideShow.Size = new System.Drawing.Size(94, 17);
            this.cbSlideShow.TabIndex = 1;
            this.cbSlideShow.Text = "Pokaz slajdów";
            this.cbSlideShow.UseVisualStyleBackColor = true;
            this.cbSlideShow.CheckedChanged += new System.EventHandler(this.cbSlideShow_CheckedChanged);
            // 
            // nudSlideChangeTime
            // 
            this.nudSlideChangeTime.Enabled = false;
            this.nudSlideChangeTime.Location = new System.Drawing.Point(518, 24);
            this.nudSlideChangeTime.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.nudSlideChangeTime.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudSlideChangeTime.Name = "nudSlideChangeTime";
            this.nudSlideChangeTime.Size = new System.Drawing.Size(87, 20);
            this.nudSlideChangeTime.TabIndex = 2;
            this.nudSlideChangeTime.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudSlideChangeTime.ValueChanged += new System.EventHandler(this.nudSlideChangeTime_ValueChanged);
            // 
            // lblChange1
            // 
            this.lblChange1.AutoSize = true;
            this.lblChange1.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblChange1.Location = new System.Drawing.Point(449, 26);
            this.lblChange1.Name = "lblChange1";
            this.lblChange1.Size = new System.Drawing.Size(57, 13);
            this.lblChange1.TabIndex = 3;
            this.lblChange1.Text = "Zmiana co";
            // 
            // lblChange2
            // 
            this.lblChange2.AutoSize = true;
            this.lblChange2.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblChange2.Location = new System.Drawing.Point(624, 26);
            this.lblChange2.Name = "lblChange2";
            this.lblChange2.Size = new System.Drawing.Size(42, 13);
            this.lblChange2.TabIndex = 4;
            this.lblChange2.Text = "sekund";
            // 
            // btnEditPictures
            // 
            this.btnEditPictures.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnEditPictures.Location = new System.Drawing.Point(161, 21);
            this.btnEditPictures.Name = "btnEditPictures";
            this.btnEditPictures.Size = new System.Drawing.Size(118, 23);
            this.btnEditPictures.TabIndex = 5;
            this.btnEditPictures.Text = "Edytuj listę";
            this.btnEditPictures.UseVisualStyleBackColor = false;
            this.btnEditPictures.Click += new System.EventHandler(this.btnEditPictures_Click);
            // 
            // pbViewer
            // 
            this.pbViewer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbViewer.BackColor = System.Drawing.Color.Cornsilk;
            this.pbViewer.Location = new System.Drawing.Point(12, 60);
            this.pbViewer.Name = "pbViewer";
            this.pbViewer.Size = new System.Drawing.Size(1215, 616);
            this.pbViewer.TabIndex = 6;
            this.pbViewer.TabStop = false;
            this.pbViewer.SizeChanged += new System.EventHandler(this.pbViewer_SizeChanged);
            // 
            // btnPrevious
            // 
            this.btnPrevious.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnPrevious.Location = new System.Drawing.Point(394, 688);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(75, 23);
            this.btnPrevious.TabIndex = 7;
            this.btnPrevious.Text = "Poprzedni";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnNext
            // 
            this.btnNext.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnNext.Location = new System.Drawing.Point(729, 688);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 8;
            this.btnNext.Text = "Następny";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // lbPictureNumber
            // 
            this.lbPictureNumber.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lbPictureNumber.AutoSize = true;
            this.lbPictureNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbPictureNumber.Location = new System.Drawing.Point(592, 688);
            this.lbPictureNumber.Name = "lbPictureNumber";
            this.lbPictureNumber.Size = new System.Drawing.Size(25, 25);
            this.lbPictureNumber.TabIndex = 9;
            this.lbPictureNumber.Text = "1";
            // 
            // timerSlideShow
            // 
            this.timerSlideShow.Tick += new System.EventHandler(this.timerSlideShow_Tick);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnClose.Location = new System.Drawing.Point(1125, 19);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(102, 23);
            this.btnClose.TabIndex = 10;
            this.btnClose.Text = "Zamknij";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(230)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1239, 725);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lbPictureNumber);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.pbViewer);
            this.Controls.Add(this.btnEditPictures);
            this.Controls.Add(this.lblChange2);
            this.Controls.Add(this.lblChange1);
            this.Controls.Add(this.nudSlideChangeTime);
            this.Controls.Add(this.cbSlideShow);
            this.Controls.Add(this.btnAddPicture);
            this.Name = "Main";
            this.Text = "Picture Viewer";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudSlideChangeTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbViewer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.FolderBrowserDialog fbdSelectPicture;
        private System.Windows.Forms.Button btnAddPicture;
        private System.Windows.Forms.CheckBox cbSlideShow;
        private System.Windows.Forms.NumericUpDown nudSlideChangeTime;
        private System.Windows.Forms.Label lblChange1;
        private System.Windows.Forms.Label lblChange2;
        private System.Windows.Forms.Button btnEditPictures;
        private System.Windows.Forms.PictureBox pbViewer;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Label lbPictureNumber;
        private System.Windows.Forms.Timer timerSlideShow;
        private System.Windows.Forms.Button btnClose;
    }
}

