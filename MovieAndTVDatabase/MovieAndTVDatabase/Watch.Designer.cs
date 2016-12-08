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
            this.watchBtn = new System.Windows.Forms.Button();
            this.showTxt = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(120, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(338, 389);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // watchBtn
            // 
            this.watchBtn.Location = new System.Drawing.Point(158, 446);
            this.watchBtn.Name = "watchBtn";
            this.watchBtn.Size = new System.Drawing.Size(271, 23);
            this.watchBtn.TabIndex = 1;
            this.watchBtn.Text = "Watch Show";
            this.watchBtn.UseVisualStyleBackColor = true;
            this.watchBtn.Click += new System.EventHandler(this.watchBtn_Click);
            // 
            // showTxt
            // 
            this.showTxt.Location = new System.Drawing.Point(158, 420);
            this.showTxt.Name = "showTxt";
            this.showTxt.Size = new System.Drawing.Size(271, 20);
            this.showTxt.TabIndex = 2;
            // 
            // Watch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(604, 481);
            this.ControlBox = false;
            this.Controls.Add(this.showTxt);
            this.Controls.Add(this.watchBtn);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Watch";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button watchBtn;
        private System.Windows.Forms.TextBox showTxt;
    }
}