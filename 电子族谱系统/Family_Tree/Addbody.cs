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
    /// 添加联系人
    /// </summary>
    public partial class AddContact : Form
    {
        public AddContact()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
  
            if (tB_Name.Text.Length == 0 && tB_Phone.Text.Length == 0)
            {
                MessageBox.Show("姓名电话必须填写！");
                return;
            }

            string sqlcon = "Data Source=DENGCHUANG\\DCMSSQLSERVER;database=phone_Book;uid=sa;pwd=666888";
            string sqlcom = "INSERT INTO Contact (姓名,性别,出生日期,父亲,管理员) VALUES('"
                + tB_Name.Text + "','" + tB_QQ.Text + "','" + tB_Phone.Text + "','" + tB_Email.Text + "','"+Login.txtLogin_Username+"')";
      
            SqlConnection con = new SqlConnection(sqlcon);
            SqlCommand com = new SqlCommand(sqlcom, con);
            con.Open();
            int eq = com.ExecuteNonQuery();
            if (eq != 0)
            {
                MessageBox.Show("添加成功!");
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

        private void AddContact_Load(object sender, EventArgs e)
        {

        }

        private void tB_Name_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
