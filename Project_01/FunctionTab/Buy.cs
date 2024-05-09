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
    public partial class Buy : UserControl
    {
        BUS_LoaiSP lsp = new BUS_LoaiSP();
        BUS_SanPham sp = new BUS_SanPham();
        BUS_KhachHang kh = new BUS_KhachHang();
        
        public DataTable listKH()
        {
            return kh.getData();
        }

        public Buy()
        {
            InitializeComponent();
        }

        private void Buy_Load(object sender, EventArgs e)
        {
            cbTenKH.DataSource = listKH();
            cbTenKH.DisplayMember = "TenKH";
        }
        private void kryptonComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
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
    }
}
