namespace IDo
{
    partial class UserControl2
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
            this.chBoxPost = new System.Windows.Forms.CheckBox();
            this.lblPath = new System.Windows.Forms.Label();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.lblInterval = new System.Windows.Forms.Label();
            this.txtIntervalPost = new System.Windows.Forms.TextBox();
            this.lblHour = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // chBoxPost
            // 
            this.chBoxPost.AutoSize = true;
            this.chBoxPost.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chBoxPost.Location = new System.Drawing.Point(20, 20);
            this.chBoxPost.Name = "chBoxPost";
            this.chBoxPost.Size = new System.Drawing.Size(62, 20);
            this.chBoxPost.TabIndex = 1;
            this.chBoxPost.Text = "Posts";
            this.chBoxPost.UseVisualStyleBackColor = true;
            this.chBoxPost.CheckedChanged += new System.EventHandler(this.chBoxPost_CheckedChanged);
            // 
            // lblPath
            // 
            this.lblPath.AutoSize = true;
            this.lblPath.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPath.Location = new System.Drawing.Point(17, 63);
            this.lblPath.Name = "lblPath";
            this.lblPath.Size = new System.Drawing.Size(105, 16);
            this.lblPath.TabIndex = 2;
            this.lblPath.Text = "Pictures PATH:";
            // 
            // txtPath
            // 
            this.txtPath.Enabled = false;
            this.txtPath.Location = new System.Drawing.Point(17, 83);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(372, 20);
            this.txtPath.TabIndex = 3;
            // 
            // lblInterval
            // 
            this.lblInterval.AutoSize = true;
            this.lblInterval.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInterval.Location = new System.Drawing.Point(17, 130);
            this.lblInterval.Name = "lblInterval";
            this.lblInterval.Size = new System.Drawing.Size(58, 16);
            this.lblInterval.TabIndex = 4;
            this.lblInterval.Text = "Interval";
            // 
            // txtIntervalPost
            // 
            this.txtIntervalPost.Enabled = false;
            this.txtIntervalPost.Location = new System.Drawing.Point(81, 129);
            this.txtIntervalPost.Name = "txtIntervalPost";
            this.txtIntervalPost.Size = new System.Drawing.Size(41, 20);
            this.txtIntervalPost.TabIndex = 5;
            // 
            // lblHour
            // 
            this.lblHour.AutoSize = true;
            this.lblHour.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHour.Location = new System.Drawing.Point(128, 130);
            this.lblHour.Name = "lblHour";
            this.lblHour.Size = new System.Drawing.Size(43, 16);
            this.lblHour.TabIndex = 6;
            this.lblHour.Text = "hours";
            // 
            // UserControl2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblHour);
            this.Controls.Add(this.txtIntervalPost);
            this.Controls.Add(this.lblInterval);
            this.Controls.Add(this.txtPath);
            this.Controls.Add(this.lblPath);
            this.Controls.Add(this.chBoxPost);
            this.Name = "UserControl2";
            this.Size = new System.Drawing.Size(412, 339);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.CheckBox chBoxPost;
        private System.Windows.Forms.Label lblPath;
        public System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Label lblInterval;
        public System.Windows.Forms.TextBox txtIntervalPost;
        private System.Windows.Forms.Label lblHour;
    }
}
