using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Services.Description;
using System.Windows.Documents;
using System.Windows.Forms;
using BUS;
using DTO;
namespace Project_01.FunctionTab
{
    public partial class QLSP : UserControl
    {
        BUS_SanPham sp = new BUS_SanPham();
        byte[] anh;
        public QLSP()
        {
            InitializeComponent();
        }

        private void bunifuTextBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void btClear_Click(object sender, EventArgs e)
        {
            ClearTB();
        }
        public void ClearTB()
        {
            tbMaSP.Clear();
            tbTenSP.Clear();
            tbMoTa.Clear();
            tbGia.Clear();
            tbSL.Clear();
            tbTim.Clear();
            cbLoaiSP.Text = "";
            lbTenLoaiSP.Text = "";
        }
        public void LoadDS()
        {
            listSP.DataSource = sp.getData();
        }

        private void QLSP_Load(object sender, EventArgs e)
        {
            cbLoaiSP.DataSource = sp.getLSP();
            cbLoaiSP.DisplayMember = "MaLoaiSP";
            
            LoadDS();
        }

        private void listSP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < listSP.Rows.Count)
            {
                int i = e.RowIndex;
                tbMaSP.Text = listSP[0, i].Value.ToString();
                tbTenSP.Text = listSP[1, i].Value.ToString();
                tbGia.Text = listSP[2, i].Value.ToString();
                tbMoTa.Text = listSP[3, i].Value.ToString();
                if (listSP[4, i].Value != null)
                {
                    anh = (byte[])listSP[4, i].Value;
                }
                else
                {
                    anh=null;
                }
                tbSL.Text = listSP[5, i].Value.ToString();
                cbLoaiSP.Text = listSP[6, i].Value.ToString();
            }
        }

        private void cbLoaiSP_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedValue = cbLoaiSP.Text;

            // Tìm dòng chứa giá trị được chọn trong DataTable
            DataRow[] selectedRows = sp.getLSP().Select("MaLoaiSP = '" + selectedValue + "'");

            // Kiểm tra xem có dòng được tìm thấy không
            if (selectedRows.Length > 0)
            {
                // Lấy giá trị từ cột khác trong dòng đầu tiên (ở đây giả sử cột có tên "OtherColumn")
                string otherValue = selectedRows[0]["TenLoaiSP"].ToString();

                // Đặt giá trị vào Label
                lbTenLSP.Text = otherValue;
            }
        }
        

        private void btThem_Click(object sender, EventArgs e)

        {
            
            SP ls = new SP();
            ls.MaSP = tbMaSP.Text;
            ls.TenSP = tbTenSP.Text;
            ls.Gia = Convert.ToInt32(tbGia.Text);
            ls.Mota = tbMoTa.Text;
            ls.SL = int.Parse(tbSL.Text);
            ls.MaLoaiSP = cbLoaiSP.Text;
            string result = sp.ThemSP(ls);
            if (result == "1")
            {
                MessageBox.Show("Thêm sản phẩm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDS();
                ClearTB();

            }
            else if (result == "-1")
            {
                MessageBox.Show("Các trường thông tin không được bỏ trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (result == "-2")
            {
                MessageBox.Show("Trùng mã sản phẩm.\nVui lòng thử lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (result == "-3")
            {
                MessageBox.Show("Đã có sản phẩm này.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Thêm thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            if (tbMaSP.Text == "")
            {
                MessageBox.Show("Chưa chọn sản phẩm nào.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                SP ls = new SP();
                ls.MaSP = tbMaSP.Text;
                ls.TenSP = tbTenSP.Text;
                ls.Gia = int.Parse(tbGia.Text);
                ls.Mota = tbMoTa.Text;
                ls.SL = int.Parse(tbSL.Text);
                ls.MaLoaiSP = cbLoaiSP.Text;
                string result = sp.SuaSP(ls);
                if (result == "1")
                {
                    MessageBox.Show("Sửa sản phẩm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDS();
                    ClearTB();

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
            
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            string masp = sp.XoaSP(tbMaSP.Text);
            if (masp == "-1")
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
            listSP.DataSource = sp.TimKiemSP(keyword);
        }

        private void lbTenLSP_Click(object sender, EventArgs e)
        {

        }
    }
}
