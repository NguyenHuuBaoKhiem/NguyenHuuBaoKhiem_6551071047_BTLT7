namespace Cau3_QuanLyLoaiPhong
{
    partial class FormLoaiPhong
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

            lblMaLoai = new Label();
            txtMaLoai = new TextBox();

            lblTenLoai = new Label();
            txtTenLoai = new TextBox();

            lblGiaMoiDem = new Label();
            nudGiaMoiDem = new NumericUpDown();

            lblMoTa = new Label();
            txtMoTa = new TextBox();

            btnThem = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnLamMoi = new Button();

            dgvLoaiPhong = new DataGridView();

            colMaLoai = new DataGridViewTextBoxColumn();
            colTenLoai = new DataGridViewTextBoxColumn();
            colGiaMoiDem = new DataGridViewTextBoxColumn();
            colMoTa = new DataGridViewTextBoxColumn();

            ((System.ComponentModel.ISupportInitialize)nudGiaMoiDem).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvLoaiPhong).BeginInit();

            SuspendLayout();

            // Tiêu đề
            lblTieuDe.AutoSize = true;
            lblTieuDe.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTieuDe.Location = new Point(30, 20);
            lblTieuDe.Text = "QUẢN LÝ LOẠI PHÒNG";

            // Mã loại
            lblMaLoai.AutoSize = true;
            lblMaLoai.Location = new Point(35, 80);
            lblMaLoai.Text = "Mã loại";

            txtMaLoai.Location = new Point(140, 76);
            txtMaLoai.ReadOnly = true;
            txtMaLoai.Size = new Size(260, 23);

            // Tên loại
            lblTenLoai.AutoSize = true;
            lblTenLoai.Location = new Point(35, 120);
            lblTenLoai.Text = "Tên loại";

            txtTenLoai.Location = new Point(140, 116);
            txtTenLoai.Size = new Size(260, 23);

            // Giá mỗi đêm
            lblGiaMoiDem.AutoSize = true;
            lblGiaMoiDem.Location = new Point(35, 160);
            lblGiaMoiDem.Text = "Giá mỗi đêm";

            nudGiaMoiDem.Location = new Point(140, 156);
            nudGiaMoiDem.Maximum = 1000000000;
            nudGiaMoiDem.ThousandsSeparator = true;
            nudGiaMoiDem.Size = new Size(260, 23);

            // Mô tả
            lblMoTa.AutoSize = true;
            lblMoTa.Location = new Point(35, 200);
            lblMoTa.Text = "Mô tả";

            txtMoTa.Location = new Point(140, 196);
            txtMoTa.Multiline = true;
            txtMoTa.ScrollBars = ScrollBars.Vertical;
            txtMoTa.Size = new Size(260, 80);

            // Buttons
            btnThem.Location = new Point(475, 75);
            btnThem.Size = new Size(100, 38);
            btnThem.Text = "Thêm";
            btnThem.Click += btnThem_Click;

            btnSua.Location = new Point(590, 75);
            btnSua.Size = new Size(100, 38);
            btnSua.Text = "Sửa";
            btnSua.Click += btnSua_Click;

            btnXoa.Location = new Point(705, 75);
            btnXoa.Size = new Size(100, 38);
            btnXoa.Text = "Xóa";
            btnXoa.Click += btnXoa_Click;

            btnLamMoi.Location = new Point(820, 75);
            btnLamMoi.Size = new Size(100, 38);
            btnLamMoi.Text = "Làm mới";
            btnLamMoi.Click += btnLamMoi_Click;

            // DataGridView
            dgvLoaiPhong.AllowUserToAddRows = false;
            dgvLoaiPhong.AllowUserToDeleteRows = false;
            dgvLoaiPhong.AutoGenerateColumns = false;
            dgvLoaiPhong.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            dgvLoaiPhong.BackgroundColor = Color.White;

            dgvLoaiPhong.Columns.AddRange(
                colMaLoai,
                colTenLoai,
                colGiaMoiDem,
                colMoTa
            );

            dgvLoaiPhong.Location = new Point(35, 315);
            dgvLoaiPhong.MultiSelect = false;
            dgvLoaiPhong.ReadOnly = true;
            dgvLoaiPhong.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            dgvLoaiPhong.Size = new Size(885, 300);

            dgvLoaiPhong.SelectionChanged +=
                dgvLoaiPhong_SelectionChanged;

            colMaLoai.DataPropertyName = "MaLoai";
            colMaLoai.HeaderText = "Mã loại";
            colMaLoai.Name = "colMaLoai";
            colMaLoai.FillWeight = 60;

            colTenLoai.DataPropertyName = "TenLoai";
            colTenLoai.HeaderText = "Tên loại";
            colTenLoai.Name = "colTenLoai";

            colGiaMoiDem.DataPropertyName = "GiaMoiDem";
            colGiaMoiDem.HeaderText = "Giá/đêm";
            colGiaMoiDem.Name = "colGiaMoiDem";
            colGiaMoiDem.DefaultCellStyle.Format = "#,##0";

            colMoTa.DataPropertyName = "MoTa";
            colMoTa.HeaderText = "Mô tả";
            colMoTa.Name = "colMoTa";
            colMoTa.FillWeight = 150;

            // Form
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;

            ClientSize = new Size(960, 650);
            BackColor = Color.WhiteSmoke;

            Controls.Add(lblTieuDe);
            Controls.Add(lblMaLoai);
            Controls.Add(txtMaLoai);
            Controls.Add(lblTenLoai);
            Controls.Add(txtTenLoai);
            Controls.Add(lblGiaMoiDem);
            Controls.Add(nudGiaMoiDem);
            Controls.Add(lblMoTa);
            Controls.Add(txtMoTa);

            Controls.Add(btnThem);
            Controls.Add(btnSua);
            Controls.Add(btnXoa);
            Controls.Add(btnLamMoi);

            Controls.Add(dgvLoaiPhong);

            StartPosition = FormStartPosition.CenterParent;
            Text = "Quản lý Loại phòng - Sunrise Homestay";

            ((System.ComponentModel.ISupportInitialize)nudGiaMoiDem).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvLoaiPhong).EndInit();

            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTieuDe;

        private Label lblMaLoai;
        private TextBox txtMaLoai;

        private Label lblTenLoai;
        private TextBox txtTenLoai;

        private Label lblGiaMoiDem;
        private NumericUpDown nudGiaMoiDem;

        private Label lblMoTa;
        private TextBox txtMoTa;

        private Button btnThem;
        private Button btnSua;
        private Button btnXoa;
        private Button btnLamMoi;

        private DataGridView dgvLoaiPhong;

        private DataGridViewTextBoxColumn colMaLoai;
        private DataGridViewTextBoxColumn colTenLoai;
        private DataGridViewTextBoxColumn colGiaMoiDem;
        private DataGridViewTextBoxColumn colMoTa;
    }
}