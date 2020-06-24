namespace Contact_Manage
{
    partial class Login
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.btt_Login = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tB_Account_Username = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tB_Account_Password = new System.Windows.Forms.TextBox();
            this.lb_Regist = new System.Windows.Forms.Label();
            this.lb_Logout = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btt_Login
            // 
            this.btt_Login.Location = new System.Drawing.Point(322, 201);
            this.btt_Login.Margin = new System.Windows.Forms.Padding(4);
            this.btt_Login.Name = "btt_Login";
            this.btt_Login.Size = new System.Drawing.Size(100, 29);
            this.btt_Login.TabIndex = 0;
            this.btt_Login.Text = "登 录";
            this.btt_Login.UseVisualStyleBackColor = true;
            this.btt_Login.Click += new System.EventHandler(this.btt_Login_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(174, 119);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "用户名：";
            // 
            // tB_Account_Username
            // 
            this.tB_Account_Username.Location = new System.Drawing.Point(245, 116);
            this.tB_Account_Username.Margin = new System.Windows.Forms.Padding(4);
            this.tB_Account_Username.Name = "tB_Account_Username";
            this.tB_Account_Username.Size = new System.Drawing.Size(265, 25);
            this.tB_Account_Username.TabIndex = 2;
            this.tB_Account_Username.TextChanged += new System.EventHandler(this.tB_Account_Username_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(174, 166);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "密  码：";
            // 
            // tB_Account_Password
            // 
            this.tB_Account_Password.Location = new System.Drawing.Point(245, 156);
            this.tB_Account_Password.Margin = new System.Windows.Forms.Padding(4);
            this.tB_Account_Password.Name = "tB_Account_Password";
            this.tB_Account_Password.PasswordChar = '*';
            this.tB_Account_Password.Size = new System.Drawing.Size(265, 25);
            this.tB_Account_Password.TabIndex = 4;
            this.tB_Account_Password.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tB_Account_Password_MouseClick);
            this.tB_Account_Password.TextChanged += new System.EventHandler(this.tB_Account_Password_TextChanged);
            // 
            // lb_Regist
            // 
            this.lb_Regist.AutoSize = true;
            this.lb_Regist.BackColor = System.Drawing.Color.Transparent;
            this.lb_Regist.Location = new System.Drawing.Point(122, 208);
            this.lb_Regist.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_Regist.Name = "lb_Regist";
            this.lb_Regist.Size = new System.Drawing.Size(157, 15);
            this.lb_Regist.TabIndex = 5;
            this.lb_Regist.Text = "没有账号？立即注册！";
            this.lb_Regist.Click += new System.EventHandler(this.lb_Regist_Click);
            // 
            // lb_Logout
            // 
            this.lb_Logout.AutoSize = true;
            this.lb_Logout.BackColor = System.Drawing.Color.Transparent;
            this.lb_Logout.Location = new System.Drawing.Point(532, 166);
            this.lb_Logout.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_Logout.Name = "lb_Logout";
            this.lb_Logout.Size = new System.Drawing.Size(67, 15);
            this.lb_Logout.TabIndex = 6;
            this.lb_Logout.Text = "注销账户";
            this.lb_Logout.Click += new System.EventHandler(this.lb_Logout_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(742, 455);
            this.Controls.Add(this.lb_Logout);
            this.Controls.Add(this.lb_Regist);
            this.Controls.Add(this.tB_Account_Password);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tB_Account_Username);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btt_Login);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "电子族谱系统";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btt_Login;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tB_Account_Username;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tB_Account_Password;
        private System.Windows.Forms.Label lb_Regist;
        private System.Windows.Forms.Label lb_Logout;
    }
}

