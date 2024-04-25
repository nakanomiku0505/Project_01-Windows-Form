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

namespace Project_01
{
    public partial class Home : KryptonForm
    {
        bool sideBar;
        bool menuExpand;
        public Home()
        {
            InitializeComponent();
            RealTime.Start();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            AnalyticBtn.Visible = true;
            ManageBtn.Visible = true;
            panelQL.Visible = true;
            panelTK.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dashboard ds = new Dashboard();
            panelTT.Controls.Clear();
            panelTT.Controls.Add(ds);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            timerMenu.Start();
        }

        private void sideBarTimer_Tick(object sender, EventArgs e)
        {
            if (sideBar)
            {
                timerMenu.Start();
                panelQL.Height -= 10;
                if (panelQL.Height == panelQL.MinimumSize.Height)
                {
                    sidebarPanel.Width -= 10;
                    if (sidebarPanel.Width == sidebarPanel.MinimumSize.Width)
                    {
                        sideBar = false;
                        sideBarTimer.Stop();
                    }
                    menuExpand = true;
                    timerMenu.Stop();
                }
                
            }
            else
            {
                
                sidebarPanel.Width += 10;
                if (sidebarPanel.Width == sidebarPanel.MaximumSize.Width)
                {
                    sideBar = true;
                    sideBarTimer.Stop();
                }
            }
        }


        private void MenuExpand_Click(object sender, EventArgs e)
        {
            sideBarTimer.Start();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AnalyticBtn_Click(object sender, EventArgs e)
        {

        }

        private void DateLabel_Click(object sender, EventArgs e)
        {

        }

        private void RealTime_Tick(object sender, EventArgs e)
        {
            TimeLabel.Text = DateTime.Now.ToLongTimeString();
            DateLabel.Text = DateTime.Now.ToLongDateString();
        }

        private void timerMenu_Tick(object sender, EventArgs e)
        {
            if (sidebarPanel.Width == sidebarPanel.MaximumSize.Width)
            {
                if (menuExpand)
                {
                    panelQL.Height -= 10;
                    if (panelQL.Height == panelQL.MinimumSize.Height)
                    {
                        menuExpand = false;
                        timerMenu.Stop();
                    }
                }
                else
                {
                    panelQL.Height += 10;
                    if (panelQL.Height == panelQL.MaximumSize.Height)
                    {
                        menuExpand = true;
                        timerMenu.Stop();
                    }
                }
            }
            else
            {
                timerMenu.Stop();
            }
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btNV_Click(object sender, EventArgs e)
        {

        }

        private void btDM_Click(object sender, EventArgs e)
        {

        }

        private void btSP_Click(object sender, EventArgs e)
        {

        }

        private void btKH_Click(object sender, EventArgs e)
        {

        }

        private void btNCC_Click(object sender, EventArgs e)
        {

        }

        private void InfoApp_Click(object sender, EventArgs e)
        {
            InfoApp ia = new InfoApp();
            panelTT.Controls.Clear();
            panelTT.Controls.Add(ia);
        }

        private void kryptonPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonDockExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
