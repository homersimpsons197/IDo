namespace IDo
{
    partial class UserControl1
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
            this.chBoxP = new System.Windows.Forms.CheckBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.lblProfile = new System.Windows.Forms.Label();
            this.cmBoxProfile = new System.Windows.Forms.ComboBox();
            this.lblFolderUsername = new System.Windows.Forms.Label();
            this.txtFolderUsername = new System.Windows.Forms.TextBox();
            this.txtP = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // chBoxP
            // 
            this.chBoxP.AutoSize = true;
            this.chBoxP.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chBoxP.Location = new System.Drawing.Point(20, 20);
            this.chBoxP.Name = "chBoxP";
            this.chBoxP.Size = new System.Drawing.Size(110, 20);
            this.chBoxP.TabIndex = 4;
            this.chBoxP.Text = "Enable Proxy";
            this.chBoxP.UseVisualStyleBackColor = true;
            this.chBoxP.CheckedChanged += new System.EventHandler(this.chBoxP_CheckedChanged);
            // 
            // lblProfile
            // 
            this.lblProfile.AutoSize = true;
            this.lblProfile.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProfile.Location = new System.Drawing.Point(17, 79);
            this.lblProfile.Name = "lblProfile";
            this.lblProfile.Size = new System.Drawing.Size(47, 16);
            this.lblProfile.TabIndex = 6;
            this.lblProfile.Text = "Profile";
            // 
            // cmBoxProfile
            // 
            this.cmBoxProfile.FormattingEnabled = true;
            this.cmBoxProfile.Items.AddRange(new object[] {
            "Profile 1",
            "Profile 2",
            "Profile 3",
            "Profile 4",
            "Profile 5"});
            this.cmBoxProfile.Location = new System.Drawing.Point(20, 99);
            this.cmBoxProfile.Name = "cmBoxProfile";
            this.cmBoxProfile.Size = new System.Drawing.Size(154, 21);
            this.cmBoxProfile.TabIndex = 7;
            // 
            // lblFolderUsername
            // 
            this.lblFolderUsername.AutoSize = true;
            this.lblFolderUsername.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFolderUsername.Location = new System.Drawing.Point(17, 133);
            this.lblFolderUsername.Name = "lblFolderUsername";
            this.lblFolderUsername.Size = new System.Drawing.Size(116, 16);
            this.lblFolderUsername.TabIndex = 8;
            this.lblFolderUsername.Text = "Folder Username";
            // 
            // txtFolderUsername
            // 
            this.txtFolderUsername.Location = new System.Drawing.Point(20, 153);
            this.txtFolderUsername.Name = "txtFolderUsername";
            this.txtFolderUsername.Size = new System.Drawing.Size(154, 20);
            this.txtFolderUsername.TabIndex = 9;
            // 
            // txtP
            // 
            this.txtP.Enabled = false;
            this.txtP.Location = new System.Drawing.Point(20, 46);
            this.txtP.Name = "txtP";
            this.txtP.Size = new System.Drawing.Size(154, 20);
            this.txtP.TabIndex = 10;
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.txtP);
            this.Controls.Add(this.txtFolderUsername);
            this.Controls.Add(this.lblFolderUsername);
            this.Controls.Add(this.cmBoxProfile);
            this.Controls.Add(this.lblProfile);
            this.Controls.Add(this.chBoxP);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(412, 339);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.CheckBox chBoxP;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label lblProfile;
        private System.Windows.Forms.ComboBox cmBoxProfile;
        private System.Windows.Forms.Label lblFolderUsername;
        public System.Windows.Forms.TextBox txtFolderUsername;
        public System.Windows.Forms.TextBox txtP;
    }
}
