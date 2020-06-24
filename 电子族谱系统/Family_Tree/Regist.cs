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
    public partial class Regist : Form
    {
  
        public static String imagePath = "C:\\Users\\95635\\Desktop\\dc.jpg";
        public Regist()
        {
            InitializeComponent();
        }

        private void btt_Regist_Click(object sender, EventArgs e)
        {
  
            String regist_Username = tB_Regist_Username.Text;
            String regist_Password1 = tB_Regist_Password1.Text;
            string regist_Password2 = tB_Regist_Password2.Text;

  
            if (regist_Username == "" || regist_Password1 == "" || regist_Password2 == "")
            {
                MessageBox.Show("请输入用户名和密码！");
                return;
            }
 
            if (!regist_Password1.Equals(regist_Password2))
            {
                MessageBox.Show("两次输入的密码不一致，请重新输入！");
                return;
            }
            


            string sqlcon = "Data Source=DENGCHUANG\\DCMSSQLSERVER;database=phone_Book;uid=sa;pwd=666888";
            String sqlcom = " select * from Account where Account_Username='" + regist_Username + "'";
            SqlConnection con = new SqlConnection(sqlcon);
            SqlCommand com = new SqlCommand(sqlcom, con);
            con.Open();

            SqlDataReader reader = com.ExecuteReader();
            if (reader.Read())
            {
                MessageBox.Show("用户名已存在，请重新输入用户名！");
                return;
            }
            reader.Close();
            



            String sqlcom2 = " insert into Account(Account_Username,Account_Password,Account_Image) values('" + regist_Username + "','" + regist_Password1 + "','"+imagePath+"')";
            SqlCommand com2 = new SqlCommand(sqlcom2, con);
            int eq=com2.ExecuteNonQuery();
            if(eq!=0)
            {
                MessageBox.Show("注册成功！将跳转到登录页面！");
                this.Close();
            }
            con.Close();

        }

        
        private void btt_ChangeImage_Click(object sender, EventArgs e)
        {

 
            OpenFileDialog f = new OpenFileDialog();
            f.InitialDirectory = Application.StartupPath + @"\images";
            f.Filter = "All files (*.*)|*.*|txt files (*.txt)|*.txt";
            f.FilterIndex = 1;
            f.RestoreDirectory = true;
            if (f.ShowDialog() == DialogResult.OK)
            {
                imagePath = f.FileName.ToString();
         
                pctrB_Regist_Image.Image = Image.FromFile(imagePath);
      
                pctrB_Regist_Image.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            return;
        }

        private void tB_Regist_Username_TextChanged(object sender, EventArgs e)
        {

        }

        private void Regist_Load(object sender, EventArgs e)
        {

        }

        private void pctrB_Regist_Image_Click(object sender, EventArgs e)
        {

        }
    }
}
