namespace Contact_Manage
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.btt_Add_Contact = new System.Windows.Forms.Button();
            this.btt_Manage_Contact = new System.Windows.Forms.Button();
            this.btt_Modification_Password = new System.Windows.Forms.Button();
            this.btt_Change_Image = new System.Windows.Forms.Button();
            this.btt_Mdfct_Username = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btt_Add_Contact
            // 
            this.btt_Add_Contact.BackColor = System.Drawing.Color.Transparent;
            this.btt_Add_Contact.Location = new System.Drawing.Point(59, 104);
            this.btt_Add_Contact.Margin = new System.Windows.Forms.Padding(4);
            this.btt_Add_Contact.Name = "btt_Add_Contact";
            this.btt_Add_Contact.Size = new System.Drawing.Size(100, 29);
            this.btt_Add_Contact.TabIndex = 0;
            this.btt_Add_Contact.Text = "添加成员";
            this.btt_Add_Contact.UseVisualStyleBackColor = false;
            this.btt_Add_Contact.Click += new System.EventHandler(this.btt_Add_Contact_Click);
            // 
            // btt_Manage_Contact
            // 
            this.btt_Manage_Contact.BackColor = System.Drawing.Color.Transparent;
            this.btt_Manage_Contact.Location = new System.Drawing.Point(186, 104);
            this.btt_Manage_Contact.Margin = new System.Windows.Forms.Padding(4);
            this.btt_Manage_Contact.Name = "btt_Manage_Contact";
            this.btt_Manage_Contact.Size = new System.Drawing.Size(100, 29);
            this.btt_Manage_Contact.TabIndex = 1;
            this.btt_Manage_Contact.Text = "管理成员";
            this.btt_Manage_Contact.UseVisualStyleBackColor = false;
            this.btt_Manage_Contact.Click += new System.EventHandler(this.btt_Manage_Contact_Click);
            // 
            // btt_Modification_Password
            // 
            this.btt_Modification_Password.BackColor = System.Drawing.Color.Transparent;
            this.btt_Modification_Password.Location = new System.Drawing.Point(313, 104);
            this.btt_Modification_Password.Margin = new System.Windows.Forms.Padding(4);
            this.btt_Modification_Password.Name = "btt_Modification_Password";
            this.btt_Modification_Password.Size = new System.Drawing.Size(100, 29);
            this.btt_Modification_Password.TabIndex = 2;
            this.btt_Modification_Password.Text = "修改密码";
            this.btt_Modification_Password.UseVisualStyleBackColor = false;
            this.btt_Modification_Password.Click += new System.EventHandler(this.btt_Modification_Password_Click);
            // 
            // btt_Change_Image
            // 
            this.btt_Change_Image.BackColor = System.Drawing.Color.Transparent;
            this.btt_Change_Image.Location = new System.Drawing.Point(440, 104);
            this.btt_Change_Image.Margin = new System.Windows.Forms.Padding(4);
            this.btt_Change_Image.Name = "btt_Change_Image";
            this.btt_Change_Image.Size = new System.Drawing.Size(100, 29);
            this.btt_Change_Image.TabIndex = 3;
            this.btt_Change_Image.Text = "更换头像";
            this.btt_Change_Image.UseVisualStyleBackColor = false;
            this.btt_Change_Image.Click += new System.EventHandler(this.btt_Change_Image_Click);
            // 
            // btt_Mdfct_Username
            // 
            this.btt_Mdfct_Username.BackColor = System.Drawing.Color.Transparent;
            this.btt_Mdfct_Username.Location = new System.Drawing.Point(567, 104);
            this.btt_Mdfct_Username.Margin = new System.Windows.Forms.Padding(4);
            this.btt_Mdfct_Username.Name = "btt_Mdfct_Username";
            this.btt_Mdfct_Username.Size = new System.Drawing.Size(100, 29);
            this.btt_Mdfct_Username.TabIndex = 4;
            this.btt_Mdfct_Username.Text = "修改账户名";
            this.btt_Mdfct_Username.UseVisualStyleBackColor = false;
            this.btt_Mdfct_Username.Click += new System.EventHandler(this.btt_Mdfct_Username_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Family_Tree.Properties.Resources._1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(743, 466);
            this.Controls.Add(this.btt_Mdfct_Username);
            this.Controls.Add(this.btt_Change_Image);
            this.Controls.Add(this.btt_Modification_Password);
            this.Controls.Add(this.btt_Manage_Contact);
            this.Controls.Add(this.btt_Add_Contact);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Menu";
            this.Text = "菜单";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btt_Add_Contact;
        private System.Windows.Forms.Button btt_Manage_Contact;
        private System.Windows.Forms.Button btt_Modification_Password;
        private System.Windows.Forms.Button btt_Change_Image;
        private System.Windows.Forms.Button btt_Mdfct_Username;
    }
}