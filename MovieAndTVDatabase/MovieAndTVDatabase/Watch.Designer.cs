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
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.watchButton = new System.Windows.Forms.Button();
            this.showText = new System.Windows.Forms.TextBox();
            this.userLabel = new System.Windows.Forms.Label();
            this.favoriteCheckBox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox.Location = new System.Drawing.Point(207, 10);
            this.pictureBox.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(422, 486);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // watchButton
            // 
            this.watchButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.watchButton.Location = new System.Drawing.Point(198, 558);
            this.watchButton.Margin = new System.Windows.Forms.Padding(4);
            this.watchButton.Name = "watchButton";
            this.watchButton.Size = new System.Drawing.Size(339, 29);
            this.watchButton.TabIndex = 1;
            this.watchButton.Text = "Watch Show";
            this.watchButton.UseVisualStyleBackColor = true;
            this.watchButton.Click += new System.EventHandler(this.watchButton_Click);
            // 
            // showText
            // 
            this.showText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.showText.Location = new System.Drawing.Point(198, 525);
            this.showText.Margin = new System.Windows.Forms.Padding(4);
            this.showText.Name = "showText";
            this.showText.Size = new System.Drawing.Size(338, 22);
            this.showText.TabIndex = 0;
            this.showText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // userLabel
            // 
            this.userLabel.AutoSize = true;
            this.userLabel.Location = new System.Drawing.Point(12, 43);
            this.userLabel.Name = "userLabel";
            this.userLabel.Size = new System.Drawing.Size(97, 17);
            this.userLabel.TabIndex = 2;
            this.userLabel.Text = "Current User: ";
            // 
            // favoriteCheckBox
            // 
            this.favoriteCheckBox.AutoSize = true;
            this.favoriteCheckBox.Enabled = false;
            this.favoriteCheckBox.Location = new System.Drawing.Point(28, 194);
            this.favoriteCheckBox.Margin = new System.Windows.Forms.Padding(2);
            this.favoriteCheckBox.Name = "favoriteCheckBox";
            this.favoriteCheckBox.Size = new System.Drawing.Size(81, 21);
            this.favoriteCheckBox.TabIndex = 4;
            this.favoriteCheckBox.Text = "Favorite";
            this.favoriteCheckBox.UseVisualStyleBackColor = true;
            this.favoriteCheckBox.CheckedChanged += new System.EventHandler(this.favoriteCheckBox_CheckedChanged);
            // 
            // Watch
            // 
            this.AcceptButton = this.watchButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(819, 643);
            this.ControlBox = false;
            this.Controls.Add(this.favoriteCheckBox);
            this.Controls.Add(this.userLabel);
            this.Controls.Add(this.showText);
            this.Controls.Add(this.watchButton);
            this.Controls.Add(this.pictureBox);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Watch";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Shown += new System.EventHandler(this.Watch_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button watchButton;
        private System.Windows.Forms.TextBox showText;
        private System.Windows.Forms.Label userLabel;
        private System.Windows.Forms.CheckBox favoriteCheckBox;
    }
}