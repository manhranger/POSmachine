using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POSmachine
{
    class nhanvienConfig
    {
        private int id;
        private string name;
        private string username;
        private string password;
        private int role;
        //connect database
        static string conString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Excercise\WINDOWSPROGRAM\BTcuoiky\GitHub\POSmachine\POSmachine\QLCUAHANG.mdf;Integrated Security=True";
        static SqlConnection myconn = new SqlConnection(conString);
        static SqlCommand cmd;
        static SqlDataAdapter da;
        static DataTable dt;
        static DataSet ds;
        static SqlDataReader rd;
        public nhanvienConfig()
        {
            try{
                myconn.Open();//open connect database
            }catch { }
        }
        public int getId()
        {
            return id;
        }
        public string getName()
        {
            return name;
        }
        public string getUsername()
        {
            return username;
        }
        public string getPassword()
        {
            return password;
        }
        public void addValue(int id, string name,string username,string password,int role)
        {
            this.id = id;
            this.name = name;
            this.username = username;
            this.password = password;
            this.role = role;
        }
        public void getInforWithId(int id)
        {
            string getTotalSellQuery = "select * from Account where Id = "+ id +";";
            cmd = new SqlCommand(getTotalSellQuery, myconn);
            da = new SqlDataAdapter(getTotalSellQuery, myconn);
            ds = new DataSet();
            da.Fill(ds);
            this.id = id;
            this.name = ds.Tables[0].Rows[0][1].ToString();
            this.username = ds.Tables[0].Rows[0][2].ToString();
            this.password = ds.Tables[0].Rows[0][3].ToString();
            this.role = Int32.Parse(ds.Tables[0].Rows[0][4].ToString());
        }
        public bool excuteInsertQuery()
        {
            string insertNvQuery = "insert into Account(Name,Username,Password,Role) Values('" + name + "','" + username + "','" + password + "','" + role + "')"; ;
            cmd = new SqlCommand(insertNvQuery, myconn);
            try{
                cmd.ExecuteNonQuery();
                return true;
            }catch{
                return false;
            }
        }
        public bool excuteUpdateQuery()
        {
            string UpdateNvQuery = "update Account set Name = '"+ name +"',Username = '"+ username +"',Password = '"+ password +"' where Id = "+ id +" ";
            cmd = new SqlCommand(UpdateNvQuery, myconn);
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
        public bool excuteDelQuery()
        {
            string UpdateNvQuery = "delete from Account where Id = " + id + "";
            cmd = new SqlCommand(UpdateNvQuery, myconn);
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
        public string deleteQuery(int id)
        {
            string res = "delete from Account where id = "+ id +"";
            return res;
        }
    }
}
