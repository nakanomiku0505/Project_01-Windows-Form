using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_Database
    {
        string strcon = @"Data Source=LAPTOP-A34FEDCG;Initial Catalog=QLCHMT;Integrated Security=True;Encrypt=False";

        public SqlConnection con;
        public SqlCommand cmd;
        public SqlDataReader dr;
        SqlDataAdapter da;
        DataTable dt;
        public SqlParameter[] pi;
        public void Connect()
        {
            con = new SqlConnection(strcon);
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
        }
        public void Disconnect()
        {
            con = new SqlConnection(strcon);
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }

        }
        public void Execute(string sql)
        {
            Connect();
            cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            Disconnect();
        }
        public DataTable getData(string sql)
        {
            Connect();
            da = new SqlDataAdapter(sql, con);
            dt = new DataTable();
            da.Fill(dt);
            Disconnect();
            return dt;
        }
        public int CheckID(string ma, string sql)
        {
            Connect();
            int i;
            cmd = new SqlCommand(sql, con);
            i = (int)cmd.ExecuteScalar();
            Disconnect();
            return i;
        }
    }
}
