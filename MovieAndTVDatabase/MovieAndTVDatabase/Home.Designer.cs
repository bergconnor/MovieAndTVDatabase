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
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(279, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(360, 92);
            this.label1.TabIndex = 0;
            this.label1.Text = "Home2";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // usersCombo
            // 
            this.usersCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.usersCombo.FormattingEnabled = true;
            this.usersCombo.Location = new System.Drawing.Point(12, 149);
            this.usersCombo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.usersCombo.MaxDropDownItems = 5;
            this.usersCombo.Name = "usersCombo";
            this.usersCombo.Size = new System.Drawing.Size(121, 24);
            this.usersCombo.TabIndex = 1;
            this.usersCombo.SelectedIndexChanged += new System.EventHandler(this.usersCombo_SelectedIndexChanged);
            // 
            // logoutBtn
            // 
            this.logoutBtn.Location = new System.Drawing.Point(706, 25);
            this.logoutBtn.Margin = new System.Windows.Forms.Padding(4);
            this.logoutBtn.Name = "logoutBtn";
            this.logoutBtn.Size = new System.Drawing.Size(100, 28);
            this.logoutBtn.TabIndex = 2;
            this.logoutBtn.Text = "Logout";
            this.logoutBtn.UseVisualStyleBackColor = true;
            this.logoutBtn.Click += new System.EventHandler(this.logoutBtn_Click);
            // 
            // genreCombo
            // 
            this.genreCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.genreCombo.FormattingEnabled = true;
            this.genreCombo.Location = new System.Drawing.Point(535, 283);
            this.genreCombo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.genreCombo.MaxDropDownItems = 5;
            this.genreCombo.Name = "genreCombo";
            this.genreCombo.Size = new System.Drawing.Size(121, 24);
            this.genreCombo.TabIndex = 3;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 614);
            this.ControlBox = false;
            this.Controls.Add(this.genreCombo);
            this.Controls.Add(this.logoutBtn);
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

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox usersCombo;
        private System.Windows.Forms.Button logoutBtn;
        private System.Windows.Forms.ComboBox genreCombo;
    }
}