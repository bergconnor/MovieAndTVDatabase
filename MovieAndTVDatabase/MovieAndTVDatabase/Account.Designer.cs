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
            this.extendButton = new System.Windows.Forms.Button();
            this.membershipText = new System.Windows.Forms.TextBox();
            this.endText = new System.Windows.Forms.TextBox();
            this.startText = new System.Windows.Forms.TextBox();
            this.userText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // addButton
            // 
            this.addButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.addButton.Location = new System.Drawing.Point(310, 434);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(216, 49);
            this.addButton.TabIndex = 2;
            this.addButton.Text = "Add User";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // nameText
            // 
            this.nameText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.nameText.Location = new System.Drawing.Point(310, 234);
            this.nameText.Name = "nameText";
            this.nameText.Size = new System.Drawing.Size(216, 22);
            this.nameText.TabIndex = 1;
            // 
            // outputText
            // 
            this.outputText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.outputText.Location = new System.Drawing.Point(310, 262);
            this.outputText.Multiline = true;
            this.outputText.Name = "outputText";
            this.outputText.ReadOnly = true;
            this.outputText.Size = new System.Drawing.Size(216, 157);
            this.outputText.TabIndex = 0;
            // 
            // usersCombo
            // 
            this.usersCombo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.usersCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.usersCombo.FormattingEnabled = true;
            this.usersCombo.Location = new System.Drawing.Point(310, 504);
            this.usersCombo.MaxDropDownItems = 5;
            this.usersCombo.Name = "usersCombo";
            this.usersCombo.Size = new System.Drawing.Size(216, 24);
            this.usersCombo.TabIndex = 3;
            // 
            // removeButton
            // 
            this.removeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.removeButton.Location = new System.Drawing.Point(310, 534);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(216, 49);
            this.removeButton.TabIndex = 4;
            this.removeButton.Text = "Remove User";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // userLabel
            // 
            this.userLabel.AutoSize = true;
            this.userLabel.Location = new System.Drawing.Point(12, 40);
            this.userLabel.Name = "userLabel";
            this.userLabel.Size = new System.Drawing.Size(97, 17);
            this.userLabel.TabIndex = 0;
            this.userLabel.Text = "Current User: ";
            // 
            // endLabel
            // 
            this.endLabel.AutoSize = true;
            this.endLabel.Location = new System.Drawing.Point(12, 104);
            this.endLabel.Name = "endLabel";
            this.endLabel.Size = new System.Drawing.Size(123, 17);
            this.endLabel.TabIndex = 5;
            this.endLabel.Text = "Subscription End: ";
            // 
            // membershipLabel
            // 
            this.membershipLabel.AutoSize = true;
            this.membershipLabel.Location = new System.Drawing.Point(12, 136);
            this.membershipLabel.Name = "membershipLabel";
            this.membershipLabel.Size = new System.Drawing.Size(157, 17);
            this.membershipLabel.TabIndex = 6;
            this.membershipLabel.Text = "Length of Membership: ";
            // 
            // startLabel
            // 
            this.startLabel.AutoSize = true;
            this.startLabel.Location = new System.Drawing.Point(12, 72);
            this.startLabel.Name = "startLabel";
            this.startLabel.Size = new System.Drawing.Size(128, 17);
            this.startLabel.TabIndex = 7;
            this.startLabel.Text = "Subscription Start: ";
            // 
            // extendButton
            // 
            this.extendButton.Location = new System.Drawing.Point(12, 196);
            this.extendButton.Name = "extendButton";
            this.extendButton.Size = new System.Drawing.Size(178, 45);
            this.extendButton.TabIndex = 8;
            this.extendButton.Text = "Extend Membership";
            this.extendButton.UseVisualStyleBackColor = true;
            this.extendButton.Click += new System.EventHandler(this.extendButton_Click);
            // 
            // membershipText
            // 
            this.membershipText.Location = new System.Drawing.Point(175, 136);
            this.membershipText.Name = "membershipText";
            this.membershipText.ReadOnly = true;
            this.membershipText.Size = new System.Drawing.Size(125, 22);
            this.membershipText.TabIndex = 9;
            // 
            // endText
            // 
            this.endText.Location = new System.Drawing.Point(175, 100);
            this.endText.Name = "endText";
            this.endText.ReadOnly = true;
            this.endText.Size = new System.Drawing.Size(125, 22);
            this.endText.TabIndex = 10;
            // 
            // startText
            // 
            this.startText.Location = new System.Drawing.Point(175, 64);
            this.startText.Name = "startText";
            this.startText.ReadOnly = true;
            this.startText.Size = new System.Drawing.Size(125, 22);
            this.startText.TabIndex = 11;
            // 
            // userText
            // 
            this.userText.Location = new System.Drawing.Point(175, 28);
            this.userText.Name = "userText";
            this.userText.ReadOnly = true;
            this.userText.Size = new System.Drawing.Size(125, 22);
            this.userText.TabIndex = 12;
            // 
            // Account
            // 
            this.AcceptButton = this.addButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 614);
            this.ControlBox = false;
            this.Controls.Add(this.userText);
            this.Controls.Add(this.startText);
            this.Controls.Add(this.endText);
            this.Controls.Add(this.membershipText);
            this.Controls.Add(this.extendButton);
            this.Controls.Add(this.startLabel);
            this.Controls.Add(this.membershipLabel);
            this.Controls.Add(this.endLabel);
            this.Controls.Add(this.userLabel);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.usersCombo);
            this.Controls.Add(this.outputText);
            this.Controls.Add(this.nameText);
            this.Controls.Add(this.addButton);
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
        private System.Windows.Forms.Button extendButton;
        private System.Windows.Forms.TextBox membershipText;
        private System.Windows.Forms.TextBox endText;
        private System.Windows.Forms.TextBox startText;
        private System.Windows.Forms.TextBox userText;
        private System.Windows.Forms.Label membershipLabel;
    }
}