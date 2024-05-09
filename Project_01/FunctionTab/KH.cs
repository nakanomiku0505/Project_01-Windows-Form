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
    public partial class KH : UserControl
    {
        BUS_KhachHang kh = new BUS_KhachHang();
        public KH()
        {
            InitializeComponent();
        }

        private void listKH_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void listKH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < listKH.Rows.Count)
            {
                int i = e.RowIndex;
                tbMaKH.Text = listKH[0, i].Value.ToString();
                tbTenKH.Text = listKH[1, i].Value.ToString();
                tbDC.Text = listKH[2, i].Value.ToString();
                tbSDT.Text = listKH[3, i].Value.ToString();
                tbEmail.Text = listKH[4, i].Value.ToString();
            }
        }
        public void LoadDS()
        {
            listKH.DataSource = kh.getData();
        }
        public void ClearTB()
        {
            tbMaKH.Clear();
            tbTenKH.Clear();
            tbDC.Clear();
            tbSDT.Clear();
            tbEmail.Clear();
        }

        private void KH_Load(object sender, EventArgs e)
        {
            LoadDS();
        }

        private void btTim_Click(object sender, EventArgs e)
        {
            string keyword = tbTim.Text;
            listKH.DataSource = kh.TimKiemKH(keyword);
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            KhachHang ls = new KhachHang();
            ls.MaKH = tbMaKH.Text;
            ls.TenKH = tbTenKH.Text;
            ls.DiaChi = tbDC.Text;
            ls.SDT = tbSDT.Text;
            ls.Email = tbEmail.Text;
            string result = kh.ThemKH(ls);
            if (result == "1")
            {
                MessageBox.Show("Thêm khách hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDS();
                ClearTB();

            }
            else if (result == "-1")
            {
                MessageBox.Show("Các trường thông tin không được bỏ trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (result == "-2")
            {
                MessageBox.Show("Trùng mã khách hàng.\nVui lòng thử lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Thêm thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            KhachHang ls = new KhachHang();
            ls.MaKH = tbMaKH.Text;
            ls.TenKH = tbTenKH.Text;
            ls.DiaChi = tbDC.Text;
            ls.SDT = tbSDT.Text;
            ls.Email = tbEmail.Text;
            string result = kh.SuaKH(ls);
            if (result == "1")
            {
                MessageBox.Show("Sửa khách hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDS();
                ClearTB();

            }
            else if (result == "-1")
            {
                MessageBox.Show("Các trường thông tin không được bỏ trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Thêm thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            string makh = kh.XoaKH(tbMaKH.Text);
            if (makh == "-1")
            {
                MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearTB();
                LoadDS();
            }
            else
            {
                MessageBox.Show("Xóa thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btClear_Click(object sender, EventArgs e)
        {
            ClearTB();
        }

        private void bunifuGroupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
