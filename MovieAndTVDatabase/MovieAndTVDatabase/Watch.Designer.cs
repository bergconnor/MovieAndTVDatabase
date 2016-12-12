namespace MovieAndTVDatabase
{
    partial class Watch
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.showTxt = new System.Windows.Forms.TextBox();
            this.currentUserLbl = new System.Windows.Forms.Label();
            this.FavoriteCheckBox3 = new System.Windows.Forms.CheckBox();
            this.showTxt2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(414, 20);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(840, 968);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // showTxt
            // 
            this.showTxt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.showTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.showTxt.Location = new System.Drawing.Point(396, 1050);
            this.showTxt.Margin = new System.Windows.Forms.Padding(8);
            this.showTxt.Name = "showTxt";
            this.showTxt.Size = new System.Drawing.Size(672, 64);
            this.showTxt.TabIndex = 0;
            this.showTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // currentUserLbl
            // 
            this.currentUserLbl.AutoSize = true;
            this.currentUserLbl.Location = new System.Drawing.Point(24, 86);
            this.currentUserLbl.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.currentUserLbl.Name = "currentUserLbl";
            this.currentUserLbl.Size = new System.Drawing.Size(190, 32);
            this.currentUserLbl.TabIndex = 2;
            this.currentUserLbl.Text = "Current User: ";
            // 
            // FavoriteCheckBox3
            // 
            this.FavoriteCheckBox3.AutoSize = true;
            this.FavoriteCheckBox3.Enabled = false;
            this.FavoriteCheckBox3.Location = new System.Drawing.Point(1302, 732);
            this.FavoriteCheckBox3.Name = "FavoriteCheckBox3";
            this.FavoriteCheckBox3.Size = new System.Drawing.Size(156, 36);
            this.FavoriteCheckBox3.TabIndex = 3;
            this.FavoriteCheckBox3.Text = "Favorite";
            this.FavoriteCheckBox3.UseVisualStyleBackColor = true;
            this.FavoriteCheckBox3.CheckedChanged += new System.EventHandler(this.FavoriteCheckBox_CheckedChanged_1);
            this.FavoriteCheckBox3.CheckStateChanged += new System.EventHandler(this.FavoriteCheckBox_CheckedChanged_1);
            // 
            // showTxt2
            // 
            this.showTxt2.AutoSize = true;
            this.showTxt2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.showTxt2.Location = new System.Drawing.Point(639, 1119);
            this.showTxt2.Name = "showTxt2";
            this.showTxt2.Size = new System.Drawing.Size(126, 46);
            this.showTxt2.TabIndex = 4;
            this.showTxt2.Text = "label1";
            // 
            // Watch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(240F, 240F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1638, 1286);
            this.ControlBox = false;
            this.Controls.Add(this.showTxt2);
            this.Controls.Add(this.FavoriteCheckBox3);
            this.Controls.Add(this.currentUserLbl);
            this.Controls.Add(this.showTxt);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(8);
            this.Name = "Watch";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Shown += new System.EventHandler(this.Watch_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox showTxt;
        private System.Windows.Forms.Label currentUserLbl;
        private System.Windows.Forms.CheckBox FavoriteCheckBox3;
        private System.Windows.Forms.Label showTxt2;
    }
}