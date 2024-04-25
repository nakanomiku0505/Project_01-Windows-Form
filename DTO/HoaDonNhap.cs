using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    internal class HoaDonNhap
    {
        public string MaHDN {  get; set; }
        public string MaNV { get; set; }
        public string MaNCC { get; set; }
        public DateTime NgayNhap { get; set;}
        public float TongTien {  get; set; }
    }
}
