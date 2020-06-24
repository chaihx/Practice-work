namespace Contact_Manage
{
    partial class Regist
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
            this.label2 = new System.Windows.Forms.Label();
            this.btt_Regist = new System.Windows.Forms.Button();
            this.tB_Regist_Username = new System.Windows.Forms.TextBox();
            this.tB_Regist_Password1 = new System.Windows.Forms.TextBox();
            this.tB_Regist_Password2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pctrB_Regist_Image = new System.Windows.Forms.PictureBox();
            this.btt_ChangeImage = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pctrB_Regist_Image)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(135, 93);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "用户名：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(122, 135);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "输入密码：";
            // 
            // btt_Regist
            // 
            this.btt_Regist.Location = new System.Drawing.Point(298, 225);
            this.btt_Regist.Margin = new System.Windows.Forms.Padding(4);
            this.btt_Regist.Name = "btt_Regist";
            this.btt_Regist.Size = new System.Drawing.Size(100, 29);
            this.btt_Regist.TabIndex = 5;
            this.btt_Regist.Text = "注 册";
            this.btt_Regist.UseVisualStyleBackColor = true;
            this.btt_Regist.Click += new System.EventHandler(this.btt_Regist_Click);
            // 
            // tB_Regist_Username
            // 
            this.tB_Regist_Username.Location = new System.Drawing.Point(214, 89);
            this.tB_Regist_Username.Margin = new System.Windows.Forms.Padding(4);
            this.tB_Regist_Username.Name = "tB_Regist_Username";
            this.tB_Regist_Username.Size = new System.Drawing.Size(273, 25);
            this.tB_Regist_Username.TabIndex = 6;
            this.tB_Regist_Username.TextChanged += new System.EventHandler(this.tB_Regist_Username_TextChanged);
            // 
            // tB_Regist_Password1
            // 
            this.tB_Regist_Password1.Location = new System.Drawing.Point(212, 132);
            this.tB_Regist_Password1.Margin = new System.Windows.Forms.Padding(4);
            this.tB_Regist_Password1.Name = "tB_Regist_Password1";
            this.tB_Regist_Password1.PasswordChar = '*';
            this.tB_Regist_Password1.Size = new System.Drawing.Size(275, 25);
            this.tB_Regist_Password1.TabIndex = 7;
            // 
            // tB_Regist_Password2
            // 
            this.tB_Regist_Password2.Location = new System.Drawing.Point(214, 177);
            this.tB_Regist_Password2.Margin = new System.Windows.Forms.Padding(4);
            this.tB_Regist_Password2.Name = "tB_Regist_Password2";
            this.tB_Regist_Password2.PasswordChar = '*';
            this.tB_Regist_Password2.Size = new System.Drawing.Size(275, 25);
            this.tB_Regist_Password2.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(94, 180);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "再次输入密码：";
            // 
            // pctrB_Regist_Image
            // 
            this.pctrB_Regist_Image.Location = new System.Drawing.Point(535, 118);
            this.pctrB_Regist_Image.Margin = new System.Windows.Forms.Padding(4);
            this.pctrB_Regist_Image.Name = "pctrB_Regist_Image";
            this.pctrB_Regist_Image.Size = new System.Drawing.Size(113, 84);
            this.pctrB_Regist_Image.TabIndex = 10;
            this.pctrB_Regist_Image.TabStop = false;
            this.pctrB_Regist_Image.Click += new System.EventHandler(this.pctrB_Regist_Image_Click);
            // 
            // btt_ChangeImage
            // 
            this.btt_ChangeImage.Location = new System.Drawing.Point(541, 225);
            this.btt_ChangeImage.Margin = new System.Windows.Forms.Padding(4);
            this.btt_ChangeImage.Name = "btt_ChangeImage";
            this.btt_ChangeImage.Size = new System.Drawing.Size(100, 29);
            this.btt_ChangeImage.TabIndex = 11;
            this.btt_ChangeImage.Text = "更换头像";
            this.btt_ChangeImage.UseVisualStyleBackColor = true;
            this.btt_ChangeImage.Click += new System.EventHandler(this.btt_ChangeImage_Click);
            // 
            // Regist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Family_Tree.Properties.Resources._1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(743, 466);
            this.Controls.Add(this.btt_ChangeImage);
            this.Controls.Add(this.pctrB_Regist_Image);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tB_Regist_Password2);
            this.Controls.Add(this.tB_Regist_Password1);
            this.Controls.Add(this.tB_Regist_Username);
            this.Controls.Add(this.btt_Regist);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Regist";
            this.Text = "注册";
            this.Load += new System.EventHandler(this.Regist_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pctrB_Regist_Image)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btt_Regist;
        private System.Windows.Forms.TextBox tB_Regist_Username;
        private System.Windows.Forms.TextBox tB_Regist_Password1;
        private System.Windows.Forms.TextBox tB_Regist_Password2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pctrB_Regist_Image;
        private System.Windows.Forms.Button btt_ChangeImage;
    }
}