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
        public DataTable getData()
        {
            return nc.getData();
        }
        public int kiemtramatrung(string ma)
        {
            return nc.kiemtramatrung(ma);
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
