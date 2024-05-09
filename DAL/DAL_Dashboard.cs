using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_Dashboard
    {
        DAL_Database db = new DAL_Database();
        public int CheckSLNV(string ma)
        {
            string sql = "Select count(*) from NhanVien";
            return db.CheckID(ma, sql);
        }
        public int CheckSLLSP(string ma)
        {
            string sql = "Select count(*) from LoaiSP";
            return db.CheckID(ma, sql);
        }
        public int CheckSLSP(string ma)
        {
            string sql = "Select count(*) from SP";
            return db.CheckID(ma, sql);

        }
        public int CheckSLNCC(string ma)
        {
            string sql = "Select count(*) from NhaCungCap";
            return db.CheckID(ma, sql);
        }
    }
}
