namespace MovieAndTVDatabase
{
    partial class Home
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
            this.label1 = new System.Windows.Forms.Label();
            this.usersCombo = new System.Windows.Forms.ComboBox();
            this.logoutBtn = new System.Windows.Forms.Button();
            this.genreCombo = new System.Windows.Forms.ComboBox();
            this.searchLabel = new System.Windows.Forms.Label();
            this.userLabel = new System.Windows.Forms.Label();
            this.genreLabel = new System.Windows.Forms.Label();
            this.actorLabel = new System.Windows.Forms.Label();
            this.actorText = new System.Windows.Forms.TextBox();
            this.showLabel = new System.Windows.Forms.Label();
            this.showText = new System.Windows.Forms.TextBox();
            this.resultCombo = new System.Windows.Forms.ComboBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.infoButton = new System.Windows.Forms.Button();
            this.resultLabel = new System.Windows.Forms.Label();
            this.watchButton = new System.Windows.Forms.Button();
            this.movieLabel = new System.Windows.Forms.Label();
            this.movieCombo = new System.Windows.Forms.ComboBox();
            this.recommendButton = new System.Windows.Forms.Button();
            this.HistoryButton = new System.Windows.Forms.Button();
            this.FavoritesButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(554, 52);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(490, 114);
            this.label1.TabIndex = 0;
            this.label1.Text = "Home";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // usersCombo
            // 
            this.usersCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.usersCombo.FormattingEnabled = true;
            this.usersCombo.Location = new System.Drawing.Point(32, 116);
            this.usersCombo.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.usersCombo.MaxDropDownItems = 5;
            this.usersCombo.Name = "usersCombo";
            this.usersCombo.Size = new System.Drawing.Size(302, 39);
            this.usersCombo.TabIndex = 1;
            this.usersCombo.SelectedIndexChanged += new System.EventHandler(this.usersCombo_SelectedIndexChanged);
            // 
            // logoutBtn
            // 
            this.logoutBtn.Location = new System.Drawing.Point(1406, 62);
            this.logoutBtn.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.logoutBtn.Name = "logoutBtn";
            this.logoutBtn.Size = new System.Drawing.Size(200, 54);
            this.logoutBtn.TabIndex = 2;
            this.logoutBtn.Text = "Logout";
            this.logoutBtn.UseVisualStyleBackColor = true;
            this.logoutBtn.Click += new System.EventHandler(this.logoutBtn_Click);
            // 
            // genreCombo
            // 
            this.genreCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.genreCombo.Enabled = false;
            this.genreCombo.FormattingEnabled = true;
            this.genreCombo.Location = new System.Drawing.Point(30, 709);
            this.genreCombo.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.genreCombo.MaxDropDownItems = 5;
            this.genreCombo.Name = "genreCombo";
            this.genreCombo.Size = new System.Drawing.Size(482, 39);
            this.genreCombo.TabIndex = 3;
            // 
            // searchLabel
            // 
            this.searchLabel.AutoSize = true;
            this.searchLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchLabel.Location = new System.Drawing.Point(574, 442);
            this.searchLabel.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.searchLabel.Name = "searchLabel";
            this.searchLabel.Size = new System.Drawing.Size(438, 135);
            this.searchLabel.TabIndex = 4;
            this.searchLabel.Text = "Search";
            // 
            // userLabel
            // 
            this.userLabel.AutoSize = true;
            this.userLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userLabel.Location = new System.Drawing.Point(32, 52);
            this.userLabel.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.userLabel.Name = "userLabel";
            this.userLabel.Size = new System.Drawing.Size(301, 61);
            this.userLabel.TabIndex = 5;
            this.userLabel.Text = "Select User";
            // 
            // genreLabel
            // 
            this.genreLabel.AutoSize = true;
            this.genreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genreLabel.Location = new System.Drawing.Point(32, 643);
            this.genreLabel.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.genreLabel.Name = "genreLabel";
            this.genreLabel.Size = new System.Drawing.Size(200, 61);
            this.genreLabel.TabIndex = 6;
            this.genreLabel.Text = "Genres";
            // 
            // actorLabel
            // 
            this.actorLabel.AutoSize = true;
            this.actorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.actorLabel.Location = new System.Drawing.Point(32, 763);
            this.actorLabel.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.actorLabel.Name = "actorLabel";
            this.actorLabel.Size = new System.Drawing.Size(344, 61);
            this.actorLabel.TabIndex = 7;
            this.actorLabel.Text = "Actor/Actress";
            // 
            // actorText
            // 
            this.actorText.Enabled = false;
            this.actorText.Location = new System.Drawing.Point(30, 829);
            this.actorText.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.actorText.Name = "actorText";
            this.actorText.Size = new System.Drawing.Size(482, 38);
            this.actorText.TabIndex = 8;
            // 
            // showLabel
            // 
            this.showLabel.AutoSize = true;
            this.showLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showLabel.Location = new System.Drawing.Point(32, 513);
            this.showLabel.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.showLabel.Name = "showLabel";
            this.showLabel.Size = new System.Drawing.Size(274, 61);
            this.showLabel.TabIndex = 9;
            this.showLabel.Text = "Show Title";
            // 
            // showText
            // 
            this.showText.Enabled = false;
            this.showText.Location = new System.Drawing.Point(30, 591);
            this.showText.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.showText.Name = "showText";
            this.showText.Size = new System.Drawing.Size(482, 38);
            this.showText.TabIndex = 10;
            // 
            // resultCombo
            // 
            this.resultCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.resultCombo.Enabled = false;
            this.resultCombo.FormattingEnabled = true;
            this.resultCombo.Location = new System.Drawing.Point(600, 659);
            this.resultCombo.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.resultCombo.Name = "resultCombo";
            this.resultCombo.Size = new System.Drawing.Size(870, 384);
            this.resultCombo.TabIndex = 11;
            this.resultCombo.SelectedIndexChanged += new System.EventHandler(this.resultCombo_SelectedIndexChanged);
            // 
            // searchButton
            // 
            this.searchButton.Enabled = false;
            this.searchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchButton.Location = new System.Drawing.Point(30, 1050);
            this.searchButton.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(446, 112);
            this.searchButton.TabIndex = 12;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // infoButton
            // 
            this.infoButton.Enabled = false;
            this.infoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoButton.Location = new System.Drawing.Point(600, 1058);
            this.infoButton.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.infoButton.Name = "infoButton";
            this.infoButton.Size = new System.Drawing.Size(390, 81);
            this.infoButton.TabIndex = 13;
            this.infoButton.Text = "More Information";
            this.infoButton.UseVisualStyleBackColor = true;
            this.infoButton.Click += new System.EventHandler(this.infoButton_Click);
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultLabel.Location = new System.Drawing.Point(952, 591);
            this.resultLabel.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(205, 61);
            this.resultLabel.TabIndex = 14;
            this.resultLabel.Text = "Results";
            // 
            // watchButton
            // 
            this.watchButton.Enabled = false;
            this.watchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.watchButton.Location = new System.Drawing.Point(1088, 1058);
            this.watchButton.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.watchButton.Name = "watchButton";
            this.watchButton.Size = new System.Drawing.Size(390, 81);
            this.watchButton.TabIndex = 15;
            this.watchButton.Text = "Watch Show";
            this.watchButton.UseVisualStyleBackColor = true;
            this.watchButton.Click += new System.EventHandler(this.watchButton_Click);
            // 
            // movieLabel
            // 
            this.movieLabel.AutoSize = true;
            this.movieLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.movieLabel.Location = new System.Drawing.Point(32, 885);
            this.movieLabel.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.movieLabel.Name = "movieLabel";
            this.movieLabel.Size = new System.Drawing.Size(251, 61);
            this.movieLabel.TabIndex = 16;
            this.movieLabel.Text = "Movie/TV";
            // 
            // movieCombo
            // 
            this.movieCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.movieCombo.Enabled = false;
            this.movieCombo.FormattingEnabled = true;
            this.movieCombo.Location = new System.Drawing.Point(32, 951);
            this.movieCombo.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.movieCombo.Name = "movieCombo";
            this.movieCombo.Size = new System.Drawing.Size(478, 39);
            this.movieCombo.TabIndex = 17;
            // 
            // recommendButton
            // 
            this.recommendButton.Enabled = false;
            this.recommendButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recommendButton.Location = new System.Drawing.Point(32, 203);
            this.recommendButton.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.recommendButton.Name = "recommendButton";
            this.recommendButton.Size = new System.Drawing.Size(310, 116);
            this.recommendButton.TabIndex = 18;
            this.recommendButton.Text = "Recommend Shows";
            this.recommendButton.UseVisualStyleBackColor = true;
            this.recommendButton.Click += new System.EventHandler(this.recommendButton_Click);
            // 
            // HistoryButton
            // 
            this.HistoryButton.Enabled = false;
            this.HistoryButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HistoryButton.Location = new System.Drawing.Point(402, 203);
            this.HistoryButton.Margin = new System.Windows.Forms.Padding(8);
            this.HistoryButton.Name = "HistoryButton";
            this.HistoryButton.Size = new System.Drawing.Size(310, 116);
            this.HistoryButton.TabIndex = 19;
            this.HistoryButton.Text = "Watch History";
            this.HistoryButton.UseVisualStyleBackColor = true;
            this.HistoryButton.Click += new System.EventHandler(this.HistoryButton_Click);
            // 
            // FavoritesButton
            // 
            this.FavoritesButton.Enabled = false;
            this.FavoritesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FavoritesButton.Location = new System.Drawing.Point(801, 203);
            this.FavoritesButton.Margin = new System.Windows.Forms.Padding(8);
            this.FavoritesButton.Name = "FavoritesButton";
            this.FavoritesButton.Size = new System.Drawing.Size(310, 116);
            this.FavoritesButton.TabIndex = 20;
            this.FavoritesButton.Text = "Favorite Shows";
            this.FavoritesButton.UseVisualStyleBackColor = true;
            this.FavoritesButton.Click += new System.EventHandler(this.Fav_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1638, 1190);
            this.ControlBox = false;
            this.Controls.Add(this.FavoritesButton);
            this.Controls.Add(this.HistoryButton);
            this.Controls.Add(this.recommendButton);
            this.Controls.Add(this.movieCombo);
            this.Controls.Add(this.movieLabel);
            this.Controls.Add(this.watchButton);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.infoButton);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.resultCombo);
            this.Controls.Add(this.showText);
            this.Controls.Add(this.showLabel);
            this.Controls.Add(this.actorText);
            this.Controls.Add(this.actorLabel);
            this.Controls.Add(this.genreLabel);
            this.Controls.Add(this.userLabel);
            this.Controls.Add(this.searchLabel);
            this.Controls.Add(this.genreCombo);
            this.Controls.Add(this.logoutBtn);
            this.Controls.Add(this.usersCombo);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.MaximizeBox = false;
            this.Name = "Home";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Shown += new System.EventHandler(this.Home_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox usersCombo;
        private System.Windows.Forms.Button logoutBtn;
        private System.Windows.Forms.ComboBox genreCombo;
        private System.Windows.Forms.Label searchLabel;
        private System.Windows.Forms.Label userLabel;
        private System.Windows.Forms.Label genreLabel;
        private System.Windows.Forms.Label actorLabel;
        private System.Windows.Forms.TextBox actorText;
        private System.Windows.Forms.Label showLabel;
        private System.Windows.Forms.TextBox showText;
        private System.Windows.Forms.ComboBox resultCombo;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button infoButton;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.Button watchButton;
        private System.Windows.Forms.Label movieLabel;
        private System.Windows.Forms.ComboBox movieCombo;
        private System.Windows.Forms.Button recommendButton;
        private System.Windows.Forms.Button HistoryButton;
        private System.Windows.Forms.Button FavoritesButton;
    }
}