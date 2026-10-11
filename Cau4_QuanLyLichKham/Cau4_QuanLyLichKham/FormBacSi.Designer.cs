namespace Cau4_QuanLyLichKham
{
    partial class FormBacSi
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
            lblTieuDe = new Label();

            lblMaBS = new Label();
            txtMaBS = new TextBox();

            lblHoTen = new Label();
            txtHoTen = new TextBox();

            lblChuyenKhoa = new Label();
            txtChuyenKhoa = new TextBox();

            lblSDT = new Label();
            txtSDT = new TextBox();

            btnThem = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnLamMoi = new Button();

            dgvBacSi = new DataGridView();

            colMaBS = new DataGridViewTextBoxColumn();
            colHoTen = new DataGridViewTextBoxColumn();
            colChuyenKhoa = new DataGridViewTextBoxColumn();
            colSDT = new DataGridViewTextBoxColumn();

            ((System.ComponentModel.ISupportInitialize)dgvBacSi)
                .BeginInit();

            SuspendLayout();

            // Tiêu đề
            lblTieuDe.AutoSize = true;
            lblTieuDe.Font =
                new Font("Segoe UI", 15F, FontStyle.Bold);

            lblTieuDe.Location =
                new Point(30, 20);

            lblTieuDe.Text =
                "QUẢN LÝ BÁC SĨ";

            // Mã bác sĩ
            lblMaBS.AutoSize = true;
            lblMaBS.Location =
                new Point(40, 85);

            lblMaBS.Text =
                "Mã bác sĩ";

            txtMaBS.Location =
                new Point(150, 81);

            txtMaBS.ReadOnly = true;
            txtMaBS.Size =
                new Size(250, 23);

            // Họ tên
            lblHoTen.AutoSize = true;
            lblHoTen.Location =
                new Point(40, 125);

            lblHoTen.Text =
                "Họ tên";

            txtHoTen.Location =
                new Point(150, 121);

            txtHoTen.Size =
                new Size(250, 23);

            // Chuyên khoa
            lblChuyenKhoa.AutoSize = true;
            lblChuyenKhoa.Location =
                new Point(40, 165);

            lblChuyenKhoa.Text =
                "Chuyên khoa";

            txtChuyenKhoa.Location =
                new Point(150, 161);

            txtChuyenKhoa.Size =
                new Size(250, 23);

            // SĐT
            lblSDT.AutoSize = true;
            lblSDT.Location =
                new Point(40, 205);

            lblSDT.Text =
                "Số điện thoại";

            txtSDT.Location =
                new Point(150, 201);

            txtSDT.Size =
                new Size(250, 23);

            // Buttons
            btnThem.Location =
                new Point(480, 80);

            btnThem.Size =
                new Size(100, 38);

            btnThem.Text = "Thêm";
            btnThem.Click += btnThem_Click;

            btnSua.Location =
                new Point(595, 80);

            btnSua.Size =
                new Size(100, 38);

            btnSua.Text = "Sửa";
            btnSua.Click += btnSua_Click;

            btnXoa.Location =
                new Point(710, 80);

            btnXoa.Size =
                new Size(100, 38);

            btnXoa.Text = "Xóa";
            btnXoa.Click += btnXoa_Click;

            btnLamMoi.Location =
                new Point(825, 80);

            btnLamMoi.Size =
                new Size(100, 38);

            btnLamMoi.Text = "Làm mới";
            btnLamMoi.Click += btnLamMoi_Click;

            // DataGridView
            dgvBacSi.AllowUserToAddRows = false;
            dgvBacSi.AllowUserToDeleteRows = false;
            dgvBacSi.AutoGenerateColumns = false;

            dgvBacSi.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            dgvBacSi.BackgroundColor =
                Color.White;

            dgvBacSi.Columns.AddRange(
                colMaBS,
                colHoTen,
                colChuyenKhoa,
                colSDT
            );

            dgvBacSi.Location =
                new Point(40, 275);

            dgvBacSi.MultiSelect = false;
            dgvBacSi.ReadOnly = true;

            dgvBacSi.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            dgvBacSi.Size =
                new Size(885, 310);

            dgvBacSi.SelectionChanged +=
                dgvBacSi_SelectionChanged;

            colMaBS.DataPropertyName =
                "MaBs";

            colMaBS.HeaderText =
                "Mã BS";

            colMaBS.FillWeight = 60;

            colHoTen.DataPropertyName =
                "HoTen";

            colHoTen.HeaderText =
                "Họ tên";

            colChuyenKhoa.DataPropertyName =
                "ChuyenKhoa";

            colChuyenKhoa.HeaderText =
                "Chuyên khoa";

            colSDT.DataPropertyName =
                "Sdt";

            colSDT.HeaderText =
                "SĐT";

            // Form
            AutoScaleDimensions =
                new SizeF(7F, 15F);

            AutoScaleMode =
                AutoScaleMode.Font;

            BackColor =
                Color.WhiteSmoke;

            ClientSize =
                new Size(970, 625);

            Controls.Add(lblTieuDe);

            Controls.Add(lblMaBS);
            Controls.Add(txtMaBS);

            Controls.Add(lblHoTen);
            Controls.Add(txtHoTen);

            Controls.Add(lblChuyenKhoa);
            Controls.Add(txtChuyenKhoa);

            Controls.Add(lblSDT);
            Controls.Add(txtSDT);

            Controls.Add(btnThem);
            Controls.Add(btnSua);
            Controls.Add(btnXoa);
            Controls.Add(btnLamMoi);

            Controls.Add(dgvBacSi);

            StartPosition =
                FormStartPosition.CenterParent;

            Text =
                "Quản lý Bác sĩ";

            ((System.ComponentModel.ISupportInitialize)dgvBacSi)
                .EndInit();

            ResumeLayout(false);
            PerformLayout();
        }

        private Label lblTieuDe;

        private Label lblMaBS;
        private TextBox txtMaBS;

        private Label lblHoTen;
        private TextBox txtHoTen;

        private Label lblChuyenKhoa;
        private TextBox txtChuyenKhoa;

        private Label lblSDT;
        private TextBox txtSDT;

        private Button btnThem;
        private Button btnSua;
        private Button btnXoa;
        private Button btnLamMoi;

        private DataGridView dgvBacSi;

        private DataGridViewTextBoxColumn colMaBS;
        private DataGridViewTextBoxColumn colHoTen;
        private DataGridViewTextBoxColumn colChuyenKhoa;
        private DataGridViewTextBoxColumn colSDT;
    }
}