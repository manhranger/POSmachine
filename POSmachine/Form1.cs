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
        static string conString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Excercise\WINDOWSPROGRAM\BTcuoiky\GitHub\POSmachine\POSmachine\QLCUAHANG.mdf;Integrated Security=True";
        SqlConnection myconn = new SqlConnection(conString);
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;
        SqlDataReader rd;

        public Form1()
        {
            InitializeComponent();
            myconn.Open();
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
            int checklogin = checkLogin();
            if(checklogin<0){
                lbthongbao.Text = "Sai tài khoản hoặc mật khẩu!!!";
                lbthongbao.Visible = true;
            }
            else{
                lbthongbao.Visible = false;
                this.Hide();
                if (checklogin == 0)
                {
                    nhanvien nv = new nhanvien();
                    nv.Show();
                }
                else
                {
                    admin adm = new admin();
                    adm.Show();
                }
            }
            
        }
        private void Form1_Load(object sender, EventArgs e) {

        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
        private int checkLogin()
        {
            string taikhoan = tbtaikhoan.Text;
            string matkhau = tbmatkhau.Text;
            string checkConQuery = "select * from Account where Username = '" + taikhoan + "' and Password ='" + matkhau + "'";
            cmd = new SqlCommand(checkConQuery, myconn);
            da = new SqlDataAdapter(checkConQuery, myconn);
            dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count == 0)
            {
                return -1;
            }
            else
            {
                using (rd = cmd.ExecuteReader())
                {
                    if (rd.Read())
                    {
                        return Int32.Parse(String.Format("{0}", rd["role"]));
                    }
                }
                return -2;
            }
        }
    }
}
