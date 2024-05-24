using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAL
{
    public class DAL_HoaDon_ThongKe
    {
        DAL_Database db = new DAL_Database();
        public DataTable getDataHD()
        {
            string sql = "EXEC LayDSHoaDon";
            return db.getData(sql);

        }
        public DataTable getDataCTHD(string ma)
        {
            string sql = string.Format("EXEC LayCTHD '{0}'", ma);
            return db.getData(sql);
        }
        public DataTable getSLSPBan()
        {
            string sql = "EXEC LayDSSanPhamBan";
            return db.getData(sql);
        }
        public DataTable getDoanhThu(int m, int y)
        {
            string sql = string.Format("EXEC GetDoanhThuTrongThang @Thang = '{0}', @Nam = '{1}'",m,y);
            return db.getData(sql);
        }
        public DataTable getDataHDTheoDate(int m, int y)
        {
            string sql = string.Format("EXEC GetHoaDonByThangNam @Thang = {0}, @Nam = {1};",m,y);
            return db.getData(sql);

        }
        public DataTable getDataHDTheoMa(string ma)
        {
            string sql = string.Format("EXEC HienThiHoaDonTheoMa @MaHDB = '{0}'", ma);
            return db.getData(sql);
        }
        //public DataTable getDataCTHDTheoDate(int m, int y)
        //{
        //    string sql = string.Format("EXEC HienThiHoaDonTheoMonth @Thang ='{0}', @Nam = '{1}'", m, y);
        //    return db.getData(sql);

        //}

        public bool XoaHD(string ma)
        {
            string sql = string.Format("DELETE FROM HoaDonBan WHERE MaHDB = '{0}'", ma);
            db.Execute(sql);
            return true;
        }
        public bool XoaCTHD(string ma)
        {
            string sql = string.Format("DELETE FROM CTHDBan WHERE MaHDB = '{0}'", ma);
            db.Execute(sql);
            return true;
        }
    }
}
