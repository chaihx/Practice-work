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
using System.Configuration;


namespace Contact_Manage
{
    public partial class Contact_Manage : Form
    {

        string sqlcon = "server=DENGCHUANG\\DCMSSQLSERVER;database=phone_Book;uid=sa;pwd=666888";
        public Contact_Manage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string condition = " 1=1";

            if (tB_Name.Text != "")
                condition = condition + " and 姓名 like'" + tB_Name.Text + "%'";
    
            if (tB_Phone.Text != "")
                condition = condition + " and 性别 like'" + tB_Phone.Text + "%'";
  
            if (tB_QQ.Text != "")
                condition = condition + " and 出生日期 like'" + tB_QQ.Text + "%'";

            if (tB_Email.Text != "")
                condition = condition + " and 父亲 like'" + tB_Email.Text + "%'";

            if (tB_ID.Text != "")
            {
                condition = condition + " and Contact_ID='" + tB_ID.Text + "'";
            }
            string sqlcom = "select * from Contact where" + condition;
            
            SqlConnection con = new SqlConnection(sqlcon);
            con.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(sqlcom, con);

            DataSet ds = new DataSet();
            adapter.Fill(ds,"cs");
            dataGridView1.DataSource = ds.Tables["cs"];//绑定

            con.Close();

   
            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }

    
            lb_Username.Text = Login.txtLogin_Username;
        
            String sqlcom2 = "select Account_Image from Account where Account_Username='" + Login.txtLogin_Username + "'";
            SqlConnection con2 = new SqlConnection(sqlcon);
            SqlCommand com2 = new SqlCommand(sqlcom2, con2);
            con2.Open();
     
            object obj = com2.ExecuteScalar();
        
            String image_Path = obj.ToString();

            con2.Close();
            pctrB_Image.Image = Image.FromFile(image_Path);
     
            pctrB_Image.SizeMode = PictureBoxSizeMode.StretchImage;

        }

        private void btt_Modification_Click(object sender, EventArgs e)
        {

 
            String modification_ID = tB_ID.Text;

            if (modification_ID != "")
            {
                String condition = "";
         
                if (tB_Phone.Text != "")
                    condition = condition + ",Contact_Phone='" + tB_Phone.Text + "'";
 
                if (tB_QQ.Text != "")
                    condition = condition + ",Contact_QQ='" + tB_QQ.Text + "'";
  
                if (tB_Email.Text != "")
                    condition = condition + ",Contact_Email='" + tB_Email.Text + "'";

                String sqlcom = "update Contact set Contact_Name='" + tB_Name.Text + "'" + condition + " where Contact_ID = '" + modification_ID + "'";

                SqlConnection con = new SqlConnection(sqlcon);
                SqlCommand com = new SqlCommand(sqlcom, con);
                con.Open();
                int eq = com.ExecuteNonQuery();
                if (eq != 0)
                {
                    MessageBox.Show("修改成功！");
                }
                else MessageBox.Show("修改失败！");
                con.Close();
                
                foreach (Control item in this.Controls)
                {
                    if (item is TextBox)
                    {
                        item.Text = "";
                    }
                }
            }
            else MessageBox.Show("请先点击联系人再进行修改操作！");

        }


        private void btt_Delete_Click(object sender, EventArgs e)
        {

            String delete_ID = tB_ID.Text;

            String sqlcom = "delete from Contact where ID='" + delete_ID + "'";
            SqlConnection con = new SqlConnection(sqlcon);
            SqlCommand com = new SqlCommand(sqlcom, con);
            con.Open();
            int eq = com.ExecuteNonQuery();
            if (eq != 0)
            {
                MessageBox.Show("删除成功");
            }
            else MessageBox.Show("删除失败");
            con.Close();


            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }

        }

        private void btt_Hint_Click(object sender, EventArgs e)
        {
       
            lb_Username.Text = Login.txtLogin_Username;
            
            String sqlcom = "select Account_Image from Account where Account_Username='" + Login.txtLogin_Username + "'";
            SqlConnection con = new SqlConnection(sqlcon);
            SqlCommand com = new SqlCommand(sqlcom, con);
            con.Open();
   
            object obj = com.ExecuteScalar();
        
            String image_Path = obj.ToString();

            con.Close();
            pctrB_Image.Image = Image.FromFile(image_Path);

            pctrB_Image.SizeMode = PictureBoxSizeMode.StretchImage;

            MessageBox.Show("查询：文本框全为空时，点击查询将列出所有数据，除ID之外都为模糊查询。\r删除：点击要删除的行。\r修改：ID不可改");
        }

        private void tB_Name_MouseClick(object sender, MouseEventArgs e)
        {
     
            lb_Username.Text = Login.txtLogin_Username;
            String sqlcon = "Data Source=DENGCHUANG\\DCMSSQLSERVER;database=phone_Book;uid=sa;pwd=666888;";
            String sqlcom = "select Account_Image from Account where Account_Username='" + Login.txtLogin_Username + "'";
            SqlConnection con = new SqlConnection(sqlcon);
            SqlCommand com = new SqlCommand(sqlcom, con);
            con.Open();
            object obj = com.ExecuteScalar();
      
            String image_Path = obj.ToString();

            con.Close();
           // pctrB_Image.Image = Image.FromFile(image_Path);
   
          //  pctrB_Image.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            tB_ID.Text = this.dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            tB_Name.Text = this.dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            tB_QQ.Text = this.dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            tB_Phone.Text = this.dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            tB_Email.Text = this.dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
        }

        private void Contact_Manage_Load(object sender, EventArgs e)
        {

        }

        private void pctrB_Image_Click(object sender, EventArgs e)
        {

        }
    }
}
