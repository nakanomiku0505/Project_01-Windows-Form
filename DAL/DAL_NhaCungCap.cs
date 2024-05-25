using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAL
{
    public class DAL_NhaCungCap
    {
        DAL_Database db = new DAL_Database();
        public DataTable getData()
        {
            string sql = "Select * from NhaCungCap";
            return db.getData(sql);

        }
        public int kiemtramatrung(string ma)
        {
            string sql = "Select count(*) from NhaCungCap where MaNCC='" + ma.Trim() + "'";
            return db.CheckID(ma, sql);
        }
        public int kiemtratentrung(string ma)
        {
            string sql = "Select count(*) from NhaCungCap where TenNCC = N'" + ma.Trim() + "'";
            return db.CheckID(ma, sql);
        }
        public bool ThemNCC(NhaCungCap ls)
        {
            string sql = string.Format("EXEC InsertNhaCungCap @TenNCC = N'{0}',@DiaChi = N'{1}',@SDT = '{2}',@Email = '{3}'", ls.TenNCC, ls.DiaChi, ls.SDT, ls.Email);
            db.Execute(sql);
            return true;

        }
        public bool SuaNCC(NhaCungCap ls)
        {
            string sql = string.Format("UPDATE NhaCungCap SET TenNCC = N'{0}', DiaChi = N'{1}', SDT = '{2}', Email = '{3}' WHERE MaNCC = '{4}'", ls.TenNCC, ls.DiaChi, ls.SDT, ls.Email, ls.MaNCC);
            db.Execute(sql);
            return true;
        }
        public bool XoaNCC(string ma)
        {
            string sql = string.Format("DELETE FROM NhaCungCap WHERE MaNCC = '{0}'", ma);
            db.Execute(sql);
            return true;
        }
        public DataTable TimKiemNCC(string keyword)
        {
            string sql = string.Format("SELECT * FROM NhaCungCap WHERE MaNCC LIKE N'%{0}%' OR TenNCC LIKE N'%{0}%'", keyword);
            return db.getData(sql);
        }
        
    }
}
