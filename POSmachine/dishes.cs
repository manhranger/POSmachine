using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POSmachine
{
    class dishes
    {
        private int id;
        private int idCategory;
        private string dishName;
        private string dishCategory;
        private string dishDetail;
        private int price;
        private bool used = false;
        //connect database
        static string conString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Excercise\WINDOWSPROGRAM\BTcuoiky\GitHub\POSmachine\POSmachine\QLCUAHANG.mdf;Integrated Security=True";
        static SqlConnection myconn = new SqlConnection(conString);
        static SqlCommand cmd;
        static SqlDataAdapter da;
        static DataTable dt;
        static DataSet ds;
        static SqlDataReader rd;
        public dishes()
        {
            try
            {
                myconn.Open();//open connect database
            }
            catch { }
        }
        public int getIdCategory()
        {
            return idCategory;
        }
        public string getDishName()
        {
            return dishName;
        }
        public string getDishCategory()
        {
            return dishCategory;
        }
        public int getPrice()
        {
            return price;
        }
        public string getDishDetail()
        {
            return dishDetail;
        }
        public bool getUsed()
        {
            return used;
        }
        public string[] getCategory()
        {
            string getCategoryQuery = "select Tenchude from Chude;";
            cmd = new SqlCommand(getCategoryQuery, myconn);
            da = new SqlDataAdapter(getCategoryQuery, myconn);
            ds = new DataSet();
            da.Fill(ds);
            string[] res = new string[ds.Tables[0].Rows.Count];
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                res[i] = ds.Tables[0].Rows[i][0].ToString();
            }
            return res;
        }
        public ArrayList showInfor()
        {
            ArrayList res = new ArrayList();
            string getItemQuery = "select * from Chude,Items where " +
            "Chude.Idchude = Items.Idchude and Items.Used = 1;";
            cmd = new SqlCommand(getItemQuery, myconn);
            da = new SqlDataAdapter(getItemQuery, myconn);
            ds = new DataSet();
            da.Fill(ds);
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                res.Add(Int32.Parse(ds.Tables[0].Rows[i][2].ToString()));
                res.Add(ds.Tables[0].Rows[i][3].ToString());
                res.Add(ds.Tables[0].Rows[i][1].ToString());
                res.Add(ds.Tables[0].Rows[i][5].ToString());
                res.Add(Int32.Parse(ds.Tables[0].Rows[i][4].ToString()));
                res.Add(true);
            }
            return res;
        }
        public void setValue(int id,string itemName,int price,string category,string itemDetail)
        {
            this.id = id;
            this.dishName = itemName;
            this.price = price;
            this.dishCategory = category;
            this.dishDetail = itemDetail;
        }
        public bool updateDish()
        {
            idCategory = getIdCategory(dishCategory);
            string insertNvQuery = "update Items set " +
            "Itemname = N'"+ dishName +"',Price = "+ price +",Idchude ='"+ idCategory +"' ,describe = N'"+ dishDetail +"' where Iditem="+ id +";";
            cmd = new SqlCommand(insertNvQuery, myconn);
            try
            {
                cmd.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool insertDish(string itemName, int cost, string itemDetail, string categoryName)
        {
            idCategory = getIdCategory(categoryName);
            string insertNvQuery = "insert into Items(Itemname,Price,describe,Idchude,Used)" +
            "values(N'" + itemName + "'," + cost + ",N'" + itemDetail + "'," + idCategory + ",1);";
            cmd = new SqlCommand(insertNvQuery, myconn);
            try
            {
                cmd.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool delDish(int id)
        {
            string DelNvQuery = "delete from Items where Iditem = "+ id +";";
            cmd = new SqlCommand(DelNvQuery, myconn);
            try
            {
                cmd.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public string[] getCategoriesNameList()
        {
            string getIdCategoryQuery = "select Tenchude from Chude";
            cmd = new SqlCommand(getIdCategoryQuery, myconn);
            da = new SqlDataAdapter(getIdCategoryQuery, myconn);
            ds = new DataSet();
            da.Fill(ds);
            string[] res = new string[ds.Tables[0].Rows.Count];
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                res[i] = ds.Tables[0].Rows[i][0].ToString();
            }
            return res;
            

        }
        private int getIdCategory(string categoryName)
        {
            string getIdCategoryQuery = "select Idchude from Chude where Tenchude = N'" + categoryName + "'";
            cmd = new SqlCommand(getIdCategoryQuery, myconn);
            da = new SqlDataAdapter(getIdCategoryQuery, myconn);
            ds = new DataSet();
            da.Fill(ds);
            int res = Int32.Parse(ds.Tables[0].Rows[0][0].ToString());
            return res;
        }
    }
}
