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
            this.userLabel = new System.Windows.Forms.Label();
            this.favoriteCheckBox = new System.Windows.Forms.CheckBox();
            this.showLabel = new System.Windows.Forms.Label();
            this.episodesCombo = new System.Windows.Forms.ComboBox();
            this.episodeLabel = new System.Windows.Forms.Label();
            this.seasonsCombo = new System.Windows.Forms.ComboBox();
            this.seasonsDecoratorLabel = new System.Windows.Forms.Label();
            this.episodesLabel = new System.Windows.Forms.Label();
            this.episodesDecoratorLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox.Location = new System.Drawing.Point(170, 70);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(284, 355);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // userLabel
            // 
            this.userLabel.AutoSize = true;
            this.userLabel.Location = new System.Drawing.Point(10, 34);
            this.userLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.userLabel.Name = "userLabel";
            this.userLabel.Size = new System.Drawing.Size(72, 13);
            this.userLabel.TabIndex = 2;
            this.userLabel.Text = "Current User: ";
            // 
            // favoriteCheckBox
            // 
            this.favoriteCheckBox.AutoSize = true;
            this.favoriteCheckBox.Enabled = false;
            this.favoriteCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.favoriteCheckBox.Location = new System.Drawing.Point(369, 424);
            this.favoriteCheckBox.Margin = new System.Windows.Forms.Padding(2);
            this.favoriteCheckBox.Name = "favoriteCheckBox";
            this.favoriteCheckBox.Size = new System.Drawing.Size(85, 24);
            this.favoriteCheckBox.TabIndex = 4;
            this.favoriteCheckBox.Text = "Favorite";
            this.favoriteCheckBox.UseVisualStyleBackColor = true;
            this.favoriteCheckBox.CheckedChanged += new System.EventHandler(this.favoriteCheckBox_CheckedChanged);
            // 
            // showLabel
            // 
            this.showLabel.AutoSize = true;
            this.showLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showLabel.Location = new System.Drawing.Point(165, 6);
            this.showLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.showLabel.Name = "showLabel";
            this.showLabel.Size = new System.Drawing.Size(41, 25);
            this.showLabel.TabIndex = 5;
            this.showLabel.Text = "title";
            // 
            // episodesCombo
            // 
            this.episodesCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.episodesCombo.FormattingEnabled = true;
            this.episodesCombo.Location = new System.Drawing.Point(297, 429);
            this.episodesCombo.Name = "episodesCombo";
            this.episodesCombo.Size = new System.Drawing.Size(38, 21);
            this.episodesCombo.TabIndex = 19;
            this.episodesCombo.Visible = false;
            this.episodesCombo.SelectedIndexChanged += new System.EventHandler(this.episodeCombo_SelectedIndexChanged);
            // 
            // episodeLabel
            // 
            this.episodeLabel.AutoSize = true;
            this.episodeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.episodeLabel.Location = new System.Drawing.Point(192, 429);
            this.episodeLabel.Name = "episodeLabel";
            this.episodeLabel.Size = new System.Drawing.Size(71, 20);
            this.episodeLabel.TabIndex = 18;
            this.episodeLabel.Text = "Episode:";
            this.episodeLabel.Visible = false;
            this.episodeLabel.Click += new System.EventHandler(this.episodeLabel_Click);
            // 
            // seasonsCombo
            // 
            this.seasonsCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.seasonsCombo.FormattingEnabled = true;
            this.seasonsCombo.Location = new System.Drawing.Point(120, 429);
            this.seasonsCombo.Name = "seasonsCombo";
            this.seasonsCombo.Size = new System.Drawing.Size(38, 21);
            this.seasonsCombo.TabIndex = 17;
            this.seasonsCombo.Visible = false;
            this.seasonsCombo.SelectedIndexChanged += new System.EventHandler(this.seasonsCombo_SelectedIndexChanged);
            // 
            // seasonsDecoratorLabel
            // 
            this.seasonsDecoratorLabel.AutoSize = true;
            this.seasonsDecoratorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seasonsDecoratorLabel.Location = new System.Drawing.Point(11, 428);
            this.seasonsDecoratorLabel.Name = "seasonsDecoratorLabel";
            this.seasonsDecoratorLabel.Size = new System.Drawing.Size(72, 20);
            this.seasonsDecoratorLabel.TabIndex = 16;
            this.seasonsDecoratorLabel.Text = "Season: ";
            this.seasonsDecoratorLabel.Visible = false;
            this.seasonsDecoratorLabel.Click += new System.EventHandler(this.seasonsDecoratorLabel_Click);
            // 
            // episodesLabel
            // 
            this.episodesLabel.AutoSize = true;
            this.episodesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.episodesLabel.Location = new System.Drawing.Point(147, 395);
            this.episodesLabel.Name = "episodesLabel";
            this.episodesLabel.Size = new System.Drawing.Size(38, 20);
            this.episodesLabel.TabIndex = 21;
            this.episodesLabel.Text = "Title";
            this.episodesLabel.Visible = false;
            // 
            // episodesDecoratorLabel
            // 
            this.episodesDecoratorLabel.AutoSize = true;
            this.episodesDecoratorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.episodesDecoratorLabel.Location = new System.Drawing.Point(11, 391);
            this.episodesDecoratorLabel.Name = "episodesDecoratorLabel";
            this.episodesDecoratorLabel.Size = new System.Drawing.Size(130, 24);
            this.episodesDecoratorLabel.TabIndex = 20;
            this.episodesDecoratorLabel.Text = "Episode Title: ";
            this.episodesDecoratorLabel.Visible = false;
            // 
            // Watch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(655, 514);
            this.ControlBox = false;
            this.Controls.Add(this.episodesLabel);
            this.Controls.Add(this.episodesDecoratorLabel);
            this.Controls.Add(this.episodesCombo);
            this.Controls.Add(this.episodeLabel);
            this.Controls.Add(this.seasonsCombo);
            this.Controls.Add(this.seasonsDecoratorLabel);
            this.Controls.Add(this.showLabel);
            this.Controls.Add(this.favoriteCheckBox);
            this.Controls.Add(this.userLabel);
            this.Controls.Add(this.pictureBox);
            this.Name = "Watch";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "s";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Watch_Load);
            this.Shown += new System.EventHandler(this.Watch_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Label userLabel;
        private System.Windows.Forms.CheckBox favoriteCheckBox;
        private System.Windows.Forms.Label showLabel;
        private System.Windows.Forms.ComboBox episodesCombo;
        private System.Windows.Forms.Label episodeLabel;
        private System.Windows.Forms.ComboBox seasonsCombo;
        private System.Windows.Forms.Label seasonsDecoratorLabel;
        private System.Windows.Forms.Label episodesLabel;
        private System.Windows.Forms.Label episodesDecoratorLabel;
    }
}