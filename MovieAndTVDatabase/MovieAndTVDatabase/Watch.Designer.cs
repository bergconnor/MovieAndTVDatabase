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
            this.etitleLabel2 = new System.Windows.Forms.Label();
            this.etitleLabel1 = new System.Windows.Forms.Label();
            this.episodeCombo = new System.Windows.Forms.ComboBox();
            this.episodeLabel = new System.Windows.Forms.Label();
            this.seCombo = new System.Windows.Forms.ComboBox();
            this.seLabel = new System.Windows.Forms.Label();
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
            // etitleLabel2
            // 
            this.etitleLabel2.AutoSize = true;
            this.etitleLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.etitleLabel2.Location = new System.Drawing.Point(19, 340);
            this.etitleLabel2.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.etitleLabel2.Name = "etitleLabel2";
            this.etitleLabel2.Size = new System.Drawing.Size(95, 46);
            this.etitleLabel2.TabIndex = 23;
            this.etitleLabel2.Text = "Title";
            this.etitleLabel2.Visible = false;
            // 
            // etitleLabel1
            // 
            this.etitleLabel1.AutoSize = true;
            this.etitleLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.etitleLabel1.Location = new System.Drawing.Point(17, 257);
            this.etitleLabel1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.etitleLabel1.Name = "etitleLabel1";
            this.etitleLabel1.Size = new System.Drawing.Size(326, 55);
            this.etitleLabel1.TabIndex = 22;
            this.etitleLabel1.Text = "Episode Title: ";
            this.etitleLabel1.Visible = false;
            // 
            // episodeCombo
            // 
            this.episodeCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.episodeCombo.FormattingEnabled = true;
            this.episodeCombo.Location = new System.Drawing.Point(258, 566);
            this.episodeCombo.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.episodeCombo.Name = "episodeCombo";
            this.episodeCombo.Size = new System.Drawing.Size(137, 39);
            this.episodeCombo.TabIndex = 21;
            this.episodeCombo.Visible = false;
            // 
            // episodeLabel
            // 
            this.episodeLabel.AutoSize = true;
            this.episodeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.episodeLabel.Location = new System.Drawing.Point(20, 550);
            this.episodeLabel.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.episodeLabel.Name = "episodeLabel";
            this.episodeLabel.Size = new System.Drawing.Size(222, 55);
            this.episodeLabel.TabIndex = 20;
            this.episodeLabel.Text = "Episodes";
            this.episodeLabel.Visible = false;
            // 
            // seCombo
            // 
            this.seCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.seCombo.FormattingEnabled = true;
            this.seCombo.Location = new System.Drawing.Point(245, 460);
            this.seCombo.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.seCombo.Name = "seCombo";
            this.seCombo.Size = new System.Drawing.Size(153, 39);
            this.seCombo.TabIndex = 19;
            this.seCombo.Visible = false;
            this.seCombo.SelectedIndexChanged += new System.EventHandler(this.seCombo_SelectedIndexChanged);
            // 
            // seLabel
            // 
            this.seLabel.AutoSize = true;
            this.seLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seLabel.Location = new System.Drawing.Point(11, 441);
            this.seLabel.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.seLabel.Name = "seLabel";
            this.seLabel.Size = new System.Drawing.Size(261, 61);
            this.seLabel.TabIndex = 18;
            this.seLabel.Text = "Seasons: ";
            this.seLabel.Visible = false;
            // 
            // Watch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(240F, 240F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1638, 1286);
            this.ControlBox = false;
            this.Controls.Add(this.etitleLabel2);
            this.Controls.Add(this.etitleLabel1);
            this.Controls.Add(this.episodeCombo);
            this.Controls.Add(this.episodeLabel);
            this.Controls.Add(this.seCombo);
            this.Controls.Add(this.seLabel);
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
        private System.Windows.Forms.Label etitleLabel2;
        private System.Windows.Forms.Label etitleLabel1;
        private System.Windows.Forms.ComboBox episodeCombo;
        private System.Windows.Forms.Label episodeLabel;
        private System.Windows.Forms.ComboBox seCombo;
        private System.Windows.Forms.Label seLabel;
    }
}