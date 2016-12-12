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
            this.usersCombo = new System.Windows.Forms.ComboBox();
            this.logoutButton = new System.Windows.Forms.Button();
            this.genreCombo = new System.Windows.Forms.ComboBox();
            this.userLabel = new System.Windows.Forms.Label();
            this.genreLabel = new System.Windows.Forms.Label();
            this.actorLabel = new System.Windows.Forms.Label();
            this.actorText = new System.Windows.Forms.TextBox();
            this.showLabel = new System.Windows.Forms.Label();
            this.showText = new System.Windows.Forms.TextBox();
            this.resultsCombo = new System.Windows.Forms.ComboBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.infoButton = new System.Windows.Forms.Button();
            this.resultLabel = new System.Windows.Forms.Label();
            this.watchButton = new System.Windows.Forms.Button();
            this.movieLabel = new System.Windows.Forms.Label();
            this.movieCombo = new System.Windows.Forms.ComboBox();
            this.recommendButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // usersCombo
            // 
            this.usersCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.usersCombo.FormattingEnabled = true;
            this.usersCombo.Location = new System.Drawing.Point(16, 139);
            this.usersCombo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.usersCombo.MaxDropDownItems = 5;
            this.usersCombo.Name = "usersCombo";
            this.usersCombo.Size = new System.Drawing.Size(277, 24);
            this.usersCombo.TabIndex = 1;
            this.usersCombo.SelectedIndexChanged += new System.EventHandler(this.usersCombo_SelectedIndexChanged);
            // 
            // logoutButton
            // 
            this.logoutButton.Location = new System.Drawing.Point(706, 51);
            this.logoutButton.Margin = new System.Windows.Forms.Padding(4);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(100, 28);
            this.logoutButton.TabIndex = 2;
            this.logoutButton.Text = "Logout";
            this.logoutButton.UseVisualStyleBackColor = true;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // genreCombo
            // 
            this.genreCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.genreCombo.Enabled = false;
            this.genreCombo.FormattingEnabled = true;
            this.genreCombo.Location = new System.Drawing.Point(16, 354);
            this.genreCombo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.genreCombo.MaxDropDownItems = 5;
            this.genreCombo.Name = "genreCombo";
            this.genreCombo.Size = new System.Drawing.Size(277, 24);
            this.genreCombo.TabIndex = 3;
            // 
            // userLabel
            // 
            this.userLabel.AutoSize = true;
            this.userLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userLabel.Location = new System.Drawing.Point(16, 106);
            this.userLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.userLabel.Name = "userLabel";
            this.userLabel.Size = new System.Drawing.Size(155, 31);
            this.userLabel.TabIndex = 5;
            this.userLabel.Text = "Select User";
            // 
            // genreLabel
            // 
            this.genreLabel.AutoSize = true;
            this.genreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genreLabel.Location = new System.Drawing.Point(16, 316);
            this.genreLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.genreLabel.Name = "genreLabel";
            this.genreLabel.Size = new System.Drawing.Size(103, 31);
            this.genreLabel.TabIndex = 6;
            this.genreLabel.Text = "Genres";
            // 
            // actorLabel
            // 
            this.actorLabel.AutoSize = true;
            this.actorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.actorLabel.Location = new System.Drawing.Point(16, 385);
            this.actorLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.actorLabel.Name = "actorLabel";
            this.actorLabel.Size = new System.Drawing.Size(178, 31);
            this.actorLabel.TabIndex = 7;
            this.actorLabel.Text = "Actor/Actress";
            // 
            // actorText
            // 
            this.actorText.Enabled = false;
            this.actorText.Location = new System.Drawing.Point(16, 423);
            this.actorText.Margin = new System.Windows.Forms.Padding(4);
            this.actorText.Name = "actorText";
            this.actorText.Size = new System.Drawing.Size(277, 22);
            this.actorText.TabIndex = 8;
            // 
            // showLabel
            // 
            this.showLabel.AutoSize = true;
            this.showLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showLabel.Location = new System.Drawing.Point(16, 249);
            this.showLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.showLabel.Name = "showLabel";
            this.showLabel.Size = new System.Drawing.Size(141, 31);
            this.showLabel.TabIndex = 9;
            this.showLabel.Text = "Show Title";
            // 
            // showText
            // 
            this.showText.Enabled = false;
            this.showText.Location = new System.Drawing.Point(16, 287);
            this.showText.Margin = new System.Windows.Forms.Padding(4);
            this.showText.Name = "showText";
            this.showText.Size = new System.Drawing.Size(277, 22);
            this.showText.TabIndex = 10;
            // 
            // resultsCombo
            // 
            this.resultsCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.resultsCombo.Enabled = false;
            this.resultsCombo.FormattingEnabled = true;
            this.resultsCombo.Location = new System.Drawing.Point(320, 316);
            this.resultsCombo.Margin = new System.Windows.Forms.Padding(4);
            this.resultsCombo.Name = "resultsCombo";
            this.resultsCombo.Size = new System.Drawing.Size(486, 200);
            this.resultsCombo.TabIndex = 11;
            this.resultsCombo.SelectedIndexChanged += new System.EventHandler(this.resultCombo_SelectedIndexChanged);
            // 
            // searchButton
            // 
            this.searchButton.Enabled = false;
            this.searchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchButton.Location = new System.Drawing.Point(16, 534);
            this.searchButton.Margin = new System.Windows.Forms.Padding(4);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(277, 46);
            this.searchButton.TabIndex = 12;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // infoButton
            // 
            this.infoButton.Enabled = false;
            this.infoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoButton.Location = new System.Drawing.Point(320, 541);
            this.infoButton.Margin = new System.Windows.Forms.Padding(4);
            this.infoButton.Name = "infoButton";
            this.infoButton.Size = new System.Drawing.Size(213, 42);
            this.infoButton.TabIndex = 13;
            this.infoButton.Text = "More Information";
            this.infoButton.UseVisualStyleBackColor = true;
            this.infoButton.Click += new System.EventHandler(this.infoButton_Click);
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultLabel.Location = new System.Drawing.Point(515, 281);
            this.resultLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(106, 31);
            this.resultLabel.TabIndex = 14;
            this.resultLabel.Text = "Results";
            // 
            // watchButton
            // 
            this.watchButton.Enabled = false;
            this.watchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.watchButton.Location = new System.Drawing.Point(593, 541);
            this.watchButton.Margin = new System.Windows.Forms.Padding(4);
            this.watchButton.Name = "watchButton";
            this.watchButton.Size = new System.Drawing.Size(213, 42);
            this.watchButton.TabIndex = 15;
            this.watchButton.Text = "Watch Show";
            this.watchButton.UseVisualStyleBackColor = true;
            this.watchButton.Click += new System.EventHandler(this.watchButton_Click);
            // 
            // movieLabel
            // 
            this.movieLabel.AutoSize = true;
            this.movieLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.movieLabel.Location = new System.Drawing.Point(16, 452);
            this.movieLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.movieLabel.Name = "movieLabel";
            this.movieLabel.Size = new System.Drawing.Size(129, 31);
            this.movieLabel.TabIndex = 16;
            this.movieLabel.Text = "Movie/TV";
            // 
            // movieCombo
            // 
            this.movieCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.movieCombo.Enabled = false;
            this.movieCombo.FormattingEnabled = true;
            this.movieCombo.Location = new System.Drawing.Point(16, 490);
            this.movieCombo.Margin = new System.Windows.Forms.Padding(4);
            this.movieCombo.Name = "movieCombo";
            this.movieCombo.Size = new System.Drawing.Size(277, 24);
            this.movieCombo.TabIndex = 17;
            // 
            // recommendButton
            // 
            this.recommendButton.Enabled = false;
            this.recommendButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recommendButton.Location = new System.Drawing.Point(16, 184);
            this.recommendButton.Margin = new System.Windows.Forms.Padding(4);
            this.recommendButton.Name = "recommendButton";
            this.recommendButton.Size = new System.Drawing.Size(277, 46);
            this.recommendButton.TabIndex = 18;
            this.recommendButton.Text = "Recommend Shows";
            this.recommendButton.UseVisualStyleBackColor = true;
            this.recommendButton.Click += new System.EventHandler(this.recommendButton_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(308, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 59);
            this.label1.TabIndex = 0;
            this.label1.Text = "Home";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Home
            // 
            this.AcceptButton = this.searchButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 643);
            this.ControlBox = false;
            this.Controls.Add(this.recommendButton);
            this.Controls.Add(this.movieCombo);
            this.Controls.Add(this.movieLabel);
            this.Controls.Add(this.watchButton);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.infoButton);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.resultsCombo);
            this.Controls.Add(this.showText);
            this.Controls.Add(this.showLabel);
            this.Controls.Add(this.actorText);
            this.Controls.Add(this.actorLabel);
            this.Controls.Add(this.genreLabel);
            this.Controls.Add(this.userLabel);
            this.Controls.Add(this.genreCombo);
            this.Controls.Add(this.logoutButton);
            this.Controls.Add(this.usersCombo);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
        private System.Windows.Forms.ComboBox usersCombo;
        private System.Windows.Forms.Button logoutButton;
        private System.Windows.Forms.ComboBox genreCombo;
        private System.Windows.Forms.Label userLabel;
        private System.Windows.Forms.Label genreLabel;
        private System.Windows.Forms.Label actorLabel;
        private System.Windows.Forms.TextBox actorText;
        private System.Windows.Forms.Label showLabel;
        private System.Windows.Forms.TextBox showText;
        private System.Windows.Forms.ComboBox resultsCombo;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button infoButton;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.Button watchButton;
        private System.Windows.Forms.Label movieLabel;
        private System.Windows.Forms.ComboBox movieCombo;
        private System.Windows.Forms.Button recommendButton;
        private System.Windows.Forms.Label label1;
    }
}