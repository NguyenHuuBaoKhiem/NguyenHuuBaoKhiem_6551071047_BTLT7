namespace Cau1_QuanLyTheLoaiSach
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            lblTieuDe = new Label();
            lblMaTL = new Label();
            txtMaTL = new TextBox();
            lblTenTheLoai = new Label();
            txtTenTheLoai = new TextBox();
            lblMoTa = new Label();
            txtMoTa = new TextBox();
            lblNgayTaoTitle = new Label();
            lblNgayTao = new Label();

            btnThem = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnLamMoi = new Button();

            txtTimKiem = new TextBox();
            btnTimKiem = new Button();

            dgvTheLoaiSach = new DataGridView();

            colMaTL = new DataGridViewTextBoxColumn();
            colTenTheLoai = new DataGridViewTextBoxColumn();
            colMoTa = new DataGridViewTextBoxColumn();
            colSoLuongSach = new DataGridViewTextBoxColumn();
            colNgayTao = new DataGridViewTextBoxColumn();

            ((System.ComponentModel.ISupportInitialize)dgvTheLoaiSach).BeginInit();
            SuspendLayout();

            // lblTieuDe
            lblTieuDe.AutoSize = true;
            lblTieuDe.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTieuDe.Location = new Point(30, 20);
            lblTieuDe.Text = "QUẢN LÝ THỂ LOẠI SÁCH - TRI THỨC BOOKS";

            // lblMaTL
            lblMaTL.AutoSize = true;
            lblMaTL.Location = new Point(35, 82);
            lblMaTL.Text = "Mã thể loại:";

            // txtMaTL
            txtMaTL.Location = new Point(140, 78);
            txtMaTL.ReadOnly = true;
            txtMaTL.Size = new Size(260, 23);

            // lblTenTheLoai
            lblTenTheLoai.AutoSize = true;
            lblTenTheLoai.Location = new Point(35, 122);
            lblTenTheLoai.Text = "Tên thể loại:";

            // txtTenTheLoai
            txtTenTheLoai.Location = new Point(140, 118);
            txtTenTheLoai.Size = new Size(260, 23);

            // lblMoTa
            lblMoTa.AutoSize = true;
            lblMoTa.Location = new Point(35, 163);
            lblMoTa.Text = "Mô tả:";

            // txtMoTa
            txtMoTa.Location = new Point(140, 158);
            txtMoTa.Multiline = true;
            txtMoTa.ScrollBars = ScrollBars.Vertical;
            txtMoTa.Size = new Size(260, 85);

            // lblNgayTaoTitle
            lblNgayTaoTitle.AutoSize = true;
            lblNgayTaoTitle.Location = new Point(35, 265);
            lblNgayTaoTitle.Text = "Ngày tạo:";

            // lblNgayTao
            lblNgayTao.AutoSize = true;
            lblNgayTao.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblNgayTao.Location = new Point(140, 265);
            lblNgayTao.Text = "---";

            // btnThem
            btnThem.Location = new Point(490, 78);
            btnThem.Size = new Size(95, 38);
            btnThem.Text = "Thêm";
            btnThem.Click += btnThem_Click;

            // btnSua
            btnSua.Location = new Point(600, 78);
            btnSua.Size = new Size(95, 38);
            btnSua.Text = "Sửa";
            btnSua.Click += btnSua_Click;

            // btnXoa
            btnXoa.Location = new Point(710, 78);
            btnXoa.Size = new Size(95, 38);
            btnXoa.Text = "Xóa";
            btnXoa.Click += btnXoa_Click;

            // btnLamMoi
            btnLamMoi.Location = new Point(820, 78);
            btnLamMoi.Size = new Size(95, 38);
            btnLamMoi.Text = "Làm mới";
            btnLamMoi.Click += btnLamMoi_Click;

            // txtTimKiem
            txtTimKiem.Location = new Point(35, 315);
            txtTimKiem.PlaceholderText = "Nhập tên thể loại cần tìm...";
            txtTimKiem.Size = new Size(365, 23);

            // btnTimKiem
            btnTimKiem.Location = new Point(415, 311);
            btnTimKiem.Size = new Size(100, 31);
            btnTimKiem.Text = "Tìm kiếm";
            btnTimKiem.Click += btnTimKiem_Click;

            // dgvTheLoaiSach
            dgvTheLoaiSach.AllowUserToAddRows = false;
            dgvTheLoaiSach.AllowUserToDeleteRows = false;
            dgvTheLoaiSach.AutoGenerateColumns = false;
            dgvTheLoaiSach.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;
            dgvTheLoaiSach.BackgroundColor = Color.White;
            dgvTheLoaiSach.ColumnHeadersHeightSizeMode =
                DataGridViewColumnHeadersHeightSizeMode.AutoSize;

            dgvTheLoaiSach.Columns.AddRange(
                colMaTL,
                colTenTheLoai,
                colMoTa,
                colSoLuongSach,
                colNgayTao
            );

            dgvTheLoaiSach.Location = new Point(35, 360);
            dgvTheLoaiSach.MultiSelect = false;
            dgvTheLoaiSach.ReadOnly = true;
            dgvTheLoaiSach.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;
            dgvTheLoaiSach.Size = new Size(880, 285);

            dgvTheLoaiSach.SelectionChanged +=
                dgvTheLoaiSach_SelectionChanged;

            // colMaTL
            colMaTL.DataPropertyName = "MaTl";
            colMaTL.HeaderText = "Mã TL";
            colMaTL.FillWeight = 60;

            // colTenTheLoai
            colTenTheLoai.DataPropertyName = "TenTheLoai";
            colTenTheLoai.HeaderText = "Tên thể loại";

            // colMoTa
            colMoTa.DataPropertyName = "MoTa";
            colMoTa.HeaderText = "Mô tả";
            colMoTa.FillWeight = 150;

            // colSoLuongSach
            colSoLuongSach.DataPropertyName = "SoLuongSach";
            colSoLuongSach.HeaderText = "Số lượng sách";

            // colNgayTao
            colNgayTao.DataPropertyName = "NgayTao";
            colNgayTao.HeaderText = "Ngày tạo";
            colNgayTao.DefaultCellStyle.Format =
                "dd/MM/yyyy HH:mm";

            // Form1
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(950, 680);

            Controls.Add(lblTieuDe);
            Controls.Add(lblMaTL);
            Controls.Add(txtMaTL);
            Controls.Add(lblTenTheLoai);
            Controls.Add(txtTenTheLoai);
            Controls.Add(lblMoTa);
            Controls.Add(txtMoTa);
            Controls.Add(lblNgayTaoTitle);
            Controls.Add(lblNgayTao);

            Controls.Add(btnThem);
            Controls.Add(btnSua);
            Controls.Add(btnXoa);
            Controls.Add(btnLamMoi);

            Controls.Add(txtTimKiem);
            Controls.Add(btnTimKiem);
            Controls.Add(dgvTheLoaiSach);

            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản lý Thể loại Sách - Tri Thức Books";

            ((System.ComponentModel.ISupportInitialize)dgvTheLoaiSach)
                .EndInit();

            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTieuDe;

        private Label lblMaTL;
        private TextBox txtMaTL;

        private Label lblTenTheLoai;
        private TextBox txtTenTheLoai;

        private Label lblMoTa;
        private TextBox txtMoTa;

        private Label lblNgayTaoTitle;
        private Label lblNgayTao;

        private Button btnThem;
        private Button btnSua;
        private Button btnXoa;
        private Button btnLamMoi;

        private TextBox txtTimKiem;
        private Button btnTimKiem;

        private DataGridView dgvTheLoaiSach;

        private DataGridViewTextBoxColumn colMaTL;
        private DataGridViewTextBoxColumn colTenTheLoai;
        private DataGridViewTextBoxColumn colMoTa;
        private DataGridViewTextBoxColumn colSoLuongSach;
        private DataGridViewTextBoxColumn colNgayTao;
    }
}