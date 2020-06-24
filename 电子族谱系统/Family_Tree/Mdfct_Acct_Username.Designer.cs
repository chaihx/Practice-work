namespace Contact_Manage
{
    partial class Mdfct_Acct_Username
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
            this.lb_Username = new System.Windows.Forms.Label();
            this.lb_NewUsername = new System.Windows.Forms.Label();
            this.btt_Modfct_Username = new System.Windows.Forms.Button();
            this.tB_Username = new System.Windows.Forms.TextBox();
            this.tB_NewUsername = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lb_Username
            // 
            this.lb_Username.AutoSize = true;
            this.lb_Username.BackColor = System.Drawing.Color.Transparent;
            this.lb_Username.Location = new System.Drawing.Point(199, 98);
            this.lb_Username.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_Username.Name = "lb_Username";
            this.lb_Username.Size = new System.Drawing.Size(97, 15);
            this.lb_Username.TabIndex = 0;
            this.lb_Username.Text = "当前用户名：";
            // 
            // lb_NewUsername
            // 
            this.lb_NewUsername.AutoSize = true;
            this.lb_NewUsername.BackColor = System.Drawing.Color.Transparent;
            this.lb_NewUsername.Location = new System.Drawing.Point(215, 167);
            this.lb_NewUsername.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_NewUsername.Name = "lb_NewUsername";
            this.lb_NewUsername.Size = new System.Drawing.Size(82, 15);
            this.lb_NewUsername.TabIndex = 1;
            this.lb_NewUsername.Text = "新用户名：";
            // 
            // btt_Modfct_Username
            // 
            this.btt_Modfct_Username.Location = new System.Drawing.Point(331, 219);
            this.btt_Modfct_Username.Margin = new System.Windows.Forms.Padding(4);
            this.btt_Modfct_Username.Name = "btt_Modfct_Username";
            this.btt_Modfct_Username.Size = new System.Drawing.Size(100, 29);
            this.btt_Modfct_Username.TabIndex = 2;
            this.btt_Modfct_Username.Text = "修 改";
            this.btt_Modfct_Username.UseVisualStyleBackColor = true;
            this.btt_Modfct_Username.Click += new System.EventHandler(this.btt_Modfct_Username_Click);
            // 
            // tB_Username
            // 
            this.tB_Username.Location = new System.Drawing.Point(293, 94);
            this.tB_Username.Margin = new System.Windows.Forms.Padding(4);
            this.tB_Username.Name = "tB_Username";
            this.tB_Username.ReadOnly = true;
            this.tB_Username.Size = new System.Drawing.Size(177, 25);
            this.tB_Username.TabIndex = 3;
            this.tB_Username.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tB_Username_MouseClick);
            this.tB_Username.TextChanged += new System.EventHandler(this.tB_Username_TextChanged);
            // 
            // tB_NewUsername
            // 
            this.tB_NewUsername.Location = new System.Drawing.Point(293, 163);
            this.tB_NewUsername.Margin = new System.Windows.Forms.Padding(4);
            this.tB_NewUsername.Name = "tB_NewUsername";
            this.tB_NewUsername.Size = new System.Drawing.Size(177, 25);
            this.tB_NewUsername.TabIndex = 4;
            this.tB_NewUsername.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tB_NewUsername_MouseClick);
            // 
            // Mdfct_Acct_Username
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Family_Tree.Properties.Resources._1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(743, 466);
            this.Controls.Add(this.tB_NewUsername);
            this.Controls.Add(this.tB_Username);
            this.Controls.Add(this.btt_Modfct_Username);
            this.Controls.Add(this.lb_NewUsername);
            this.Controls.Add(this.lb_Username);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Mdfct_Acct_Username";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "修改账户名";
            this.Load += new System.EventHandler(this.Mdfct_Acct_Username_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_Username;
        private System.Windows.Forms.Label lb_NewUsername;
        private System.Windows.Forms.Button btt_Modfct_Username;
        private System.Windows.Forms.TextBox tB_Username;
        private System.Windows.Forms.TextBox tB_NewUsername;
    }
}