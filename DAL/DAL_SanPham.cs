using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_SanPham
    {
        DAL_Database db = new DAL_Database();
        public DataTable getData()
        {
            string sql = "Select * from SP";
            return db.getData(sql);

        }
        public int kiemtramatrung(string ma)
        {
            string sql = "Select count(*) from SP where MaSP='" + ma.Trim() + "'";
            return db.CheckID(ma, sql);
        }
        public bool ThemSP(SP s)
        {
            string sql = string.Format("EXEC InsertSanPham @TenSP = N'{0}',@Gia = '{1}', @Mota = N'{2}' ,@SL = '{3}' ,@MaLoaiSP = '{4}'", s.TenSP, s.Gia, s.Mota, s.SL, s.MaLoaiSP);
            db.Execute(sql);
            return true;

        }
        public bool SuaSP(SP s)
        {
            string sql = string.Format("UPDATE SP SET TenSP = N'{0}', Gia = '{1}', Mota = N'{2}',  SL = '{3}', MaLoaiSP = '{4}' WHERE MaSP = '{5}'", s.TenSP, s.Gia, s.Mota, s.SL, s.MaLoaiSP, s.MaSP);
            db.Execute(sql);
            return true;
        }
        public bool XoaSP(string ma)
        {
            string sql = string.Format("DELETE FROM SP WHERE MaSP = '{0}'", ma);
            db.Execute(sql);
            return true;
        }
        public DataTable TimKiemSP(string keyword)
        {
            string sql = string.Format("SELECT * FROM SP WHERE MaSP LIKE N'%{0}%' OR TenSP LIKE N'%{0}%'", keyword);
            return db.getData(sql);
        }
        public DataTable getLSP()
        {
            string sql = "SELECT [MaLoaiSP],[TenLoaiSP] FROM LoaiSP ";
            return db.getData(sql);
        }
    }
}
