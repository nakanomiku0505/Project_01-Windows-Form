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
    public class BUS_Buy
    {
        DAL_Buy b = new DAL_Buy();
        
        public List<KhachHang> laydskh(string MaKH)
        {
            return b.laydskh(MaKH);
        }
        public DataTable getDataLSP()
        {
            return b.getDataLSP();
        }
        public DataTable getDataSP(string lsp)
        {
            return b.getDataSP(lsp);
        }
        public DataTable getDataNV()
        {
            
            return b.getDataNV();

        }
        public string ThemHD(HoaDonBan hd)
        {
            if (b.ThemHD(hd))
            {
                return "1";
            }
            return "0";
        }
        public string ThemCTHD(CTHDBan ct)
        {
            if (b.ThemCTHD(ct))
            {
                return "1";
            }
            return "0";
        }
        public void UpdateSLSP(SP s)
        {
            b.UpdateSL(s);
        }
    }
}
