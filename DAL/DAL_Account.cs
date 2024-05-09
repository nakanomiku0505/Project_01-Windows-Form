using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class DAL_Account
    {
        DAL_Database acc = new DAL_Database();
        public DataTable getData()
        {
            string sql = "Select * from Accounts";
            return acc.getData(sql);
        }
        public string checkAcc(string users, string passwords)
        {
            string query = $"SELECT * FROM Accounts WHERE users = N'{users}' AND passwords = N'{passwords}'";
            DataTable table = acc.getData(query);
            if (table.Rows.Count < 1)  // kt so hang trong bảng
            {
                return "-1";
            }
            else
            {
                Accounts taiKhoan = new Accounts();
                foreach (DataRow row in table.Rows)
                {
                    taiKhoan.users = row["users"].ToString();

                    taiKhoan.passwords = row["passwords"].ToString();

                    taiKhoan.quyen = Convert.ToInt32(row["quyen"]);


                };


                return taiKhoan.quyen.ToString();

            }
        }
        public bool Them(object obj)
        {
            Accounts TK = (Accounts)obj;
            string sql = string.Format("Insert into Accounts values('{0}','{1}', '1', '{2}')", TK.users, TK.passwords, TK.Email);
            acc.Execute(sql);
            return true;

        }

        public void Sua(object obj)
        {
            Accounts TK = (Accounts)obj;
            string sql = string.Format("UPDATE Accounts SET passwords= '{0}', quyen = '1', Email = '{1}' WHERE users = '{2}'", TK.passwords, TK.Email, TK.users);
            acc.Execute(sql);

        }

        public void Xoa(object obj)
        {
            Accounts TK = (Accounts)obj;
            string queryDelete = string.Format("DELETE FROM Accounts WHERE users = '{0}'", TK.users);
            acc.Execute(queryDelete);
        }

        public void TimKiem(object obj)
        {
            Accounts TK = (Accounts)obj;
            string querySelect = string.Format("SELECT * FROM Accounts WHERE users = '{0}'", TK.users);
            acc.Execute(querySelect);

        }
        public int Check(string ma)
        {
            string sql = "Select count(*) from Accounts where users='" + ma.Trim() + "'";
            return acc.CheckID(ma, sql);
        }
        public void QuenMK(object obj)
        {
            Accounts TK = (Accounts)obj;
            string sql = string.Format("UPDATE Accounts SET passwords= '{0}' WHERE users = '{1}'", TK.passwords, TK.users);
            acc.Execute(sql);
            
        }
        public int XacMinh(object obj)
        {
            Accounts TK = (Accounts)obj;
            string query = string.Format("SELECT COUNT(*) FROM Accounts WHERE users = '{0}' AND Email = '{1}'",TK.users,TK.Email);
            acc.Connect();
            acc.cmd = new SqlCommand(query, acc.con);
            

            int result = (int)acc.cmd.ExecuteScalar();

            acc.Disconnect();

            return result;
        }
        public DataTable layusers()
        {
            string sql = "SELECT A.users,N.MaNV, N.TenNV\r\nFROM NhanVien N\r\nLEFT JOIN Accounts A ON N.users = A.users;";
            return acc.getData(sql);
        }
        public string layusers(string tk)
        {
            string sql = string.Format("select* from Accounts where users ='{0}'", tk);
            DataTable dt = acc.getData(sql);

            if (dt.Rows.Count > 0)
            {
                Accounts ac = new Accounts(dt.Rows[0]);
                return ac.users;
            }

            return "null";
        }
    }
}
