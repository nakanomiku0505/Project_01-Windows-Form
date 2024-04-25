using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_01.FunctionTab
{
    public partial class InfoApp : UserControl
    {
        public InfoApp()
        {
            InitializeComponent();
        }

        private void linkLabelMail_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string email = "managecomputerwf@outlook.com";
            System.Diagnostics.ProcessStartInfo mo = new System.Diagnostics.ProcessStartInfo
            {
                FileName = "mailto:" + email,
                UseShellExecute = true
            };
            System.Diagnostics.Process.Start(mo);
        }

        private void linkLabelFB_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ProcessStartInfo sInfo = new ProcessStartInfo("http://fb.com/nakano.miku.55");
            Process.Start(sInfo);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            ProcessStartInfo sInfo = new ProcessStartInfo("http://fb.com/nakano.miku.55");
            Process.Start(sInfo);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            string email = "managecomputerwf@outlook.com";
            System.Diagnostics.ProcessStartInfo mo = new System.Diagnostics.ProcessStartInfo
            {
                FileName = "mailto:" + email,
                UseShellExecute = true
            };
            System.Diagnostics.Process.Start(mo);
        }
    }
}
