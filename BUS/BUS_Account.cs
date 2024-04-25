using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
namespace BUS
{
    public class BUS_Account
    {
        DAL_Account account = new DAL_Account();
        public DataTable getData()
        {
            return account.getData();
        }
        public string checkAcc(string users, string passwords)
        {
            if (string.IsNullOrEmpty(users) || string.IsNullOrEmpty(passwords))
            {
                throw new Exception("Tên đăng nhập và mật khẩu không được để trống.");
            }
            else
            {
                string quyen = account.checkAcc(users, passwords);

                if (quyen == "-1")
                {
                    throw new Exception("Đăng nhập thất bại!: Sai tên tài khoản hoặc mật khẩu .");
                }
                else if (quyen == "0")
                {
                    return "Login Success! (Role: Admin)";
                }
                else
                {
                    return "Welcome.";

                }
            }
        }
    }
}
