using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
namespace BUS
{
    public class BUS_KhachHang
    {
        DAL_KhachHang kh = new DAL_KhachHang();
        public static bool IsValidEmail(string email)
        {
            // Sử dụng biểu thức chính quy để kiểm tra định dạng email
            var regex = new System.Text.RegularExpressions.Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            return regex.IsMatch(email);
        }
        public DataTable getData()
        {
            return kh.getData();
        }
        public int kiemtramatrung(string ma)
        {
            return kh.kiemtramatrung(ma);
        }
        public string ThemKH(KhachHang nvien)
        {
            if (string.IsNullOrEmpty(nvien.TenKH) || string.IsNullOrEmpty(nvien.DiaChi) || string.IsNullOrEmpty(nvien.SDT) || string.IsNullOrEmpty(nvien.Email))
            {
                return "-1";
            }
            else if (kiemtramatrung(nvien.MaKH) > 0)
            {
                return "-2";
            }
            else if (nvien.SDT.Length != 10)
            {
                return "-4";
            }
            else if (!IsValidEmail(nvien.Email))
            {
                return "-5";
            }
            else if (kh.ThemKH(nvien))
            {
                return "1";
            }

            return "0";

        }
        public string XoaKH(string ma)
        {

            if (kh.XoaKH(ma))
            {
                return "-1";
            }
            else
            {
                return "0";
            }
        }

        public string SuaKH(KhachHang nvien)
        {
            if (string.IsNullOrEmpty(nvien.TenKH) || string.IsNullOrEmpty(nvien.DiaChi) || string.IsNullOrEmpty(nvien.SDT) || string.IsNullOrEmpty(nvien.Email))
            {
                return "-1";
            }
            else if (nvien.SDT.Length != 10)
            {
                return "-4";
            }
            else if (!IsValidEmail(nvien.Email))
            {
                return "-5";
            }
            else if (kh.SuaKH(nvien))
            {
                return "1";
            }
            else
            {
                return "0";
            }
        }
        public DataTable TimKiemKH(string keyword)
        {
            return kh.TimKiemKH(keyword);
        }
    }
}
