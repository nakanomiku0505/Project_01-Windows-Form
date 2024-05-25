using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
namespace BUS
{
    public class BUS_LoaiSP
    {
        DAL_LoaiSP lsp = new DAL_LoaiSP();
        public DataTable getData()
        {
            return lsp.getData();
        }
        public int kiemtramatrung(string ma)
        {
            return lsp.kiemtramatrung(ma);
        }
        public int kiemtratentrung(string ma)
        {
            return lsp.kiemtratentrung(ma);
        }
        public string ThemLSP(LoaiSP nvien)
        {
            if (string.IsNullOrEmpty(nvien.TenLoaiSP) || string.IsNullOrEmpty(nvien.MoTa) || string.IsNullOrEmpty(nvien.MaNCC))
            {
                return "-1";
            }
            
            else if (kiemtramatrung(nvien.MaLoaiSP) > 0)
            {
                return "-2";
            }
            else if (kiemtratentrung(nvien.TenLoaiSP) > 0)
            {
                return "-3";
            }
            
            else if (lsp.ThemLSP(nvien))
            {
                return "1";
            }

            return "0";

        }
        public string XoaLSP(string ma)
        {

            if (lsp.XoaLSP(ma))
            {
                return "-1";
            }
            else
            {
                return "0";
            }
        }

        public string SuaLSP(LoaiSP nvien)
        {
            if (string.IsNullOrEmpty(nvien.TenLoaiSP) || string.IsNullOrEmpty(nvien.MoTa) || string.IsNullOrEmpty(nvien.MaNCC))
            {
                return "-1";
            }
            else if (lsp.SuaLSP(nvien))
            {
                return "1";
            }
            else
            {
                return "0";
            }
        }
        public DataTable TimKiemLSP(string keyword)
        {
            return lsp.TimKiemLoaiSP(keyword);
        }
        public DataTable getNCC()
        {
            return lsp.getNCC();
        }
    }
}
