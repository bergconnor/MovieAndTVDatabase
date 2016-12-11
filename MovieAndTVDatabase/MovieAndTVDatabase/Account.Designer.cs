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
            this.SuspendLayout();
            // 
            // addUserBtn
            // 
            this.addUserBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.addUserBtn.Location = new System.Drawing.Point(310, 310);
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
            this.nameTxt.Location = new System.Drawing.Point(310, 110);
            this.nameTxt.Name = "nameTxt";
            this.nameTxt.Size = new System.Drawing.Size(216, 22);
            this.nameTxt.TabIndex = 1;
            // 
            // resultTxt
            // 
            this.resultTxt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.resultTxt.Location = new System.Drawing.Point(310, 138);
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
            this.usersCombo.Location = new System.Drawing.Point(310, 380);
            this.usersCombo.MaxDropDownItems = 5;
            this.usersCombo.Name = "usersCombo";
            this.usersCombo.Size = new System.Drawing.Size(216, 24);
            this.usersCombo.TabIndex = 3;
            // 
            // rmvUserBtn
            // 
            this.rmvUserBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.rmvUserBtn.Location = new System.Drawing.Point(310, 410);
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
            this.endLbl.Location = new System.Drawing.Point(12, 69);
            this.endLbl.Name = "endLbl";
            this.endLbl.Size = new System.Drawing.Size(123, 17);
            this.endLbl.TabIndex = 5;
            this.endLbl.Text = "Subscription End: ";
            // 
            // subscriptionLengthLbl
            // 
            this.subscriptionLengthLbl.AutoSize = true;
            this.subscriptionLengthLbl.Location = new System.Drawing.Point(12, 98);
            this.subscriptionLengthLbl.Name = "subscriptionLengthLbl";
            this.subscriptionLengthLbl.Size = new System.Drawing.Size(157, 17);
            this.subscriptionLengthLbl.TabIndex = 6;
            this.subscriptionLengthLbl.Text = "Length of Membership: ";
            // 
            // Account
            // 
            this.AcceptButton = this.addUserBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 614);
            this.ControlBox = false;
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
    }
}