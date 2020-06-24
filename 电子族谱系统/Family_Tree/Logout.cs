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
    /// 注销用户界面
    /// </summary>
    public partial class Logout : Form
    {
        //注销账号名
        public static string txtLogoutName;
        public Logout()
        {
            InitializeComponent();
        }


        private void btt_Logout_Click(object sender, EventArgs e)
        {
            
            String logout_Username = tB_Logout_Username.Text;
            String logout_Password = tB_Logout_Password.Text;

 
            if (logout_Username == "" || logout_Password == "")
            {
                MessageBox.Show("请输入要注销的用户名和密码！");
                return;
            }


            String sqlcon = "Data Source=DENGCHUANG\\DCMSSQLSERVER;database=phone_Book;uid=sa;pwd=666888;";
            String sqlcom = "select * from Account where Account_Username='"+logout_Username+"' and Account_Password='"+logout_Password+"'";
            SqlConnection con = new SqlConnection(sqlcon);
            SqlCommand com = new SqlCommand(sqlcom,con);
            con.Open();
            SqlDataReader reader= com.ExecuteReader();
            if (reader.Read())
            {
   
                txtLogoutName= tB_Logout_Username.Text;
                Affirm affirm = new Affirm();
                affirm.Show();
                
            }
            else { MessageBox.Show("你输入的用户名或密码不正确，请重新输入！"); }

          
            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }
            
            con.Close();

            
        }

        private void Logout_Load(object sender, EventArgs e)
        {

        }
    }
}
