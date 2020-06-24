namespace Contact_Manage
{
    partial class Logout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Logout));
            this.btt_Logout = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tB_Logout_Username = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tB_Logout_Password = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btt_Logout
            // 
            this.btt_Logout.Location = new System.Drawing.Point(328, 226);
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
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(124, 87);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "要注销的用户名：";
            // 
            // tB_Logout_Username
            // 
            this.tB_Logout_Username.Location = new System.Drawing.Point(258, 83);
            this.tB_Logout_Username.Margin = new System.Windows.Forms.Padding(4);
            this.tB_Logout_Username.Name = "tB_Logout_Username";
            this.tB_Logout_Username.Size = new System.Drawing.Size(257, 25);
            this.tB_Logout_Username.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(172, 157);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "输入密码：";
            // 
            // tB_Logout_Password
            // 
            this.tB_Logout_Password.Location = new System.Drawing.Point(258, 153);
            this.tB_Logout_Password.Margin = new System.Windows.Forms.Padding(4);
            this.tB_Logout_Password.Name = "tB_Logout_Password";
            this.tB_Logout_Password.PasswordChar = '*';
            this.tB_Logout_Password.Size = new System.Drawing.Size(257, 25);
            this.tB_Logout_Password.TabIndex = 4;
            // 
            // Logout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Family_Tree.Properties.Resources._1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(743, 466);
            this.Controls.Add(this.tB_Logout_Password);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tB_Logout_Username);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btt_Logout);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Logout";
            this.Text = "注销";
            this.Load += new System.EventHandler(this.Logout_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btt_Logout;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tB_Logout_Password;
        public System.Windows.Forms.TextBox tB_Logout_Username;
    }
}