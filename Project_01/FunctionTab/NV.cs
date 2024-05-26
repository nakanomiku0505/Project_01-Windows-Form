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
    public partial class NV : UserControl
    {
        BUS_NhanVien nv = new BUS_NhanVien ();
        public NV()
        {
            InitializeComponent();
        }

        private void listNV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            
        }

        private void NV_Load(object sender, EventArgs e)
        {
            LoadDS();
        }

        private void listNV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < listNV.Rows.Count)
            {
                int i = e.RowIndex;
                tbMaNV.Text = listNV[0, i].Value.ToString();
                tbTenNV.Text = listNV[1, i].Value.ToString();
                tbDC.Text = listNV[2, i].Value.ToString();
                tbSDT.Text = listNV[3, i].Value.ToString();
            }
            
        }

        private void bunifuButton2_Click(object sender, EventArgs e)
        {
            NhanVien nvien = new NhanVien();
            nvien.MaNV = tbMaNV.Text;
            nvien.TenNV = tbTenNV.Text;
            nvien.DiaChi = tbDC.Text;
            nvien.SDT = tbSDT.Text;
            string result = nv.Themnv(nvien);
            if (result == "Thêm thành công.")
            {
                MessageBox.Show("Thêm nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                listNV.DataSource = nv.getData();
                ClearTB();
                LoadDS();

            }
            else if(result == "-1")
            {
                MessageBox.Show("Các trường thông tin không được bỏ trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (result == "-2")
            {
                MessageBox.Show("Trùng mã nhân viên.\nVui lòng thử lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (result == "-4")
            {
                MessageBox.Show("Định dạng số điện thoại sai.\nSố điện thoại chỉ có 10 số.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            else
            {
                MessageBox.Show("Thêm nhân viên thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void LoadDS()
        {
            listNV.DataSource = nv.getData();
        }
        public void ClearTB()
        {
            tbMaNV.Text = "";
            tbTenNV.Text = "";
            tbDC.Text = "";
            tbSDT.Text = "";
        }

        private void bunifuTextBox5_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btClear_Click(object sender, EventArgs e)
        {
            ClearTB();
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            if (tbMaNV.Text == "")
            {
                MessageBox.Show("Chưa chọn nhân viên nào.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                NhanVien nvien = new NhanVien();
                nvien.MaNV = tbMaNV.Text;
                nvien.TenNV = tbTenNV.Text;
                nvien.DiaChi = tbDC.Text;
                nvien.SDT = tbSDT.Text;
                string result = nv.Suanv(nvien);
                if (result == "1")
                {
                    MessageBox.Show("Sửa nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    listNV.DataSource = nv.getData();
                    ClearTB();
                    LoadDS();

                }
                else if (result == "-1")
                {
                    MessageBox.Show("Các trường thông tin không được bỏ trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (result == "-4")
                {
                    MessageBox.Show("Định dạng số điện thoại sai.\nSố điện thoại chỉ có 10 số.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
                else
                {
                    MessageBox.Show("Sửa nhân viên thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            string manv = nv.Xoanv(tbMaNV.Text);
            if (tbMaNV.Text == "")
            {
                MessageBox.Show("Chưa chọn nhân viên nào.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (manv == "-1")
                {
                    MessageBox.Show("Xóa nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    listNV.DataSource = nv.getData();
                    ClearTB();
                    LoadDS();
                }
                else
                {
                    MessageBox.Show("Xóa nhân viên thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            string keyword = tbTim.Text;
            listNV.DataSource = nv.TimKiemNhanVien(keyword);
        }

        private void tbSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
