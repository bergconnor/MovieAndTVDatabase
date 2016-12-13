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
            this.descriptionText = new System.Windows.Forms.TextBox();
            this.actorsLabel = new System.Windows.Forms.Label();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.linkLabel = new System.Windows.Forms.LinkLabel();
            this.genresLabel = new System.Windows.Forms.Label();
            this.genresCombo = new System.Windows.Forms.TextBox();
            this.actorsCombo = new System.Windows.Forms.TextBox();
            this.channelDecoratorLabel = new System.Windows.Forms.Label();
            this.channelLabel = new System.Windows.Forms.Label();
            this.seasonsDecoratorLabel = new System.Windows.Forms.Label();
            this.seasonsCombo = new System.Windows.Forms.ComboBox();
            this.episodeLabel = new System.Windows.Forms.Label();
            this.episodesCombo = new System.Windows.Forms.ComboBox();
            this.episodesDecoratorLabel = new System.Windows.Forms.Label();
            this.episodesLabel = new System.Windows.Forms.Label();
            this.dateDecoratorLabel = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(10, 33);
            this.titleLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(71, 33);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Title";
            // 
            // descriptionText
            // 
            this.descriptionText.Location = new System.Drawing.Point(182, 251);
            this.descriptionText.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.descriptionText.Multiline = true;
            this.descriptionText.Name = "descriptionText";
            this.descriptionText.ReadOnly = true;
            this.descriptionText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.descriptionText.Size = new System.Drawing.Size(416, 71);
            this.descriptionText.TabIndex = 1;
            // 
            // actorsLabel
            // 
            this.actorsLabel.AutoSize = true;
            this.actorsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.actorsLabel.Location = new System.Drawing.Point(43, 332);
            this.actorsLabel.Name = "actorsLabel";
            this.actorsLabel.Size = new System.Drawing.Size(56, 25);
            this.actorsLabel.TabIndex = 3;
            this.actorsLabel.Text = "Cast";
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionLabel.Location = new System.Drawing.Point(43, 251);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(109, 24);
            this.descriptionLabel.TabIndex = 4;
            this.descriptionLabel.Text = "Description:";
            // 
            // linkLabel
            // 
            this.linkLabel.AutoSize = true;
            this.linkLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel.LinkArea = new System.Windows.Forms.LinkArea(6, 4);
            this.linkLabel.Location = new System.Drawing.Point(43, 446);
            this.linkLabel.Margin = new System.Windows.Forms.Padding(0);
            this.linkLabel.Name = "linkLabel";
            this.linkLabel.Size = new System.Drawing.Size(280, 22);
            this.linkLabel.TabIndex = 5;
            this.linkLabel.TabStop = true;
            this.linkLabel.Text = "Click here to visit the show\'s homepage!";
            this.linkLabel.UseCompatibleTextRendering = true;
            this.linkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.homepageLink_LinkClicked);
            // 
            // genresLabel
            // 
            this.genresLabel.AutoSize = true;
            this.genresLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genresLabel.Location = new System.Drawing.Point(388, 332);
            this.genresLabel.Name = "genresLabel";
            this.genresLabel.Size = new System.Drawing.Size(82, 25);
            this.genresLabel.TabIndex = 7;
            this.genresLabel.Text = "Genres";
            // 
            // genresCombo
            // 
            this.genresCombo.Location = new System.Drawing.Point(392, 360);
            this.genresCombo.Multiline = true;
            this.genresCombo.Name = "genresCombo";
            this.genresCombo.ReadOnly = true;
            this.genresCombo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.genresCombo.Size = new System.Drawing.Size(205, 67);
            this.genresCombo.TabIndex = 8;
            // 
            // actorsCombo
            // 
            this.actorsCombo.Location = new System.Drawing.Point(43, 360);
            this.actorsCombo.Multiline = true;
            this.actorsCombo.Name = "actorsCombo";
            this.actorsCombo.ReadOnly = true;
            this.actorsCombo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.actorsCombo.Size = new System.Drawing.Size(303, 67);
            this.actorsCombo.TabIndex = 9;
            // 
            // channelDecoratorLabel
            // 
            this.channelDecoratorLabel.AutoSize = true;
            this.channelDecoratorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.channelDecoratorLabel.Location = new System.Drawing.Point(43, 88);
            this.channelDecoratorLabel.Name = "channelDecoratorLabel";
            this.channelDecoratorLabel.Size = new System.Drawing.Size(89, 24);
            this.channelDecoratorLabel.TabIndex = 10;
            this.channelDecoratorLabel.Text = "Network: ";
            this.channelDecoratorLabel.Visible = false;
            // 
            // channelLabel
            // 
            this.channelLabel.AutoSize = true;
            this.channelLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.channelLabel.Location = new System.Drawing.Point(182, 88);
            this.channelLabel.Name = "channelLabel";
            this.channelLabel.Size = new System.Drawing.Size(79, 24);
            this.channelLabel.TabIndex = 11;
            this.channelLabel.Text = "Network";
            this.channelLabel.Visible = false;
            // 
            // seasonsDecoratorLabel
            // 
            this.seasonsDecoratorLabel.AutoSize = true;
            this.seasonsDecoratorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seasonsDecoratorLabel.Location = new System.Drawing.Point(43, 126);
            this.seasonsDecoratorLabel.Name = "seasonsDecoratorLabel";
            this.seasonsDecoratorLabel.Size = new System.Drawing.Size(84, 24);
            this.seasonsDecoratorLabel.TabIndex = 12;
            this.seasonsDecoratorLabel.Text = "Season: ";
            this.seasonsDecoratorLabel.Visible = false;
            // 
            // seasonsCombo
            // 
            this.seasonsCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.seasonsCombo.FormattingEnabled = true;
            this.seasonsCombo.Location = new System.Drawing.Point(182, 128);
            this.seasonsCombo.Name = "seasonsCombo";
            this.seasonsCombo.Size = new System.Drawing.Size(38, 21);
            this.seasonsCombo.TabIndex = 13;
            this.seasonsCombo.Visible = false;
            this.seasonsCombo.SelectedIndexChanged += new System.EventHandler(this.seasonsCombo_SelectedIndexChanged);
            // 
            // episodeLabel
            // 
            this.episodeLabel.AutoSize = true;
            this.episodeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.episodeLabel.Location = new System.Drawing.Point(277, 126);
            this.episodeLabel.Name = "episodeLabel";
            this.episodeLabel.Size = new System.Drawing.Size(85, 24);
            this.episodeLabel.TabIndex = 14;
            this.episodeLabel.Text = "Episode:";
            this.episodeLabel.Visible = false;
            // 
            // episodesCombo
            // 
            this.episodesCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.episodesCombo.FormattingEnabled = true;
            this.episodesCombo.Location = new System.Drawing.Point(371, 128);
            this.episodesCombo.Name = "episodesCombo";
            this.episodesCombo.Size = new System.Drawing.Size(38, 21);
            this.episodesCombo.TabIndex = 15;
            this.episodesCombo.Visible = false;
            this.episodesCombo.SelectedIndexChanged += new System.EventHandler(this.episodeCombo_SelectedIndexChanged);
            // 
            // episodesDecoratorLabel
            // 
            this.episodesDecoratorLabel.AutoSize = true;
            this.episodesDecoratorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.episodesDecoratorLabel.Location = new System.Drawing.Point(43, 180);
            this.episodesDecoratorLabel.Name = "episodesDecoratorLabel";
            this.episodesDecoratorLabel.Size = new System.Drawing.Size(130, 24);
            this.episodesDecoratorLabel.TabIndex = 16;
            this.episodesDecoratorLabel.Text = "Episode Title: ";
            this.episodesDecoratorLabel.Visible = false;
            // 
            // episodesLabel
            // 
            this.episodesLabel.AutoSize = true;
            this.episodesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.episodesLabel.Location = new System.Drawing.Point(182, 180);
            this.episodesLabel.Name = "episodesLabel";
            this.episodesLabel.Size = new System.Drawing.Size(45, 24);
            this.episodesLabel.TabIndex = 17;
            this.episodesLabel.Text = "Title";
            this.episodesLabel.Visible = false;
            // 
            // dateDecoratorLabel
            // 
            this.dateDecoratorLabel.AutoSize = true;
            this.dateDecoratorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateDecoratorLabel.Location = new System.Drawing.Point(43, 216);
            this.dateDecoratorLabel.Name = "dateDecoratorLabel";
            this.dateDecoratorLabel.Size = new System.Drawing.Size(86, 24);
            this.dateDecoratorLabel.TabIndex = 20;
            this.dateDecoratorLabel.Text = "Air Date: ";
            this.dateDecoratorLabel.Visible = false;
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateLabel.Location = new System.Drawing.Point(182, 216);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(48, 24);
            this.dateLabel.TabIndex = 21;
            this.dateLabel.Text = "Date";
            this.dateLabel.Visible = false;
            // 
            // Information
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 475);
            this.ControlBox = false;
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.dateDecoratorLabel);
            this.Controls.Add(this.episodesLabel);
            this.Controls.Add(this.episodesDecoratorLabel);
            this.Controls.Add(this.episodesCombo);
            this.Controls.Add(this.episodeLabel);
            this.Controls.Add(this.seasonsCombo);
            this.Controls.Add(this.seasonsDecoratorLabel);
            this.Controls.Add(this.channelLabel);
            this.Controls.Add(this.channelDecoratorLabel);
            this.Controls.Add(this.actorsCombo);
            this.Controls.Add(this.genresCombo);
            this.Controls.Add(this.genresLabel);
            this.Controls.Add(this.linkLabel);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.actorsLabel);
            this.Controls.Add(this.descriptionText);
            this.Controls.Add(this.titleLabel);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "Information";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Shown += new System.EventHandler(this.Information_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.TextBox descriptionText;
        private System.Windows.Forms.Label actorsLabel;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.LinkLabel linkLabel;
        private System.Windows.Forms.Label genresLabel;
        private System.Windows.Forms.TextBox genresCombo;
        private System.Windows.Forms.TextBox actorsCombo;
        private System.Windows.Forms.Label channelDecoratorLabel;
        private System.Windows.Forms.Label channelLabel;
        private System.Windows.Forms.Label seasonsDecoratorLabel;
        private System.Windows.Forms.ComboBox seasonsCombo;
        private System.Windows.Forms.Label episodeLabel;
        private System.Windows.Forms.ComboBox episodesCombo;
        private System.Windows.Forms.Label episodesDecoratorLabel;
        private System.Windows.Forms.Label episodesLabel;
        private System.Windows.Forms.Label dateDecoratorLabel;
        private System.Windows.Forms.Label dateLabel;
    }
}