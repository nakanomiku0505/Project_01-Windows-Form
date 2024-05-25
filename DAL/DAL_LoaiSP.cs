using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAL
{
    public class DAL_LoaiSP
    {
        DAL_Database db = new DAL_Database();
        public DataTable getData()
        {
            string sql = "Select * from LoaiSP";
            return db.getData(sql);

        }
        public int kiemtramatrung(string ma)
        {
            string sql = "Select count(*) from LoaiSP where MaLoaiSP='" + ma.Trim() + "'";
            return db.CheckID(ma, sql);
        }
        public int kiemtratentrung(string ma)
        {
            string sql = "Select count(*) from LoaiSP where TenLoaiSP = N'" + ma.Trim() + "'";
            return db.CheckID(ma, sql);
        }
        public bool ThemLSP(LoaiSP ls)
        {
            string sql = string.Format("EXEC InsertLoaiSP @TenLoaiSP = N'{0}',@MoTa = N'{1}',@MaNCC = '{2}'", ls.TenLoaiSP, ls.MoTa, ls.MaNCC);
            db.Execute(sql);
            return true;

        }
        public bool SuaLSP(LoaiSP ls)
        {
            string sql = string.Format("UPDATE LoaiSP SET TenLoaiSP = N'{0}', MoTa = N'{1}', MaNCC = '{2}' WHERE MaLoaiSP = '{3}'", ls.TenLoaiSP, ls.MoTa, ls.MaNCC, ls.MaLoaiSP);
            db.Execute(sql);
            return true;
        }
        public bool XoaLSP(string ma)
        {
            string sql = string.Format("DELETE FROM LoaiSP WHERE MaLoaiSP = '{0}'", ma);
            db.Execute(sql);
            return true;
        }
        public DataTable TimKiemLoaiSP(string keyword)
        {
            string sql = string.Format("SELECT * FROM LoaiSP WHERE MaLoaiSP LIKE N'%{0}%' OR TenLoaiSP LIKE N'%{0}%'", keyword);
            return db.getData(sql);
        }
        public DataTable getNCC()
        {
            string sql = "SELECT [MaNCC] FROM [NhaCungCap]";
            return db.getData(sql);
        }
    }
}
