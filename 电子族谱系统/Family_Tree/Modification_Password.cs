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

    public partial class Modification_Password : Form
    {
        public Modification_Password()
        {
            InitializeComponent();
        }


        private void btt_Modification_Password_Click(object sender, EventArgs e)
        {
 
            String modification_Username = Login.txtLogin_Username;


            String login_Pwd = tB_Modif_Password.Text;
            String modif_NewPwd1 = tB_Modif_NewPassword.Text;
            String modif_NewPwd2 = tB_Modif_NewPassword2.Text;

            if (login_Pwd == "")
            {
                MessageBox.Show("请输入密码！");
                return;
            }

 
            String sqlcon = "Data Source=DENGCHUANG\\DCMSSQLSERVER;database=phone_Book;uid=sa;pwd=666888;";
            String sqlcom = "select * from Account where Account_Password='"+login_Pwd+"'";
            SqlConnection con = new SqlConnection(sqlcon);
            SqlCommand com = new SqlCommand(sqlcom,con);
            con.Open();
            SqlDataReader reader= com.ExecuteReader();
            if (!reader.Read())
            {
                MessageBox.Show("原登录密码错误，请重新输入！");
                return;
            }
            con.Close();


            if (modif_NewPwd1 == "" || modif_NewPwd2 == "")
            {
                MessageBox.Show("请输入新密码！");
                return;
            }

            if (!modif_NewPwd1.Equals(modif_NewPwd2))
            {
                MessageBox.Show("你两次输入的新密码不一致，请重新输入！");
                return;
            }

  
            String sqlcom2 = "update Account set Account_Password='"+modif_NewPwd1+"' where Account_Username='"+modification_Username+"'";
            SqlConnection con2 = new SqlConnection(sqlcon);
            SqlCommand com2 = new SqlCommand(sqlcom2, con2);
            con2.Open();
            int eq=com2.ExecuteNonQuery();
            if (eq != 0)
            {
                MessageBox.Show("修改密码成功！");
                this.Close();
            }
            else MessageBox.Show("修改密码失败！");

            con2.Close();
        }

  
        private void tB_Modif_Password_MouseClick(object sender, MouseEventArgs e)
        {

            String modification_Username = Login.txtLogin_Username;
            tB_Modif_Username.Text = modification_Username;
        }

  
        private void tB_Modif_Username_MouseClick(object sender, MouseEventArgs e)
        {

            String modification_Username = Login.txtLogin_Username;
            tB_Modif_Username.Text = modification_Username;
        }

        private void Modification_Password_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
