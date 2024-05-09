using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAL
{
    public class DAL_KhachHang
    {
        DAL_Database db = new DAL_Database();
        public DataTable getData()
        {
            string sql = "Select * from KhachHang";
            return db.getData(sql);

        }
        public int kiemtramatrung(string ma)
        {
            string sql = "Select count(*) from KhachHang where MaKH='" + ma.Trim() + "'";
            return db.CheckID(ma, sql);
        }
        public bool ThemKH(KhachHang ls)
        {
            string sql = string.Format("EXEC InsertKhachHang @TenKH = N'{0}',@DiaChi = N'{1}',@SDT = '{2}',@Email = '{3}'", ls.TenKH, ls.DiaChi, ls.SDT, ls.Email);
            db.Execute(sql);
            return true;

        }
        public bool SuaKH(KhachHang ls)
        {
            string sql = string.Format("UPDATE KhachHang SET TenKH = N'{0}', DiaChi = N'{1}', SDT = '{2}', Email = '{3}' WHERE MaKH = '{4}'", ls.TenKH, ls.DiaChi, ls.SDT, ls.Email, ls.MaKH);
            db.Execute(sql);
            return true;
        }
        public bool XoaKH(string ma)
        {
            string sql = string.Format("DELETE FROM KhachHang WHERE MaKH = '{0}'", ma);
            db.Execute(sql);
            return true;
        }
        public DataTable TimKiemKH(string keyword)
        {
            string sql = string.Format("SELECT * FROM KHachHang WHERE MaKH LIKE N'%{0}%' OR TenKH LIKE N'%{0}%'", keyword);
            return db.getData(sql);
        }
    }
}
