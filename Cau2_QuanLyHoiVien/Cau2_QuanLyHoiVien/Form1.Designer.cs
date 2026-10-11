namespace Cau2_QuanLyHoiVien
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

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            lblTieuDe = new Label();

            lblHoTen = new Label();
            txtHoTen = new TextBox();

            lblSDT = new Label();
            txtSDT = new TextBox();

            lblEmail = new Label();
            txtEmail = new TextBox();

            lblNgaySinh = new Label();
            dtpNgaySinh = new DateTimePicker();

            lblHangThanhVien = new Label();
            cboHangThanhVien = new ComboBox();

            chkTrangThai = new CheckBox();

            grpGioiTinh = new GroupBox();
            radNam = new RadioButton();
            radNu = new RadioButton();

            btnThem = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnLamMoi = new Button();

            txtTimKiem = new TextBox();

            lblLocHang = new Label();
            cboLocHang = new ComboBox();

            btnTimKiem = new Button();

            dgvHoiVien = new DataGridView();

            colMaHV = new DataGridViewTextBoxColumn();
            colHoTen = new DataGridViewTextBoxColumn();
            colGioiTinh = new DataGridViewTextBoxColumn();
            colNgaySinh = new DataGridViewTextBoxColumn();
            colSDT = new DataGridViewTextBoxColumn();
            colHangThanhVien = new DataGridViewTextBoxColumn();
            colTrangThai = new DataGridViewTextBoxColumn();

            grpGioiTinh.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHoiVien).BeginInit();

            SuspendLayout();

            // ==============================
            // TIÊU ĐỀ
            // ==============================
            lblTieuDe.AutoSize = true;
            lblTieuDe.Font = new Font(
                "Segoe UI",
                12F,
                FontStyle.Regular);

            lblTieuDe.Location =
                new Point(25, 20);

            lblTieuDe.Text =
                "Quản Lý Hội Viên Phòng Gym FitZone";

            // ==============================
            // HỌ TÊN
            // ==============================
            lblHoTen.AutoSize = true;
            lblHoTen.Location =
                new Point(50, 83);

            lblHoTen.Text = "Họ tên";

            txtHoTen.Location =
                new Point(170, 79);

            txtHoTen.Size =
                new Size(250, 23);

            // ==============================
            // SỐ ĐIỆN THOẠI
            // ==============================
            lblSDT.AutoSize = true;
            lblSDT.Location =
                new Point(50, 125);

            lblSDT.Text = "Số điện thoại";

            txtSDT.Location =
                new Point(170, 121);

            txtSDT.Size =
                new Size(250, 23);

            // ==============================
            // EMAIL
            // ==============================
            lblEmail.AutoSize = true;
            lblEmail.Location =
                new Point(50, 167);

            lblEmail.Text = "Email";

            txtEmail.Location =
                new Point(170, 163);

            txtEmail.Size =
                new Size(250, 23);

            // ==============================
            // NGÀY SINH
            // ==============================
            lblNgaySinh.AutoSize = true;
            lblNgaySinh.Location =
                new Point(50, 209);

            lblNgaySinh.Text = "Ngày sinh";

            dtpNgaySinh.CustomFormat =
                "dd/MM/yyyy";

            dtpNgaySinh.Format =
                DateTimePickerFormat.Custom;

            dtpNgaySinh.Location =
                new Point(170, 205);

            dtpNgaySinh.Size =
                new Size(250, 23);

            // ==============================
            // HẠNG THÀNH VIÊN
            // ==============================
            lblHangThanhVien.AutoSize = true;

            lblHangThanhVien.Location =
                new Point(50, 251);

            lblHangThanhVien.Text =
                "Hạng thành viên";

            cboHangThanhVien.DropDownStyle =
                ComboBoxStyle.DropDownList;

            cboHangThanhVien.Location =
                new Point(170, 247);

            cboHangThanhVien.Size =
                new Size(250, 23);

            // ==============================
            // ĐANG HOẠT ĐỘNG
            // ==============================
            chkTrangThai.AutoSize = true;

            chkTrangThai.Location =
                new Point(50, 292);

            chkTrangThai.Text =
                "Đang hoạt động";

            chkTrangThai.Checked = true;

            // ==============================
            // GIỚI TÍNH
            // ==============================
            grpGioiTinh.Controls.Add(radNam);
            grpGioiTinh.Controls.Add(radNu);

            grpGioiTinh.Location =
                new Point(475, 73);

            grpGioiTinh.Size =
                new Size(235, 85);

            grpGioiTinh.Text =
                "Giới tính";

            radNam.AutoSize = true;

            radNam.Location =
                new Point(35, 36);

            radNam.Text = "Nam";
            radNam.Checked = true;

            radNu.AutoSize = true;

            radNu.Location =
                new Point(140, 36);

            radNu.Text = "Nữ";

            // ==============================
            // BUTTON THÊM
            // ==============================
            btnThem.Location =
                new Point(795, 75);

            btnThem.Size =
                new Size(125, 40);

            btnThem.Text = "Thêm";

            btnThem.UseVisualStyleBackColor = true;

            btnThem.Click +=
                btnThem_Click;

            // ==============================
            // BUTTON SỬA
            // ==============================
            btnSua.Location =
                new Point(795, 125);

            btnSua.Size =
                new Size(125, 40);

            btnSua.Text = "Sửa";

            btnSua.UseVisualStyleBackColor = true;

            btnSua.Click +=
                btnSua_Click;

            // ==============================
            // BUTTON XÓA
            // ==============================
            btnXoa.Location =
                new Point(795, 175);

            btnXoa.Size =
                new Size(125, 40);

            btnXoa.Text = "Xóa";

            btnXoa.UseVisualStyleBackColor = true;

            btnXoa.Click +=
                btnXoa_Click;

            // ==============================
            // BUTTON LÀM MỚI
            // ==============================
            btnLamMoi.Location =
                new Point(795, 225);

            btnLamMoi.Size =
                new Size(125, 40);

            btnLamMoi.Text =
                "Làm mới";

            btnLamMoi.UseVisualStyleBackColor = true;

            btnLamMoi.Click +=
                btnLamMoi_Click;

            // ==============================
            // Ô TÌM HỌ TÊN
            // ==============================
            txtTimKiem.Location =
                new Point(50, 350);

            txtTimKiem.Size =
                new Size(280, 23);

            // ==============================
            // LỌC HẠNG
            // ==============================
            lblLocHang.AutoSize = true;

            lblLocHang.Location =
                new Point(360, 354);

            lblLocHang.Text =
                "Hạng thành viên";

            cboLocHang.DropDownStyle =
                ComboBoxStyle.DropDownList;

            cboLocHang.Location =
                new Point(475, 350);

            cboLocHang.Size =
                new Size(170, 23);

            // ==============================
            // BUTTON TÌM KIẾM
            // ==============================
            btnTimKiem.Location =
                new Point(715, 345);

            btnTimKiem.Size =
                new Size(125, 34);

            btnTimKiem.Text =
                "Tìm kiếm";

            btnTimKiem.UseVisualStyleBackColor =
                true;

            btnTimKiem.Click +=
                btnTimKiem_Click;

            // ==============================
            // DATAGRIDVIEW
            // ==============================
            dgvHoiVien.AllowUserToAddRows =
                false;

            dgvHoiVien.AllowUserToDeleteRows =
                false;

            // Rất quan trọng:
            // không để DataGridView tự sinh cột bool
            dgvHoiVien.AutoGenerateColumns =
                false;

            dgvHoiVien.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            dgvHoiVien.BackgroundColor =
                Color.White;

            dgvHoiVien.ColumnHeadersHeightSizeMode =
                DataGridViewColumnHeadersHeightSizeMode.AutoSize;

            dgvHoiVien.Columns.AddRange(
                colMaHV,
                colHoTen,
                colGioiTinh,
                colNgaySinh,
                colSDT,
                colHangThanhVien,
                colTrangThai
            );

            dgvHoiVien.Location =
                new Point(50, 405);

            dgvHoiVien.MultiSelect =
                false;

            dgvHoiVien.ReadOnly =
                true;

            dgvHoiVien.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            dgvHoiVien.Size =
                new Size(1050, 330);

            dgvHoiVien.SelectionChanged +=
                dgvHoiVien_SelectionChanged;

            dgvHoiVien.CellFormatting +=
                dgvHoiVien_CellFormatting;

            // ==============================
            // MÃ HỘI VIÊN
            // ==============================
            colMaHV.DataPropertyName =
                "MaHv";

            colMaHV.HeaderText =
                "Mã HV";

            colMaHV.Name =
                "colMaHV";

            colMaHV.ReadOnly =
                true;

            colMaHV.FillWeight =
                55;

            // ==============================
            // HỌ TÊN
            // ==============================
            colHoTen.DataPropertyName =
                "HoTen";

            colHoTen.HeaderText =
                "Họ tên";

            colHoTen.Name =
                "colHoTen";

            colHoTen.ReadOnly =
                true;

            colHoTen.FillWeight =
                120;

            // ==============================
            // GIỚI TÍNH
            // TEXTBOX COLUMN - KHÔNG CHECKBOX
            // ==============================
            colGioiTinh.DataPropertyName =
                "GioiTinh";

            colGioiTinh.HeaderText =
                "Giới tính";

            colGioiTinh.Name =
                "colGioiTinh";

            colGioiTinh.ReadOnly =
                true;

            colGioiTinh.FillWeight =
                70;

            // ==============================
            // NGÀY SINH
            // ==============================
            colNgaySinh.DataPropertyName =
                "NgaySinh";

            colNgaySinh.HeaderText =
                "Ngày sinh";

            colNgaySinh.Name =
                "colNgaySinh";

            colNgaySinh.ReadOnly =
                true;

            colNgaySinh.FillWeight =
                85;

            // ==============================
            // SĐT
            // ==============================
            colSDT.DataPropertyName =
                "Sdt";

            colSDT.HeaderText =
                "SĐT";

            colSDT.Name =
                "colSDT";

            colSDT.ReadOnly =
                true;

            colSDT.FillWeight =
                90;

            // ==============================
            // HẠNG THÀNH VIÊN
            // ==============================
            colHangThanhVien.DataPropertyName =
                "HangThanhVien";

            colHangThanhVien.HeaderText =
                "Hạng thành viên";

            colHangThanhVien.Name =
                "colHangThanhVien";

            colHangThanhVien.ReadOnly =
                true;

            colHangThanhVien.FillWeight =
                100;

            // ==============================
            // TRẠNG THÁI
            // TEXTBOX COLUMN - KHÔNG CHECKBOX
            // ==============================
            colTrangThai.DataPropertyName =
                "TrangThai";

            colTrangThai.HeaderText =
                "Trạng thái";

            colTrangThai.Name =
                "colTrangThai";

            colTrangThai.ReadOnly =
                true;

            colTrangThai.FillWeight =
                100;

            // ==============================
            // FORM
            // ==============================
            AutoScaleDimensions =
                new SizeF(7F, 15F);

            AutoScaleMode =
                AutoScaleMode.Font;

            BackColor =
                Color.WhiteSmoke;

            ClientSize =
                new Size(1150, 780);

            Controls.Add(lblTieuDe);

            Controls.Add(lblHoTen);
            Controls.Add(txtHoTen);

            Controls.Add(lblSDT);
            Controls.Add(txtSDT);

            Controls.Add(lblEmail);
            Controls.Add(txtEmail);

            Controls.Add(lblNgaySinh);
            Controls.Add(dtpNgaySinh);

            Controls.Add(lblHangThanhVien);
            Controls.Add(cboHangThanhVien);

            Controls.Add(chkTrangThai);

            Controls.Add(grpGioiTinh);

            Controls.Add(btnThem);
            Controls.Add(btnSua);
            Controls.Add(btnXoa);
            Controls.Add(btnLamMoi);

            Controls.Add(txtTimKiem);

            Controls.Add(lblLocHang);
            Controls.Add(cboLocHang);

            Controls.Add(btnTimKiem);

            Controls.Add(dgvHoiVien);

            StartPosition =
                FormStartPosition.CenterScreen;

            Text =
                "Quản Lý Hội Viên Phòng Gym FitZone";

            grpGioiTinh.ResumeLayout(false);
            grpGioiTinh.PerformLayout();

            ((System.ComponentModel.ISupportInitialize)
                dgvHoiVien).EndInit();

            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTieuDe;

        private Label lblHoTen;
        private TextBox txtHoTen;

        private Label lblSDT;
        private TextBox txtSDT;

        private Label lblEmail;
        private TextBox txtEmail;

        private Label lblNgaySinh;
        private DateTimePicker dtpNgaySinh;

        private Label lblHangThanhVien;
        private ComboBox cboHangThanhVien;

        private CheckBox chkTrangThai;

        private GroupBox grpGioiTinh;
        private RadioButton radNam;
        private RadioButton radNu;

        private Button btnThem;
        private Button btnSua;
        private Button btnXoa;
        private Button btnLamMoi;

        private TextBox txtTimKiem;

        private Label lblLocHang;
        private ComboBox cboLocHang;

        private Button btnTimKiem;

        private DataGridView dgvHoiVien;

        private DataGridViewTextBoxColumn colMaHV;
        private DataGridViewTextBoxColumn colHoTen;
        private DataGridViewTextBoxColumn colGioiTinh;
        private DataGridViewTextBoxColumn colNgaySinh;
        private DataGridViewTextBoxColumn colSDT;
        private DataGridViewTextBoxColumn colHangThanhVien;
        private DataGridViewTextBoxColumn colTrangThai;
    }
}