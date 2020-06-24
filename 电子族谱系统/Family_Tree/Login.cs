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
    /// <summary>
    /// 登录
    /// </summary>
    public partial class Login : Form
    {

        public static String txtLogin_Username;
        public Login()
        {
            InitializeComponent();
        }
        private void btt_Login_Click(object sender, EventArgs e)
        {
 
            txtLogin_Username = tB_Account_Username.Text;
            String password = tB_Account_Password.Text;

            if (txtLogin_Username == "" || password == "")
            {
                MessageBox.Show("请输入用户名和密码！");
                return;
            }

     
            string sqlcon = "server=DENGCHUANG\\DCMSSQLSERVER;database=phone_Book;uid=sa;pwd=666888";
            String sqlcom = " select * from Account where Account_Username='" + txtLogin_Username + "' and Account_password='" + password + "'";
            SqlConnection con = new SqlConnection(sqlcon);
            SqlCommand com = new SqlCommand(sqlcom, con);
            con.Open();

            SqlDataReader reader = com.ExecuteReader();
            if (reader.Read())
            {
      
                Menu menu = new Menu();
                menu.Show();
            }
            else
            {
                MessageBox.Show("用户名或密码错误，请重新输入！");
            }
            con.Close();

       
            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }
        }

    
        private void lb_Regist_Click(object sender, EventArgs e)
        {
            Regist rigist = new Regist();
            rigist.Show();
        }

      
        private void lb_Logout_Click(object sender, EventArgs e)
        {
       
            Logout logout = new Logout();
            logout.Show();

        }

    
        private void tB_Account_Password_MouseClick(object sender, MouseEventArgs e)
        {
    
            String username = tB_Account_Username.Text;

            if (username != "")
            {
              
                string sqlcon = "Data Source=DENGCHUANG\\DCMSSQLSERVER;Initial Catalog=phone_Book;Integrated Security=True";
                String sqlcom = " select * from Account where Account_Username='" + username + "'";
                SqlConnection con = new SqlConnection(sqlcon);
                SqlCommand com = new SqlCommand(sqlcom, con);
                con.Open();

                SqlDataReader reader = com.ExecuteReader();
                if (reader.Read())
                {
                    reader.Close();
                   
                    string sqlcon2 = "server=DENGCHUANG\\DCMSSQLSERVER;database=phone_Book;uid=sa;pwd=666888";
                    String sqlcom2 = "select Account_Image from Account where Account_Username='" + username + "'";
                    SqlConnection con2 = new SqlConnection(sqlcon2);
                    SqlCommand com2 = new SqlCommand(sqlcom2, con2);
                    con2.Open();
               
                    object obj = com2.ExecuteScalar();
               
                    String image_Path = obj.ToString();

                    con2.Close();

                }
                else
                {
                    MessageBox.Show("用户名不存在，请重新输入！");
                }
                con.Close();

            }


        }

        private void tB_Account_Username_TextChanged(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void pctrB_Image_Click(object sender, EventArgs e)
        {

        }

        private void tB_Account_Password_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
