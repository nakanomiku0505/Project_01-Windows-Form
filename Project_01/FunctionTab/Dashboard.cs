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
using DTO;
namespace Project_01.FunctionTab
{
    public partial class Dashboard : UserControl
    {
        BUS_Dashboard ba = new BUS_Dashboard();
        string slsp;
        string sllsp;
        string slnv;
        string slncc;
        public Dashboard()
        {
            InitializeComponent();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            lbStatSP.Text = CountSP(slsp);
            lbStatLSP.Text = CountLSP(sllsp);
            lbStatNV.Text = CountNV(slnv);
            lbStatNCC.Text = CountNCC(slncc);
        }

        private void lbAppName_Click(object sender, EventArgs e)
        {

        }

        private void bunifuPanel3_Click(object sender, EventArgs e)
        {

        }

        private void bunifuPanel1_Click(object sender, EventArgs e)
        {

        }
        public string CountSP(string sl)
        {
            slsp = ba.kiemtraSLSP(sl);
            return slsp;
        }
        public string CountLSP(string sl)
        {
            sllsp = ba.kiemtraSLLSP(sl);
            return sllsp;
        }
        public string CountNV(string sl)
        {
            slnv = ba.kiemtraSLNV(sl);
            return slnv;
        }
        public string CountNCC(string sl)
        {
            slncc = ba.kiemtraSLNCC(sl);
            return slncc;
        }
    }
}
