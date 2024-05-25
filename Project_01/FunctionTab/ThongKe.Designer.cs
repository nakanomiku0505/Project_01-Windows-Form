namespace Project_01.FunctionTab
{
    partial class ThongKe
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ThongKe));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges4 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.chartSPBan = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartDoanhThu = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.listHD = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.MaHDB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TongTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.listCTHD = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.MaHDBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SLBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbDoanhThu = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btReset = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btXoa = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btHDMonth = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btHD = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.dtPickerThang = new Bunifu.UI.WinForms.BunifuDatePicker();
            this.lbMa = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chartSPBan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartDoanhThu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listHD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listCTHD)).BeginInit();
            this.SuspendLayout();
            // 
            // chartSPBan
            // 
            this.chartSPBan.BorderlineColor = System.Drawing.Color.Transparent;
            chartArea1.Name = "ChartArea1";
            this.chartSPBan.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartSPBan.Legends.Add(legend1);
            this.chartSPBan.Location = new System.Drawing.Point(671, 111);
            this.chartSPBan.Name = "chartSPBan";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartSPBan.Series.Add(series1);
            this.chartSPBan.Size = new System.Drawing.Size(464, 216);
            this.chartSPBan.TabIndex = 0;
            this.chartSPBan.Text = "chart1";
            this.chartSPBan.Click += new System.EventHandler(this.chart1_Click);
            // 
            // chartDoanhThu
            // 
            chartArea2.Name = "ChartArea1";
            this.chartDoanhThu.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartDoanhThu.Legends.Add(legend2);
            this.chartDoanhThu.Location = new System.Drawing.Point(16, 111);
            this.chartDoanhThu.Name = "chartDoanhThu";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Doanh thu";
            this.chartDoanhThu.Series.Add(series2);
            this.chartDoanhThu.Size = new System.Drawing.Size(557, 216);
            this.chartDoanhThu.TabIndex = 1;
            this.chartDoanhThu.Text = "chart2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label1.Location = new System.Drawing.Point(455, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(258, 37);
            this.label1.TabIndex = 2;
            this.label1.Text = "Hóa đơn - Thống kê";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // listHD
            // 
            this.listHD.AllowCustomTheming = false;
            this.listHD.AllowUserToAddRows = false;
            this.listHD.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.listHD.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.listHD.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.listHD.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listHD.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.listHD.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.listHD.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.listHD.ColumnHeadersHeight = 40;
            this.listHD.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaHDB,
            this.MaNV,
            this.KH,
            this.NgayBan,
            this.TongTien});
            this.listHD.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.listHD.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.listHD.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.listHD.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.listHD.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.listHD.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.listHD.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.listHD.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.listHD.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.listHD.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.listHD.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            this.listHD.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.listHD.CurrentTheme.Name = null;
            this.listHD.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.listHD.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.listHD.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.listHD.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.listHD.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.listHD.DefaultCellStyle = dataGridViewCellStyle3;
            this.listHD.EnableHeadersVisualStyles = false;
            this.listHD.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.listHD.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.listHD.HeaderBgColor = System.Drawing.Color.Empty;
            this.listHD.HeaderForeColor = System.Drawing.Color.White;
            this.listHD.Location = new System.Drawing.Point(0, 418);
            this.listHD.Name = "listHD";
            this.listHD.ReadOnly = true;
            this.listHD.RowHeadersVisible = false;
            this.listHD.RowTemplate.Height = 40;
            this.listHD.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.listHD.Size = new System.Drawing.Size(576, 236);
            this.listHD.TabIndex = 24;
            this.listHD.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            this.listHD.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.listHD_CellClick);
            // 
            // MaHDB
            // 
            this.MaHDB.DataPropertyName = "MaHDB";
            this.MaHDB.HeaderText = "Mã hóa đơn";
            this.MaHDB.Name = "MaHDB";
            this.MaHDB.ReadOnly = true;
            // 
            // MaNV
            // 
            this.MaNV.DataPropertyName = "MaNV";
            this.MaNV.HeaderText = "Mã NV";
            this.MaNV.Name = "MaNV";
            this.MaNV.ReadOnly = true;
            // 
            // KH
            // 
            this.KH.DataPropertyName = "TenKH";
            this.KH.HeaderText = "Khách hàng";
            this.KH.Name = "KH";
            this.KH.ReadOnly = true;
            // 
            // NgayBan
            // 
            this.NgayBan.DataPropertyName = "NgayBan";
            this.NgayBan.HeaderText = "Ngày bán";
            this.NgayBan.Name = "NgayBan";
            this.NgayBan.ReadOnly = true;
            // 
            // TongTien
            // 
            this.TongTien.DataPropertyName = "TongTien";
            this.TongTien.HeaderText = "Thành tiền";
            this.TongTien.Name = "TongTien";
            this.TongTien.ReadOnly = true;
            // 
            // listCTHD
            // 
            this.listCTHD.AllowCustomTheming = false;
            this.listCTHD.AllowUserToAddRows = false;
            this.listCTHD.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            this.listCTHD.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.listCTHD.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.listCTHD.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listCTHD.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.listCTHD.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.listCTHD.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.listCTHD.ColumnHeadersHeight = 40;
            this.listCTHD.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaHDBan,
            this.MaSP,
            this.TenSP,
            this.SLBan,
            this.GiaBan});
            this.listCTHD.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.listCTHD.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.listCTHD.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.listCTHD.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.listCTHD.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.listCTHD.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.listCTHD.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.listCTHD.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.listCTHD.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.listCTHD.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.listCTHD.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            this.listCTHD.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.listCTHD.CurrentTheme.Name = null;
            this.listCTHD.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.listCTHD.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.listCTHD.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.listCTHD.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.listCTHD.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.listCTHD.DefaultCellStyle = dataGridViewCellStyle6;
            this.listCTHD.EnableHeadersVisualStyles = false;
            this.listCTHD.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.listCTHD.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.listCTHD.HeaderBgColor = System.Drawing.Color.Empty;
            this.listCTHD.HeaderForeColor = System.Drawing.Color.White;
            this.listCTHD.Location = new System.Drawing.Point(579, 418);
            this.listCTHD.Name = "listCTHD";
            this.listCTHD.ReadOnly = true;
            this.listCTHD.RowHeadersVisible = false;
            this.listCTHD.RowTemplate.Height = 40;
            this.listCTHD.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.listCTHD.Size = new System.Drawing.Size(575, 236);
            this.listCTHD.TabIndex = 25;
            this.listCTHD.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            // 
            // MaHDBan
            // 
            this.MaHDBan.DataPropertyName = "MaHDB";
            this.MaHDBan.HeaderText = "Mã HDB";
            this.MaHDBan.Name = "MaHDBan";
            this.MaHDBan.ReadOnly = true;
            this.MaHDBan.Visible = false;
            // 
            // MaSP
            // 
            this.MaSP.DataPropertyName = "MaSP";
            this.MaSP.HeaderText = "Mã SP";
            this.MaSP.Name = "MaSP";
            this.MaSP.ReadOnly = true;
            // 
            // TenSP
            // 
            this.TenSP.DataPropertyName = "TenSP";
            this.TenSP.HeaderText = "Tên SP";
            this.TenSP.Name = "TenSP";
            this.TenSP.ReadOnly = true;
            // 
            // SLBan
            // 
            this.SLBan.DataPropertyName = "SLBan";
            this.SLBan.HeaderText = "Số lượng";
            this.SLBan.Name = "SLBan";
            this.SLBan.ReadOnly = true;
            // 
            // GiaBan
            // 
            this.GiaBan.DataPropertyName = "GiaBan";
            this.GiaBan.HeaderText = "Giá";
            this.GiaBan.Name = "GiaBan";
            this.GiaBan.ReadOnly = true;
            // 
            // lbDoanhThu
            // 
            this.lbDoanhThu.AutoSize = true;
            this.lbDoanhThu.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbDoanhThu.Location = new System.Drawing.Point(144, 69);
            this.lbDoanhThu.Name = "lbDoanhThu";
            this.lbDoanhThu.Size = new System.Drawing.Size(289, 30);
            this.lbDoanhThu.TabIndex = 36;
            this.lbDoanhThu.Text = "Biểu đồ doanh thu theo ngày";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(772, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(265, 30);
            this.label2.TabIndex = 37;
            this.label2.Text = "Số lượng sản phẩm bán ra";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(26, 342);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(180, 30);
            this.label3.TabIndex = 38;
            this.label3.Text = "Chọn tháng/năm:";
            // 
            // btReset
            // 
            this.btReset.AllowAnimations = true;
            this.btReset.AllowMouseEffects = true;
            this.btReset.AllowToggling = false;
            this.btReset.AnimationSpeed = 200;
            this.btReset.AutoGenerateColors = false;
            this.btReset.AutoRoundBorders = false;
            this.btReset.AutoSizeLeftIcon = true;
            this.btReset.AutoSizeRightIcon = true;
            this.btReset.BackColor = System.Drawing.Color.Transparent;
            this.btReset.BackColor1 = System.Drawing.Color.Teal;
            this.btReset.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btReset.BackgroundImage")));
            this.btReset.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btReset.ButtonText = "Reset";
            this.btReset.ButtonTextMarginLeft = 0;
            this.btReset.ColorContrastOnClick = 45;
            this.btReset.ColorContrastOnHover = 45;
            this.btReset.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btReset.CustomizableEdges = borderEdges1;
            this.btReset.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btReset.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btReset.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btReset.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btReset.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btReset.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btReset.ForeColor = System.Drawing.Color.White;
            this.btReset.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btReset.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btReset.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btReset.IconMarginLeft = 11;
            this.btReset.IconPadding = 10;
            this.btReset.IconRightAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btReset.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btReset.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btReset.IconSize = 25;
            this.btReset.IdleBorderColor = System.Drawing.Color.Teal;
            this.btReset.IdleBorderRadius = 10;
            this.btReset.IdleBorderThickness = 5;
            this.btReset.IdleFillColor = System.Drawing.Color.Teal;
            this.btReset.IdleIconLeftImage = global::Project_01.Properties.Resources.icons8_refresh_96;
            this.btReset.IdleIconRightImage = null;
            this.btReset.IndicateFocus = false;
            this.btReset.Location = new System.Drawing.Point(579, 342);
            this.btReset.Name = "btReset";
            this.btReset.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btReset.OnDisabledState.BorderRadius = 10;
            this.btReset.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btReset.OnDisabledState.BorderThickness = 5;
            this.btReset.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btReset.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btReset.OnDisabledState.IconLeftImage = null;
            this.btReset.OnDisabledState.IconRightImage = null;
            this.btReset.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btReset.onHoverState.BorderRadius = 10;
            this.btReset.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btReset.onHoverState.BorderThickness = 5;
            this.btReset.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btReset.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btReset.onHoverState.IconLeftImage = null;
            this.btReset.onHoverState.IconRightImage = null;
            this.btReset.OnIdleState.BorderColor = System.Drawing.Color.Teal;
            this.btReset.OnIdleState.BorderRadius = 10;
            this.btReset.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btReset.OnIdleState.BorderThickness = 5;
            this.btReset.OnIdleState.FillColor = System.Drawing.Color.Teal;
            this.btReset.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btReset.OnIdleState.IconLeftImage = global::Project_01.Properties.Resources.icons8_refresh_96;
            this.btReset.OnIdleState.IconRightImage = null;
            this.btReset.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btReset.OnPressedState.BorderRadius = 10;
            this.btReset.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btReset.OnPressedState.BorderThickness = 5;
            this.btReset.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btReset.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btReset.OnPressedState.IconLeftImage = null;
            this.btReset.OnPressedState.IconRightImage = null;
            this.btReset.Size = new System.Drawing.Size(112, 39);
            this.btReset.TabIndex = 42;
            this.btReset.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btReset.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btReset.TextMarginLeft = 0;
            this.btReset.TextPadding = new System.Windows.Forms.Padding(0);
            this.btReset.UseDefaultRadiusAndThickness = true;
            this.btReset.Click += new System.EventHandler(this.btClear_Click);
            // 
            // btXoa
            // 
            this.btXoa.AllowAnimations = true;
            this.btXoa.AllowMouseEffects = true;
            this.btXoa.AllowToggling = false;
            this.btXoa.AnimationSpeed = 200;
            this.btXoa.AutoGenerateColors = false;
            this.btXoa.AutoRoundBorders = false;
            this.btXoa.AutoSizeLeftIcon = true;
            this.btXoa.AutoSizeRightIcon = true;
            this.btXoa.BackColor = System.Drawing.Color.Transparent;
            this.btXoa.BackColor1 = System.Drawing.Color.DodgerBlue;
            this.btXoa.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btXoa.BackgroundImage")));
            this.btXoa.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btXoa.ButtonText = "Xóa";
            this.btXoa.ButtonTextMarginLeft = 0;
            this.btXoa.ColorContrastOnClick = 45;
            this.btXoa.ColorContrastOnHover = 45;
            this.btXoa.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.btXoa.CustomizableEdges = borderEdges2;
            this.btXoa.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btXoa.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btXoa.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btXoa.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btXoa.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btXoa.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btXoa.ForeColor = System.Drawing.Color.White;
            this.btXoa.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btXoa.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btXoa.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btXoa.IconMarginLeft = 11;
            this.btXoa.IconPadding = 10;
            this.btXoa.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btXoa.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btXoa.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btXoa.IconSize = 25;
            this.btXoa.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.btXoa.IdleBorderRadius = 10;
            this.btXoa.IdleBorderThickness = 5;
            this.btXoa.IdleFillColor = System.Drawing.Color.DodgerBlue;
            this.btXoa.IdleIconLeftImage = global::Project_01.Properties.Resources.icons8_delete_96;
            this.btXoa.IdleIconRightImage = null;
            this.btXoa.IndicateFocus = false;
            this.btXoa.Location = new System.Drawing.Point(461, 342);
            this.btXoa.Name = "btXoa";
            this.btXoa.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btXoa.OnDisabledState.BorderRadius = 10;
            this.btXoa.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btXoa.OnDisabledState.BorderThickness = 5;
            this.btXoa.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btXoa.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btXoa.OnDisabledState.IconLeftImage = null;
            this.btXoa.OnDisabledState.IconRightImage = null;
            this.btXoa.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btXoa.onHoverState.BorderRadius = 10;
            this.btXoa.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btXoa.onHoverState.BorderThickness = 5;
            this.btXoa.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btXoa.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btXoa.onHoverState.IconLeftImage = null;
            this.btXoa.onHoverState.IconRightImage = null;
            this.btXoa.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btXoa.OnIdleState.BorderRadius = 10;
            this.btXoa.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btXoa.OnIdleState.BorderThickness = 5;
            this.btXoa.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.btXoa.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btXoa.OnIdleState.IconLeftImage = global::Project_01.Properties.Resources.icons8_delete_96;
            this.btXoa.OnIdleState.IconRightImage = null;
            this.btXoa.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btXoa.OnPressedState.BorderRadius = 10;
            this.btXoa.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btXoa.OnPressedState.BorderThickness = 5;
            this.btXoa.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btXoa.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btXoa.OnPressedState.IconLeftImage = null;
            this.btXoa.OnPressedState.IconRightImage = null;
            this.btXoa.Size = new System.Drawing.Size(112, 39);
            this.btXoa.TabIndex = 41;
            this.btXoa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btXoa.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btXoa.TextMarginLeft = 0;
            this.btXoa.TextPadding = new System.Windows.Forms.Padding(0);
            this.btXoa.UseDefaultRadiusAndThickness = true;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // btHDMonth
            // 
            this.btHDMonth.AllowAnimations = true;
            this.btHDMonth.AllowMouseEffects = true;
            this.btHDMonth.AllowToggling = false;
            this.btHDMonth.AnimationSpeed = 200;
            this.btHDMonth.AutoGenerateColors = false;
            this.btHDMonth.AutoRoundBorders = false;
            this.btHDMonth.AutoSizeLeftIcon = true;
            this.btHDMonth.AutoSizeRightIcon = true;
            this.btHDMonth.BackColor = System.Drawing.Color.Transparent;
            this.btHDMonth.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btHDMonth.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btHDMonth.BackgroundImage")));
            this.btHDMonth.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btHDMonth.ButtonText = "         In hóa đơn\r\n         của tháng";
            this.btHDMonth.ButtonTextMarginLeft = 0;
            this.btHDMonth.ColorContrastOnClick = 45;
            this.btHDMonth.ColorContrastOnHover = 45;
            this.btHDMonth.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges3.BottomLeft = true;
            borderEdges3.BottomRight = true;
            borderEdges3.TopLeft = true;
            borderEdges3.TopRight = true;
            this.btHDMonth.CustomizableEdges = borderEdges3;
            this.btHDMonth.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btHDMonth.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btHDMonth.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btHDMonth.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btHDMonth.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btHDMonth.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btHDMonth.ForeColor = System.Drawing.Color.Black;
            this.btHDMonth.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btHDMonth.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btHDMonth.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btHDMonth.IconMarginLeft = 11;
            this.btHDMonth.IconPadding = 20;
            this.btHDMonth.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btHDMonth.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btHDMonth.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btHDMonth.IconSize = 10;
            this.btHDMonth.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btHDMonth.IdleBorderRadius = 10;
            this.btHDMonth.IdleBorderThickness = 5;
            this.btHDMonth.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btHDMonth.IdleIconLeftImage = global::Project_01.Properties.Resources.icons8_print_100;
            this.btHDMonth.IdleIconRightImage = null;
            this.btHDMonth.IndicateFocus = false;
            this.btHDMonth.Location = new System.Drawing.Point(984, 342);
            this.btHDMonth.Name = "btHDMonth";
            this.btHDMonth.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btHDMonth.OnDisabledState.BorderRadius = 10;
            this.btHDMonth.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btHDMonth.OnDisabledState.BorderThickness = 5;
            this.btHDMonth.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btHDMonth.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btHDMonth.OnDisabledState.IconLeftImage = null;
            this.btHDMonth.OnDisabledState.IconRightImage = null;
            this.btHDMonth.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btHDMonth.onHoverState.BorderRadius = 10;
            this.btHDMonth.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btHDMonth.onHoverState.BorderThickness = 5;
            this.btHDMonth.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btHDMonth.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btHDMonth.onHoverState.IconLeftImage = null;
            this.btHDMonth.onHoverState.IconRightImage = null;
            this.btHDMonth.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btHDMonth.OnIdleState.BorderRadius = 10;
            this.btHDMonth.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btHDMonth.OnIdleState.BorderThickness = 5;
            this.btHDMonth.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btHDMonth.OnIdleState.ForeColor = System.Drawing.Color.Black;
            this.btHDMonth.OnIdleState.IconLeftImage = global::Project_01.Properties.Resources.icons8_print_100;
            this.btHDMonth.OnIdleState.IconRightImage = null;
            this.btHDMonth.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btHDMonth.OnPressedState.BorderRadius = 10;
            this.btHDMonth.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btHDMonth.OnPressedState.BorderThickness = 5;
            this.btHDMonth.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btHDMonth.OnPressedState.ForeColor = System.Drawing.Color.Gray;
            this.btHDMonth.OnPressedState.IconLeftImage = null;
            this.btHDMonth.OnPressedState.IconRightImage = null;
            this.btHDMonth.Size = new System.Drawing.Size(130, 70);
            this.btHDMonth.TabIndex = 40;
            this.btHDMonth.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btHDMonth.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btHDMonth.TextMarginLeft = 0;
            this.btHDMonth.TextPadding = new System.Windows.Forms.Padding(0);
            this.btHDMonth.UseDefaultRadiusAndThickness = true;
            this.btHDMonth.Click += new System.EventHandler(this.bunifuButton1_Click);
            // 
            // btHD
            // 
            this.btHD.AllowAnimations = true;
            this.btHD.AllowMouseEffects = true;
            this.btHD.AllowToggling = false;
            this.btHD.AnimationSpeed = 200;
            this.btHD.AutoGenerateColors = false;
            this.btHD.AutoRoundBorders = false;
            this.btHD.AutoSizeLeftIcon = true;
            this.btHD.AutoSizeRightIcon = true;
            this.btHD.BackColor = System.Drawing.Color.Transparent;
            this.btHD.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btHD.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btHD.BackgroundImage")));
            this.btHD.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btHD.ButtonText = "          In hóa đơn\r\n          đang chọn";
            this.btHD.ButtonTextMarginLeft = 0;
            this.btHD.ColorContrastOnClick = 45;
            this.btHD.ColorContrastOnHover = 45;
            this.btHD.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges4.BottomLeft = true;
            borderEdges4.BottomRight = true;
            borderEdges4.TopLeft = true;
            borderEdges4.TopRight = true;
            this.btHD.CustomizableEdges = borderEdges4;
            this.btHD.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btHD.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btHD.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btHD.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btHD.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btHD.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btHD.ForeColor = System.Drawing.Color.Black;
            this.btHD.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btHD.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btHD.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btHD.IconMarginLeft = 11;
            this.btHD.IconPadding = 20;
            this.btHD.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btHD.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btHD.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btHD.IconSize = 10;
            this.btHD.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btHD.IdleBorderRadius = 10;
            this.btHD.IdleBorderThickness = 5;
            this.btHD.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btHD.IdleIconLeftImage = global::Project_01.Properties.Resources.icons8_print_100;
            this.btHD.IdleIconRightImage = null;
            this.btHD.IndicateFocus = false;
            this.btHD.Location = new System.Drawing.Point(800, 342);
            this.btHD.Name = "btHD";
            this.btHD.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btHD.OnDisabledState.BorderRadius = 10;
            this.btHD.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btHD.OnDisabledState.BorderThickness = 5;
            this.btHD.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btHD.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btHD.OnDisabledState.IconLeftImage = null;
            this.btHD.OnDisabledState.IconRightImage = null;
            this.btHD.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btHD.onHoverState.BorderRadius = 10;
            this.btHD.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btHD.onHoverState.BorderThickness = 5;
            this.btHD.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btHD.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btHD.onHoverState.IconLeftImage = null;
            this.btHD.onHoverState.IconRightImage = null;
            this.btHD.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btHD.OnIdleState.BorderRadius = 10;
            this.btHD.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btHD.OnIdleState.BorderThickness = 5;
            this.btHD.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btHD.OnIdleState.ForeColor = System.Drawing.Color.Black;
            this.btHD.OnIdleState.IconLeftImage = global::Project_01.Properties.Resources.icons8_print_100;
            this.btHD.OnIdleState.IconRightImage = null;
            this.btHD.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btHD.OnPressedState.BorderRadius = 10;
            this.btHD.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btHD.OnPressedState.BorderThickness = 5;
            this.btHD.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btHD.OnPressedState.ForeColor = System.Drawing.Color.Gray;
            this.btHD.OnPressedState.IconLeftImage = null;
            this.btHD.OnPressedState.IconRightImage = null;
            this.btHD.Size = new System.Drawing.Size(130, 70);
            this.btHD.TabIndex = 39;
            this.btHD.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btHD.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btHD.TextMarginLeft = 0;
            this.btHD.TextPadding = new System.Windows.Forms.Padding(0);
            this.btHD.UseDefaultRadiusAndThickness = true;
            this.btHD.Click += new System.EventHandler(this.btThanhToan_Click);
            // 
            // dtPickerThang
            // 
            this.dtPickerThang.BackColor = System.Drawing.Color.Transparent;
            this.dtPickerThang.BorderRadius = 4;
            this.dtPickerThang.Color = System.Drawing.Color.Silver;
            this.dtPickerThang.DateBorderThickness = Bunifu.UI.WinForms.BunifuDatePicker.BorderThickness.Thick;
            this.dtPickerThang.DateTextAlign = Bunifu.UI.WinForms.BunifuDatePicker.TextAlign.Left;
            this.dtPickerThang.DisabledColor = System.Drawing.Color.Gray;
            this.dtPickerThang.DisplayWeekNumbers = false;
            this.dtPickerThang.DPHeight = 0;
            this.dtPickerThang.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtPickerThang.FillDatePicker = false;
            this.dtPickerThang.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtPickerThang.ForeColor = System.Drawing.Color.Black;
            this.dtPickerThang.Icon = ((System.Drawing.Image)(resources.GetObject("dtPickerThang.Icon")));
            this.dtPickerThang.IconColor = System.Drawing.Color.Gray;
            this.dtPickerThang.IconLocation = Bunifu.UI.WinForms.BunifuDatePicker.Indicator.Right;
            this.dtPickerThang.LeftTextMargin = 5;
            this.dtPickerThang.Location = new System.Drawing.Point(212, 345);
            this.dtPickerThang.MinimumSize = new System.Drawing.Size(4, 32);
            this.dtPickerThang.Name = "dtPickerThang";
            this.dtPickerThang.Size = new System.Drawing.Size(220, 32);
            this.dtPickerThang.TabIndex = 26;
            this.dtPickerThang.Value = new System.DateTime(2024, 5, 23, 21, 11, 0, 0);
            this.dtPickerThang.ValueChanged += new System.EventHandler(this.bunifuDatePicker1_ValueChanged);
            // 
            // lbMa
            // 
            this.lbMa.AutoSize = true;
            this.lbMa.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbMa.Location = new System.Drawing.Point(582, 398);
            this.lbMa.Name = "lbMa";
            this.lbMa.Size = new System.Drawing.Size(54, 17);
            this.lbMa.TabIndex = 43;
            this.lbMa.Text = "MaHDB";
            // 
            // ThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbMa);
            this.Controls.Add(this.btReset);
            this.Controls.Add(this.btXoa);
            this.Controls.Add(this.btHDMonth);
            this.Controls.Add(this.btHD);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbDoanhThu);
            this.Controls.Add(this.dtPickerThang);
            this.Controls.Add(this.listCTHD);
            this.Controls.Add(this.listHD);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chartDoanhThu);
            this.Controls.Add(this.chartSPBan);
            this.Name = "ThongKe";
            this.Size = new System.Drawing.Size(1154, 654);
            this.Load += new System.EventHandler(this.ThongKe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartSPBan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartDoanhThu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listHD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listCTHD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartSPBan;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartDoanhThu;
        private System.Windows.Forms.Label label1;
        private Bunifu.UI.WinForms.BunifuDataGridView listHD;
        private Bunifu.UI.WinForms.BunifuDataGridView listCTHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHDB;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn KH;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn TongTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHDBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn SLBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaBan;
        private Bunifu.UI.WinForms.BunifuDatePicker dtPickerThang;
        private System.Windows.Forms.Label lbDoanhThu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btHD;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btHDMonth;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btXoa;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btReset;
        private System.Windows.Forms.Label lbMa;
    }
}
