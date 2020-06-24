using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Contact_Manage
{
    public partial class Change_Image : Form
    {
        public Change_Image()
        {
            InitializeComponent();
        }

        private void btt_Select_Image_Click(object sender, EventArgs e)
        {
           
            OpenFileDialog f = new OpenFileDialog();
            f.InitialDirectory = Application.StartupPath + @"\images";
            f.Filter = "All files (*.*)|*.*|txt files (*.txt)|*.txt";
            f.FilterIndex = 1;
            f.RestoreDirectory = true;
            if (f.ShowDialog() == DialogResult.OK)
            {
                Regist.imagePath = f.FileName.ToString();
          
                pictrB_Image.Image = Image.FromFile(Regist.imagePath);
         
                pictrB_Image.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            return;
        }

        private void btt_Change_Image_Click(object sender, EventArgs e)
        {
            if (pictrB_Image.Image != null)
            {
                string sqlcon = "Data Source=DENGCHUANG\\DCMSSQLSERVER;database=phone_Book;uid=sa;pwd=666888";
                String sqlcom2 = "update Account set Account_Image='" + Regist.imagePath + "' where Account_Username='" + Login.txtLogin_Username + "'";
                SqlConnection con = new SqlConnection(sqlcon);
                SqlCommand com2 = new SqlCommand(sqlcom2, con);
                con.Open();
                int eq = com2.ExecuteNonQuery();
                if (eq != 0)
                {
                    MessageBox.Show("头像更换成功！");
                    this.Close();
                }
                else MessageBox.Show("头像更换失败！");
                con.Close();
            }
            else MessageBox.Show("请选择图片!");
            
        }

        private void Change_Image_Load(object sender, EventArgs e)
        {

        }
    }
}
