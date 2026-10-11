using Cau4_QuanLyLichKham.Models;
using Microsoft.EntityFrameworkCore;

namespace Cau4_QuanLyLichKham
{
    public partial class Form1 : Form
    {
        private readonly QuanLyLichKhamContext _context;

        private int _maLichDangChon = 0;

        public Form1()
        {
            InitializeComponent();

            _context =
                new QuanLyLichKhamContext();

            Load += Form1_Load;
        }

        // =========================
        // VIEW MODEL
        // =========================
        private class LichKhamViewModel
        {
            public int MaLich { get; set; }

            public string TenBenhNhan { get; set; } = "";

            public string Sdt { get; set; } = "";

            public string NgayKham { get; set; } = "";

            public string GioKham { get; set; } = "";

            public int MaBs { get; set; }

            public string TenBacSi { get; set; } = "";

            public string ChuyenKhoa { get; set; } = "";

            public string TrangThai { get; set; } = "";
        }

        private class BacSiComboItem
        {
            public int? MaBs { get; set; }

            public string HienThi { get; set; } = "";

            public override string ToString()
            {
                return HienThi;
            }
        }

        // =========================
        // LOAD FORM
        // =========================
        private async void Form1_Load(
            object? sender,
            EventArgs e)
        {
            cboTrangThai.Items.AddRange(
                new object[]
                {
                    "Chờ khám",
                    "Đã khám",
                    "Đã hủy"
                });

            cboTrangThai.SelectedIndex = 0;

            dtpNgayKham.Value =
                DateTime.Today;

            dtpGioKham.Value =
                DateTime.Today.AddHours(8);

            dtpTuNgay.Value =
                DateTime.Today;

            dtpDenNgay.Value =
                DateTime.Today.AddDays(30);

            await LoadBacSi();

            await LoadData();

            LamMoiNhapLieu();
        }

        // =========================
        // LOAD BÁC SĨ
        // =========================
        private async Task LoadBacSi()
        {
            List<BacSi> ds =
                await _context.Set<BacSi>()
                    .AsNoTracking()
                    .OrderBy(x => x.HoTen)
                    .ToListAsync();

            List<BacSiComboItem> combo =
                ds.Select(x =>
                    new BacSiComboItem
                    {
                        MaBs = x.MaBs,

                        HienThi =
                            "BS. " + x.HoTen
                            + " - "
                            + (x.ChuyenKhoa ?? "")
                    })
                .ToList();

            cboBacSi.DataSource =
                combo.ToList();

            cboBacSi.DisplayMember =
                "HienThi";

            List<BacSiComboItem> loc =
                new List<BacSiComboItem>
                {
                    new BacSiComboItem
                    {
                        MaBs = null,
                        HienThi = "Tất cả bác sĩ"
                    }
                };

            loc.AddRange(combo);

            cboLocBacSi.DataSource =
                loc;

            cboLocBacSi.DisplayMember =
                "HienThi";
        }

        // =========================
        // LOAD DATA
        // =========================
        private async Task LoadData()
        {
            try
            {
                DateOnly tuNgay =
                    DateOnly.FromDateTime(
                        dtpTuNgay.Value.Date);

                DateOnly denNgay =
                    DateOnly.FromDateTime(
                        dtpDenNgay.Value.Date);

                IQueryable<LichKham> query =
                    _context.Set<LichKham>()
                        .AsNoTracking()
                        .Include(x =>
                            x.MaBsNavigation);

                query =
                    query.Where(x =>
                        x.NgayKham >= tuNgay &&
                        x.NgayKham <= denNgay);

                if (cboLocBacSi.SelectedItem
                    is BacSiComboItem bacSiLoc &&
                    bacSiLoc.MaBs.HasValue)
                {
                    int maBs =
                        bacSiLoc.MaBs.Value;

                    query =
                        query.Where(x =>
                            x.MaBs == maBs);
                }

                List<LichKham> ds =
                    await query
                        .OrderBy(x => x.NgayKham)
                        .ThenBy(x => x.GioKham)
                        .ToListAsync();

                dgvLichKham.DataSource =
                    ds.Select(x =>
                        new LichKhamViewModel
                        {
                            MaLich =
                                x.MaLich,

                            TenBenhNhan =
                                x.TenBenhNhan,

                            Sdt =
                                x.Sdt ?? "",

                            NgayKham =
                                x.NgayKham
                                    .ToString(
                                        "dd/MM/yyyy"),

                            GioKham =
                                x.GioKham
                                    .ToString(
                                        "HH:mm"),

                            MaBs =
                                x.MaBs,

                            TenBacSi =
                                x.MaBsNavigation?
                                    .HoTen
                                ?? "",

                            ChuyenKhoa =
                                x.MaBsNavigation?
                                    .ChuyenKhoa
                                ?? "",

                            TrangThai =
                                x.TrangThai ?? ""
                        })
                    .ToList();

                dgvLichKham.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Không thể tải dữ liệu!\n"
                    + ex.Message);
            }
        }

        // =========================
        // VALIDATE
        // =========================
        private bool KiemTraDuLieu()
        {
            if (string.IsNullOrWhiteSpace(
                    txtTenBenhNhan.Text))
            {
                MessageBox.Show(
                    "Tên bệnh nhân không được để trống!");

                txtTenBenhNhan.Focus();

                return false;
            }

            if (dtpNgayKham.Value.Date <
                DateTime.Today)
            {
                MessageBox.Show(
                    "Không được đặt lịch khám trong quá khứ!");

                return false;
            }

            if (cboBacSi.SelectedItem
                is not BacSiComboItem bacSi ||
                !bacSi.MaBs.HasValue)
            {
                MessageBox.Show(
                    "Vui lòng chọn bác sĩ!");

                return false;
            }

            return true;
        }

        // =========================
        // THÊM
        // =========================
        private async void btnThem_Click(
            object sender,
            EventArgs e)
        {
            if (!KiemTraDuLieu())
                return;

            BacSiComboItem bacSi =
                (BacSiComboItem)
                    cboBacSi.SelectedItem!;

            LichKham lich =
                new LichKham
                {
                    TenBenhNhan =
                        txtTenBenhNhan.Text.Trim(),

                    Sdt =
                        string.IsNullOrWhiteSpace(
                            txtSDT.Text)
                        ? null
                        : txtSDT.Text.Trim(),

                    NgayKham =
                        DateOnly.FromDateTime(
                            dtpNgayKham.Value),

                    GioKham =
                        TimeOnly.FromDateTime(
                            dtpGioKham.Value),

                    MaBs =
                        bacSi.MaBs!.Value,

                    TrangThai =
                        cboTrangThai
                            .SelectedItem!
                            .ToString()
                };

            _context.Set<LichKham>()
                .Add(lich);

            await _context
                .SaveChangesAsync();

            MessageBox.Show(
                "Thêm lịch khám thành công!");

            await LoadData();

            LamMoiNhapLieu();
        }

        // =========================
        // SỬA
        // =========================
        private async void btnSua_Click(
            object sender,
            EventArgs e)
        {
            if (_maLichDangChon == 0)
            {
                MessageBox.Show(
                    "Vui lòng chọn lịch khám cần sửa!");

                return;
            }

            if (!KiemTraDuLieu())
                return;

            LichKham? lich =
                await _context.Set<LichKham>()
                    .FindAsync(
                        _maLichDangChon);

            if (lich == null)
                return;

            BacSiComboItem bacSi =
                (BacSiComboItem)
                    cboBacSi.SelectedItem!;

            lich.TenBenhNhan =
                txtTenBenhNhan.Text.Trim();

            lich.Sdt =
                string.IsNullOrWhiteSpace(
                    txtSDT.Text)
                ? null
                : txtSDT.Text.Trim();

            lich.NgayKham =
                DateOnly.FromDateTime(
                    dtpNgayKham.Value);

            lich.GioKham =
                TimeOnly.FromDateTime(
                    dtpGioKham.Value);

            lich.MaBs =
                bacSi.MaBs!.Value;

            lich.TrangThai =
                cboTrangThai
                    .SelectedItem!
                    .ToString();

            await _context
                .SaveChangesAsync();

            MessageBox.Show(
                "Cập nhật lịch khám thành công!");

            await LoadData();

            LamMoiNhapLieu();
        }

        // =========================
        // XÓA
        // =========================
        private async void btnXoa_Click(
            object sender,
            EventArgs e)
        {
            if (_maLichDangChon == 0)
            {
                MessageBox.Show(
                    "Vui lòng chọn lịch khám cần xóa!");

                return;
            }

            DialogResult result =
                MessageBox.Show(
                    "Bạn có chắc muốn xóa lịch khám này?",
                    "Xác nhận xóa",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

            if (result != DialogResult.Yes)
                return;

            LichKham? lich =
                await _context.Set<LichKham>()
                    .FindAsync(
                        _maLichDangChon);

            if (lich == null)
                return;

            _context.Set<LichKham>()
                .Remove(lich);

            await _context
                .SaveChangesAsync();

            MessageBox.Show(
                "Xóa lịch khám thành công!");

            await LoadData();

            LamMoiNhapLieu();
        }

        // =========================
        // TÌM KIẾM
        // =========================
        private async void btnTimKiem_Click(
            object sender,
            EventArgs e)
        {
            if (dtpTuNgay.Value.Date >
                dtpDenNgay.Value.Date)
            {
                MessageBox.Show(
                    "Từ ngày phải nhỏ hơn hoặc bằng Đến ngày!");

                return;
            }

            await LoadData();
        }

        // =========================
        // LÀM MỚI
        // =========================
        private async void btnLamMoi_Click(
            object sender,
            EventArgs e)
        {
            dtpTuNgay.Value =
                DateTime.Today;

            dtpDenNgay.Value =
                DateTime.Today.AddDays(30);

            if (cboLocBacSi.Items.Count > 0)
                cboLocBacSi.SelectedIndex = 0;

            LamMoiNhapLieu();

            await LoadData();
        }

        // =========================
        // NÚT ĐI LIST
        // =========================
        private async void btnDiLiet_Click(
            object sender,
            EventArgs e)
        {
            dtpTuNgay.Value =
                DateTime.Today;

            dtpDenNgay.Value =
                DateTime.Today.AddYears(10);

            if (cboLocBacSi.Items.Count > 0)
                cboLocBacSi.SelectedIndex = 0;

            await LoadData();
        }

        // =========================
        // FORM BÁC SĨ
        // =========================
        private async void btnQuanLyBacSi_Click(
            object sender,
            EventArgs e)
        {
            using FormBacSi form =
                new FormBacSi();

            form.ShowDialog(this);

            await LoadBacSi();

            await LoadData();
        }

        // =========================
        // CHỌN DÒNG
        // =========================
        private void dgvLichKham_SelectionChanged(
            object sender,
            EventArgs e)
        {
            if (dgvLichKham.SelectedRows.Count == 0)
                return;

            if (dgvLichKham.SelectedRows[0]
                    .DataBoundItem
                is not LichKhamViewModel lich)
            {
                return;
            }

            _maLichDangChon =
                lich.MaLich;

            txtTenBenhNhan.Text =
                lich.TenBenhNhan;

            txtSDT.Text =
                lich.Sdt;

            if (DateTime.TryParseExact(
                    lich.NgayKham,
                    "dd/MM/yyyy",
                    null,
                    System.Globalization.DateTimeStyles.None,
                    out DateTime ngay))
            {
                dtpNgayKham.Value =
                    ngay;
            }

            if (TimeSpan.TryParse(
                    lich.GioKham,
                    out TimeSpan gio))
            {
                dtpGioKham.Value =
                    DateTime.Today.Add(gio);
            }

            for (int i = 0;
                 i < cboBacSi.Items.Count;
                 i++)
            {
                if (cboBacSi.Items[i]
                    is BacSiComboItem bs &&
                    bs.MaBs == lich.MaBs)
                {
                    cboBacSi.SelectedIndex =
                        i;

                    break;
                }
            }

            cboTrangThai.SelectedItem =
                lich.TrangThai;
        }

        // =========================
        // RESET
        // =========================
        private void LamMoiNhapLieu()
        {
            _maLichDangChon = 0;

            txtTenBenhNhan.Clear();
            txtSDT.Clear();

            dtpNgayKham.Value =
                DateTime.Today;

            dtpGioKham.Value =
                DateTime.Today.AddHours(8);

            if (cboBacSi.Items.Count > 0)
                cboBacSi.SelectedIndex = 0;

            if (cboTrangThai.Items.Count > 0)
                cboTrangThai.SelectedIndex = 0;

            dgvLichKham.ClearSelection();

            txtTenBenhNhan.Focus();
        }

        protected override void OnFormClosed(
            FormClosedEventArgs e)
        {
            _context.Dispose();

            base.OnFormClosed(e);
        }

        private void dtpGioKham_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }
    }
}