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
    public class BUS_NhaCungCap
    {
        DAL_NhaCungCap nc = new DAL_NhaCungCap();
        public static bool IsValidEmail(string email)
        {
                // Sử dụng biểu thức chính quy để kiểm tra định dạng email
                var regex = new System.Text.RegularExpressions.Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
                return regex.IsMatch(email);
        }
        public DataTable getData()
        {
            return nc.getData();
        }
        public int kiemtramatrung(string ma)
        {
            return nc.kiemtramatrung(ma);
        }
        public int kiemtratentrung(string ma)
        {
            return nc.kiemtratentrung(ma);
        }
        public string ThemNCC(NhaCungCap nvien)
        {
            if (string.IsNullOrEmpty(nvien.TenNCC) || string.IsNullOrEmpty(nvien.DiaChi) || string.IsNullOrEmpty(nvien.SDT) || string.IsNullOrEmpty(nvien.Email))
            {
                return "-1";
            }
            else if (kiemtramatrung(nvien.MaNCC) > 0)
            {
                return "-2";
            }
            else if (kiemtratentrung(nvien.TenNCC) > 0)
            {
                return "-3";
            }
            else if (nvien.SDT.Length != 10)
            {
                return "-4";
            }
            else if (!IsValidEmail(nvien.Email))
            {
                return "-5";
            }
            else if (nc.ThemNCC(nvien))
            {
                return "1";
            }

            return "0";

        }
        public string XoaNCC(string ma)
        {

            if (nc.XoaNCC(ma))
            {
                return "-1";
            }
            else
            {
                return "0";
            }
        }

        public string SuaNCC(NhaCungCap nvien)
        {
            if (string.IsNullOrEmpty(nvien.TenNCC) || string.IsNullOrEmpty(nvien.DiaChi) || string.IsNullOrEmpty(nvien.SDT) || string.IsNullOrEmpty(nvien.Email))
            {
                return "-1";
            }
            else if (nc.SuaNCC(nvien))
            {
                return "1";
            }
            else if (kiemtratentrung(nvien.TenNCC) > 0)
            {
                return "-3";
            }
            else if (nvien.SDT.Length != 10)
            {
                return "-4";
            }
            else if (!IsValidEmail(nvien.Email))
            {
                return "-5";
            }
            else
            {
                return "0";
            }
        }
        public DataTable TimKiemNCC(string keyword)
        {
            return nc.TimKiemNCC(keyword);
        }
    }
}
