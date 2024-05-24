using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using Project_01.FunctionTab;
using BUS;
using DTO;
namespace Project_01
{
    public partial class HoaDonTK : KryptonForm
    {
        BUS_HD_TK hd = new BUS_HD_TK();
        public HoaDonTK()
        {
            InitializeComponent();
        }

        private void HoaDonTK_Load(object sender, EventArgs e)
        {
            rpHoaDonTheoMa rp = new rpHoaDonTheoMa();
            rp.SetDataSource(hd.getDataHDTheoMa(SaveMa.ma));


            crystalReportViewer1.ReportSource = rp;
            crystalReportViewer1.Refresh();

        }

    }
}
