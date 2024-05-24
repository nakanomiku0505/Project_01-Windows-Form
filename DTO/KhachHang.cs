using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class KhachHang
    {
        public KhachHang() { }
        public KhachHang(string MaKH, string TenKH, string DiaChi, string SDT, string email)

        {
            this.MaKH = MaKH;
            this.TenKH = TenKH;
            this.DiaChi = DiaChi;
            this.SDT = SDT;
            this.Email = email;


        }
        public KhachHang(DataRow row)
        {
            this.MaKH = row["MaKH"].ToString();
            this.TenKH = row["TenKH"].ToString();
            this.DiaChi = row["DiaChi"].ToString();
            this.SDT = row["SDT"].ToString();
            this.Email = row["Email"].ToString() ;
        }
        public string MaKH {  get; set; }
        public string TenKH { get; set; }
        public string DiaChi { get; set; }
        public string SDT {  get; set; }
        public string Email { get; set; }
    }
}
