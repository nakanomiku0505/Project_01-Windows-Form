using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms;
using BUS;
using DTO;
namespace Project_01.FunctionTab
{
    public partial class DanhMuc : UserControl
    {
        BUS_LoaiSP lsp = new BUS_LoaiSP();
        public DanhMuc()
        {
            InitializeComponent();
        }

        private void bunifuGroupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void bunifuDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void LoadDS()
        {

            listLSP.DataSource = lsp.getData();
            tbMaNCC.DataSource = lsp.getNCC();
            tbMaNCC.DisplayMember = "MaNCC";
        }

        private void DanhMuc_Load(object sender, EventArgs e)
        {
            LoadDS();

        }

        private void btThem_Click(object sender, EventArgs e)
        {
            LoaiSP ls = new LoaiSP();
            ls.MaLoaiSP = tbMaLSP.Text;
            ls.TenLoaiSP = tbTenLSP.Text;
            ls.MoTa = tbMoTa.Text;
            ls.MaNCC = tbMaNCC.Text;
            string result = lsp.ThemLSP(ls);
            if (result == "1")
            {
                MessageBox.Show("Thêm loại sản phẩm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearTB();
                LoadDS();

            }
            else if (result == "-1")
            {
                MessageBox.Show("Các trường thông tin không được bỏ trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (result == "-2")
            {
                MessageBox.Show("Trùng mã loại sản phẩm.\nVui lòng thử lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Thêm thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void ClearTB()
        {
            tbMaLSP.Clear();
            tbTenLSP.Clear();
            tbMoTa.Clear();
            tbMaNCC.Text = "";
            tbTim.Clear();
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            LoaiSP ls = new LoaiSP();
            ls.MaLoaiSP = tbMaLSP.Text;
            ls.TenLoaiSP = tbTenLSP.Text;
            ls.MoTa = tbMoTa.Text;
            ls.MaNCC = tbMaNCC.Text;
            string result = lsp.SuaLSP(ls);
            if (result == "1")
            {
                MessageBox.Show("Sửa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearTB();
                LoadDS();

            }
            else if (result == "-1")
            {
                MessageBox.Show("Các trường thông tin không được bỏ trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Sửa thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btClear_Click(object sender, EventArgs e)
        {
            ClearTB();
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            string malsp = lsp.XoaLSP(tbMaLSP.Text);
            if (malsp == "-1")
            {
                MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                listLSP.DataSource = lsp.getData();
                ClearTB();
                LoadDS();
            }
            else
            {
                MessageBox.Show("Xóa thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void listLSP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < listLSP.Rows.Count)
            {
                int i = e.RowIndex;
                tbMaLSP.Text = listLSP[0, i].Value.ToString();
                tbTenLSP.Text = listLSP[1, i].Value.ToString();
                tbMoTa.Text = listLSP[2, i].Value.ToString();
                tbMaNCC.Text = listLSP[3, i].Value.ToString();
            }
            
        }



        private void btTim_Click(object sender, EventArgs e)
        {
            string keyword = tbTim.Text;
            listLSP.DataSource = lsp.TimKiemLSP(keyword);
        }

        private void tbMaNCC_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}