using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POSmachine
{
    public partial class CreateEmployee : Form
    {
        public bool isInsert;
        string name;
        string username;
        string password;
        string rePassword;
        //
        static nhanvienConfig nv;
        public CreateEmployee()
        {
            InitializeComponent();
            nv = new nhanvienConfig();
            isInsert = false;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnhuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btndongy_Click(object sender, EventArgs e)
        {
            if (checkValidate())
            {
                int id = -1, role = 0;
                nv.addValue(id, name, username, password, role);
                if (!nv.excuteInsertQuery())
                {
                    lbThongbao.Text = "Tên tài khoản bị trùng,xin nhập tên khác!";
                    return;
                }
                //excute success
                isInsert = true;
                this.Close();
                MessageBox.Show("Thêm nhân viên thành công!!");
            }
        }
        private bool checkValidate()
        {
            name = txtbtennhanvien.Text;
            username = txttaikhoan.Text;
            password = txtmatkhau.Text;
            rePassword = txtbnhaplaimatkhau.Text;
            string thongbao;
            bool res = true;
            if (name == "" || username == "" || password == "" || rePassword == "")
            {
                thongbao = "Bạn chưa nhập hết dữ liệu!!";
                res = false;
            }else if (password != rePassword)
            {
                thongbao = "Nhập lại mật khẩu không đúng";
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

        private void CreateEmployee_Load(object sender, EventArgs e)
        {

        }
    }
}
