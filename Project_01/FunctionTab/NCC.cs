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
    public partial class NCC : UserControl
    {
        BUS_NhaCungCap nc = new BUS_NhaCungCap();
        public NCC()
        {
            InitializeComponent();
        }

        private void NCC_Load(object sender, EventArgs e)
        {
            LoadDS();
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            ClearTB();
        }
        public void ClearTB()
        {
            tbMaNCC.Clear();
            tbTenNCC.Clear();
            tbDC.Clear();
            tbSDT.Clear();
            tbEmail.Clear();
        }
        public void LoadDS()
        {
            listNCC.DataSource = nc.getData();
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            NhaCungCap ls = new NhaCungCap();
            ls.MaNCC = tbMaNCC.Text;
            ls.TenNCC = tbTenNCC.Text;
            ls.DiaChi = tbDC.Text;
            ls.SDT = tbSDT.Text;
            ls.Email = tbEmail.Text;
            string result = nc.ThemNCC(ls);
            if (result == "1")
            {
                MessageBox.Show("Thêm nhà cung cấp thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDS();
                ClearTB();

            }
            else if (result == "-1")
            {
                MessageBox.Show("Các trường thông tin không được bỏ trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (result == "-2")
            {
                MessageBox.Show("Trùng mã nhà cung cấp.\nVui lòng thử lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (result == "-3")
            {
                MessageBox.Show("Đã có nhà cung cấp này.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (result == "-4")
            {
                MessageBox.Show("Định dạng số điện thoại sai.\nSố điện thoại chỉ có 10 số.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (result == "-5")
            {
                MessageBox.Show("Email không phù hợp.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Thêm thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            if (tbMaNCC.Text == "")
            {
                MessageBox.Show("Chưa chọn nhà cung cấp nào.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                NhaCungCap ls = new NhaCungCap();
                ls.MaNCC = tbMaNCC.Text;
                ls.TenNCC = tbTenNCC.Text;
                ls.DiaChi = tbDC.Text;
                ls.SDT = tbSDT.Text;
                ls.Email = tbEmail.Text;
                string result = nc.SuaNCC(ls);
                if (result == "1")
                {
                    MessageBox.Show("Sửa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDS();
                    ClearTB();

                }
                else if (result == "-1")
                {
                    MessageBox.Show("Các trường thông tin không được bỏ trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (result == "-3")
                {
                    MessageBox.Show("Đã có nhà cung cấp này.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (result == "-4")
                {
                    MessageBox.Show("Định dạng số điện thoại sai.\nSố điện thoại chỉ có 10 số.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (result == "-5")
                {
                    MessageBox.Show("Email không phù hợp.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Sửa thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            string mancc = nc.XoaNCC(tbMaNCC.Text);
            if (mancc == "-1")
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

        private void btTim_Click(object sender, EventArgs e)
        {
            string keyword = tbTim.Text;
            listNCC.DataSource = nc.TimKiemNCC(keyword);
        }

        private void listNCC_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < listNCC.Rows.Count)
            {
                int i = e.RowIndex;
                tbMaNCC.Text = listNCC[0, i].Value.ToString();
                tbTenNCC.Text = listNCC[1, i].Value.ToString();
                tbDC.Text = listNCC[2, i].Value.ToString();
                tbSDT.Text = listNCC[3, i].Value.ToString();
                tbEmail.Text = listNCC[4, i].Value.ToString();
            }

        }

        private void tbTim_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbTim.Text))
            {
                LoadDS();
            }
        }

        private void bunifuGroupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
