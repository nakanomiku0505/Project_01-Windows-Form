using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Speech.Synthesis.TtsEngine;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;

namespace Project_01.FunctionTab
{
    public partial class Buy : UserControl
    {
        BUS_KhachHang kh = new BUS_KhachHang();
        BUS_Buy b = new BUS_Buy();
        string lsp;
        public DataTable listKH()
        {
            return kh.getData();
        }
        public DataTable listLSP()
        {
            return b.getDataLSP();
        }
        public Buy()
        {
            InitializeComponent();
        }
        public DataTable listNV()
        {
            return b.getDataNV();
        }
        private void Buy_Load(object sender, EventArgs e)
        {
            LoadDT();
            
        }
        public void LoadDT()
        {
            cbTenKH.DataSource = listKH();
            cbTenKH.DisplayMember = "TenKH";
            cbLoaiSP.DataSource = listLSP();
            cbLoaiSP.DisplayMember = "MaLoaiSP";
            tbTru.Text = "0";
            cbNV.DataSource = listNV();
            cbNV.DisplayMember = "MaNV";
        }
        public DataTable listSP()
        {
            lsp = cbLoaiSP.Text;
            return b.getDataSP(lsp);
        }
        
        private void kryptonComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Trích xuất giá trị từ Combobox
            string selectedItem = cbTenKH.Text;

            // Lấy danh sách KhachHang
            List<KhachHang> khachHangList = GetKH();

            // Tìm đối tượng KhachHang có TenKH trùng khớp
            KhachHang selectedKhachHang = khachHangList.FirstOrDefault(kh => kh.TenKH == selectedItem);

            if (selectedKhachHang != null)
            {
                // Gán giá trị cho các Textbox tương ứng
                tbMaKH.Text = selectedKhachHang.MaKH;
                tbDC.Text = selectedKhachHang.DiaChi;
                tbSDT.Text = selectedKhachHang.SDT;
                tbEmail.Text = selectedKhachHang.Email;
            }
            else
            {
                // Nếu không tìm thấy KhachHang, xóa nội dung của các Textbox
                tbMaKH.Text = "";
                tbDC.Text = "";
                tbSDT.Text = "";
                tbEmail.Text = "";
            }
        }
        public List<KhachHang> GetKH()
        {
            List<KhachHang> khachHangList = listKH().AsEnumerable()
                .Select(row => new KhachHang
                {
                    MaKH = row.Field<string>("MaKH"),
                    TenKH = row.Field<string>("TenKH"),
                    DiaChi = row.Field<string>("DiaChi"),
                    SDT = row.Field<string>("SDT"),
                    Email = row.Field<string>("Email")
                })
                .ToList();
            return khachHangList;
        }
        public List<SP> GetSP()
        {
            List<SP> splist = listSP().AsEnumerable()
                .Select(row => new SP
                {
                    MaSP = row.Field<string>("MaSP"),
                    TenSP = row.Field<string>("TenSP"),
                    Gia = row.Field<int>("SL"),
                    Mota = row.Field<string>("Mota"),
                    SL = row.Field<int>("SL"),
                    MaLoaiSP = row.Field<string>("MaLoaiSP")
                })
                .ToList();
            return splist;
        }
        private void kryptonComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Kiểm tra xem có mục nào được chọn không
            if (cbTenSP.Text != "")
            {
                // Lấy giá trị của mục được chọn
                string selectedValue = cbTenSP.Text;

                // Tìm dòng chứa giá trị được chọn trong DataTable
                DataRow[] selectedRows = listSP().Select("TenSP = '" + selectedValue + "'");

                // Kiểm tra xem có dòng được tìm thấy không
                if (selectedRows.Length > 0)
                {
                    tbMaSP.Text = selectedRows[0]["MaSP"].ToString();
                    tbGia.Text = selectedRows[0]["Gia"].ToString();
                    tbSL.Text = selectedRows[0]["SL"].ToString();
                    tbMoTa.Text = selectedRows[0]["Mota"].ToString();

                }
                else
                {
                    tbMaSP.Text = "";
                    tbGia.Text = "";
                    tbSL.Text = "";
                    tbMoTa.Text = "";
                }
            }
            else if (cbTenSP.Text == null)
            {
                tbMaSP.Text = "";
                tbGia.Text = "";
                tbSL.Text = "";
                tbMoTa.Text = "";
            }
        }
        
        private void bunifuGroupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void cbLoaiSP_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedValue = cbLoaiSP.Text;

            // Tìm dòng chứa giá trị được chọn trong DataTable
            DataRow[] selectedRows = listLSP().Select("MaLoaiSP = '" + selectedValue + "'");

            // Kiểm tra xem có dòng được tìm thấy không
            if (selectedRows.Length > 0)
            {
                // Lấy giá trị từ cột khác trong dòng đầu tiên (ở đây giả sử cột có tên "OtherColumn")
                string otherValue = selectedRows[0]["TenLoaiSP"].ToString();

                // Đặt giá trị vào Label
                lbTenLSP.Text = otherValue;
            }
            cbTenSP.DataSource = listSP();
            cbTenSP.DisplayMember = "TenSP";
        }

        private void listBuy_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btThem_Click(object sender, EventArgs e)
        {
            string productCode = tbMaSP.Text;
            if (cbTenSP.Text == "")
            {
                MessageBox.Show("Vui lòng chọn 1 sản phẩm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if(tbSL.Text == "0")
            {
                MessageBox.Show("Trong kho đã hết sản phẩm này.\nVui lòng chọn sản phẩm khác.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if(numSL.Value == 0)
            {
                MessageBox.Show("Vui lòng chọn số lượng sản phẩm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            // Kiểm tra sản phẩm có bị trùng lặp trong giỏ hàng hay không
            else if (IsProductDuplicate(productCode))
            {
                MessageBox.Show("Sản phẩm đã tồn tại trong giỏ hàng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                
                listBuy.Rows.Add(cbLoaiSP.Text, tbMaSP.Text, cbTenSP.Text, tbGia.Text, tbMoTa.Text, numSL.Text) ;
                lbPrice.Text = TongTien().ToString();
                foreach (DataGridViewRow row in listBuy.Rows)
                {
                    int giaTriSanPham = Convert.ToInt32(row.Cells["Gia"].Value);
                    int soLuong = Convert.ToInt32(row.Cells["SL"].Value);
                    int tong = giaTriSanPham * soLuong;
                    row.Cells["Tong"].Value = tong;
                }
                
            }
        }

        private bool IsProductDuplicate(string productCode)
        {
            foreach (DataGridViewRow row in listBuy.Rows)
            {
                if (!row.IsNewRow)
                {
                    string existingProductCode = row.Cells["MaSP"].Value.ToString();
                    if (existingProductCode == productCode)
                    {
                        return true; // Sản phẩm đã tồn tại trong giỏ hàng
                    }
                }
            }
            return false; // Sản phẩm không trùng lặp trong giỏ hàng
        }

        private void numSL_ValueChanged(object sender, EventArgs e)
        {
            if (numSL.Value > Convert.ToInt32(tbSL.Text))
            {
                MessageBox.Show("Không được chọn quá số lượng trong kho.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                numSL.Value = Convert.ToInt32(tbSL.Text);
            }
        }

        private void btThem_ContextMenuStripChanged(object sender, EventArgs e)
        {

        }

        private void listBuy_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {

            foreach (DataGridViewRow row in listBuy.Rows)
            {
                int giaTriSanPham = Convert.ToInt32(row.Cells["Gia"].Value);
                int soLuong = Convert.ToInt32(row.Cells["SL"].Value);
                int tong = giaTriSanPham * soLuong;
                row.Cells["Tong"].Value = tong;
            }

            int sum = 0;

            foreach (DataGridViewRow row in listBuy.Rows)
            {
                if (!row.IsNewRow)
                {
                    int cellValue = Convert.ToInt32(row.Cells["Tong"].Value);
                    sum += cellValue;
                }
            }
            lbPrice.Text = sum.ToString();
        }

        private void listBuy_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void listBuy_CellValidated(object sender, DataGridViewCellEventArgs e)
        {
            
        }
        public int TongTien()
        {
            int tongTien = 0;

            foreach (DataGridViewRow row in listBuy.Rows)
            {
                if (!row.IsNewRow)
                {
                    int giaTriSanPham = Convert.ToInt32(row.Cells["Gia"].Value);
                    int soLuong = Convert.ToInt32(row.Cells["SL"].Value);

                    tongTien += giaTriSanPham * soLuong;
                }
            }

            return tongTien;
        }

        private void listBuy_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == listBuy.Columns["XoaInList"].Index && e.RowIndex >= 0)
            {
                DialogResult result = MessageBox.Show("Bạn có muốn xóa sản phẩm này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    DataGridViewRow row = listBuy.Rows[e.RowIndex];
                    listBuy.Rows.Remove(row);
                    lbPrice.Text = TongTien().ToString();
                    foreach (DataGridViewRow rows in listBuy.Rows)
                    {
                        int giaTriSanPham = Convert.ToInt32(rows.Cells["Gia"].Value);
                        int soLuong = Convert.ToInt32(rows.Cells["SL"].Value);
                        int tong = giaTriSanPham * soLuong;
                        row.Cells["Tong"].Value = tong;
                    }
                }
            }
            if (e.RowIndex >= 0 && e.RowIndex < listBuy.Rows.Count)
            {
                int i = e.RowIndex;
                cbLoaiSP.Text = listBuy[0, i].Value.ToString();
                tbMaSP.Text = listBuy[1, i].Value.ToString();
                cbTenSP.Text = listBuy[2, i].Value.ToString();
                tbGia.Text = listBuy[3, i].Value.ToString();
                tbMoTa.Text = listBuy[4, i].Value.ToString();
                numSL.Text = listBuy[5, i].Value.ToString();

            }
        }

        private void listBuy_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            listBuy.Rows.Clear();
            lbPrice.Text = TongTien().ToString();
            foreach (DataGridViewRow row in listBuy.Rows)
            {
                int giaTriSanPham = Convert.ToInt32(row.Cells["Gia"].Value);
                int soLuong = Convert.ToInt32(row.Cells["SL"].Value);
                int tong = giaTriSanPham * soLuong;
                row.Cells["Tong"].Value = tong;
            }
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            if (cbTenSP.Text == "")
            {
                MessageBox.Show("Vui lòng chọn 1 sản phẩm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (tbSL.Text == "0")
            {
                MessageBox.Show("Trong kho đã hết sản phẩm này.\nVui lòng chọn sản phẩm khác.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (numSL.Value == 0)
            {
                MessageBox.Show("Vui lòng chọn số lượng sản phẩm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {

                if (listBuy.SelectedRows.Count > 0)
                {
                    // Lấy hàng đang được sửa
                    DataGridViewRow selectedRow = listBuy.SelectedRows[0];

                    // Cập nhật các giá trị của hàng với các giá trị từ các điều khiển
                    selectedRow.Cells["MLSP"].Value = cbLoaiSP.Text;
                    selectedRow.Cells["MaSP"].Value = tbMaSP.Text;
                    selectedRow.Cells["TenSP"].Value = cbTenSP.Text;
                    selectedRow.Cells["Gia"].Value = tbGia.Text;
                    selectedRow.Cells["MoTa"].Value = tbMoTa.Text;
                    selectedRow.Cells["SL"].Value = numSL.Text;

                    // Hiển thị lại giá trị tổng tiền
                    lbPrice.Text = TongTien().ToString();
                    

                    // Hiển thị lại giá trị tổng tiền của từng hàng
                    foreach (DataGridViewRow row in listBuy.Rows)
                    {
                        int giaTriSanPham = Convert.ToInt32(row.Cells["Gia"].Value);
                        int soLuong = Convert.ToInt32(row.Cells["SL"].Value);
                        int tong = giaTriSanPham * soLuong;
                        row.Cells["Tong"].Value = tong;
                    }
                }
                else
                {
                    MessageBox.Show("Chưa có hàng nào được chọn.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btTru_Click(object sender, EventArgs e)
        {
            if (tbTru.Text == null)
            {
                MessageBox.Show("Vui lòng nhập số tiền muốn trừ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                discount();
            }
        }

        private void btGiamGia_Click(object sender, EventArgs e)
        {

            discount();
        }

        public void discount()
        {
            if (lbPrice.Text == "0" || lbPrice.Text == "price")
            {
                return;
            }
            else
            {
                decimal tt = 0;
                int giamgia = (int)numGiamGia.Value;
                int tru = Convert.ToInt32(tbTru.Text);
                tt = TongTien() - (TongTien() / 100 * giamgia) - tru;
                if (tt < 0)
                {
                    lbPrice.Text = "0";
                }
                else
                {
                    lbPrice.Text = tt.ToString();
                }
            }
        }

        private void tbTru_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbTru.Text))
            {
                tbTru.Text = "0";
            }
            if (tbTru.Text.Length > 1 && tbTru.Text.StartsWith("0"))
            {
                tbTru.Text = tbTru.Text.TrimStart('0');
            }
            tbTru.Select(tbTru.Text.Length, 0);
        }


        private void tbTru_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void cbNV_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedValue = cbNV.Text;

            // Tìm dòng chứa giá trị được chọn trong DataTable
            DataRow[] selectedRows = listNV().Select("MaNV = '" + selectedValue + "'");

            // Kiểm tra xem có dòng được tìm thấy không
            if (selectedRows.Length > 0)
            {
                // Lấy giá trị từ cột khác trong dòng đầu tiên (ở đây giả sử cột có tên "OtherColumn")
                string otherValue = selectedRows[0]["TenNV"].ToString();

                // Đặt giá trị vào Label
                tenNV.Text = otherValue;
            }
        }

        private void btThanhToan_Click(object sender, EventArgs e)
        {
            if (listBuy.Rows.Count < 1)
            {
                MessageBox.Show("Không có sản phẩm nào cần thanh toán.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                DialogResult result = MessageBox.Show("Bạn có muốn thanh toán ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                
                if (result == DialogResult.Yes)
                {
                    HoaDonBan hdb = new HoaDonBan();
                    hdb.MaNV = cbNV.Text;
                    hdb.MaKH = tbMaKH.Text;
                    var dateString2 = DateTime.Now.Date.ToString("yyyy-MM-dd");
                    hdb.NgayBan = dateString2;
                    hdb.TongTien = Convert.ToInt32(lbPrice.Text);
                    string rs = b.ThemHD(hdb);
                    foreach (DataGridViewRow row in listBuy.Rows)
                    {
                        if (!row.IsNewRow)
                        {
                            CTHDBan ct = new CTHDBan();
                            ct.MaSP = row.Cells[1].Value.ToString();
                            string sl = row.Cells[5].Value.ToString();
                            string gia= row.Cells[3].Value.ToString();
                            ct.SLBan = Convert.ToInt32(sl);
                            ct.GiaBan = Convert.ToInt32(gia);
                            b.ThemCTHD(ct);
                            SP s = new SP();
                            s.SL = Convert.ToInt32(sl);
                            s.MaSP = row.Cells[1].Value.ToString();
                            b.UpdateSLSP(s);
                        }
                    }
                    if (rs == "1")
                    {
                        DialogResult results = MessageBox.Show("Thanh toán thành công.\nBạn có muốn in hóa đơn?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                        if (results == DialogResult.Yes)
                        {
                            HoaDon hd = new HoaDon();
                            hd.Show();
                            hd.FormClosing += Hd_FormClosing;
                            
                        }
                        else
                        {
                            listBuy.Rows.Clear();
                            lbPrice.Text = "0";
                            LoadDT();
                        }
                        
                    }
                    else if(rs == "0")
                    {
                        MessageBox.Show("Lỗi CSDL.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                
            }
            
        }
        private void Hd_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Xóa danh sách các sản phẩm trong giỏ hàng
            listBuy.Rows.Clear();
            lbPrice.Text = "0";
            LoadDT();
            
        }

        private void lbPrice_Click(object sender, EventArgs e)
        {

        }
    }
}
