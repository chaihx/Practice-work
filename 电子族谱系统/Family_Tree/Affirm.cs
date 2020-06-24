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
    public partial class Affirm : Form
    {
       
        public Affirm()
        {
            InitializeComponent();
        }


        private void btt_Logout_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();      
        }


        private void btt_Logout_Click(object sender, EventArgs e)
        {
            String sqlcon = "Data Source=DENGCHUANG\\DCMSSQLSERVER;database=phone_Book;uid=sa;pwd=666888;";
            String sqlcom = "delete from Account where Account_Username='"+ Logout.txtLogoutName+ "'";
            SqlConnection con = new SqlConnection(sqlcon);
            SqlCommand com = new SqlCommand(sqlcom, con);
            con.Open();
            int eq=com.ExecuteNonQuery();
            if (eq != 0)
            {
                MessageBox.Show("注销成功！");
            }
            else MessageBox.Show("注销失败！");
            con.Close();
            this.Close();
        }

        private void Affirm_Load(object sender, EventArgs e)
        {

        }
    }
}
