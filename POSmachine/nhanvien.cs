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

namespace POSmachine
{
    public partial class nhanvien : Form
    {
        public int valPosVertical = -11;
        Panel mypanel = new Panel() {Name = "pntest2"};
        public nhanvien()
        {
            InitializeComponent();
            this.Controls.Add(mypanel);
            mypanel.AutoScroll = true;
            mypanel.Location = new Point(288, 46);
            mypanel.Size = new System.Drawing.Size(321, 301);
            mypanel.BorderStyle = BorderStyle.FixedSingle;
        }
        private void AddGroupBoxAndLables()
        {
            int distance = 23;
            Label lblCompleted = new Label { Name = "lbtest"+valPosVertical, Text = "Completed"+valPosVertical };
            lblCompleted.Location = new Point(3, valPosVertical+distance);
            mypanel.Controls.Add(lblCompleted);
            valPosVertical += distance;
        }
        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 login = new Form1();
            login.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void nhanvien_Load(object sender, EventArgs e)
        {
            InitializeComponent();
        }

        private void btnclick_Click(object sender, EventArgs e)
        {
            //addNewTextBox();
            AddGroupBoxAndLables();
        }
    }
}
