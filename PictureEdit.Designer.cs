namespace PictureViewer
{
    partial class PictureEdit
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
            this.dgvPictureList = new System.Windows.Forms.DataGridView();
            this.pbMiniature = new System.Windows.Forms.PictureBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPictureList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMiniature)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPictureList
            // 
            this.dgvPictureList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPictureList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPictureList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPictureList.Location = new System.Drawing.Point(12, 12);
            this.dgvPictureList.Name = "dgvPictureList";
            this.dgvPictureList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPictureList.Size = new System.Drawing.Size(907, 435);
            this.dgvPictureList.TabIndex = 0;
            this.dgvPictureList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPictureList_CellClick);
            // 
            // pbMiniature
            // 
            this.pbMiniature.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pbMiniature.Location = new System.Drawing.Point(501, 453);
            this.pbMiniature.Name = "pbMiniature";
            this.pbMiniature.Size = new System.Drawing.Size(419, 299);
            this.pbMiniature.TabIndex = 1;
            this.pbMiniature.TabStop = false;
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDelete.Location = new System.Drawing.Point(101, 564);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(224, 75);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Usuń zdjęcie";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // PictureEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(230)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(932, 764);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.pbMiniature);
            this.Controls.Add(this.dgvPictureList);
            this.Name = "PictureEdit";
            this.Text = "PictureEdit";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPictureList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMiniature)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPictureList;
        private System.Windows.Forms.PictureBox pbMiniature;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button btnDelete;
    }
}