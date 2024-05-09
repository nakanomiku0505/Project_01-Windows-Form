using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
namespace BUS
{
    public class BUS_Dashboard
    {
        DAL_Dashboard da = new DAL_Dashboard();
        public string kiemtraSLNV(string ma)
        {
            return da.CheckSLNV(ma).ToString();
        }
        public string kiemtraSLLSP(string ma)
        {
            return da.CheckSLLSP(ma).ToString();
        }
        public string kiemtraSLSP(string ma)
        {
            return da.CheckSLSP(ma).ToString();
        }
        public string kiemtraSLNCC(string ma)
        {
            return da.CheckSLNCC(ma).ToString();
        }
    }
}
