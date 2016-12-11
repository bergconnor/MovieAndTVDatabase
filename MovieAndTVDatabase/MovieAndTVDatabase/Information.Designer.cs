namespace MovieAndTVDatabase
{
    partial class Information
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
            this.titleLabel = new System.Windows.Forms.Label();
            this.descriptionTxt = new System.Windows.Forms.TextBox();
            this.actorLabel = new System.Windows.Forms.Label();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.homepageLink = new System.Windows.Forms.LinkLabel();
            this.homepageLabel = new System.Windows.Forms.Label();
            this.genreLabel = new System.Windows.Forms.Label();
            this.genreCombo = new System.Windows.Forms.TextBox();
            this.actorsCombo = new System.Windows.Forms.TextBox();
            this.channelLabel = new System.Windows.Forms.Label();
            this.channel2Label = new System.Windows.Forms.Label();
            this.seLabel = new System.Windows.Forms.Label();
            this.seCombo = new System.Windows.Forms.ComboBox();
            this.episodeLabel = new System.Windows.Forms.Label();
            this.episodeCombo = new System.Windows.Forms.ComboBox();
            this.etitleLabel1 = new System.Windows.Forms.Label();
            this.etitleLabel2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(10, 25);
            this.titleLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(71, 33);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Title";
            // 
            // descriptionTxt
            // 
            this.descriptionTxt.Location = new System.Drawing.Point(157, 317);
            this.descriptionTxt.Margin = new System.Windows.Forms.Padding(2);
            this.descriptionTxt.Multiline = true;
            this.descriptionTxt.Name = "descriptionTxt";
            this.descriptionTxt.ReadOnly = true;
            this.descriptionTxt.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.descriptionTxt.Size = new System.Drawing.Size(419, 84);
            this.descriptionTxt.TabIndex = 1;
            // 
            // actorLabel
            // 
            this.actorLabel.AutoSize = true;
            this.actorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.actorLabel.Location = new System.Drawing.Point(7, 187);
            this.actorLabel.Name = "actorLabel";
            this.actorLabel.Size = new System.Drawing.Size(140, 25);
            this.actorLabel.TabIndex = 3;
            this.actorLabel.Text = "Actor/Actress";
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionLabel.Location = new System.Drawing.Point(7, 317);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(135, 29);
            this.descriptionLabel.TabIndex = 4;
            this.descriptionLabel.Text = "Description";
            // 
            // homepageLink
            // 
            this.homepageLink.AutoSize = true;
            this.homepageLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homepageLink.Location = new System.Drawing.Point(149, 414);
            this.homepageLink.Name = "homepageLink";
            this.homepageLink.Size = new System.Drawing.Size(73, 18);
            this.homepageLink.TabIndex = 5;
            this.homepageLink.TabStop = true;
            this.homepageLink.Text = "linkLabel1";
            this.homepageLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.homepageLink_LinkClicked);
            // 
            // homepageLabel
            // 
            this.homepageLabel.AutoSize = true;
            this.homepageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homepageLabel.Location = new System.Drawing.Point(7, 407);
            this.homepageLabel.Name = "homepageLabel";
            this.homepageLabel.Size = new System.Drawing.Size(136, 25);
            this.homepageLabel.TabIndex = 6;
            this.homepageLabel.Text = "Home Page: ";
            // 
            // genreLabel
            // 
            this.genreLabel.AutoSize = true;
            this.genreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genreLabel.Location = new System.Drawing.Point(274, 187);
            this.genreLabel.Name = "genreLabel";
            this.genreLabel.Size = new System.Drawing.Size(82, 25);
            this.genreLabel.TabIndex = 7;
            this.genreLabel.Text = "Genres";
            // 
            // genreCombo
            // 
            this.genreCombo.Location = new System.Drawing.Point(279, 215);
            this.genreCombo.Multiline = true;
            this.genreCombo.Name = "genreCombo";
            this.genreCombo.ReadOnly = true;
            this.genreCombo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.genreCombo.Size = new System.Drawing.Size(205, 86);
            this.genreCombo.TabIndex = 8;
            // 
            // actorsCombo
            // 
            this.actorsCombo.Location = new System.Drawing.Point(12, 215);
            this.actorsCombo.Multiline = true;
            this.actorsCombo.Name = "actorsCombo";
            this.actorsCombo.ReadOnly = true;
            this.actorsCombo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.actorsCombo.Size = new System.Drawing.Size(236, 86);
            this.actorsCombo.TabIndex = 9;
            // 
            // channelLabel
            // 
            this.channelLabel.AutoSize = true;
            this.channelLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.channelLabel.Location = new System.Drawing.Point(12, 63);
            this.channelLabel.Name = "channelLabel";
            this.channelLabel.Size = new System.Drawing.Size(104, 25);
            this.channelLabel.TabIndex = 10;
            this.channelLabel.Text = "Channel: ";
            this.channelLabel.Visible = false;
            // 
            // channel2Label
            // 
            this.channel2Label.AutoSize = true;
            this.channel2Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.channel2Label.Location = new System.Drawing.Point(115, 68);
            this.channel2Label.Name = "channel2Label";
            this.channel2Label.Size = new System.Drawing.Size(51, 20);
            this.channel2Label.TabIndex = 11;
            this.channel2Label.Text = "label1";
            this.channel2Label.Visible = false;
            // 
            // seLabel
            // 
            this.seLabel.AutoSize = true;
            this.seLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seLabel.Location = new System.Drawing.Point(7, 149);
            this.seLabel.Name = "seLabel";
            this.seLabel.Size = new System.Drawing.Size(108, 25);
            this.seLabel.TabIndex = 12;
            this.seLabel.Text = "Seasons: ";
            this.seLabel.Visible = false;
            // 
            // seCombo
            // 
            this.seCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.seCombo.FormattingEnabled = true;
            this.seCombo.Location = new System.Drawing.Point(106, 155);
            this.seCombo.Name = "seCombo";
            this.seCombo.Size = new System.Drawing.Size(60, 21);
            this.seCombo.TabIndex = 13;
            this.seCombo.Visible = false;
            this.seCombo.SelectedIndexChanged += new System.EventHandler(this.seCombo_SelectedIndexChanged);
            // 
            // episodeLabel
            // 
            this.episodeLabel.AutoSize = true;
            this.episodeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.episodeLabel.Location = new System.Drawing.Point(194, 150);
            this.episodeLabel.Name = "episodeLabel";
            this.episodeLabel.Size = new System.Drawing.Size(89, 24);
            this.episodeLabel.TabIndex = 14;
            this.episodeLabel.Text = "Episodes";
            this.episodeLabel.Visible = false;
            // 
            // episodeCombo
            // 
            this.episodeCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.episodeCombo.FormattingEnabled = true;
            this.episodeCombo.Location = new System.Drawing.Point(289, 153);
            this.episodeCombo.Name = "episodeCombo";
            this.episodeCombo.Size = new System.Drawing.Size(54, 21);
            this.episodeCombo.TabIndex = 15;
            this.episodeCombo.Visible = false;
            this.episodeCombo.SelectedIndexChanged += new System.EventHandler(this.episodeCombo_SelectedIndexChanged);
            // 
            // etitleLabel1
            // 
            this.etitleLabel1.AutoSize = true;
            this.etitleLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.etitleLabel1.Location = new System.Drawing.Point(12, 102);
            this.etitleLabel1.Name = "etitleLabel1";
            this.etitleLabel1.Size = new System.Drawing.Size(130, 24);
            this.etitleLabel1.TabIndex = 16;
            this.etitleLabel1.Text = "Episode Title: ";
            this.etitleLabel1.Visible = false;
            // 
            // etitleLabel2
            // 
            this.etitleLabel2.AutoSize = true;
            this.etitleLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.etitleLabel2.Location = new System.Drawing.Point(137, 105);
            this.etitleLabel2.Name = "etitleLabel2";
            this.etitleLabel2.Size = new System.Drawing.Size(38, 20);
            this.etitleLabel2.TabIndex = 17;
            this.etitleLabel2.Text = "Title";
            this.etitleLabel2.Visible = false;
            // 
            // Information
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 475);
            this.ControlBox = false;
            this.Controls.Add(this.etitleLabel2);
            this.Controls.Add(this.etitleLabel1);
            this.Controls.Add(this.episodeCombo);
            this.Controls.Add(this.episodeLabel);
            this.Controls.Add(this.seCombo);
            this.Controls.Add(this.seLabel);
            this.Controls.Add(this.channel2Label);
            this.Controls.Add(this.channelLabel);
            this.Controls.Add(this.actorsCombo);
            this.Controls.Add(this.genreCombo);
            this.Controls.Add(this.genreLabel);
            this.Controls.Add(this.homepageLabel);
            this.Controls.Add(this.homepageLink);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.actorLabel);
            this.Controls.Add(this.descriptionTxt);
            this.Controls.Add(this.titleLabel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "Information";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.TextBox descriptionTxt;
        private System.Windows.Forms.Label actorLabel;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.LinkLabel homepageLink;
        private System.Windows.Forms.Label homepageLabel;
        private System.Windows.Forms.Label genreLabel;
        private System.Windows.Forms.TextBox genreCombo;
        private System.Windows.Forms.TextBox actorsCombo;
        private System.Windows.Forms.Label channelLabel;
        private System.Windows.Forms.Label channel2Label;
        private System.Windows.Forms.Label seLabel;
        private System.Windows.Forms.ComboBox seCombo;
        private System.Windows.Forms.Label episodeLabel;
        private System.Windows.Forms.ComboBox episodeCombo;
        private System.Windows.Forms.Label etitleLabel1;
        private System.Windows.Forms.Label etitleLabel2;
    }
}