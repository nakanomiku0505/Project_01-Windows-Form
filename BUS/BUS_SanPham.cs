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
    public class BUS_SanPham
    {
        DAL_SanPham sp = new DAL_SanPham();
        public DataTable getData()
        {
            return sp.getData();
        }
        public int kiemtramatrung(string ma)
        {
            return sp.kiemtramatrung(ma);
        }
        public string ThemSP(SP nvien)
        {
            if (string.IsNullOrEmpty(nvien.TenSP) || string.IsNullOrEmpty(nvien.Gia.ToString()) || string.IsNullOrEmpty(nvien.Mota) || string.IsNullOrEmpty(nvien.SL.ToString()) || string.IsNullOrEmpty(nvien.MaLoaiSP))
            {
                return "-1";
            }
            else if (kiemtramatrung(nvien.MaSP) > 0)
            {
                return "-2";
            }
            else if (sp.ThemSP(nvien))
            {
                return "1";
            }

            return "0";

        }
        public string XoaSP(string ma)
        {

            if (sp.XoaSP(ma))
            {
                return "-1";
            }
            else
            {
                return "0";
            }
        }

        public string SuaSP(SP nvien)
        {
            if (string.IsNullOrEmpty(nvien.TenSP) || string.IsNullOrEmpty(nvien.Gia.ToString()) || string.IsNullOrEmpty(nvien.Mota) || string.IsNullOrEmpty(nvien.SL.ToString()) || string.IsNullOrEmpty(nvien.MaLoaiSP))
            {
                return "-1";
            }
            else if (sp.SuaSP(nvien))
            {
                return "1";
            }
            else
            {
                return "0";
            }
        }
        public DataTable TimKiemSP(string keyword)
        {
            return sp.TimKiemSP(keyword);
        }
        public DataTable getLSP()
        {
            return sp.getLSP();
        }
    }
}
