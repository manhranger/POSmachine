using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POSmachine
{
    public partial class Form1 : Form
    {
        static string conString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Excercise\WINDOWSPROGRAM\BTcuoiky\POSmachine\POSmachine\QLCUAHANG.mdf;Integrated Security=True";
        SqlConnection myconn = new SqlConnection(conString);
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;

        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string taikhoan = tbtaikhoan.Text;
            string matkhau = tbmatkhau.Text;
            string checkConQuery = "select * from account where username = '" + taikhoan + "' and password ='" + matkhau + "'";
            cmd = new SqlCommand(checkConQuery, myconn);
            da = new SqlDataAdapter(checkConQuery,myconn);
            dt = new DataTable();
            da.Fill(dt);
            if(dt.Rows.Count == 0){
                lbthongbao.Text = "Sai tài khoản hoặc mật khẩu!!!";
                lbthongbao.Visible = true;
            }
            else{
                lbthongbao.Visible = false;
                this.Hide();
                nhanvien nv = new nhanvien();
                nv.Show();
            }
            
        }

        private void Form1_Load(object sender, EventArgs e) {

        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
