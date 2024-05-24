using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BUS;
using ComponentFactory.Krypton.Toolkit;
namespace Project_01
{
    public partial class HoaDonMonth : KryptonForm
    {
        BUS_HD_TK hd = new BUS_HD_TK();
        public HoaDonMonth()
        {
            InitializeComponent();
        }

        private void HoaDonMonth_Load(object sender, EventArgs e)
        {
            rpHDMonth rp = new rpHDMonth();
            rp.SetDataSource(hd.getDataHDTheoDate(SaveDate.month,SaveDate.year));


            crystalReportViewer1.ReportSource = rp;
            crystalReportViewer1.Refresh();
        }

        private void rpHDMonth1_InitReport(object sender, EventArgs e)
        {

        }
    }
}
