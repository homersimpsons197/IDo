namespace IDo
{
    partial class UserControl3
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.chBoxFollow = new System.Windows.Forms.CheckBox();
            this.txtNbOfFollows = new System.Windows.Forms.TextBox();
            this.lblNumberOfFollows = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIntervalFollow = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gBoxAccounts = new System.Windows.Forms.GroupBox();
            this.rTxtAccounts = new System.Windows.Forms.RichTextBox();
            this.gBoxAccounts.SuspendLayout();
            this.SuspendLayout();
            // 
            // chBoxFollow
            // 
            this.chBoxFollow.AutoSize = true;
            this.chBoxFollow.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chBoxFollow.Location = new System.Drawing.Point(20, 20);
            this.chBoxFollow.Name = "chBoxFollow";
            this.chBoxFollow.Size = new System.Drawing.Size(74, 20);
            this.chBoxFollow.TabIndex = 2;
            this.chBoxFollow.Text = "Follows";
            this.chBoxFollow.UseVisualStyleBackColor = true;
            this.chBoxFollow.CheckedChanged += new System.EventHandler(this.chBoxFollow_CheckedChanged);
            // 
            // txtNbOfFollows
            // 
            this.txtNbOfFollows.Enabled = false;
            this.txtNbOfFollows.Location = new System.Drawing.Point(147, 62);
            this.txtNbOfFollows.Name = "txtNbOfFollows";
            this.txtNbOfFollows.Size = new System.Drawing.Size(41, 20);
            this.txtNbOfFollows.TabIndex = 8;
            // 
            // lblNumberOfFollows
            // 
            this.lblNumberOfFollows.AutoSize = true;
            this.lblNumberOfFollows.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberOfFollows.Location = new System.Drawing.Point(17, 63);
            this.lblNumberOfFollows.Name = "lblNumberOfFollows";
            this.lblNumberOfFollows.Size = new System.Drawing.Size(124, 16);
            this.lblNumberOfFollows.TabIndex = 7;
            this.lblNumberOfFollows.Text = "Number of follows";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(128, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "hours";
            // 
            // txtIntervalFollow
            // 
            this.txtIntervalFollow.Enabled = false;
            this.txtIntervalFollow.Location = new System.Drawing.Point(81, 108);
            this.txtIntervalFollow.Name = "txtIntervalFollow";
            this.txtIntervalFollow.Size = new System.Drawing.Size(41, 20);
            this.txtIntervalFollow.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Interval";
            // 
            // gBoxAccounts
            // 
            this.gBoxAccounts.Controls.Add(this.rTxtAccounts);
            this.gBoxAccounts.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBoxAccounts.Location = new System.Drawing.Point(20, 154);
            this.gBoxAccounts.Name = "gBoxAccounts";
            this.gBoxAccounts.Size = new System.Drawing.Size(200, 180);
            this.gBoxAccounts.TabIndex = 13;
            this.gBoxAccounts.TabStop = false;
            this.gBoxAccounts.Text = "Accounts to find Followers";
            // 
            // rTxtAccounts
            // 
            this.rTxtAccounts.Enabled = false;
            this.rTxtAccounts.Location = new System.Drawing.Point(7, 23);
            this.rTxtAccounts.Name = "rTxtAccounts";
            this.rTxtAccounts.Size = new System.Drawing.Size(187, 151);
            this.rTxtAccounts.TabIndex = 0;
            this.rTxtAccounts.Text = "";
            // 
            // UserControl3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gBoxAccounts);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtIntervalFollow);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNbOfFollows);
            this.Controls.Add(this.lblNumberOfFollows);
            this.Controls.Add(this.chBoxFollow);
            this.Name = "UserControl3";
            this.Size = new System.Drawing.Size(412, 339);
            this.gBoxAccounts.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.CheckBox chBoxFollow;
        public System.Windows.Forms.TextBox txtNbOfFollows;
        private System.Windows.Forms.Label lblNumberOfFollows;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtIntervalFollow;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gBoxAccounts;
        private System.Windows.Forms.RichTextBox rTxtAccounts;
    }
}
