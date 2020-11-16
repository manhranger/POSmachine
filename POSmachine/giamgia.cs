using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POSmachine
{
    public partial class giamgia : Form
    {
        public static int gtgiamgia = 0;
        public giamgia()
        {
            InitializeComponent();
        }

        private void giamgia_Load(object sender, EventArgs e)
        {

        }

        private void btn20percent_Click(object sender, EventArgs e)
        {

            gtgiamgia = 20;
            btn40percent.ForeColor = Color.Blue;
            btn50percent.ForeColor = Color.Blue;
            btn20percent.ForeColor = Color.Red;
        }

        private void btn40percent_Click(object sender, EventArgs e)
        {
            gtgiamgia = 40;
            btn40percent.ForeColor = Color.Red;
            btn50percent.ForeColor = Color.Blue;
            btn20percent.ForeColor = Color.Blue;
        }

        private void btn50percent_Click(object sender, EventArgs e)
        {
            gtgiamgia = 50;
            btn40percent.ForeColor = Color.Blue;
            btn50percent.ForeColor = Color.Red;
            btn20percent.ForeColor = Color.Blue;
        }

        private void btnhuy_Click(object sender, EventArgs e)
        {
            gtgiamgia = 0;
            this.Close();
        }

        private void btndongy_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }
    }
}
