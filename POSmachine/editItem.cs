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
    public partial class editItem : Form
    {
        int id;
        string itemName;
        string category;
        string itemDetail;
        int price;
        public bool isEdit = false;
        dishes dish;
        public editItem(int id,string itemName,string category,int price,string itemDetail)
        {
            dish = new dishes();
            this.id = id;
            this.itemName = itemName;
            this.category = category;
            this.price = price;
            this.itemDetail = itemDetail;
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btndongy_Click(object sender, EventArgs e)
        {
            if (checkValidate())
            {
                dish.setValue(id,itemName,price,category,itemDetail);
                if (dish.updateDish())
                {
                    MessageBox.Show("Chỉnh sửa thành công!");
                    isEdit = true;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Có lỗi!!");
                }
            }
        }
        private bool checkValidate()
        {
            itemName = txtbEditItemname.Text;
            category = cbbEditCategory.Text;
            itemDetail = txtbEditMoTa.Text;
            try { price = Int32.Parse(txtbEditCost.Text); }
            catch
            {
                lbThongbao.Text = "Nhập giá bán không đúng định dạng";
                return false;
            }
            if (itemName == "" || category == "")
            {
                lbThongbao.Text = "Bạn chưa nhập hết dữ liệu!!";
                return false;
            }
            else
            {
                return true;
            }
        }

        private void editItem_Load(object sender, EventArgs e)
        {
            txtbEditItemname.Text = itemName;
            txtbEditMoTa.Text = itemDetail;
            txtbEditCost.Text = price+"";
            string[] categoryList = dish.getCategoriesNameList();
            cbbEditCategory.Items.AddRange(categoryList);
            for (int i = 0; i < categoryList.Length; i++)
            {
                if(categoryList[i] == category)
                {
                    cbbEditCategory.SelectedIndex = i;
                    break;
                }
            }
        }

        private void btnhuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
