using Cau2_QuanLyHoiVien.Models;
using Microsoft.EntityFrameworkCore;

namespace Cau2_QuanLyHoiVien
{
    public partial class Form1 : Form
    {
        private readonly QuanLyHoiVienContext _context;

        private int _maHVDangChon = 0;

        public Form1()
        {
            InitializeComponent();

            _context =
                new QuanLyHoiVienContext();

            Load += Form1_Load;
        }

        // ==============================
        // LOAD FORM
        // ==============================
        private async void Form1_Load(
            object? sender,
            EventArgs e)
        {
            // Hạng thành viên
            cboHangThanhVien.Items.Clear();

            cboHangThanhVien.Items.AddRange(
                new object[]
                {
                    "Basic",
                    "VIP",
                    "Premium"
                });

            cboHangThanhVien.SelectedIndex = 0;

            // ComboBox lọc
            cboLocHang.Items.Clear();

            cboLocHang.Items.AddRange(
                new object[]
                {
                    "Tất cả",
                    "Basic",
                    "VIP",
                    "Premium"
                });

            cboLocHang.SelectedIndex = 0;

            // Ngày sinh mặc định
            dtpNgaySinh.Value =
                DateTime.Today.AddYears(-18);

            await LoadData();

            LamMoiNhapLieu();
        }

        // ==============================
        // LOAD DỮ LIỆU
        // ==============================
        private async Task LoadData()
        {
            try
            {
                string hoTen =
                    txtTimKiem.Text.Trim();

                string hang =
                    cboLocHang.SelectedItem?.ToString()
                    ?? "Tất cả";

                IQueryable<HoiVien> query =
                    _context.HoiViens
                        .AsNoTracking();

                // Tìm gần đúng theo họ tên
                if (!string.IsNullOrWhiteSpace(hoTen))
                {
                    query =
                        query.Where(x =>
                            x.HoTen.Contains(hoTen));
                }

                // Lọc theo hạng
                if (hang != "Tất cả")
                {
                    query =
                        query.Where(x =>
                            x.HangThanhVien == hang);
                }

                dgvHoiVien.DataSource =
                    await query
                        .OrderBy(x => x.MaHv)
                        .ToListAsync();

                dgvHoiVien.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Không thể tải dữ liệu!\n"
                    + ex.Message,
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // ==============================
        // VALIDATE
        // ==============================
        private bool KiemTraDuLieu()
        {
            // Họ tên
            if (string.IsNullOrWhiteSpace(
                    txtHoTen.Text))
            {
                MessageBox.Show(
                    "Họ tên không được để trống!",
                    "Lỗi họ tên",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtHoTen.Focus();

                return false;
            }

            // SĐT
            string sdt =
                txtSDT.Text.Trim();

            if (string.IsNullOrWhiteSpace(sdt))
            {
                MessageBox.Show(
                    "Số điện thoại không được để trống!",
                    "Lỗi số điện thoại",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtSDT.Focus();

                return false;
            }

            if (!sdt.All(char.IsDigit))
            {
                MessageBox.Show(
                    "Số điện thoại chỉ được chứa chữ số!",
                    "Lỗi số điện thoại",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtSDT.Focus();

                return false;
            }

            if (sdt.Length < 9 ||
                sdt.Length > 11)
            {
                MessageBox.Show(
                    "Số điện thoại phải từ 9 đến 11 chữ số!",
                    "Lỗi số điện thoại",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtSDT.Focus();

                return false;
            }

            // Email
            string email =
                txtEmail.Text.Trim();

            if (string.IsNullOrWhiteSpace(email))
            {
                MessageBox.Show(
                    "Email không được để trống!",
                    "Lỗi Email",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtEmail.Focus();

                return false;
            }

            if (!email.Contains('@'))
            {
                MessageBox.Show(
                    "Email phải chứa ký tự @!",
                    "Lỗi Email",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtEmail.Focus();

                return false;
            }

            // Tuổi
            int tuoi =
                TinhTuoi(
                    dtpNgaySinh.Value);

            if (tuoi < 15)
            {
                MessageBox.Show(
                    "Hội viên phải từ 15 tuổi trở lên!",
                    "Lỗi ngày sinh",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                dtpNgaySinh.Focus();

                return false;
            }

            // Hạng
            if (cboHangThanhVien.SelectedIndex == -1)
            {
                MessageBox.Show(
                    "Vui lòng chọn hạng thành viên!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return false;
            }

            return true;
        }

        // ==============================
        // TÍNH TUỔI
        // ==============================
        private int TinhTuoi(
            DateTime ngaySinh)
        {
            DateTime homNay =
                DateTime.Today;

            int tuoi =
                homNay.Year
                - ngaySinh.Year;

            if (ngaySinh.Date >
                homNay.AddYears(-tuoi))
            {
                tuoi--;
            }

            return tuoi;
        }

        // ==============================
        // THÊM
        // ==============================
        private async void btnThem_Click(
            object sender,
            EventArgs e)
        {
            if (!KiemTraDuLieu())
                return;

            try
            {
                HoiVien hoiVien =
                    new HoiVien
                    {
                        HoTen =
                            txtHoTen.Text.Trim(),

                        // 1 = Nam
                        // 0 = Nữ
                        GioiTinh =
                            radNam.Checked,

                        NgaySinh =
                            DateOnly.FromDateTime(
                                dtpNgaySinh.Value),

                        Sdt =
                            txtSDT.Text.Trim(),

                        Email =
                            txtEmail.Text.Trim(),

                        HangThanhVien =
                            cboHangThanhVien
                                .SelectedItem!
                                .ToString(),

                        NgayDangKy =
                            DateTime.Now,

                        TrangThai =
                            chkTrangThai.Checked
                    };

                _context.HoiViens.Add(
                    hoiVien);

                await _context
                    .SaveChangesAsync();

                MessageBox.Show(
                    "Thêm hội viên thành công!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                LamMoiNhapLieu();

                await LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Có lỗi xảy ra!\n"
                    + ex.Message,
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // ==============================
        // SỬA
        // ==============================
        private async void btnSua_Click(
            object sender,
            EventArgs e)
        {
            if (_maHVDangChon == 0)
            {
                MessageBox.Show(
                    "Vui lòng chọn hội viên cần sửa!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            if (!KiemTraDuLieu())
                return;

            try
            {
                HoiVien? hoiVien =
                    await _context.HoiViens
                        .FindAsync(
                            _maHVDangChon);

                if (hoiVien == null)
                {
                    MessageBox.Show(
                        "Không tìm thấy hội viên!");

                    return;
                }

                hoiVien.HoTen =
                    txtHoTen.Text.Trim();

                hoiVien.GioiTinh =
                    radNam.Checked;

                hoiVien.NgaySinh =
                    DateOnly.FromDateTime(
                        dtpNgaySinh.Value);

                hoiVien.Sdt =
                    txtSDT.Text.Trim();

                hoiVien.Email =
                    txtEmail.Text.Trim();

                hoiVien.HangThanhVien =
                    cboHangThanhVien
                        .SelectedItem!
                        .ToString();

                hoiVien.TrangThai =
                    chkTrangThai.Checked;

                await _context
                    .SaveChangesAsync();

                MessageBox.Show(
                    "Cập nhật hội viên thành công!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                LamMoiNhapLieu();

                await LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Có lỗi xảy ra!\n"
                    + ex.Message,
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // ==============================
        // XÓA
        // ==============================
        private async void btnXoa_Click(
            object sender,
            EventArgs e)
        {
            if (_maHVDangChon == 0)
            {
                MessageBox.Show(
                    "Vui lòng chọn hội viên cần xóa!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            DialogResult result =
                MessageBox.Show(
                    "Bạn có chắc chắn muốn xóa hội viên này?",
                    "Xác nhận xóa",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

            if (result != DialogResult.Yes)
                return;

            try
            {
                HoiVien? hoiVien =
                    await _context.HoiViens
                        .FindAsync(
                            _maHVDangChon);

                if (hoiVien == null)
                {
                    MessageBox.Show(
                        "Không tìm thấy hội viên!");

                    return;
                }

                _context.HoiViens.Remove(
                    hoiVien);

                await _context
                    .SaveChangesAsync();

                MessageBox.Show(
                    "Xóa hội viên thành công!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                LamMoiNhapLieu();

                await LoadData();
            }
            catch (DbUpdateException)
            {
                MessageBox.Show(
                    "Không thể xóa hội viên do lỗi dữ liệu!",
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Có lỗi xảy ra!\n"
                    + ex.Message,
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // ==============================
        // TÌM KIẾM
        // ==============================
        private async void btnTimKiem_Click(
            object sender,
            EventArgs e)
        {
            await LoadData();
        }

        // ==============================
        // LÀM MỚI
        // ==============================
        private async void btnLamMoi_Click(
            object sender,
            EventArgs e)
        {
            txtTimKiem.Clear();

            cboLocHang.SelectedIndex = 0;

            LamMoiNhapLieu();

            await LoadData();
        }

        // ==============================
        // RESET FORM
        // ==============================
        private void LamMoiNhapLieu()
        {
            _maHVDangChon = 0;

            txtHoTen.Clear();
            txtSDT.Clear();
            txtEmail.Clear();

            radNam.Checked = true;

            dtpNgaySinh.Value =
                DateTime.Today.AddYears(-18);

            if (cboHangThanhVien.Items.Count > 0)
            {
                cboHangThanhVien.SelectedIndex =
                    0;
            }

            chkTrangThai.Checked =
                true;

            dgvHoiVien.ClearSelection();

            txtHoTen.Focus();
        }

        // ==============================
        // CHỌN DÒNG DATAGRIDVIEW
        // ==============================
        private void dgvHoiVien_SelectionChanged(
            object sender,
            EventArgs e)
        {
            if (dgvHoiVien.SelectedRows.Count == 0)
                return;

            if (dgvHoiVien.SelectedRows[0]
                    .DataBoundItem
                is not HoiVien hoiVien)
            {
                return;
            }

            _maHVDangChon =
                hoiVien.MaHv;

            txtHoTen.Text =
                hoiVien.HoTen;

            txtSDT.Text =
                hoiVien.Sdt ?? "";

            txtEmail.Text =
                hoiVien.Email ?? "";

            // Giới tính
            if (hoiVien.GioiTinh == true)
            {
                radNam.Checked =
                    true;
            }
            else
            {
                radNu.Checked =
                    true;
            }

            // Ngày sinh
            if (DateTime.TryParse(
                    hoiVien.NgaySinh.ToString(),
                    out DateTime ngaySinh))
            {
                dtpNgaySinh.Value =
                    ngaySinh;
            }

            // Hạng thành viên
            if (!string.IsNullOrWhiteSpace(
                    hoiVien.HangThanhVien))
            {
                cboHangThanhVien.SelectedItem =
                    hoiVien.HangThanhVien;
            }

            // Trạng thái
            chkTrangThai.Checked =
                hoiVien.TrangThai == true;
        }

        // ==============================
        // HIỂN THỊ BOOL THÀNH CHỮ
        // ==============================
        private void dgvHoiVien_CellFormatting(
            object sender,
            DataGridViewCellFormattingEventArgs e)
        {
            // ==========================
            // GIỚI TÍNH
            // ==========================
            if (dgvHoiVien.Columns[e.ColumnIndex]
                    .Name == "colGioiTinh")
            {
                if (e.Value != null &&
                    e.Value != DBNull.Value)
                {
                    bool gioiTinh =
                        Convert.ToBoolean(
                            e.Value);

                    e.Value =
                        gioiTinh
                            ? "Nam"
                            : "Nữ";

                    e.FormattingApplied =
                        true;
                }
            }

            // ==========================
            // TRẠNG THÁI
            // ==========================
            if (dgvHoiVien.Columns[e.ColumnIndex]
                    .Name == "colTrangThai")
            {
                if (e.Value != null &&
                    e.Value != DBNull.Value)
                {
                    bool trangThai =
                        Convert.ToBoolean(
                            e.Value);

                    e.Value =
                        trangThai
                            ? "Đang hoạt động"
                            : "Tạm ngưng";

                    e.FormattingApplied =
                        true;
                }
            }

            // ==========================
            // NGÀY SINH
            // ==========================
            if (dgvHoiVien.Columns[e.ColumnIndex]
                    .Name == "colNgaySinh")
            {
                if (e.Value != null)
                {
                    if (DateTime.TryParse(
                            e.Value.ToString(),
                            out DateTime ngaySinh))
                    {
                        e.Value =
                            ngaySinh.ToString(
                                "dd/MM/yyyy");

                        e.FormattingApplied =
                            true;
                    }
                }
            }
        }

        // ==============================
        // ĐÓNG FORM
        // ==============================
        protected override void OnFormClosed(
            FormClosedEventArgs e)
        {
            _context.Dispose();

            base.OnFormClosed(e);
        }
    }
}