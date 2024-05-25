using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAL
{
    public class DAL_NhanVien
    {
        DAL_Database db = new DAL_Database();
        public DataTable getData()
        {
            string sql = "Select * from NhanVien";
            return db.getData(sql);

        }
        public int kiemtramatrung(string ma)
        {
            string sql = "Select count(*) from NhanVien where MaNV='" + ma.Trim() + "'";
            return db.CheckID(ma, sql);
        }

        
        public bool Themnv(NhanVien nv)
        {
            string sql = string.Format("EXEC InsertEmployee @TenNV = N'{0}' ,@DiaChi = N'{1}' ,@SDT = '{2}' ,@users = null", nv.TenNV, nv.DiaChi, nv.SDT);
            db.Execute(sql);
            return true;

        }
        public bool Suavn(NhanVien nv)
        {
            string sql = string.Format("UPDATE NhanVien SET TenNV = N'{0}', DiaChi = N'{1}', SDT = '{2}' WHERE MaNV = '{3}'", nv.TenNV, nv.DiaChi, nv.SDT, nv.MaNV);
            db.Execute(sql);
            return true;
        }
        public bool Xoanv(string ma)
        {
            string sql = string.Format("DELETE FROM NhanVien WHERE MaNV = '{0}'", ma);
            db.Execute(sql);
            return true;
        }
        public DataTable TimKiemNhanVien(string keyword)
        {
            string sql = string.Format("SELECT * FROM NhanVien WHERE MaNV LIKE N'%{0}%' OR TenNV LIKE N'%{0}%'", keyword);
            return db.getData(sql);
        }
        public DataTable getUsers()
        {
            string sql = "SELECT [users],[quyen] FROM [Accounts]";
            return db.getData(sql);
        }
    }
}
