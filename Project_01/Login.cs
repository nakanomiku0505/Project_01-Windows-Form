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
    public partial class Login : KryptonForm
    {
        BUS_Account acc = new BUS_Account();
        
        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pLogin.BorderRadius = 10;
        }

        private void kryptonTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbUser_TextChanged(object sender, EventArgs e)
        {

        }

        

        private void btLogin_Click(object sender, EventArgs e)
        {
            string users = tbUser.Text;
            string passwords = tbPass.Text;
            try
            {
                
                string check = acc.checkAcc(users, passwords);

                MessageBox.Show(check, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                SaveAccount.users = users;
                SaveAccount.passwords = passwords;
                SaveAccount.quyen = check;
                this.Hide();
                Home home = new Home();

                home.ShowDialog();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbUser.Text = "";
                tbPass.Text = "";
                tbUser.Focus();
            }
        }

        private void tbUser_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btLogin_Click(sender, e);
            }
        }

        private void tbPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btLogin_Click(sender, e);
            }
        }

        private void tbUser_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void tbPass_TextChanged(object sender, EventArgs e)
        {
            if (tbPass.Text == "")
            {
                tbPass.PasswordChar = '\0';
                tbPass.PlaceholderText = "Mật khẩu";
            }
            
            else
            {
                tbPass.PasswordChar = '*';
            }
        }

        private void tbPass_Load(object sender, EventArgs e)
        {
            tbPass.PlaceholderText = "Mật khẩu";
        }

        private void labelForgot_Click(object sender, EventArgs e)
        {
            this.Hide();
            Forgot fg = new Forgot();
            fg.ShowDialog();
            
        }

        private void btRegister_Click(object sender, EventArgs e)
        {
            this.Hide();
            Register rs = new Register();
            rs.ShowDialog();
            
        }

        private void Login_Leave(object sender, EventArgs e)
        {
            
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        public DataTable layuser()
        {
            string tk = tbUser.Text;
            if (tk.ToLower() == "admin")
            {
                DataTable dt = new DataTable();
                dt.Columns.Add("users", typeof(string));
                dt.Columns.Add("MaNV", typeof(string));
                dt.Columns.Add("TenNV", typeof(string));
                dt.Rows.Add("admin", "admin", "admin");
                return dt;
            }
            return acc.layuser(tk);
        }
        public string users()
        {
            string tk = tbUser.Text;
            return tk;
        }
    }
}
