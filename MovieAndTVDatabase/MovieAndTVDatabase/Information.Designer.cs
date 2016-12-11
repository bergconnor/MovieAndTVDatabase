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
            this.titleLbl = new System.Windows.Forms.Label();
            this.descriptionTxt = new System.Windows.Forms.TextBox();
            this.actorsCombo = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // titleLbl
            // 
            this.titleLbl.AutoSize = true;
            this.titleLbl.Location = new System.Drawing.Point(385, 45);
            this.titleLbl.Name = "titleLbl";
            this.titleLbl.Size = new System.Drawing.Size(46, 17);
            this.titleLbl.TabIndex = 0;
            this.titleLbl.Text = "label1";
            // 
            // descriptionTxt
            // 
            this.descriptionTxt.Location = new System.Drawing.Point(189, 188);
            this.descriptionTxt.Multiline = true;
            this.descriptionTxt.Name = "descriptionTxt";
            this.descriptionTxt.ReadOnly = true;
            this.descriptionTxt.Size = new System.Drawing.Size(408, 167);
            this.descriptionTxt.TabIndex = 1;
            // 
            // actorsCombo
            // 
            this.actorsCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.actorsCombo.FormattingEnabled = true;
            this.actorsCombo.Location = new System.Drawing.Point(266, 395);
            this.actorsCombo.Name = "actorsCombo";
            this.actorsCombo.Size = new System.Drawing.Size(260, 25);
            this.actorsCombo.TabIndex = 2;
            // 
            // Information
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 585);
            this.ControlBox = false;
            this.Controls.Add(this.actorsCombo);
            this.Controls.Add(this.descriptionTxt);
            this.Controls.Add(this.titleLbl);
            this.MaximizeBox = false;
            this.Name = "Information";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLbl;
        private System.Windows.Forms.TextBox descriptionTxt;
        private System.Windows.Forms.ComboBox actorsCombo;
    }
}