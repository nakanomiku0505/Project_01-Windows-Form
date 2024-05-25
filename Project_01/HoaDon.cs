using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using ComponentFactory.Krypton.Toolkit;
using Project_01.FunctionTab;
namespace Project_01
{
    public partial class HoaDon : KryptonForm
    {
        BUS_HD_TK hd = new BUS_HD_TK();
        public HoaDon()
        {
            InitializeComponent();
        }

        private void HoaDon_Load(object sender, EventArgs e)
        {
            rpHoaDon rp = new rpHoaDon();
            rp.SetDataSource(hd.getDataHDNew());


            crystalReportViewer1.ReportSource = rp;
            crystalReportViewer1.Refresh();
        }

        public void HoaDon_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
