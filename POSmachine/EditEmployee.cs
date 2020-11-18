using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POSmachine
{
    public partial class EditEmployee : Form
    {
        int id;
        string name;
        string username;
        string password;
        public EditEmployee(int id,string name,string username,string password)
        {
            this.id = id;
            this.name = name;
            this.username = username;
            this.password = password;
            InitializeComponent();
        }

        private void btndongy_Click(object sender, EventArgs e)
        {
            MessageBox.Show(password + "-");
        }

        private void lbThongbao_Click(object sender, EventArgs e)
        {

        }

        private void EditEmployee_Load(object sender, EventArgs e)
        {
            name = name.Trim();
            username = username.Trim();
            password = password.Trim();
            txtbtennhanvien.Text = name;
            txttaikhoan.Text = username;
            txtmatkhau.Text = password;
        }

        private void btnhuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
