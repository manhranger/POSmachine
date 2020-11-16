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
    public partial class admin : Form
    {
        //values
        private int idPotitionBarRank = -54;//id location
        private int idDot=0;
        private int totalCostDot = 0;
        int[] idItemList;string[] rankItemName;
        //myControl
        ComboBox myIdDotCbb = new ComboBox();
        ComboBox myRankItemsCbb = new ComboBox();
        Label myTotalCostLb = new Label();
        Label myGrowthRateLb = new Label();
        Label myDateTimeLb = new Label() { Name = "myDateTimeLabel", Font = new Font("Microsoft Sans Serif", 10) };
        Label myRankNumberLb;
        Label myRankItemsNameLb;
        Label myRankItemsSellLb;
        Label myRankItemsCostLb;
        Label labeltextThuHang = new Label();
        Label labeltextTenMon = new Label();
        Label labeltextSoLuongBan = new Label();
        Label labeltextDoanhThu = new Label();
        Panel myRankItemsBarPn;

        //connect database
        static string conString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Excercise\WINDOWSPROGRAM\BTcuoiky\GitHub\POSmachine\POSmachine\QLCUAHANG.mdf;Integrated Security=True";
        SqlConnection myconn = new SqlConnection(conString);
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;
        DataSet ds;
        SqlDataReader rd;
        public admin()
        {
            myconn.Open();//open connect database
            InitializeComponent();
            createMyIdDotCbb();
            showDgvdanhsachmon();
            createGroupLabel();
            showTotalCost();
            showGrowthRate();
            createLabelText();
        }
        private void showDgvdanhsachmon()
        {
            string filterQuery = "Select Itemname,Soluong,Price,Khuyenmai,Idhoadon from Itemorder,Items"+
            " where Itemorder.Iditem = Items.Iditem and Idngay = '"+ idDot +"';";
            cmd = new SqlCommand(filterQuery, myconn);
            da = new SqlDataAdapter(filterQuery, myconn);
            dt = new DataTable();
            da.Fill(ds);
            da.Fill(dt);
            dgvdanhsachmon.DataSource = dt;
            dgvdanhsachmon.Columns["Itemname"].HeaderText = "Tên món";
            dgvdanhsachmon.Columns["Soluong"].HeaderText = "Số lượng";
            dgvdanhsachmon.Columns["Price"].HeaderText = "Giá";
            dgvdanhsachmon.Columns["Khuyenmai"].HeaderText = "Khuyến mãi";
            dgvdanhsachmon.Columns["Idhoadon"].HeaderText = "Mã hóa đơn";
            dgvdanhsachmon.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void showTotalCost()
        {
            string getMoneyQuery = "Select Tongtien from Hoadon" +
            " where Iddot = '" + idDot + "';";
            cmd = new SqlCommand(getMoneyQuery, myconn);
            da = new SqlDataAdapter(getMoneyQuery, myconn);
            ds = new DataSet();
            da.Fill(ds);
            totalCostDot = 0;int price = 0;
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                price = Int32.Parse(ds.Tables[0].Rows[i][0].ToString());
                totalCostDot += price;
            }
            String totalCostString = String.Format("{0:n0}", totalCostDot); ;
            myTotalCostLb.Text = totalCostString;
        }
        private void showGrowthRate()
        {
            int previousIdDot = idDot - 1;
            string getMoneyQuery = "Select Tongtien from Hoadon" +
            " where Iddot = '" + previousIdDot + "';";
            cmd = new SqlCommand(getMoneyQuery, myconn);
            da = new SqlDataAdapter(getMoneyQuery, myconn);
            ds = new DataSet();
            da.Fill(ds);
            if (ds.Tables[0].Rows.Count == 0)
            {
                myGrowthRateLb.Text = "Chưa xác định.";
                return;
            }
            int PreviousTotalCost = 0, price = 0;
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                price = Int32.Parse(ds.Tables[0].Rows[i][0].ToString());
                PreviousTotalCost += price;
            }
            int growthRate =((totalCostDot * 100) / PreviousTotalCost) - 100;
            myGrowthRateLb.Text = growthRate+"%";
        }
        private void createMyIdDotCbb()
        {
            myIdDotCbb = new ComboBox() { Name = "myIdDotCbb" };
            myIdDotCbb.Location = new Point(580, 6);
            myIdDotCbb.Size = new System.Drawing.Size(65, 21);
            //add data
            myIdDotCbb.DisplayMember = "Text";
            myIdDotCbb.ValueMember = "Value";
            string idDotString="";
            string getDotQuery = "select Iddot from Dot order by Iddot desc;";
            cmd = new SqlCommand(getDotQuery, myconn);
            da = new SqlDataAdapter(getDotQuery, myconn);
            dt = new DataTable();
            ds = new DataSet();
            da.Fill(ds);
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                if (i == 0)
                {
                    idDotString = ds.Tables[0].Rows[i][0].ToString();
                    idDot = Int32.Parse(ds.Tables[0].Rows[i][0].ToString());
                }
                else
                {
                    idDotString = ds.Tables[0].Rows[i][0].ToString();
                }
                int idcbb = i + 1;
                myIdDotCbb.Items.Add(new { Value = idcbb, Text = idDotString });
            }
            myIdDotCbb.SelectedIndex = 0;
            cbbrankitems.SelectedIndex = 0;//thuoc ve tab xep hang
            tabpdanhsachmonorder.Controls.Add(myIdDotCbb);
            // SelectedIndexChanged event.
            this.myIdDotCbb.SelectedIndexChanged +=
                new System.EventHandler(myIdDotCbb_SelectedIndexChanged);
        }
        private void createGroupLabel()
        {
            //create myTotalCostLb
            myTotalCostLb = new Label() { Name = "myTotalCostLb", Font = new Font(Label.DefaultFont, FontStyle.Bold) };
            myTotalCostLb.Location = new Point(576, 61);
            myTotalCostLb.Size = new System.Drawing.Size(69, 21);
            myTotalCostLb.TextAlign = ContentAlignment.TopRight;
            tabpdanhsachmonorder.Controls.Add(myTotalCostLb);
            //create myGrowthRateLb
            myGrowthRateLb = new Label() { Name = "myGrowthRateLb", Font = new Font(Label.DefaultFont, FontStyle.Bold) };
            myGrowthRateLb.TextAlign = ContentAlignment.TopRight;
            myGrowthRateLb.Location = new Point(577, 86);
            myGrowthRateLb.Size = new System.Drawing.Size(69, 42);
            tabpdanhsachmonorder.Controls.Add(myGrowthRateLb);
            myGrowthRateLb.Text = "0";
            myTotalCostLb.Text = "0";
        }
        private void createLabelText()
        {
            //create labelText
            labeltextThuHang = new Label() { Name = "labeltextThuHang" };
            labeltextThuHang.Location = new Point(3, 8);
            labeltextThuHang.Size = new System.Drawing.Size(53, 13);
            labeltextThuHang.Text = "Thứ hạng";
            pnGroupRankItem.Controls.Add(labeltextThuHang);
            labeltextTenMon = new Label() { Name = "labeltextTenMon" };
            labeltextTenMon.Location = new Point(66, 8);
            labeltextTenMon.Text = "Tên Món";
            pnGroupRankItem.Controls.Add(labeltextTenMon);
            labeltextSoLuongBan = new Label() { Name = "labeltextSoLuongBan" };
            labeltextSoLuongBan.Location = new Point(187, 8);
            labeltextSoLuongBan.Text = "Số lượng bán";
            pnGroupRankItem.Controls.Add(labeltextSoLuongBan);
            labeltextDoanhThu = new Label() { Name = "labeltextDoanhThu" };
            labeltextDoanhThu.Location = new Point(317, 8);
            labeltextDoanhThu.Text = "Doanh thu";
            pnGroupRankItem.Controls.Add(labeltextDoanhThu);
        }
        private void createGroupRankLabelAndPanel(int id,int soluong,int danhthu, string itemName)
        {
            //create myRankItemsBarPn
            int distance = 78;
            myRankItemsBarPn = new Panel() { Name = "myRankItemsBarPn-" + id};
            myRankItemsBarPn.Location = new Point(3, idPotitionBarRank + distance);
            myRankItemsBarPn.Size = new System.Drawing.Size(393, 72);
            pnGroupRankItem.Controls.Add(myRankItemsBarPn);
            idPotitionBarRank += distance;
            //create myRankNumberLb
            myRankNumberLb = new Label() { Name = "myRankNumberLb", Font = new Font(Label.DefaultFont, FontStyle.Bold) };
            myRankNumberLb.Location = new Point(3, 34);
            myRankNumberLb.Text = id+"";
            myRankNumberLb.Size = new System.Drawing.Size(54, 29);
            myRankItemsBarPn.Controls.Add(myRankNumberLb);
            //create myRankItemsNameLb
            myRankItemsNameLb = new Label() { Name = "myRankItemsNameLb"};
            myRankItemsNameLb.Location = new Point(66, 34);
            myRankItemsNameLb.Text = itemName;
            myRankItemsNameLb.Size = new System.Drawing.Size(120, 29);
            myRankItemsBarPn.Controls.Add(myRankItemsNameLb);
            //create myRankItemsCostLb
            myRankItemsCostLb = new Label() { Name = "myRankItemsCostLb"};
            myRankItemsCostLb.Location = new Point(187, 34);
            myRankItemsCostLb.Text = soluong+"";
            myRankItemsCostLb.Size = new System.Drawing.Size(70, 29);
            myRankItemsBarPn.Controls.Add(myRankItemsCostLb);
            //create myRankItemsSellLb
            myRankItemsSellLb = new Label() { Name = "myRankItemsSellLb", Font = new Font(Label.DefaultFont, FontStyle.Bold) };
            myRankItemsSellLb.TextAlign = ContentAlignment.TopRight;
            myRankItemsSellLb.Location = new Point(263, 34);
            myRankItemsSellLb.Text = String.Format("{0:n0}", danhthu);
            myRankItemsSellLb.Size = new System.Drawing.Size(111, 29);
            myRankItemsBarPn.Controls.Add(myRankItemsSellLb);

        }
        private void myIdDotCbb_SelectedIndexChanged(object sender,EventArgs e)
        {
            ComboBox mycbb = (ComboBox)sender;
            idDot = Int32.Parse(mycbb.GetItemText(mycbb.SelectedItem));
            showDgvdanhsachmon();
            showTotalCost();
            showGrowthRate();
        }
        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 login = new Form1();
            login.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tabpdanhsachmon_Click(object sender, EventArgs e)
        {

        }

        private void btnclickme_Click(object sender, EventArgs e)
        {

        }

        private void btnenddot_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn muốn kết thúc đợt làm việc này, bắt đầu đợt làm việc mới?", "Thông báo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                string insertBillQuery = "insert into Dot(TongTien) values(0);";
                cmd = new SqlCommand(insertBillQuery, myconn);
                cmd.ExecuteNonQuery();
                //refresh
                tabpdanhsachmonorder.Controls.Remove(myIdDotCbb);
                tabpdanhsachmonorder.Controls.Remove(myTotalCostLb);
                tabpdanhsachmonorder.Controls.Remove(myGrowthRateLb);
                createGroupLabel();
                createMyIdDotCbb();
                showDgvdanhsachmon();
            }
        }
        private void showRankItemBarPn(int index)
        {
            string getIdItemQuery = "select Iditem,Itemname from Items;";
            cmd = new SqlCommand(getIdItemQuery, myconn);
            da = new SqlDataAdapter(getIdItemQuery, myconn);
            ds = new DataSet();
            da.Fill(ds);
            idItemList = new int[ds.Tables[0].Rows.Count * 3];
            rankItemName = new string[ds.Tables[0].Rows.Count];
            int idItem = 0;
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                idItem = Int32.Parse(ds.Tables[0].Rows[i][0].ToString());
                rankItemName[i] = ds.Tables[0].Rows[i][1].ToString();
                idItemList[i * 3] = idItem;
            }
            //
            string getTotalSellQuery = "select * from Itemorder,Items where Itemorder.Iditem = Items.Iditem order by Items.Iditem; ";
            cmd = new SqlCommand(getTotalSellQuery, myconn);
            da = new SqlDataAdapter(getTotalSellQuery, myconn);
            ds = new DataSet();
            da.Fill(ds);
            int sl = 0, cost = 0, gtgiamgia = 0;
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                idItem = Int32.Parse(ds.Tables[0].Rows[i][1].ToString());
                sl = Int32.Parse(ds.Tables[0].Rows[i][4].ToString());
                cost = Int32.Parse(ds.Tables[0].Rows[i][8].ToString());
                gtgiamgia = Int32.Parse(ds.Tables[0].Rows[i][2].ToString());
                int pos = findValue(idItem);
                if (pos >= 0)
                {
                    idItemList[pos + 1] += sl;
                    idItemList[pos + 2] += (sl * cost) - (((sl * cost) * gtgiamgia) / 100);
                }
            }
            if(index == 0)
            {
                sortForMoney();
            }
            else
            {
                sortForAmount();
            }
            //refesh bar panel
            pnGroupRankItem.Controls.Clear();
            createLabelText();
            idPotitionBarRank = -54;
            //create again
            for (int i = 0; i < idItemList.Length; i += 3)
            {
                createGroupRankLabelAndPanel(i / 3 + 1, idItemList[i + 1], idItemList[i + 2], rankItemName[i / 3]);
            }
        }
        private int findValue(int id)
        {
            for(int i = 0; i < idItemList.Length; i+=3)
            {
                if (idItemList[i] == id)
                {
                    return i;
                }
            }
            return -1;
        }
        private void sortForMoney()
        {
            for(int i = 2; i < idItemList.Length; i+=3)
            {
                for(int j = i + 3; j < idItemList.Length; j+=3)
                {
                    if (idItemList[j] > idItemList[i])
                    {
                        swap(j-2, i-2);swap(j-1, i-1);swap(j, i);
                        swapString(j/3,i/3);
                    }
                }
            }
        }
        private void sortForAmount()
        {
            for (int i = 1; i < idItemList.Length; i += 3)
            {
                for (int j = i + 3; j < idItemList.Length; j += 3)
                {
                    if (idItemList[j] > idItemList[i])
                    {
                        swap(j - 1, i - 1); swap(j, i); swap(j + 1, i + 1);
                        swapString(j / 3, i / 3);
                    }
                }
            }
        }
        private void swap(int a,int b)
        {
            int temp = idItemList[a];
            idItemList[a] = idItemList[b];
            idItemList[b] = temp;
        }
        private void swapString(int a, int b)
        {
            string temp = rankItemName[a];
            rankItemName[a] = rankItemName[b];
            rankItemName[b] = temp;
        }

        private void cbbrankitems_SelectedIndexChanged(object sender, EventArgs e)
        {
            showRankItemBarPn(cbbrankitems.SelectedIndex);
        }
    }
}
