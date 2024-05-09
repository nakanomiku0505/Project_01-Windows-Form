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
    public class BUS_NhanVien
    {
        DAL_NhanVien nv = new DAL_NhanVien();
        public DataTable getData()
        {
            return nv.getData();
        }
        public int kiemtramatrung(string ma)
        {
            return nv.kiemtramatrung(ma);
        }
        public string Themnv(NhanVien nvien)
        {
            if (string.IsNullOrEmpty(nvien.TenNV) || string.IsNullOrEmpty(nvien.DiaChi) || string.IsNullOrEmpty(nvien.SDT))
            {
                return "-1";
            }
            else if (kiemtramatrung(nvien.MaNV) > 0)
            {
                return "-2";
            }
            else if (nv.Themnv(nvien))
            {
                return "Thêm thành công.";
            }

            return "Thêm thất bại";

        }
        public string Xoanv(string ma)
        {

            if (nv.Xoanv(ma))
            {
                return "-1";
            }
            else
            {
                return "Xóa nhân viên thất bại";
            }
        }

        public string Suanv(NhanVien nvien)
        {
            if (string.IsNullOrEmpty(nvien.TenNV) || string.IsNullOrEmpty(nvien.DiaChi) || string.IsNullOrEmpty(nvien.SDT))
            {
                return "-1";
            }
            else if (nv.Suavn(nvien))
            {
                return "1";
            }
            else
            {
                return "Sửa thất bại";
            }
        }
        public DataTable TimKiemNhanVien(string keyword)
        {
            return nv.TimKiemNhanVien(keyword);
        }
        public DataTable getUsers()
        {
            return nv.getUsers();
        }
    }
}
