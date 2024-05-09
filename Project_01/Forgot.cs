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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
namespace Project_01
{
    public partial class Forgot : KryptonForm
    {
        BUS_Account account = new BUS_Account();
        int otp;
        Random code = new Random();
        string email;
        public Forgot()
        {
            InitializeComponent();
        }

        private void Forgot_Load(object sender, EventArgs e)
        {
            tbOTP.Visible = false;
           btCheckOTP.Visible = false;
            lbPass.Visible = false;
            lbRePass.Visible = false;
            tbPass.Visible = false;
            tbRePass.Visible = false;
            btDoiMK.Visible = false;
            lbStat.Visible = false;
        }

        private void bunifuTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void returnLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login lg = new Login();
            lg.ShowDialog();
            
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

        private void tbRePass_TextChanged(object sender, EventArgs e)
        {
            if (tbRePass.Text == "")
            {
                tbRePass.PasswordChar = '\0';
                tbRePass.PlaceholderText = "Nhập lại mật khẩu";
            }

            else
            {
                tbRePass.PasswordChar = '*';
            }
        }

        private void btSendOTP_Click(object sender, EventArgs e)
        {
            try
            {
                string em = tbEmail.Text;
                string tk = tbUser.Text;
                string fg = account.CheckExist(tk,em);
                
                if (fg == "1")
                {
                    MessageBox.Show("Tài khoản tồn tại. \nChúng tôi sẽ gửi 1 mã OTP " +
                        "về mail liên kết với tài khoản của bạn để xác minh.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    lbStat.Visible=true;
                    

                    try
                    {
                        otp = code.Next(100000, 999999);
                        MailMessage msg = new MailMessage();
                        msg.From = new MailAddress("managecomputerwf@outlook.com");
                        msg.To.Add(em);
                        msg.Subject = "Verification code";
                        msg.Body = "Thank you for register to system.\n\n\nYour verification code is: " + otp +
                            ".\n\nWarning: You will only receive the code when you are attempting to update your password, " +
                            "login with your e-mail or add a phone number for your account. If you did not request this code, your account may be in danger. " +
                            "In this case, please login to your account immediately to change your password.\r\n" +
                            "Our staff will never ask for your security code, please do NOT send it to others.";
                        SmtpClient smt = new SmtpClient();
                        smt.Host = "smtp.office365.com";
                        System.Net.NetworkCredential ntcd = new NetworkCredential();
                        ntcd.UserName = "managecomputerwf@outlook.com";
                        ntcd.Password = "mikukawaii55";
                        smt.Credentials = ntcd;
                        smt.EnableSsl = true;
                        smt.Port = 587;
                        smt.Send(msg);

                        lbStat.Text = "Your Mail is sended. Check your mailbox to get the otp code. ";
                        tbOTP.Visible = true;
                        btCheckOTP.Visible = true;


                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show(ex.Message);
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                
            }
        }

        private void btDoiMK_Click(object sender, EventArgs e)
        {
            string us = tbUser.Text;
            string mk = tbPass.Text;
            string remk = tbRePass.Text;
            try
            {
                BUS_Account acc = new BUS_Account();
                string tb = acc.QuenMK(us, mk, remk);
                MessageBox.Show(tb, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbOTP.Visible = false;
                btCheckOTP.Visible = false;
                lbPass.Visible = false;
                lbRePass.Visible = false;
                tbPass.Visible = false;
                tbRePass.Visible = false;
                btDoiMK.Visible = false;
                lbStat.Visible = false;
                tbUser.ReadOnly = false;
                tbEmail.ReadOnly = false;
                tbOTP.ReadOnly = false;
                btSendOTP.Enabled = true;
                btCheckOTP.Enabled = true;
                tbUser.Text = "";
                tbEmail.Text = "";
                tbOTP.Text = "";
                tbPass.Text = "";
                tbRePass.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
            
        }

        private void btCheckOTP_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(tbOTP.Text))
            {
                MessageBox.Show("Mã OTP không được bỏ trống.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (tbOTP.Text != otp.ToString())
            {
                MessageBox.Show("Mã OTP sai.\nVui lòng nhập lại.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (Convert.ToInt32(tbOTP.Text) == otp)
            {
                MessageBox.Show("Xác minh thành công.", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                lbPass.Visible = true;
                tbPass.Visible = true;
                lbRePass.Visible = true;
                tbRePass.Visible = true;
                btDoiMK.Visible = true;
                tbUser.ReadOnly = true;
                tbEmail.ReadOnly = true;
                tbOTP.ReadOnly = true;
                btSendOTP.Enabled = false;
                btCheckOTP.Enabled = false;
            }
            
        }

        private void tbOTP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
