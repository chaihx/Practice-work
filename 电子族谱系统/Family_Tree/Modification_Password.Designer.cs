namespace Contact_Manage
{
    partial class Modification_Password
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
            this.label1 = new System.Windows.Forms.Label();
            this.tB_Modif_Username = new System.Windows.Forms.TextBox();
            this.btt_Modification_Password = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tB_Modif_Password = new System.Windows.Forms.TextBox();
            this.tB_Modif_NewPassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tB_Modif_NewPassword2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(180, 85);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "当前用户：";
            // 
            // tB_Modif_Username
            // 
            this.tB_Modif_Username.Location = new System.Drawing.Point(270, 75);
            this.tB_Modif_Username.Margin = new System.Windows.Forms.Padding(4);
            this.tB_Modif_Username.Name = "tB_Modif_Username";
            this.tB_Modif_Username.ReadOnly = true;
            this.tB_Modif_Username.Size = new System.Drawing.Size(237, 25);
            this.tB_Modif_Username.TabIndex = 1;
            this.tB_Modif_Username.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tB_Modif_Username_MouseClick);
            // 
            // btt_Modification_Password
            // 
            this.btt_Modification_Password.Location = new System.Drawing.Point(332, 277);
            this.btt_Modification_Password.Margin = new System.Windows.Forms.Padding(4);
            this.btt_Modification_Password.Name = "btt_Modification_Password";
            this.btt_Modification_Password.Size = new System.Drawing.Size(100, 29);
            this.btt_Modification_Password.TabIndex = 2;
            this.btt_Modification_Password.Text = "修 改";
            this.btt_Modification_Password.UseVisualStyleBackColor = true;
            this.btt_Modification_Password.Click += new System.EventHandler(this.btt_Modification_Password_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(179, 126);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "原 密 码：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(165, 169);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "输入新密码：";
            // 
            // tB_Modif_Password
            // 
            this.tB_Modif_Password.Location = new System.Drawing.Point(270, 116);
            this.tB_Modif_Password.Margin = new System.Windows.Forms.Padding(4);
            this.tB_Modif_Password.Name = "tB_Modif_Password";
            this.tB_Modif_Password.PasswordChar = '*';
            this.tB_Modif_Password.Size = new System.Drawing.Size(237, 25);
            this.tB_Modif_Password.TabIndex = 5;
            this.tB_Modif_Password.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tB_Modif_Password_MouseClick);
            // 
            // tB_Modif_NewPassword
            // 
            this.tB_Modif_NewPassword.Location = new System.Drawing.Point(270, 159);
            this.tB_Modif_NewPassword.Margin = new System.Windows.Forms.Padding(4);
            this.tB_Modif_NewPassword.Name = "tB_Modif_NewPassword";
            this.tB_Modif_NewPassword.PasswordChar = '*';
            this.tB_Modif_NewPassword.Size = new System.Drawing.Size(237, 25);
            this.tB_Modif_NewPassword.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(165, 210);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "确认新密码：";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // tB_Modif_NewPassword2
            // 
            this.tB_Modif_NewPassword2.Location = new System.Drawing.Point(270, 207);
            this.tB_Modif_NewPassword2.Margin = new System.Windows.Forms.Padding(4);
            this.tB_Modif_NewPassword2.Name = "tB_Modif_NewPassword2";
            this.tB_Modif_NewPassword2.PasswordChar = '*';
            this.tB_Modif_NewPassword2.Size = new System.Drawing.Size(237, 25);
            this.tB_Modif_NewPassword2.TabIndex = 8;
            // 
            // Modification_Password
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Family_Tree.Properties.Resources._1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(743, 466);
            this.Controls.Add(this.tB_Modif_NewPassword2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tB_Modif_NewPassword);
            this.Controls.Add(this.tB_Modif_Password);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btt_Modification_Password);
            this.Controls.Add(this.tB_Modif_Username);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Modification_Password";
            this.Text = "修改密码";
            this.Load += new System.EventHandler(this.Modification_Password_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tB_Modif_Username;
        private System.Windows.Forms.Button btt_Modification_Password;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tB_Modif_Password;
        private System.Windows.Forms.TextBox tB_Modif_NewPassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tB_Modif_NewPassword2;
    }
}