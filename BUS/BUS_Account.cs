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
        string quyen;
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
                quyen = account.checkAcc(users, passwords);

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
        public bool Them(string TenDangNhap, string MatKhau, string Email)
        {
            if (string.IsNullOrEmpty(TenDangNhap) || string.IsNullOrEmpty(MatKhau) || string.IsNullOrEmpty(Email))
            {
                throw new Exception("Các trường thông tin không được để trống.");
            }
            // Kiểm tra logic kinh doanh nếu cần thiết
            int checkid = account.Check(TenDangNhap);
            if (checkid == 1)
            {
                throw new Exception("Tài khoản đã tồn tại!");

            }
            if (MatKhau.Length < 6)
            {
                throw new Exception("Mật khẩu không đủ mạnh.");
            }

            // Tạo một đối tượng TaiKhoan từ các tham số đầu vào
            Accounts taiKhoan = new Accounts();
            taiKhoan.users = TenDangNhap;
            taiKhoan.passwords = MatKhau;
            taiKhoan.Email = Email;
            taiKhoan.quyen = 1;

            // Gọi phương thức Them từ lớp DAL để thêm tài khoản vào cơ sở dữ liệu
            DAL_Account dbacc = new DAL_Account();
            return dbacc.Them(taiKhoan);
        }
        public int kiemtramatrung(string ma)
        {
            return account.Check(ma);
        }
        public string QuenMK(string us,string pass, string repass)
        {
            if(string.IsNullOrEmpty(pass) || string.IsNullOrEmpty(repass))
            {
                throw new Exception( "Các trường thông tin không được để trống.");
            }
            
            if (pass != repass)
            {
                throw new Exception ( "Nhập lại mật khẩu không khớp.");
            }
            if (pass.Length < 6 && repass.Length < 6)
            {
                throw new Exception("Mật khẩu không đủ mạnh.");
            }
            Accounts acc = new Accounts();
            acc.users = us;
            acc.passwords = pass;

            account.QuenMK(acc);
            return "Đổi mật khẩu thành công.";
        }
        public string CheckExist(string us, string em)
        {
            Accounts acc = new Accounts();
            acc.users = us;
            acc.Email = em;
            if (string.IsNullOrEmpty(us) || string.IsNullOrEmpty(em))
            {
                throw new Exception( "Các trường thông tin không được để trống.");
            }
            if (account.XacMinh(acc) < 1)
            {
                throw new Exception ("Tài khoản không tồn tại hoặc email không đúng.");
            }
            else
            {
                return "1";
            }
        }
        
    }
}
