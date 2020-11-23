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
using System.Collections;
using System.Deployment.Internal;

namespace POSmachine
{
    public partial class nhanvien : Form
    {
        int idOrderLocation = -65;//id location Horizable
        int idCateBtnLocation = -46;//id location Horizable
        int gtgiamgia = 0;//
        int totalCost = 0;
        //
        Panel myItemPanel = new Panel() {Name = "pntest2"};
        Panel myOrderPanel = new Panel() { Name = "myOrderPanel" };
        Label myTotalCostLabel = new Label() { Name = "myTotalCostLabel", Font = new Font("Microsoft Sans Serif", 10) };
        Label myDateTimeLabel = new Label() { Name = "myDateTimeLabel", Font = new Font("Microsoft Sans Serif", 10) };
        //object
        static dishes dish = new dishes();
        //connect database
        static string conString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Excercise\WINDOWSPROGRAM\BTcuoiky\GitHub\POSmachine\POSmachine\QLCUAHANG.mdf;Integrated Security=True";
        SqlConnection myconn = new SqlConnection(conString);
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;
        DataSet ds;
        SqlDataReader rd;
        List<int> idItemAndAmountList = new List<int>();
        public nhanvien()
        {
            InitializeComponent();
            createItemPanel();
            createOrderPanel();
            createTotalCostLabel();
            createDateTimeLabel();
            //open connect
            myconn.Open();
        }
        private void showItems(string chude)
        {
            string itemName = "";
            int idLocation = -65,distance=68,price=0,id=0;
            string filterQuery = "Select * from Items,Chude where Chude.Idchude = Items.Idchude and chude.Tenchude = N'" + chude + "'";
            cmd = new SqlCommand(filterQuery, myconn);
            da = new SqlDataAdapter(filterQuery, myconn);
            dt = new DataTable();
            ds = new DataSet();
            da.Fill(ds);
            //refresh items
            this.Controls.Remove(myItemPanel);
            myItemPanel = new Panel() { Name = "pntest2" };
            createItemPanel();
            ////select items
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                id = Int32.Parse(ds.Tables[0].Rows[i][0].ToString());
                itemName = ds.Tables[0].Rows[i][1].ToString();
                price = Int32.Parse(ds.Tables[0].Rows[i][2].ToString());
                //set properties
                Label lbItemName = new Label { Name = "lbItemName-" + id, Text = itemName };
                lbItemName.Location = new Point(5, 25);
                lbItemName.AutoSize = true;
                Label lbItemPrice = new Label { Name = "lbItemPrice-" + id, Text = String.Format("{0:n0}", price) + "đ"};
                lbItemPrice.Location = new Point(180, 25);
                lbItemPrice.TextAlign = ContentAlignment.TopRight;
                Button myBtnItem = new Button() { Name = "myBtnItem-" + id };
                myBtnItem.Size = new System.Drawing.Size(295, 64);
                myBtnItem.Location = new Point(3, idLocation + distance);
                myBtnItem.BackColor = Color.White;
                myBtnItem.Controls.Add(lbItemName); myBtnItem.Controls.Add(lbItemPrice);
                //set event click
                myBtnItem.Click += new EventHandler(eventOdered);
                lbItemName.Click += new EventHandler(eventOdered);
                lbItemPrice.Click += new EventHandler(eventOdered);
                //
                myItemPanel.Controls.Add(myBtnItem);
                idLocation += distance;
            }
        }
        private void showItemOrder(int id,string itemName,int price)
        {
            int distance = 68;
            //
            Label lbOrderCount = new Label { Name = "lbOrderCount-" + id, Text = "1"};
            lbOrderCount.Location = new Point(4, 25);
            lbOrderCount.Size = new System.Drawing.Size(81, 13);
            lbOrderCount.Font = new Font("Microsoft Sans Serif", 9, FontStyle.Bold);
            //
            Label lbOrderName = new Label { Name = "lbOrderName-" + id, Text = itemName };
            lbOrderName.Location = new Point(42, 25);
            lbOrderName.Size = new System.Drawing.Size(82, 27);
            //
            Label lbOrderPrice = new Label { Name = "lbOrderPrice-" + id, Text = price + ""};
            lbOrderPrice.Location = new Point(130, 25);
            lbOrderPrice.Size = new System.Drawing.Size(43, 13);
            lbOrderPrice.TextAlign = ContentAlignment.TopRight;
            //
            Button myOrderBtn = new Button() { Name = "myOrderBtn-" + id };
            myOrderBtn.Size = new System.Drawing.Size(178, 64);
            myOrderBtn.Location = new Point(3, idOrderLocation + distance);
            myOrderBtn.BackColor = Color.White;
            myOrderBtn.Controls.Add(lbOrderName); myOrderBtn.Controls.Add(lbOrderPrice);
            myOrderBtn.Controls.Add(lbOrderCount);
            // fix error
            myOrderPanel.VerticalScroll.Value = 0; myOrderPanel.HorizontalScroll.Value = 0;
            myOrderPanel.Controls.Add(myOrderBtn);
            myOrderPanel.ScrollControlIntoView(myOrderBtn);
            //
            idOrderLocation += distance;
        }
        private void createCategoriesBt(string categoryName)
        {
            int distance = 46;
            Button btnCate = new Button() { Name="btcate"+idCateBtnLocation};
            btnCate.Text = categoryName;
            btnCate.BackColor = SystemColors.ControlLight;
            btnCate.Location = new Point(1, idCateBtnLocation+distance);
            btnCate.Size = new System.Drawing.Size(73, 40);
            btnCate.Click += new EventHandler(eventCategories);
            pnBarCategories.Controls.Add(btnCate);
            idCateBtnLocation += distance;
        }
        private void eventCategories(object sender,EventArgs e)
        {
            Button currentBtn = (Button)sender;
            string chude = currentBtn.Text;
            showItems(chude);
        }
        private void eventOdered(object sender, EventArgs e)
        {
            string strId;
            try
            {
                Button currentButton = (Button)sender;
                strId = currentButton.Name;
            }
            catch
            {
                Label currentLabel = (Label)sender;
                strId = currentLabel.Name;
            }
            strId = strId.Substring(strId.IndexOf("-")+1,strId.Length-strId.IndexOf("-")-1);
            int id = Int32.Parse(strId);
            addInforItem(id);
            tinhtongtien();
        }
        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 login = new Form1();
            login.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void nhanvien_Load(object sender, EventArgs e)
        {
            idCateBtnLocation = -46;
            string[] categories = dish.getCategory();
            for(int i = 0; i < categories.Length; i++)
            {
                createCategoriesBt(categories[i]);
            }
            //
            string chude = categories[0];
            showItems(chude);
            InitializeComponent();
        }

        private void btnclick_Click(object sender, EventArgs e)
        {
            MessageBox.Show(idItemAndAmountList.ToString());
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btndeleteI_Click(object sender, EventArgs e)
        {
            foreach (Control item in myItemPanel.Controls.OfType<Control>())
            {
                    myItemPanel.Controls.Remove(item);
            }
        }
        private void createItemPanel()
        {
            this.Controls.Add(myItemPanel);
            //myItemPanel config
            myItemPanel.AutoScroll = true;
            myItemPanel.Location = new Point(288, 48);
            myItemPanel.Size = new System.Drawing.Size(321, 298);
            myItemPanel.BorderStyle = BorderStyle.FixedSingle;
        }
        private void createOrderPanel()
        {
            this.Controls.Add(myOrderPanel);
            //myOrderPanel config
            myOrderPanel.AutoScroll = true;
            myOrderPanel.Location = new Point(12, 48);
            myOrderPanel.Size = new System.Drawing.Size(185, 298);
            myOrderPanel.BorderStyle = BorderStyle.FixedSingle;
        }
        private void createTotalCostLabel()
        {
            //create total cost price
            this.Controls.Add(myTotalCostLabel);
            myTotalCostLabel.Location = new Point(55, 356);
            myTotalCostLabel.Text = "0";
        }
        private void createDateTimeLabel()
        {
            //create total cost price
            this.Controls.Add(myDateTimeLabel);
            myDateTimeLabel.Location = new Point(537, 16);
            DateTime today = DateTime.Today;
            myDateTimeLabel.Text =today.ToString("d");
            this.Controls.Add(myDateTimeLabel);
        }
        private int tontaiId(int id)
        {
            for(int i = 0; i < idItemAndAmountList.Count; i+=2)
            {
                if (idItemAndAmountList[i] == id)
                {
                    return i;
                }
            }
            return -1;//not found
        }
        private void addInforItem(int id)
        {
            int containId = tontaiId(id);
            if (containId>=0)
            {
                idItemAndAmountList[containId + 1] += 1;
                foreach (Control ctr in myOrderPanel.Controls)
                {
                    if (ctr.Name == "myOrderBtn-"+id)
                    {
                        foreach (Control ctr2 in ctr.Controls)
                        {
                            if (ctr2.Name == "lbOrderCount-"+id)
                            {
                                ctr2.Text = (Int32.Parse(ctr2.Text) + 1)+"";
                            }
                        }
                    }
                }
            }
            else
            {
                idItemAndAmountList.Add(id); idItemAndAmountList.Add(1);
                int price=0;string itemName="";
                string filterQuery = "Select * from Items where Iditem = '" + id + "'";
                cmd = new SqlCommand(filterQuery, myconn);
                da = new SqlDataAdapter(filterQuery, myconn);
                dt = new DataTable();
                ds = new DataSet();
                da.Fill(ds);
                itemName = ds.Tables[0].Rows[0][1].ToString();
                price = Int32.Parse(ds.Tables[0].Rows[0][2].ToString());
                showItemOrder(id,itemName,price);
            }
        }
        private void tinhtongtien()
        {
            totalCost = 0;
            foreach (Control ctr in myOrderPanel.Controls)
            {
                int sl = 0, dg = 0;
                foreach (Control ctr2 in ctr.Controls)
                {
                    if (ctr2.Name.IndexOf("lbOrderCount") >= 0)
                    {
                        sl = Int32.Parse(ctr2.Text);
                    }
                    else if (ctr2.Name.IndexOf("lbOrderPrice") >= 0)
                    {
                        dg = Int32.Parse(ctr2.Text);
                    }
                }
                totalCost += (sl * dg);
            }
            foreach (Control ctr in this.Controls)
            {
                if (ctr.Name == "myTotalCostLabel")
                {
                    totalCost -= ((totalCost * gtgiamgia) / 100);
                    string moneyString = String.Format("{0:n0}", totalCost);
                    ctr.Text = moneyString; 
                    break;
                }
            }
        }
        private void btnlammoi_Click(object sender, EventArgs e)
        {
            this.Controls.Remove(myOrderPanel);
            myOrderPanel = new Panel() { Name = "myOrderPanel" };
            createOrderPanel();
            this.Controls.Add(myOrderPanel);
            idOrderLocation = -65;
            idItemAndAmountList.Clear();
            tinhtongtien();
        }

        private void btngiamgia_Click(object sender, EventArgs e)
        {
            if (gtgiamgia != 0)
            {
                DialogResult dialogResult = MessageBox.Show("Bạn đã thêm mã giãm giá rồi. Bạn muốn thu hồi?", "Thông báo", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    gtgiamgia = 0;
                    tinhtongtien();
                }
                return;
            }
            giamgia giamgia = new giamgia();
            giamgia.ShowDialog();
            gtgiamgia = giamgia.gtgiamgia;
            totalCost -= ((totalCost *gtgiamgia)/100);
            foreach (Control ctr in this.Controls)
            {
                if (ctr.Name == "myTotalCostLabel")
                {
                    string moneyString = String.Format("{0:n0}", totalCost);
                    ctr.Text = moneyString;
                    break;
                }
            }

        }

        private void btninhoadon_Click(object sender, EventArgs e)
        {
            //get id dot hien tai
            string findMaxIdDotQuery = "select max(Iddot) as maxIdDot from Dot";
            cmd = new SqlCommand(findMaxIdDotQuery, myconn);
            da = new SqlDataAdapter(findMaxIdDotQuery, myconn);
            ds = new DataSet();
            da.Fill(ds);
            int idDot = Int32.Parse(ds.Tables[0].Rows[0][0].ToString());
            //them hoa don
            string insertBillQuery = "insert into Hoadon(Iddot,Tongtien) values('"+ idDot +"','"+ totalCost +"');";
            cmd = new SqlCommand(insertBillQuery, myconn);
            cmd.ExecuteNonQuery();
            //lay id hoa don moi
            string findMaxIdHoadonQuery = "select max(Idhoadon) as maxIdHoadon from Hoadon";
            cmd = new SqlCommand(findMaxIdHoadonQuery, myconn);
            da = new SqlDataAdapter(findMaxIdHoadonQuery, myconn);
            ds = new DataSet();
            da.Fill(ds);
            int idHoadon = Int32.Parse(ds.Tables[0].Rows[0][0].ToString());
            //them mon
            string insertItemOrderQuery="";
            for (int i = 0; i < idItemAndAmountList.Count; i += 2)
            {
                int id = idItemAndAmountList[i];
                int sl = idItemAndAmountList[i + 1];
                insertItemOrderQuery += "INSERT INTO Itemorder (Iditem, Idngay, Soluong, Khuyenmai,IdHoadon)" + 
                " VALUES ('"+ id +"', '"+ idDot +"', '"+ sl +"', '"+ gtgiamgia +"','"+ idHoadon +"');";
            }
            cmd = new SqlCommand(insertItemOrderQuery, myconn);
            cmd.ExecuteNonQuery();
            //excute success;
            //refresh
            this.Controls.Remove(myOrderPanel);
            gtgiamgia = 0;
            myOrderPanel = new Panel() { Name = "myOrderPanel" };
            createOrderPanel();
            this.Controls.Add(myOrderPanel);
            idOrderLocation = -65;
            idItemAndAmountList.Clear();
            tinhtongtien();
            //
        }

        private void lbChangeText_Click(object sender, EventArgs e)
        {

        }

        private void btnthoat_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}
