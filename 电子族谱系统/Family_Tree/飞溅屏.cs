using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Contact_Manage
{
    public partial class 飞溅屏 : Form
    {
        public 飞溅屏()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.Opacity < 1)
                this.Opacity += 0.02;
            else
                this.Close();
        }

        private void 飞溅屏_Load(object sender, EventArgs e)
        {

        }
    }
}
