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
    public partial class createItems : Form
    {
        int id;
        int price;
        string ItemName;
        string itemDetail;
        string category;
        bool used;
        static dishes dish;
        public bool isUpdate = false;
        public createItems()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnhuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btndongy_Click(object sender, EventArgs e)
        {
            if (!checkValidate())
            {
                return;
            }
            if (dish.insertDish(ItemName, price, itemDetail, category))
            {
                MessageBox.Show("Thêm thành công!!");
                isUpdate = true;
                this.Close();
            }
            else
            {
                isUpdate = false;
                lbThongbao.Text = "Có lỗi!!";
            }
        }
        private bool checkValidate()
        {
            ItemName = txtbItemname.Text;
            category = cbbCategory.Text;
            itemDetail = txtbmota.Text;
            try { price = Int32.Parse(txtbCost.Text); }
            catch
            {
                lbThongbao.Text = "nhập giá bán không đúng định dạng";
                return false;
            }
            if (ItemName == "" || category == "")
            {
                lbThongbao.Text = "Bạn chưa nhập hết dữ liệu!!";
                return false;
            }
            else
            {
                return true;
            }
        }

        private void createItems_Load(object sender, EventArgs e)
        {
            configCbbChude();
        }
        private void configCbbChude()
        {
            dish = new dishes();
            string[] categoryNameList = dish.getCategoriesNameList();
            cbbCategory.Items.AddRange(categoryNameList);
            cbbCategory.SelectedIndex = 0;
            lbThongbao.Text = "";
        }
        private void txtbCost_TextChanged(object sender, EventArgs e)
        {
            txtbCost.Text = String.Format("{0:n0}", txtbCost.Text);
        }
    }
}
