namespace Cau4_QuanLyLichKham
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
                components.Dispose();

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblTenBenhNhan = new Label();
            txtTenBenhNhan = new TextBox();
            lblSDT = new Label();
            txtSDT = new TextBox();
            lblNgayKham = new Label();
            dtpNgayKham = new DateTimePicker();
            lblGioKham = new Label();
            dtpGioKham = new DateTimePicker();
            lblBacSi = new Label();
            cboBacSi = new ComboBox();
            lblTrangThai = new Label();
            cboTrangThai = new ComboBox();
            btnThem = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnLamMoi = new Button();
            lblTuNgay = new Label();
            dtpTuNgay = new DateTimePicker();
            lblDenNgay = new Label();
            dtpDenNgay = new DateTimePicker();
            cboLocBacSi = new ComboBox();
            btnTimKiem = new Button();
            btnDiLiet = new Button();
            dgvLichKham = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvLichKham).BeginInit();
            SuspendLayout();
            // 
            // lblTenBenhNhan
            // 
            lblTenBenhNhan.AutoSize = true;
            lblTenBenhNhan.Location = new Point(21, 35);
            lblTenBenhNhan.Name = "lblTenBenhNhan";
            lblTenBenhNhan.Size = new Size(105, 20);
            lblTenBenhNhan.TabIndex = 0;
            lblTenBenhNhan.Text = "Tên bệnh nhân";
            // 
            // txtTenBenhNhan
            // 
            txtTenBenhNhan.Location = new Point(131, 29);
            txtTenBenhNhan.Margin = new Padding(3, 4, 3, 4);
            txtTenBenhNhan.Name = "txtTenBenhNhan";
            txtTenBenhNhan.Size = new Size(211, 27);
            txtTenBenhNhan.TabIndex = 1;
            // 
            // lblSDT
            // 
            lblSDT.AutoSize = true;
            lblSDT.Location = new Point(21, 83);
            lblSDT.Name = "lblSDT";
            lblSDT.Size = new Size(97, 20);
            lblSDT.TabIndex = 2;
            lblSDT.Text = "Số điện thoại";
            // 
            // txtSDT
            // 
            txtSDT.Location = new Point(131, 77);
            txtSDT.Margin = new Padding(3, 4, 3, 4);
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(211, 27);
            txtSDT.TabIndex = 3;
            // 
            // lblNgayKham
            // 
            lblNgayKham.AutoSize = true;
            lblNgayKham.Location = new Point(21, 131);
            lblNgayKham.Name = "lblNgayKham";
            lblNgayKham.Size = new Size(84, 20);
            lblNgayKham.TabIndex = 4;
            lblNgayKham.Text = "Ngày khám";
            // 
            // dtpNgayKham
            // 
            dtpNgayKham.CustomFormat = "dd/MM/yyyy";
            dtpNgayKham.Format = DateTimePickerFormat.Custom;
            dtpNgayKham.Location = new Point(131, 125);
            dtpNgayKham.Margin = new Padding(3, 4, 3, 4);
            dtpNgayKham.Name = "dtpNgayKham";
            dtpNgayKham.Size = new Size(211, 27);
            dtpNgayKham.TabIndex = 5;
            // 
            // lblGioKham
            // 
            lblGioKham.AutoSize = true;
            lblGioKham.Location = new Point(368, 130);
            lblGioKham.Name = "lblGioKham";
            lblGioKham.Size = new Size(72, 20);
            lblGioKham.TabIndex = 6;
            lblGioKham.Text = "Giờ khám";
            // 
            // dtpGioKham
            // 
            dtpGioKham.CustomFormat = "HH:mm";
            dtpGioKham.Format = DateTimePickerFormat.Custom;
            dtpGioKham.Location = new Point(446, 126);
            dtpGioKham.Margin = new Padding(3, 4, 3, 4);
            dtpGioKham.Name = "dtpGioKham";
            dtpGioKham.ShowUpDown = true;
            dtpGioKham.Size = new Size(131, 27);
            dtpGioKham.TabIndex = 7;
            dtpGioKham.ValueChanged += dtpGioKham_ValueChanged;
            // 
            // lblBacSi
            // 
            lblBacSi.AutoSize = true;
            lblBacSi.Location = new Point(615, 97);
            lblBacSi.Name = "lblBacSi";
            lblBacSi.Size = new Size(47, 20);
            lblBacSi.TabIndex = 8;
            lblBacSi.Text = "Bác sĩ";
            // 
            // cboBacSi
            // 
            cboBacSi.DropDownStyle = ComboBoxStyle.DropDownList;
            cboBacSi.Location = new Point(615, 125);
            cboBacSi.Margin = new Padding(3, 4, 3, 4);
            cboBacSi.Name = "cboBacSi";
            cboBacSi.Size = new Size(319, 28);
            cboBacSi.TabIndex = 9;
            // 
            // lblTrangThai
            // 
            lblTrangThai.AutoSize = true;
            lblTrangThai.Location = new Point(952, 97);
            lblTrangThai.Name = "lblTrangThai";
            lblTrangThai.Size = new Size(75, 20);
            lblTrangThai.TabIndex = 10;
            lblTrangThai.Text = "Trạng thái";
            // 
            // cboTrangThai
            // 
            cboTrangThai.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTrangThai.Location = new Point(952, 125);
            cboTrangThai.Margin = new Padding(3, 4, 3, 4);
            cboTrangThai.Name = "cboTrangThai";
            cboTrangThai.Size = new Size(194, 28);
            cboTrangThai.TabIndex = 11;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(840, 24);
            btnThem.Margin = new Padding(3, 4, 3, 4);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(97, 43);
            btnThem.TabIndex = 12;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(949, 24);
            btnSua.Margin = new Padding(3, 4, 3, 4);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(97, 43);
            btnSua.TabIndex = 13;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(1057, 24);
            btnXoa.Margin = new Padding(3, 4, 3, 4);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(97, 43);
            btnXoa.TabIndex = 14;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnLamMoi
            // 
            btnLamMoi.Location = new Point(1166, 24);
            btnLamMoi.Margin = new Padding(3, 4, 3, 4);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(97, 43);
            btnLamMoi.TabIndex = 15;
            btnLamMoi.Text = "Làm mới";
            btnLamMoi.UseVisualStyleBackColor = true;
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // lblTuNgay
            // 
            lblTuNgay.AutoSize = true;
            lblTuNgay.Location = new Point(21, 205);
            lblTuNgay.Name = "lblTuNgay";
            lblTuNgay.Size = new Size(62, 20);
            lblTuNgay.TabIndex = 16;
            lblTuNgay.Text = "Từ ngày";
            // 
            // dtpTuNgay
            // 
            dtpTuNgay.CustomFormat = "dd/MM/yyyy";
            dtpTuNgay.Format = DateTimePickerFormat.Custom;
            dtpTuNgay.Location = new Point(86, 200);
            dtpTuNgay.Margin = new Padding(3, 4, 3, 4);
            dtpTuNgay.Name = "dtpTuNgay";
            dtpTuNgay.Size = new Size(148, 27);
            dtpTuNgay.TabIndex = 17;
            // 
            // lblDenNgay
            // 
            lblDenNgay.AutoSize = true;
            lblDenNgay.Location = new Point(257, 205);
            lblDenNgay.Name = "lblDenNgay";
            lblDenNgay.Size = new Size(72, 20);
            lblDenNgay.TabIndex = 18;
            lblDenNgay.Text = "Đến ngày";
            // 
            // dtpDenNgay
            // 
            dtpDenNgay.CustomFormat = "dd/MM/yyyy";
            dtpDenNgay.Format = DateTimePickerFormat.Custom;
            dtpDenNgay.Location = new Point(331, 200);
            dtpDenNgay.Margin = new Padding(3, 4, 3, 4);
            dtpDenNgay.Name = "dtpDenNgay";
            dtpDenNgay.Size = new Size(148, 27);
            dtpDenNgay.TabIndex = 19;
            // 
            // cboLocBacSi
            // 
            cboLocBacSi.DropDownStyle = ComboBoxStyle.DropDownList;
            cboLocBacSi.Location = new Point(520, 200);
            cboLocBacSi.Margin = new Padding(3, 4, 3, 4);
            cboLocBacSi.Name = "cboLocBacSi";
            cboLocBacSi.Size = new Size(325, 28);
            cboLocBacSi.TabIndex = 20;
            // 
            // btnTimKiem
            // 
            btnTimKiem.Location = new Point(863, 195);
            btnTimKiem.Margin = new Padding(3, 4, 3, 4);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(114, 41);
            btnTimKiem.TabIndex = 21;
            btnTimKiem.Text = "Tìm kiếm";
            btnTimKiem.UseVisualStyleBackColor = true;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // btnDiLiet
            // 
            btnDiLiet.Location = new Point(1149, 195);
            btnDiLiet.Margin = new Padding(3, 4, 3, 4);
            btnDiLiet.Name = "btnDiLiet";
            btnDiLiet.Size = new Size(114, 41);
            btnDiLiet.TabIndex = 22;
            btnDiLiet.Text = "Đi List";
            btnDiLiet.UseVisualStyleBackColor = true;
            btnDiLiet.Click += btnDiLiet_Click;
            // 
            // dgvLichKham
            // 
            dgvLichKham.AllowUserToAddRows = false;
            dgvLichKham.AllowUserToDeleteRows = false;
            dgvLichKham.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvLichKham.BackgroundColor = Color.LightGray;
            dgvLichKham.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLichKham.Location = new Point(21, 260);
            dgvLichKham.Margin = new Padding(3, 4, 3, 4);
            dgvLichKham.MultiSelect = false;
            dgvLichKham.Name = "dgvLichKham";
            dgvLichKham.ReadOnly = true;
            dgvLichKham.RowHeadersWidth = 51;
            dgvLichKham.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvLichKham.Size = new Size(1242, 447);
            dgvLichKham.TabIndex = 23;
            dgvLichKham.SelectionChanged += dgvLichKham_SelectionChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1286, 733);
            Controls.Add(lblTenBenhNhan);
            Controls.Add(txtTenBenhNhan);
            Controls.Add(lblSDT);
            Controls.Add(txtSDT);
            Controls.Add(lblNgayKham);
            Controls.Add(dtpNgayKham);
            Controls.Add(lblGioKham);
            Controls.Add(dtpGioKham);
            Controls.Add(lblBacSi);
            Controls.Add(cboBacSi);
            Controls.Add(lblTrangThai);
            Controls.Add(cboTrangThai);
            Controls.Add(btnThem);
            Controls.Add(btnSua);
            Controls.Add(btnXoa);
            Controls.Add(btnLamMoi);
            Controls.Add(lblTuNgay);
            Controls.Add(dtpTuNgay);
            Controls.Add(lblDenNgay);
            Controls.Add(dtpDenNgay);
            Controls.Add(cboLocBacSi);
            Controls.Add(btnTimKiem);
            Controls.Add(btnDiLiet);
            Controls.Add(dgvLichKham);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản Lý Lịch Khám Bệnh - An Khang Clinic";
            Load += Form1_Load_1;
            ((System.ComponentModel.ISupportInitialize)dgvLichKham).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private Label lblTenBenhNhan;
        private TextBox txtTenBenhNhan;

        private Label lblSDT;
        private TextBox txtSDT;

        private Label lblNgayKham;
        private DateTimePicker dtpNgayKham;

        private Label lblGioKham;
        private DateTimePicker dtpGioKham;

        private Label lblBacSi;
        private ComboBox cboBacSi;

        private Label lblTrangThai;
        private ComboBox cboTrangThai;

        private Button btnThem;
        private Button btnSua;
        private Button btnXoa;
        private Button btnLamMoi;

        private Label lblTuNgay;
        private DateTimePicker dtpTuNgay;

        private Label lblDenNgay;
        private DateTimePicker dtpDenNgay;

        private ComboBox cboLocBacSi;

        private Button btnTimKiem;
        private Button btnDiLiet;

        private DataGridView dgvLichKham;

        private DataGridViewTextBoxColumn colMaLich;
        private DataGridViewTextBoxColumn colTenBenhNhan;
        private DataGridViewTextBoxColumn colSDT;
        private DataGridViewTextBoxColumn colNgayKham;
        private DataGridViewTextBoxColumn colGioKham;
        private DataGridViewTextBoxColumn colBacSi;
        private DataGridViewTextBoxColumn colChuyenKhoa;
        private DataGridViewTextBoxColumn colTrangThai;
    }
}