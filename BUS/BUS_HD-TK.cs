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
    public class BUS_HD_TK
    {
        DAL_HoaDon_ThongKe hd = new DAL_HoaDon_ThongKe();
        public DataTable getDataHD()
        {
            return hd.getDataHD();

        }
        public DataTable getCTHD(string ma)
        {
            return hd.getDataCTHD(ma);
        }
        public DataTable getSLSPBan()
        {
            return hd.getSLSPBan();
        }
        public DataTable getDoanhThu(int m, int y)
        {
            return hd.getDoanhThu(m,y);
        }
        public DataTable getDataHDTheoDate(int m, int y)
        {

            return hd.getDataHDTheoDate(m, y);

        }
        public DataTable getDataHDTheoMa(string ma)
        {
            return hd.getDataHDTheoMa(ma);
        }
        //public DataTable getDataCTHDTheoDate(int m, int y)
        //{
        //    return hd.getDataCTHDTheoDate(m, y);

        //}

        public string XoaHD(string ma)
        {
            if (hd.XoaHD(ma))
            {
                return "1";
            }
            else
            {
                return "0";
            }
        }
        public string XoaCTHD(string ma)
        {
            if (hd.XoaCTHD(ma))
            {
                return "1";
            }
            else
            {
                return "0";
            }
        }
        public DataTable getDataHDNew()
        {
            return hd.getDataHDNew();
        }
    }
}
