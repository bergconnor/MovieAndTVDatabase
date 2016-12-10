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
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(171, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(270, 75);
            this.label1.TabIndex = 0;
            this.label1.Text = "Home2";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // usersCombo
            // 
            this.usersCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.usersCombo.FormattingEnabled = true;
            this.usersCombo.Location = new System.Drawing.Point(11, 83);
            this.usersCombo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.usersCombo.MaxDropDownItems = 5;
            this.usersCombo.Name = "usersCombo";
            this.usersCombo.Size = new System.Drawing.Size(116, 21);
            this.usersCombo.TabIndex = 1;
            this.usersCombo.SelectedIndexChanged += new System.EventHandler(this.usersCombo_SelectedIndexChanged);
            // 
            // logoutBtn
            // 
            this.logoutBtn.Location = new System.Drawing.Point(530, 20);
            this.logoutBtn.Name = "logoutBtn";
            this.logoutBtn.Size = new System.Drawing.Size(75, 23);
            this.logoutBtn.TabIndex = 2;
            this.logoutBtn.Text = "Logout";
            this.logoutBtn.UseVisualStyleBackColor = true;
            this.logoutBtn.Click += new System.EventHandler(this.logoutBtn_Click);
            // 
            // genreCombo
            // 
            this.genreCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.genreCombo.FormattingEnabled = true;
            this.genreCombo.Location = new System.Drawing.Point(11, 297);
            this.genreCombo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.genreCombo.MaxDropDownItems = 5;
            this.genreCombo.Name = "genreCombo";
            this.genreCombo.Size = new System.Drawing.Size(183, 21);
            this.genreCombo.TabIndex = 3;
            // 
            // searchLabel
            // 
            this.searchLabel.AutoSize = true;
            this.searchLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchLabel.Location = new System.Drawing.Point(215, 185);
            this.searchLabel.Name = "searchLabel";
            this.searchLabel.Size = new System.Drawing.Size(177, 55);
            this.searchLabel.TabIndex = 4;
            this.searchLabel.Text = "Search";
            // 
            // userLabel
            // 
            this.userLabel.AutoSize = true;
            this.userLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userLabel.Location = new System.Drawing.Point(6, 56);
            this.userLabel.Name = "userLabel";
            this.userLabel.Size = new System.Drawing.Size(123, 25);
            this.userLabel.TabIndex = 5;
            this.userLabel.Text = "Select User";
            // 
            // genreLabel
            // 
            this.genreLabel.AutoSize = true;
            this.genreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genreLabel.Location = new System.Drawing.Point(12, 270);
            this.genreLabel.Name = "genreLabel";
            this.genreLabel.Size = new System.Drawing.Size(82, 25);
            this.genreLabel.TabIndex = 6;
            this.genreLabel.Text = "Genres";
            // 
            // actorLabel
            // 
            this.actorLabel.AutoSize = true;
            this.actorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.actorLabel.Location = new System.Drawing.Point(12, 320);
            this.actorLabel.Name = "actorLabel";
            this.actorLabel.Size = new System.Drawing.Size(140, 25);
            this.actorLabel.TabIndex = 7;
            this.actorLabel.Text = "Actor/Actress";
            // 
            // actorText
            // 
            this.actorText.Location = new System.Drawing.Point(11, 348);
            this.actorText.Name = "actorText";
            this.actorText.Size = new System.Drawing.Size(183, 20);
            this.actorText.TabIndex = 8;
            // 
            // showLabel
            // 
            this.showLabel.AutoSize = true;
            this.showLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showLabel.Location = new System.Drawing.Point(12, 215);
            this.showLabel.Name = "showLabel";
            this.showLabel.Size = new System.Drawing.Size(112, 25);
            this.showLabel.TabIndex = 9;
            this.showLabel.Text = "Show Title";
            // 
            // showText
            // 
            this.showText.Location = new System.Drawing.Point(11, 248);
            this.showText.Name = "showText";
            this.showText.Size = new System.Drawing.Size(183, 20);
            this.showText.TabIndex = 10;
            // 
            // resultCombo
            // 
            this.resultCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.resultCombo.FormattingEnabled = true;
            this.resultCombo.Location = new System.Drawing.Point(225, 276);
            this.resultCombo.Name = "resultCombo";
            this.resultCombo.Size = new System.Drawing.Size(329, 163);
            this.resultCombo.TabIndex = 11;
            // 
            // searchButton
            // 
            this.searchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchButton.Location = new System.Drawing.Point(11, 440);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(167, 47);
            this.searchButton.TabIndex = 12;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // infoButton
            // 
            this.infoButton.Enabled = false;
            this.infoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoButton.Location = new System.Drawing.Point(225, 444);
            this.infoButton.Name = "infoButton";
            this.infoButton.Size = new System.Drawing.Size(146, 34);
            this.infoButton.TabIndex = 13;
            this.infoButton.Text = "More Information";
            this.infoButton.UseVisualStyleBackColor = true;
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultLabel.Location = new System.Drawing.Point(357, 248);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(84, 25);
            this.resultLabel.TabIndex = 14;
            this.resultLabel.Text = "Results";
            // 
            // watchButton
            // 
            this.watchButton.Enabled = false;
            this.watchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.watchButton.Location = new System.Drawing.Point(408, 444);
            this.watchButton.Name = "watchButton";
            this.watchButton.Size = new System.Drawing.Size(146, 34);
            this.watchButton.TabIndex = 15;
            this.watchButton.Text = "Watch Show";
            this.watchButton.UseVisualStyleBackColor = true;
            // 
            // movieLabel
            // 
            this.movieLabel.AutoSize = true;
            this.movieLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.movieLabel.Location = new System.Drawing.Point(12, 371);
            this.movieLabel.Name = "movieLabel";
            this.movieLabel.Size = new System.Drawing.Size(103, 25);
            this.movieLabel.TabIndex = 16;
            this.movieLabel.Text = "Movie/TV";
            // 
            // movieCombo
            // 
            this.movieCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.movieCombo.FormattingEnabled = true;
            this.movieCombo.Location = new System.Drawing.Point(12, 399);
            this.movieCombo.Name = "movieCombo";
            this.movieCombo.Size = new System.Drawing.Size(182, 21);
            this.movieCombo.TabIndex = 17;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 499);
            this.ControlBox = false;
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
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
    }
}