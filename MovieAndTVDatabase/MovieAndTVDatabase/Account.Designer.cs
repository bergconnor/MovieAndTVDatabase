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
            this.addUserBtn = new System.Windows.Forms.Button();
            this.nameTxt = new System.Windows.Forms.TextBox();
            this.resultTxt = new System.Windows.Forms.TextBox();
            this.usersCombo = new System.Windows.Forms.ComboBox();
            this.rmvUserBtn = new System.Windows.Forms.Button();
            this.currentUserLbl = new System.Windows.Forms.Label();
            this.endLbl = new System.Windows.Forms.Label();
            this.subscriptionLengthLbl = new System.Windows.Forms.Label();
            this.startLbl = new System.Windows.Forms.Label();
            this.extendBtn = new System.Windows.Forms.Button();
            this.membershipTxt = new System.Windows.Forms.TextBox();
            this.endTxt = new System.Windows.Forms.TextBox();
            this.startTxt = new System.Windows.Forms.TextBox();
            this.userTxt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // addUserBtn
            // 
            this.addUserBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.addUserBtn.Location = new System.Drawing.Point(310, 434);
            this.addUserBtn.Name = "addUserBtn";
            this.addUserBtn.Size = new System.Drawing.Size(216, 49);
            this.addUserBtn.TabIndex = 2;
            this.addUserBtn.Text = "Add User";
            this.addUserBtn.UseVisualStyleBackColor = true;
            this.addUserBtn.Click += new System.EventHandler(this.addUserBtn_Click);
            // 
            // nameTxt
            // 
            this.nameTxt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.nameTxt.Location = new System.Drawing.Point(310, 234);
            this.nameTxt.Name = "nameTxt";
            this.nameTxt.Size = new System.Drawing.Size(216, 22);
            this.nameTxt.TabIndex = 1;
            // 
            // resultTxt
            // 
            this.resultTxt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.resultTxt.Location = new System.Drawing.Point(310, 262);
            this.resultTxt.Multiline = true;
            this.resultTxt.Name = "resultTxt";
            this.resultTxt.ReadOnly = true;
            this.resultTxt.Size = new System.Drawing.Size(216, 157);
            this.resultTxt.TabIndex = 0;
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
            // rmvUserBtn
            // 
            this.rmvUserBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.rmvUserBtn.Location = new System.Drawing.Point(310, 534);
            this.rmvUserBtn.Name = "rmvUserBtn";
            this.rmvUserBtn.Size = new System.Drawing.Size(216, 49);
            this.rmvUserBtn.TabIndex = 4;
            this.rmvUserBtn.Text = "Remove User";
            this.rmvUserBtn.UseVisualStyleBackColor = true;
            this.rmvUserBtn.Click += new System.EventHandler(this.rmvUserBtn_Click);
            // 
            // currentUserLbl
            // 
            this.currentUserLbl.AutoSize = true;
            this.currentUserLbl.Location = new System.Drawing.Point(12, 40);
            this.currentUserLbl.Name = "currentUserLbl";
            this.currentUserLbl.Size = new System.Drawing.Size(97, 17);
            this.currentUserLbl.TabIndex = 0;
            this.currentUserLbl.Text = "Current User: ";
            // 
            // endLbl
            // 
            this.endLbl.AutoSize = true;
            this.endLbl.Location = new System.Drawing.Point(12, 104);
            this.endLbl.Name = "endLbl";
            this.endLbl.Size = new System.Drawing.Size(123, 17);
            this.endLbl.TabIndex = 5;
            this.endLbl.Text = "Subscription End: ";
            // 
            // subscriptionLengthLbl
            // 
            this.subscriptionLengthLbl.AutoSize = true;
            this.subscriptionLengthLbl.Location = new System.Drawing.Point(12, 136);
            this.subscriptionLengthLbl.Name = "subscriptionLengthLbl";
            this.subscriptionLengthLbl.Size = new System.Drawing.Size(157, 17);
            this.subscriptionLengthLbl.TabIndex = 6;
            this.subscriptionLengthLbl.Text = "Length of Membership: ";
            // 
            // startLbl
            // 
            this.startLbl.AutoSize = true;
            this.startLbl.Location = new System.Drawing.Point(12, 72);
            this.startLbl.Name = "startLbl";
            this.startLbl.Size = new System.Drawing.Size(128, 17);
            this.startLbl.TabIndex = 7;
            this.startLbl.Text = "Subscription Start: ";
            // 
            // extendBtn
            // 
            this.extendBtn.Location = new System.Drawing.Point(12, 196);
            this.extendBtn.Name = "extendBtn";
            this.extendBtn.Size = new System.Drawing.Size(178, 45);
            this.extendBtn.TabIndex = 8;
            this.extendBtn.Text = "Extend Membership";
            this.extendBtn.UseVisualStyleBackColor = true;
            this.extendBtn.Click += new System.EventHandler(this.extendBtn_Click);
            // 
            // membershipTxt
            // 
            this.membershipTxt.Location = new System.Drawing.Point(175, 136);
            this.membershipTxt.Name = "membershipTxt";
            this.membershipTxt.ReadOnly = true;
            this.membershipTxt.Size = new System.Drawing.Size(125, 22);
            this.membershipTxt.TabIndex = 9;
            // 
            // endTxt
            // 
            this.endTxt.Location = new System.Drawing.Point(175, 100);
            this.endTxt.Name = "endTxt";
            this.endTxt.ReadOnly = true;
            this.endTxt.Size = new System.Drawing.Size(125, 22);
            this.endTxt.TabIndex = 10;
            // 
            // startTxt
            // 
            this.startTxt.Location = new System.Drawing.Point(175, 64);
            this.startTxt.Name = "startTxt";
            this.startTxt.ReadOnly = true;
            this.startTxt.Size = new System.Drawing.Size(125, 22);
            this.startTxt.TabIndex = 11;
            // 
            // userTxt
            // 
            this.userTxt.Location = new System.Drawing.Point(175, 28);
            this.userTxt.Name = "userTxt";
            this.userTxt.ReadOnly = true;
            this.userTxt.Size = new System.Drawing.Size(125, 22);
            this.userTxt.TabIndex = 12;
            // 
            // Account
            // 
            this.AcceptButton = this.addUserBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 614);
            this.ControlBox = false;
            this.Controls.Add(this.userTxt);
            this.Controls.Add(this.startTxt);
            this.Controls.Add(this.endTxt);
            this.Controls.Add(this.membershipTxt);
            this.Controls.Add(this.extendBtn);
            this.Controls.Add(this.startLbl);
            this.Controls.Add(this.subscriptionLengthLbl);
            this.Controls.Add(this.endLbl);
            this.Controls.Add(this.currentUserLbl);
            this.Controls.Add(this.rmvUserBtn);
            this.Controls.Add(this.usersCombo);
            this.Controls.Add(this.resultTxt);
            this.Controls.Add(this.nameTxt);
            this.Controls.Add(this.addUserBtn);
            this.Name = "Account";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Shown += new System.EventHandler(this.Account_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addUserBtn;
        private System.Windows.Forms.TextBox nameTxt;
        private System.Windows.Forms.TextBox resultTxt;
        private System.Windows.Forms.ComboBox usersCombo;
        private System.Windows.Forms.Button rmvUserBtn;
        private System.Windows.Forms.Label currentUserLbl;
        private System.Windows.Forms.Label endLbl;
        private System.Windows.Forms.Label subscriptionLengthLbl;
        private System.Windows.Forms.Label startLbl;
        private System.Windows.Forms.Button extendBtn;
        private System.Windows.Forms.TextBox membershipTxt;
        private System.Windows.Forms.TextBox endTxt;
        private System.Windows.Forms.TextBox startTxt;
        private System.Windows.Forms.TextBox userTxt;
    }
}