namespace Contact_Manage
{
    partial class Contact_Manage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Contact_Manage));
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tB_Name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tB_Email = new System.Windows.Forms.TextBox();
            this.tB_Phone = new System.Windows.Forms.TextBox();
            this.tB_QQ = new System.Windows.Forms.TextBox();
            this.btt_Delete = new System.Windows.Forms.Button();
            this.btt_Modification = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.tB_ID = new System.Windows.Forms.TextBox();
            this.btt_Hint = new System.Windows.Forms.Button();
            this.lb_Username = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pctrB_Image = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctrB_Image)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1139, 214);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 29);
            this.button1.TabIndex = 0;
            this.button1.Text = "查 询";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(392, 381);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "姓名：";
            // 
            // tB_Name
            // 
            this.tB_Name.Location = new System.Drawing.Point(436, 378);
            this.tB_Name.Margin = new System.Windows.Forms.Padding(4);
            this.tB_Name.Name = "tB_Name";
            this.tB_Name.Size = new System.Drawing.Size(252, 25);
            this.tB_Name.TabIndex = 2;
            this.tB_Name.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tB_Name_MouseClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(696, 385);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "出生日期：";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(37, 427);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "性别：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(392, 427);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "父亲：";
            // 
            // tB_Email
            // 
            this.tB_Email.Location = new System.Drawing.Point(436, 424);
            this.tB_Email.Margin = new System.Windows.Forms.Padding(4);
            this.tB_Email.Name = "tB_Email";
            this.tB_Email.Size = new System.Drawing.Size(252, 25);
            this.tB_Email.TabIndex = 6;
            // 
            // tB_Phone
            // 
            this.tB_Phone.Location = new System.Drawing.Point(771, 378);
            this.tB_Phone.Margin = new System.Windows.Forms.Padding(4);
            this.tB_Phone.Name = "tB_Phone";
            this.tB_Phone.Size = new System.Drawing.Size(269, 25);
            this.tB_Phone.TabIndex = 7;
            // 
            // tB_QQ
            // 
            this.tB_QQ.Location = new System.Drawing.Point(80, 424);
            this.tB_QQ.Margin = new System.Windows.Forms.Padding(4);
            this.tB_QQ.Name = "tB_QQ";
            this.tB_QQ.Size = new System.Drawing.Size(235, 25);
            this.tB_QQ.TabIndex = 8;
            // 
            // btt_Delete
            // 
            this.btt_Delete.Location = new System.Drawing.Point(1139, 378);
            this.btt_Delete.Margin = new System.Windows.Forms.Padding(4);
            this.btt_Delete.Name = "btt_Delete";
            this.btt_Delete.Size = new System.Drawing.Size(100, 29);
            this.btt_Delete.TabIndex = 10;
            this.btt_Delete.Text = "删 除";
            this.btt_Delete.UseVisualStyleBackColor = true;
            this.btt_Delete.Click += new System.EventHandler(this.btt_Delete_Click);
            // 
            // btt_Modification
            // 
            this.btt_Modification.Location = new System.Drawing.Point(1139, 295);
            this.btt_Modification.Margin = new System.Windows.Forms.Padding(4);
            this.btt_Modification.Name = "btt_Modification";
            this.btt_Modification.Size = new System.Drawing.Size(100, 29);
            this.btt_Modification.TabIndex = 11;
            this.btt_Modification.Text = "修 改";
            this.btt_Modification.UseVisualStyleBackColor = true;
            this.btt_Modification.Click += new System.EventHandler(this.btt_Modification_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(43, 381);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 15);
            this.label5.TabIndex = 12;
            this.label5.Text = "I D：";
            // 
            // tB_ID
            // 
            this.tB_ID.Location = new System.Drawing.Point(80, 378);
            this.tB_ID.Margin = new System.Windows.Forms.Padding(4);
            this.tB_ID.Name = "tB_ID";
            this.tB_ID.ReadOnly = true;
            this.tB_ID.Size = new System.Drawing.Size(235, 25);
            this.tB_ID.TabIndex = 13;
            // 
            // btt_Hint
            // 
            this.btt_Hint.Location = new System.Drawing.Point(1139, 140);
            this.btt_Hint.Margin = new System.Windows.Forms.Padding(4);
            this.btt_Hint.Name = "btt_Hint";
            this.btt_Hint.Size = new System.Drawing.Size(100, 29);
            this.btt_Hint.TabIndex = 14;
            this.btt_Hint.Text = "提 示";
            this.btt_Hint.UseVisualStyleBackColor = true;
            this.btt_Hint.Click += new System.EventHandler(this.btt_Hint_Click);
            // 
            // lb_Username
            // 
            this.lb_Username.AutoSize = true;
            this.lb_Username.BackColor = System.Drawing.Color.Transparent;
            this.lb_Username.Location = new System.Drawing.Point(1076, 15);
            this.lb_Username.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_Username.Name = "lb_Username";
            this.lb_Username.Size = new System.Drawing.Size(52, 15);
            this.lb_Username.TabIndex = 15;
            this.lb_Username.Text = "账号名";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(16, 15);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(1025, 309);
            this.dataGridView1.TabIndex = 17;
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            // 
            // pctrB_Image
            // 
            this.pctrB_Image.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pctrB_Image.BackgroundImage")));
            this.pctrB_Image.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pctrB_Image.Location = new System.Drawing.Point(1139, 15);
            this.pctrB_Image.Margin = new System.Windows.Forms.Padding(4);
            this.pctrB_Image.Name = "pctrB_Image";
            this.pctrB_Image.Size = new System.Drawing.Size(108, 82);
            this.pctrB_Image.TabIndex = 16;
            this.pctrB_Image.TabStop = false;
            this.pctrB_Image.Click += new System.EventHandler(this.pctrB_Image_Click);
            // 
            // Contact_Manage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1267, 496);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pctrB_Image);
            this.Controls.Add(this.lb_Username);
            this.Controls.Add(this.btt_Hint);
            this.Controls.Add(this.tB_ID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btt_Modification);
            this.Controls.Add(this.btt_Delete);
            this.Controls.Add(this.tB_QQ);
            this.Controls.Add(this.tB_Phone);
            this.Controls.Add(this.tB_Email);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tB_Name);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Contact_Manage";
            this.Text = "成员管理";
            this.Load += new System.EventHandler(this.Contact_Manage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctrB_Image)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tB_Name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tB_Email;
        private System.Windows.Forms.TextBox tB_Phone;
        private System.Windows.Forms.TextBox tB_QQ;
        private System.Windows.Forms.Button btt_Delete;
        private System.Windows.Forms.Button btt_Modification;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tB_ID;
        private System.Windows.Forms.Button btt_Hint;
        private System.Windows.Forms.Label lb_Username;
        private System.Windows.Forms.PictureBox pctrB_Image;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}