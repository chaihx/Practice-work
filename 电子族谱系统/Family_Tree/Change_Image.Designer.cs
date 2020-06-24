namespace Contact_Manage
{
    partial class Change_Image
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Change_Image));
            this.pictrB_Image = new System.Windows.Forms.PictureBox();
            this.btt_Change_Image = new System.Windows.Forms.Button();
            this.btt_Select_Image = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictrB_Image)).BeginInit();
            this.SuspendLayout();
            // 
            // pictrB_Image
            // 
            this.pictrB_Image.Location = new System.Drawing.Point(48, 71);
            this.pictrB_Image.Margin = new System.Windows.Forms.Padding(4);
            this.pictrB_Image.Name = "pictrB_Image";
            this.pictrB_Image.Size = new System.Drawing.Size(133, 98);
            this.pictrB_Image.TabIndex = 1;
            this.pictrB_Image.TabStop = false;
            // 
            // btt_Change_Image
            // 
            this.btt_Change_Image.Location = new System.Drawing.Point(127, 232);
            this.btt_Change_Image.Margin = new System.Windows.Forms.Padding(4);
            this.btt_Change_Image.Name = "btt_Change_Image";
            this.btt_Change_Image.Size = new System.Drawing.Size(100, 29);
            this.btt_Change_Image.TabIndex = 2;
            this.btt_Change_Image.Text = "确认更换";
            this.btt_Change_Image.UseVisualStyleBackColor = true;
            this.btt_Change_Image.Click += new System.EventHandler(this.btt_Change_Image_Click);
            // 
            // btt_Select_Image
            // 
            this.btt_Select_Image.Location = new System.Drawing.Point(231, 104);
            this.btt_Select_Image.Margin = new System.Windows.Forms.Padding(4);
            this.btt_Select_Image.Name = "btt_Select_Image";
            this.btt_Select_Image.Size = new System.Drawing.Size(100, 29);
            this.btt_Select_Image.TabIndex = 3;
            this.btt_Select_Image.Text = "选择图片";
            this.btt_Select_Image.UseVisualStyleBackColor = true;
            this.btt_Select_Image.Click += new System.EventHandler(this.btt_Select_Image_Click);
            // 
            // Change_Image
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;

            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(379, 326);
            this.Controls.Add(this.btt_Select_Image);
            this.Controls.Add(this.btt_Change_Image);
            this.Controls.Add(this.pictrB_Image);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Change_Image";
            this.Text = "更换头像";
            this.Load += new System.EventHandler(this.Change_Image_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictrB_Image)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictrB_Image;
        private System.Windows.Forms.Button btt_Change_Image;
        private System.Windows.Forms.Button btt_Select_Image;
    }
}