using System;
using System.Collections.Generic;
using System.Data;
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
    }
}
