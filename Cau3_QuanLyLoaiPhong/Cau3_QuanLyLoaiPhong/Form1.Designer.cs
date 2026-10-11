namespace Cau3_QuanLyLoaiPhong
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

            lblSoPhong = new Label();
            txtSoPhong = new TextBox();

            lblTangSo = new Label();
            nudTangSo = new NumericUpDown();

            lblLoaiPhong = new Label();
            cboLoaiPhong = new ComboBox();

            lblTinhTrang = new Label();
            cboTinhTrang = new ComboBox();

            picAnh = new PictureBox();
            btnChonAnh = new Button();

            btnThem = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnLamMoi = new Button();

            btnQuanLyLoaiPhong = new Button();

            lblLocLoai = new Label();
            cboLocLoaiPhong = new ComboBox();

            lblLocTinhTrang = new Label();
            cboLocTinhTrang = new ComboBox();

            btnTimKiem = new Button();

            dgvPhong = new DataGridView();

            colMaPhong = new DataGridViewTextBoxColumn();
            colAnh = new DataGridViewImageColumn();
            colSoPhong = new DataGridViewTextBoxColumn();
            colTangSo = new DataGridViewTextBoxColumn();
            colTenLoai = new DataGridViewTextBoxColumn();
            colGiaMoiDem = new DataGridViewTextBoxColumn();
            colTinhTrang = new DataGridViewTextBoxColumn();

            ((System.ComponentModel.ISupportInitialize)nudTangSo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picAnh).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvPhong).BeginInit();

            SuspendLayout();

            // Tiêu đề
            lblTieuDe.AutoSize = true;
            lblTieuDe.Font =
                new Font("Segoe UI", 15F, FontStyle.Bold);

            lblTieuDe.Location =
                new Point(30, 20);

            lblTieuDe.Text =
                "QUẢN LÝ PHÒNG - SUNRISE HOMESTAY";

            // Số phòng
            lblSoPhong.AutoSize = true;
            lblSoPhong.Location =
                new Point(35, 85);

            lblSoPhong.Text = "Số phòng";

            txtSoPhong.Location =
                new Point(110, 81);

            txtSoPhong.Size =
                new Size(130, 23);

            // Tầng số
            lblTangSo.AutoSize = true;
            lblTangSo.Location =
                new Point(275, 85);

            lblTangSo.Text = "Tầng số";

            nudTangSo.Location =
                new Point(335, 81);

            nudTangSo.Minimum = 1;
            nudTangSo.Maximum = 100;
            nudTangSo.Value = 1;
            nudTangSo.Size =
                new Size(100, 23);

            // Loại phòng
            lblLoaiPhong.AutoSize = true;
            lblLoaiPhong.Location =
                new Point(35, 130);

            lblLoaiPhong.Text =
                "Loại phòng";

            cboLoaiPhong.DropDownStyle =
                ComboBoxStyle.DropDownList;

            cboLoaiPhong.Location =
                new Point(110, 126);

            cboLoaiPhong.Size =
                new Size(180, 23);

            // Tình trạng
            lblTinhTrang.AutoSize = true;
            lblTinhTrang.Location =
                new Point(325, 130);

            lblTinhTrang.Text =
                "Tình trạng";

            cboTinhTrang.DropDownStyle =
                ComboBoxStyle.DropDownList;

            cboTinhTrang.Location =
                new Point(395, 126);

            cboTinhTrang.Size =
                new Size(160, 23);

            // PictureBox
            picAnh.BorderStyle =
                BorderStyle.FixedSingle;

            picAnh.Location =
                new Point(605, 70);

            picAnh.Size =
                new Size(145, 110);

            picAnh.SizeMode =
                PictureBoxSizeMode.Zoom;

            // Chọn ảnh
            btnChonAnh.Location =
                new Point(605, 190);

            btnChonAnh.Size =
                new Size(145, 32);

            btnChonAnh.Text =
                "Chọn ảnh...";

            btnChonAnh.Click +=
                btnChonAnh_Click;

            // CRUD buttons
            btnThem.Location =
                new Point(800, 75);

            btnThem.Size =
                new Size(100, 38);

            btnThem.Text = "Thêm";

            btnThem.Click +=
                btnThem_Click;

            btnSua.Location =
                new Point(915, 75);

            btnSua.Size =
                new Size(100, 38);

            btnSua.Text = "Sửa";

            btnSua.Click +=
                btnSua_Click;

            btnXoa.Location =
                new Point(1030, 75);

            btnXoa.Size =
                new Size(100, 38);

            btnXoa.Text = "Xóa";

            btnXoa.Click +=
                btnXoa_Click;

            btnLamMoi.Location =
                new Point(1145, 75);

            btnLamMoi.Size =
                new Size(100, 38);

            btnLamMoi.Text =
                "Làm mới";

            btnLamMoi.Click +=
                btnLamMoi_Click;

            btnQuanLyLoaiPhong.Location =
                new Point(800, 130);

            btnQuanLyLoaiPhong.Size =
                new Size(215, 38);

            btnQuanLyLoaiPhong.Text =
                "Quản lý loại phòng";

            btnQuanLyLoaiPhong.Click +=
                btnQuanLyLoaiPhong_Click;

            // Filter loại phòng
            lblLocLoai.AutoSize = true;

            lblLocLoai.Location =
                new Point(35, 270);

            lblLocLoai.Text =
                "Lọc loại phòng";

            cboLocLoaiPhong.DropDownStyle =
                ComboBoxStyle.DropDownList;

            cboLocLoaiPhong.Location =
                new Point(135, 266);

            cboLocLoaiPhong.Size =
                new Size(180, 23);

            // Filter tình trạng
            lblLocTinhTrang.AutoSize = true;

            lblLocTinhTrang.Location =
                new Point(350, 270);

            lblLocTinhTrang.Text =
                "Lọc tình trạng";

            cboLocTinhTrang.DropDownStyle =
                ComboBoxStyle.DropDownList;

            cboLocTinhTrang.Location =
                new Point(445, 266);

            cboLocTinhTrang.Size =
                new Size(170, 23);

            btnTimKiem.Location =
                new Point(645, 261);

            btnTimKiem.Size =
                new Size(110, 32);

            btnTimKiem.Text =
                "Tìm kiếm";

            btnTimKiem.Click +=
                btnTimKiem_Click;

            // DataGrid
            dgvPhong.AllowUserToAddRows = false;
            dgvPhong.AllowUserToDeleteRows = false;
            dgvPhong.AutoGenerateColumns = false;

            dgvPhong.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            dgvPhong.BackgroundColor =
                Color.White;

            dgvPhong.Columns.AddRange(
                colMaPhong,
                colAnh,
                colSoPhong,
                colTangSo,
                colTenLoai,
                colGiaMoiDem,
                colTinhTrang
            );

            dgvPhong.Location =
                new Point(35, 325);

            dgvPhong.MultiSelect = false;
            dgvPhong.ReadOnly = true;

            dgvPhong.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            dgvPhong.RowTemplate.Height = 75;

            dgvPhong.Size =
                new Size(1210, 410);

            dgvPhong.SelectionChanged +=
                dgvPhong_SelectionChanged;

            // Columns
            colMaPhong.DataPropertyName =
                "MaPhong";

            colMaPhong.HeaderText =
                "Mã phòng";

            colMaPhong.Name =
                "colMaPhong";

            colMaPhong.FillWeight = 60;

            colAnh.DataPropertyName =
                "Anh";

            colAnh.HeaderText =
                "Ảnh";

            colAnh.Name =
                "colAnh";

            colAnh.ImageLayout =
                DataGridViewImageCellLayout.Zoom;

            colAnh.FillWeight = 90;

            colSoPhong.DataPropertyName =
                "SoPhong";

            colSoPhong.HeaderText =
                "Số phòng";

            colSoPhong.Name =
                "colSoPhong";

            colTangSo.DataPropertyName =
                "TangSo";

            colTangSo.HeaderText =
                "Tầng";

            colTangSo.Name =
                "colTangSo";

            colTangSo.FillWeight = 60;

            colTenLoai.DataPropertyName =
                "TenLoai";

            colTenLoai.HeaderText =
                "Loại phòng";

            colTenLoai.Name =
                "colTenLoai";

            colGiaMoiDem.DataPropertyName =
                "GiaMoiDem";

            colGiaMoiDem.HeaderText =
                "Giá/đêm";

            colGiaMoiDem.Name =
                "colGiaMoiDem";

            colGiaMoiDem.DefaultCellStyle.Format =
                "#,##0";

            colTinhTrang.DataPropertyName =
                "TinhTrang";

            colTinhTrang.HeaderText =
                "Tình trạng";

            colTinhTrang.Name =
                "colTinhTrang";

            // Form
            AutoScaleDimensions =
                new SizeF(7F, 15F);

            AutoScaleMode =
                AutoScaleMode.Font;

            ClientSize =
                new Size(1280, 780);

            BackColor =
                Color.WhiteSmoke;

            Controls.Add(lblTieuDe);

            Controls.Add(lblSoPhong);
            Controls.Add(txtSoPhong);

            Controls.Add(lblTangSo);
            Controls.Add(nudTangSo);

            Controls.Add(lblLoaiPhong);
            Controls.Add(cboLoaiPhong);

            Controls.Add(lblTinhTrang);
            Controls.Add(cboTinhTrang);

            Controls.Add(picAnh);
            Controls.Add(btnChonAnh);

            Controls.Add(btnThem);
            Controls.Add(btnSua);
            Controls.Add(btnXoa);
            Controls.Add(btnLamMoi);

            Controls.Add(btnQuanLyLoaiPhong);

            Controls.Add(lblLocLoai);
            Controls.Add(cboLocLoaiPhong);

            Controls.Add(lblLocTinhTrang);
            Controls.Add(cboLocTinhTrang);

            Controls.Add(btnTimKiem);

            Controls.Add(dgvPhong);

            StartPosition =
                FormStartPosition.CenterScreen;

            Text =
                "Quản lý Phòng - Sunrise Homestay";

            ((System.ComponentModel.ISupportInitialize)nudTangSo).EndInit();
            ((System.ComponentModel.ISupportInitialize)picAnh).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvPhong).EndInit();

            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTieuDe;

        private Label lblSoPhong;
        private TextBox txtSoPhong;

        private Label lblTangSo;
        private NumericUpDown nudTangSo;

        private Label lblLoaiPhong;
        private ComboBox cboLoaiPhong;

        private Label lblTinhTrang;
        private ComboBox cboTinhTrang;

        private PictureBox picAnh;
        private Button btnChonAnh;

        private Button btnThem;
        private Button btnSua;
        private Button btnXoa;
        private Button btnLamMoi;

        private Button btnQuanLyLoaiPhong;

        private Label lblLocLoai;
        private ComboBox cboLocLoaiPhong;

        private Label lblLocTinhTrang;
        private ComboBox cboLocTinhTrang;

        private Button btnTimKiem;

        private DataGridView dgvPhong;

        private DataGridViewTextBoxColumn colMaPhong;
        private DataGridViewImageColumn colAnh;
        private DataGridViewTextBoxColumn colSoPhong;
        private DataGridViewTextBoxColumn colTangSo;
        private DataGridViewTextBoxColumn colTenLoai;
        private DataGridViewTextBoxColumn colGiaMoiDem;
        private DataGridViewTextBoxColumn colTinhTrang;
    }
}