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
using System.Windows.Forms.DataVisualization.Charting;
using BUS;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using DTO;
namespace Project_01.FunctionTab
{
    public partial class ThongKe : UserControl
    {
        
        BUS_HD_TK hd = new BUS_HD_TK();
        public ThongKe()
        {
            InitializeComponent();
        }
        public DataTable dsHD()
        {
            return hd.getDataHD();
        }
        public DataTable dsCTHD(string ma)
        {
            return hd.getCTHD(ma);
        }
        public DataTable getSLSPBan()
        {
            return hd.getSLSPBan();
        }
        public DataTable getDoanhThu(int m,int y)
        {
            return hd.getDoanhThu(m, y);
        }
        public DataTable getDataHDTheoDate(int m, int y)
        {
            return hd.getDataHDTheoDate(m, y);

        }
        public DataTable getDataHDTheoMa(string ma)
        {
            return hd.getDataHDTheoMa(ma);
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        public void LoadDS()
        {
            listHD.DataSource = dsHD();
            dtPickerThang.Format = DateTimePickerFormat.Custom;
            dtPickerThang.CustomFormat = "MM/yyyy";
        }

        private void ThongKe_Load(object sender, EventArgs e)
        {
            LoadDS();
            chartSP();
        }

        private void listHD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < listHD.Rows.Count)
            {
                int i = e.RowIndex;
                string ma = listHD[0, i].Value.ToString();
                SaveMa.ma = ma;
                lbMa.Text = ma;
                listCTHD.DataSource = dsCTHD(ma);
            }
        }

        private void bunifuDatePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime selectedDate = dtPickerThang.Value;
            int month = selectedDate.Month;
            int year = selectedDate.Year;
            DataTable dt = getDoanhThu(month, year);
            SaveDate.month = month; SaveDate.year = year;
            chartDoanhThu.Series.Clear();
            // Tạo một loạt dữ liệu mới
            Series series = new Series("Doanh thu");
            series.ChartType = SeriesChartType.Column; // Loại biểu đồ cột

            
            foreach (DataRow row in dt.Rows)
            {
                int productName = Convert.ToInt32(row["Ngay"]);
                int qtySold = Convert.ToInt32(row["DoanhThu"]);
                series.Points.AddXY(productName, qtySold);
            }

            // Thêm loạt dữ liệu vào biểu đồ
            chartDoanhThu.Series.Add(series);

            // Cấu hình các thuộc tính cho biểu đồ tròn
            ChartArea chartArea = chartDoanhThu.ChartAreas["ChartArea1"];
            chartArea.AxisX.Title = "Ngày";
            chartArea.AxisY.Title = "VNĐ";

            series.IsValueShownAsLabel = true; // Hiển thị giá trị trên biểu đồ

            

            DataTable ds = getDataHDTheoDate(month, year);
            listHD.DataSource = ds;
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
        public void chartSP()
        {
            // Tạo một loạt dữ liệu mới
            Series series = new Series("Sản phẩm bán");
            series.ChartType = SeriesChartType.Doughnut; // Loại biểu đồ tròn

            // Thêm dữ liệu vào loạt dữ liệu mới từ DataTable
            DataTable dataTable = getSLSPBan();
            foreach (DataRow row in dataTable.Rows)
            {
                string productName = row["TenSP"].ToString();
                int qtySold = Convert.ToInt32(row["SLBan"]);
                series.Points.AddXY(productName, qtySold);
            }

            // Thêm loạt dữ liệu vào biểu đồ
            chartSPBan.Series.Add(series);

            // Cấu hình các thuộc tính cho biểu đồ tròn
            ChartArea chartArea = chartSPBan.ChartAreas["ChartArea1"];
            chartArea.AxisX.Title = "Tên Sản Phẩm";
            chartArea.AxisY.Title = "Số lượng đã bán";

            series.IsValueShownAsLabel = true; // Hiển thị giá trị trên biểu đồ
        }

        private void btClear_Click(object sender, EventArgs e)
        {
            lbMa.Text = "MaHDB";
            string ma = "";
            listCTHD.DataSource = dsCTHD(ma);
            listHD.DataSource = dsHD();
            chartDoanhThu.Series.Clear();
        }
        private void btThanhToan_Click(object sender, EventArgs e)
        {
            
            HoaDonTK hoaDonTK = new HoaDonTK();
            hoaDonTK.Show();
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            HoaDonMonth hd = new HoaDonMonth();
            hd.Show();
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            if (lbMa.Text == "MaHDB")
            {
                MessageBox.Show("Chưa chọn bất kì hóa đơn nào.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                string macthd = hd.XoaCTHD(lbMa.Text);

                if (macthd == "1")
                {
                    string mahd = hd.XoaHD(lbMa.Text);
                    if (mahd == "1")
                    {
                        MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        lbMa.Text = "MaHDB";
                        string ma = "";
                        listCTHD.DataSource = dsCTHD(ma);
                        chartDoanhThu.Series.Clear();
                        LoadDS();
                    }
                    else
                    {
                        MessageBox.Show("Xóa thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                else
                {
                    MessageBox.Show("Xóa thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
        }
    }
}
