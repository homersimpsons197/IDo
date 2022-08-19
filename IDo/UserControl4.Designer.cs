namespace IDo
{
    partial class UserControl4
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtIntervalUnfollow = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNbOfUnfollows = new System.Windows.Forms.TextBox();
            this.lblNumberOfUnfollows = new System.Windows.Forms.Label();
            this.chBoxUnfollow = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(128, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 16);
            this.label1.TabIndex = 18;
            this.label1.Text = "hours";
            // 
            // txtIntervalUnfollow
            // 
            this.txtIntervalUnfollow.Enabled = false;
            this.txtIntervalUnfollow.Location = new System.Drawing.Point(81, 98);
            this.txtIntervalUnfollow.Name = "txtIntervalUnfollow";
            this.txtIntervalUnfollow.Size = new System.Drawing.Size(41, 20);
            this.txtIntervalUnfollow.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 16);
            this.label2.TabIndex = 16;
            this.label2.Text = "Interval";
            // 
            // txtNbOfUnfollows
            // 
            this.txtNbOfUnfollows.Enabled = false;
            this.txtNbOfUnfollows.Location = new System.Drawing.Point(163, 62);
            this.txtNbOfUnfollows.Name = "txtNbOfUnfollows";
            this.txtNbOfUnfollows.Size = new System.Drawing.Size(41, 20);
            this.txtNbOfUnfollows.TabIndex = 15;
            // 
            // lblNumberOfUnfollows
            // 
            this.lblNumberOfUnfollows.AutoSize = true;
            this.lblNumberOfUnfollows.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberOfUnfollows.Location = new System.Drawing.Point(17, 63);
            this.lblNumberOfUnfollows.Name = "lblNumberOfUnfollows";
            this.lblNumberOfUnfollows.Size = new System.Drawing.Size(140, 16);
            this.lblNumberOfUnfollows.TabIndex = 14;
            this.lblNumberOfUnfollows.Text = "Number of unfollows";
            // 
            // chBoxUnfollow
            // 
            this.chBoxUnfollow.AutoSize = true;
            this.chBoxUnfollow.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chBoxUnfollow.Location = new System.Drawing.Point(20, 20);
            this.chBoxUnfollow.Name = "chBoxUnfollow";
            this.chBoxUnfollow.Size = new System.Drawing.Size(88, 20);
            this.chBoxUnfollow.TabIndex = 13;
            this.chBoxUnfollow.Text = "Unfollows";
            this.chBoxUnfollow.UseVisualStyleBackColor = true;
            this.chBoxUnfollow.CheckedChanged += new System.EventHandler(this.chBoxUnfollow_CheckedChanged);
            // 
            // UserControl4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtIntervalUnfollow);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNbOfUnfollows);
            this.Controls.Add(this.lblNumberOfUnfollows);
            this.Controls.Add(this.chBoxUnfollow);
            this.Name = "UserControl4";
            this.Size = new System.Drawing.Size(412, 339);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtIntervalUnfollow;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txtNbOfUnfollows;
        private System.Windows.Forms.Label lblNumberOfUnfollows;
        public System.Windows.Forms.CheckBox chBoxUnfollow;
    }
}
