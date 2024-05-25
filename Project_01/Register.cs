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
using BUS;
using DTO;
using static System.Net.WebRequestMethods;
using System.Net.Mail;
using System.Net;
namespace Project_01
{
    public partial class Register : KryptonForm
    {
        
        public Register()
        {
            InitializeComponent();
        }

        private void Register_Load(object sender, EventArgs e)
        {

        }

        private void returnLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login ln = new Login();
            ln.Show();
        }
        
        private void tbEmail_TextChanged(object sender, EventArgs e)
        {

        }

        //private void btSendOTP_Click(object sender, EventArgs e)
        //{
        //    if (string.IsNullOrEmpty(tbEmail.Text))
        //    {
        //        MessageBox.Show("Email không được để trống.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //    }
        //    else
        //    {
        //        try
        //        {
        //            otp = code.Next(100000, 999999);
        //            MailMessage msg = new MailMessage();
        //            msg.From = new MailAddress("managecomputerwf@outlook.com");
        //            msg.To.Add(tbEmail.Text);
        //            msg.Subject = "Verification code";
        //            msg.Body = "Thank you for register to system.\n\n\nYour verification code is: " + otp +
        //                ".\n\nWarning: You will only receive the code when you are attempting to update your password, " +
        //                "login with your e-mail or add a phone number for your account. If you did not request this code, your account may be in danger. " +
        //                "In this case, please login to your account immediately to change your password.\r\nOur staff will never ask for your security code, please do NOT send it to others.";
        //            SmtpClient smt = new SmtpClient();
        //            smt.Host = "smtp.office365.com";
        //            System.Net.NetworkCredential ntcd = new NetworkCredential();
        //            ntcd.UserName = "managecomputerwf@outlook.com";
        //            ntcd.Password = "mikukawaii55";
        //            smt.Credentials = ntcd;
        //            smt.EnableSsl = true;
        //            smt.Port = 587;
        //            smt.Send(msg);

        //            MessageBox.Show("Your Mail is sended. \nCheck your mailbox to get the otp code. ");

        //        }
        //        catch (Exception ex)
        //        {

        //            MessageBox.Show(ex.Message);
        //        }
        //    }
        //}

        private void btDangKy_Click(object sender, EventArgs e)
        {
            string tk = tbUser.Text;
            string mk = tbPass.Text;
            string em = tbEmail.Text;
            try
            {
                BUS_Account acc = new BUS_Account();
                bool them = acc.Them(tk, mk, em);

                MessageBox.Show("Đăng ký thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbUser.Text = "";
                tbPass.Text = "";
                tbEmail.Text = "";
                tbUser.Focus();
            }

        }

        private void tbOTP_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbPass_TextChanged(object sender, EventArgs e)
        {
            if (tbPass.Text == "")
            {
                tbPass.PasswordChar = '\0';
                tbPass.PlaceholderText = "Nhập mật khẩu";
            }

            else
            {
                tbPass.PasswordChar = '*';
            }
        }

        private void Register_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
