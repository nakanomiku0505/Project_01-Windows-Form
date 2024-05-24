using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using DTO;

namespace DAL
{
    public class DAL_Buy
    {
        DAL_Database db = new DAL_Database();
        public List<KhachHang> laydskh(string MaKH)
        {
            List<KhachHang> ds = new List<KhachHang>();
            string sql = string.Format("select * from KhachHang where MaKH= '{0}'", MaKH);
            DataTable dt = db.getData(sql);
            foreach (DataRow dr in dt.Rows)
            {
                KhachHang mon = new KhachHang(dr);
                ds.Add(mon);

            }
            return ds;
        }
        public DataTable getDataLSP()
        {
            string sql = "Select * from LoaiSP";
            return db.getData(sql);

        }
        public DataTable getDataSP(string lsp)
        {
            string sql = string.Format( "Select * from SP where MaLoaiSP = '{0}'",lsp );
            DataTable dt = db.getData(sql);
            return dt;
        }
        public DataTable getDataNV()
        {
            string sql = "Select * from NhanVien";
            return db.getData(sql);

        }
        public bool ThemHD(HoaDonBan hd)
        {
            string sql = string.Format("EXEC InsertHoaDon @MaNV = '{0}', @MaKH = '{1}', @NgayBan = '{2}', @TongTien = '{3}';",
                hd.MaNV,hd.MaKH,hd.NgayBan,hd.TongTien);
            db.Execute(sql);
            return true;
        }
        public string GetMaxMHD()
        {
            string sql = "SELECT ISNULL(MAX(MaHDB), 0) FROM HoaDonBan";
            string ma = db.GetInt(sql);
            return ma;
        }
        public bool ThemCTHD(CTHDBan hd)
        {
            string ma = GetMaxMHD();
            string sql = string.Format("INSERT INTO CTHDBan (MaHDB, MaSP, SLBan, GiaBan) VALUES ('{0}', '{1}', {2}, '{3}');",
                ma, hd.MaSP, hd.SLBan, hd.GiaBan);
            db.Execute(sql);
            return true;
        }
        public bool UpdateSL(SP s)
        {
            string sql = string.Format("UPDATE SP SET SL = SL - '{0}' WHERE MaSP = '{1}'",
                s.SL, s.MaSP);
            db.Execute(sql);
            return true;
        }
    }

}
