namespace MovieAndTVDatabase
{
    partial class Account
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
            this.addButton = new System.Windows.Forms.Button();
            this.nameText = new System.Windows.Forms.TextBox();
            this.outputText = new System.Windows.Forms.TextBox();
            this.usersCombo = new System.Windows.Forms.ComboBox();
            this.removeButton = new System.Windows.Forms.Button();
            this.userLabel = new System.Windows.Forms.Label();
            this.endLabel = new System.Windows.Forms.Label();
            this.membershipLabel = new System.Windows.Forms.Label();
            this.startLabel = new System.Windows.Forms.Label();
            this.renewButton = new System.Windows.Forms.Button();
            this.membershipText = new System.Windows.Forms.TextBox();
            this.endText = new System.Windows.Forms.TextBox();
            this.startText = new System.Windows.Forms.TextBox();
            this.userText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // addButton
            // 
            this.addButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.addButton.Location = new System.Drawing.Point(232, 353);
            this.addButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(162, 40);
            this.addButton.TabIndex = 2;
            this.addButton.Text = "Add User";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // nameText
            // 
            this.nameText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.nameText.Location = new System.Drawing.Point(232, 190);
            this.nameText.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nameText.Name = "nameText";
            this.nameText.Size = new System.Drawing.Size(163, 20);
            this.nameText.TabIndex = 1;
            // 
            // outputText
            // 
            this.outputText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.outputText.Location = new System.Drawing.Point(232, 213);
            this.outputText.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.outputText.Multiline = true;
            this.outputText.Name = "outputText";
            this.outputText.ReadOnly = true;
            this.outputText.Size = new System.Drawing.Size(163, 128);
            this.outputText.TabIndex = 0;
            // 
            // usersCombo
            // 
            this.usersCombo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.usersCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.usersCombo.FormattingEnabled = true;
            this.usersCombo.Location = new System.Drawing.Point(232, 410);
            this.usersCombo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.usersCombo.MaxDropDownItems = 5;
            this.usersCombo.Name = "usersCombo";
            this.usersCombo.Size = new System.Drawing.Size(163, 21);
            this.usersCombo.TabIndex = 3;
            // 
            // removeButton
            // 
            this.removeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.removeButton.Location = new System.Drawing.Point(232, 434);
            this.removeButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(162, 40);
            this.removeButton.TabIndex = 4;
            this.removeButton.Text = "Remove User";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // userLabel
            // 
            this.userLabel.AutoSize = true;
            this.userLabel.Location = new System.Drawing.Point(9, 32);
            this.userLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.userLabel.Name = "userLabel";
            this.userLabel.Size = new System.Drawing.Size(72, 13);
            this.userLabel.TabIndex = 0;
            this.userLabel.Text = "Current User: ";
            // 
            // endLabel
            // 
            this.endLabel.AutoSize = true;
            this.endLabel.Location = new System.Drawing.Point(9, 84);
            this.endLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.endLabel.Name = "endLabel";
            this.endLabel.Size = new System.Drawing.Size(93, 13);
            this.endLabel.TabIndex = 5;
            this.endLabel.Text = "Subscription End: ";
            // 
            // membershipLabel
            // 
            this.membershipLabel.AutoSize = true;
            this.membershipLabel.Location = new System.Drawing.Point(9, 110);
            this.membershipLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.membershipLabel.Name = "membershipLabel";
            this.membershipLabel.Size = new System.Drawing.Size(118, 13);
            this.membershipLabel.TabIndex = 6;
            this.membershipLabel.Text = "Length of Membership: ";
            // 
            // startLabel
            // 
            this.startLabel.AutoSize = true;
            this.startLabel.Location = new System.Drawing.Point(9, 58);
            this.startLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.startLabel.Name = "startLabel";
            this.startLabel.Size = new System.Drawing.Size(96, 13);
            this.startLabel.TabIndex = 7;
            this.startLabel.Text = "Subscription Start: ";
            // 
            // renewButton
            // 
            this.renewButton.Location = new System.Drawing.Point(9, 159);
            this.renewButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.renewButton.Name = "renewButton";
            this.renewButton.Size = new System.Drawing.Size(134, 37);
            this.renewButton.TabIndex = 8;
            this.renewButton.Text = "Renew Subscription";
            this.renewButton.UseVisualStyleBackColor = true;
            this.renewButton.Click += new System.EventHandler(this.renewButton_Click);
            // 
            // membershipText
            // 
            this.membershipText.Location = new System.Drawing.Point(131, 110);
            this.membershipText.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.membershipText.Name = "membershipText";
            this.membershipText.ReadOnly = true;
            this.membershipText.Size = new System.Drawing.Size(95, 20);
            this.membershipText.TabIndex = 9;
            // 
            // endText
            // 
            this.endText.Location = new System.Drawing.Point(131, 81);
            this.endText.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.endText.Name = "endText";
            this.endText.ReadOnly = true;
            this.endText.Size = new System.Drawing.Size(95, 20);
            this.endText.TabIndex = 10;
            // 
            // startText
            // 
            this.startText.Location = new System.Drawing.Point(131, 52);
            this.startText.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.startText.Name = "startText";
            this.startText.ReadOnly = true;
            this.startText.Size = new System.Drawing.Size(95, 20);
            this.startText.TabIndex = 11;
            // 
            // userText
            // 
            this.userText.Location = new System.Drawing.Point(131, 23);
            this.userText.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.userText.Name = "userText";
            this.userText.ReadOnly = true;
            this.userText.Size = new System.Drawing.Size(95, 20);
            this.userText.TabIndex = 12;
            // 
            // Account
            // 
            this.AcceptButton = this.addButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 499);
            this.ControlBox = false;
            this.Controls.Add(this.userText);
            this.Controls.Add(this.startText);
            this.Controls.Add(this.endText);
            this.Controls.Add(this.membershipText);
            this.Controls.Add(this.renewButton);
            this.Controls.Add(this.startLabel);
            this.Controls.Add(this.membershipLabel);
            this.Controls.Add(this.endLabel);
            this.Controls.Add(this.userLabel);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.usersCombo);
            this.Controls.Add(this.outputText);
            this.Controls.Add(this.nameText);
            this.Controls.Add(this.addButton);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Account";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Shown += new System.EventHandler(this.Account_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.TextBox nameText;
        private System.Windows.Forms.TextBox outputText;
        private System.Windows.Forms.ComboBox usersCombo;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.Label userLabel;
        private System.Windows.Forms.Label endLabel;
        private System.Windows.Forms.Label startLabel;
        private System.Windows.Forms.Button renewButton;
        private System.Windows.Forms.TextBox membershipText;
        private System.Windows.Forms.TextBox endText;
        private System.Windows.Forms.TextBox startText;
        private System.Windows.Forms.TextBox userText;
        private System.Windows.Forms.Label membershipLabel;
    }
}