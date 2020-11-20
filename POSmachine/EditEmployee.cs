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
        public bool isUpdate;
        static nhanvienConfig nv;
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
            nv = new nhanvienConfig();
            name = txtbtennhanvien.Text;
            username = txttaikhoan.Text;
            password = txtmatkhau.Text;
            if (checkValidate())
            {
                int role = 0;
                nv.addValue(id, name, username, password, role);
                if (nv.excuteUpdateQuery())
                {
                    MessageBox.Show("Chỉnh sửa thành công!");
                    isUpdate = true;
                    this.Close();
                }
                else
                {
                    lbThongbao.Text = "Có ai đó đã đặt tên tài khoản này, xin hãy đỗi lại!";
                    isUpdate = false;
                }
            } 
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
        private bool checkValidate()
        {
            string thongbao;
            bool res = true;
            if (name == "" || username == "" || password == "")
            {
                thongbao = "Bạn chưa nhập hết dữ liệu!!";
                res = false;
            }
            else
            {
                res = true;
                thongbao = "";
            }
            lbThongbao.Text = thongbao;
            return res;
        }

        private void btnhuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
