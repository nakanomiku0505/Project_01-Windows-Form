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

namespace Project_01
{
    public partial class Login : KryptonForm
    {
        private string dfUser = "Username";
        private string dfPass = "Password";
        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void kryptonTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbUser_Enter(object sender, EventArgs e)
        {
            if (tbUser.Text == dfUser)
            {
                tbUser.Text = "";
            }
        }

        private void tbUser_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbUser.Text))
            {
                tbUser.Text = dfUser;
            }
        }

        private void tbPass_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbPass.Text))
            {
                tbPass.Text = dfPass;
            }
        }

        private void tbPass_Enter(object sender, EventArgs e)
        {
            if (tbPass.Text == dfPass)
            {
                tbPass.Text = "";
            }
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            string users = tbUser.Text;
            string passwords = tbPass.Text;
            try
            {
                BUS_Account acc = new BUS_Account();
                string check = acc.checkAcc(users, passwords);

                MessageBox.Show(check, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                Home home = new Home();
                
                home.ShowDialog();
                
            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message, "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbUser.Text = "";   
                tbPass.Text = "";
            }
        }
    }
}
