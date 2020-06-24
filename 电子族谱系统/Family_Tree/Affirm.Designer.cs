namespace Contact_Manage
{
    partial class Affirm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Affirm));
            this.btt_Logout = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btt_Logout_Cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btt_Logout
            // 
            this.btt_Logout.Location = new System.Drawing.Point(55, 160);
            this.btt_Logout.Margin = new System.Windows.Forms.Padding(4);
            this.btt_Logout.Name = "btt_Logout";
            this.btt_Logout.Size = new System.Drawing.Size(100, 29);
            this.btt_Logout.TabIndex = 0;
            this.btt_Logout.Text = "注 销";
            this.btt_Logout.UseVisualStyleBackColor = true;
            this.btt_Logout.Click += new System.EventHandler(this.btt_Logout_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 59);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(292, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "此用户将要被注销，是否确定注销此用户？";
            // 
            // btt_Logout_Cancel
            // 
            this.btt_Logout_Cancel.Location = new System.Drawing.Point(209, 160);
            this.btt_Logout_Cancel.Margin = new System.Windows.Forms.Padding(4);
            this.btt_Logout_Cancel.Name = "btt_Logout_Cancel";
            this.btt_Logout_Cancel.Size = new System.Drawing.Size(100, 29);
            this.btt_Logout_Cancel.TabIndex = 2;
            this.btt_Logout_Cancel.Text = "取 消";
            this.btt_Logout_Cancel.UseVisualStyleBackColor = true;
            this.btt_Logout_Cancel.Click += new System.EventHandler(this.btt_Logout_Cancel_Click);
            // 
            // Affirm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 326);
            this.Controls.Add(this.btt_Logout_Cancel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btt_Logout);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Affirm";
            this.Text = "注销";
            this.Load += new System.EventHandler(this.Affirm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btt_Logout;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btt_Logout_Cancel;
    }
}