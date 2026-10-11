using Cau1_QuanLyTheLoaiSach.Models;
using Microsoft.EntityFrameworkCore;

namespace Cau1_QuanLyTheLoaiSach
{
    public partial class Form1 : Form
    {
        private readonly QuanLyTheLoaiSachContext _context;

        private int _maTLDangChon = 0;

        public Form1()
        {
            InitializeComponent();

            _context = new QuanLyTheLoaiSachContext();

            Load += Form1_Load;
        }

        // =========================
        // LOAD FORM
        // =========================
        private async void Form1_Load(object? sender, EventArgs e)
        {
            await LoadData();
            LamMoiNhapLieu();
        }

        // =========================
        // LOAD DATABASE
        // =========================
        private async Task LoadData(string tuKhoa = "")
        {
            try
            {
                IQueryable<TheLoaiSach> query =
                    _context.TheLoaiSaches
                        .AsNoTracking();

                if (!string.IsNullOrWhiteSpace(tuKhoa))
                {
                    tuKhoa = tuKhoa.Trim();

                    query = query.Where(x =>
                        x.TenTheLoai.Contains(tuKhoa));
                }

                dgvTheLoaiSach.DataSource =
                    await query
                        .OrderBy(x => x.MaTl)
                        .ToListAsync();

                dgvTheLoaiSach.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Không thể tải dữ liệu!\n" + ex.Message,
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // =========================
        // VALIDATE
        // =========================
        private bool KiemTraDuLieu()
        {
            if (string.IsNullOrWhiteSpace(txtTenTheLoai.Text))
            {
                MessageBox.Show(
                    "Tên thể loại không được để trống!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtTenTheLoai.Focus();

                return false;
            }

            return true;
        }

        // =========================
        // KIỂM TRA TRÙNG TÊN
        // =========================
        private async Task<bool> TenDaTonTai(
            string ten,
            int maTLBoQua = 0)
        {
            return await _context.TheLoaiSaches
                .AsNoTracking()
                .AnyAsync(x =>
                    x.TenTheLoai == ten &&
                    x.MaTl != maTLBoQua);
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

            string ten = txtTenTheLoai.Text.Trim();

            if (await TenDaTonTai(ten))
            {
                MessageBox.Show(
                    "Tên thể loại đã tồn tại!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtTenTheLoai.Focus();

                return;
            }

            try
            {
                TheLoaiSach theLoai = new TheLoaiSach
                {
                    TenTheLoai = ten,

                    MoTa = string.IsNullOrWhiteSpace(txtMoTa.Text)
                        ? null
                        : txtMoTa.Text.Trim(),

                    SoLuongSach = 0,

                    NgayTao = DateTime.Now
                };

                _context.TheLoaiSaches.Add(theLoai);

                await _context.SaveChangesAsync();

                MessageBox.Show(
                    "Thêm thể loại thành công!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                await LoadData();

                LamMoiNhapLieu();
            }
            catch (DbUpdateException)
            {
                MessageBox.Show(
                    "Tên thể loại đã tồn tại hoặc dữ liệu không hợp lệ!",
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Có lỗi xảy ra!\n" + ex.Message,
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // =========================
        // SỬA
        // =========================
        private async void btnSua_Click(
            object sender,
            EventArgs e)
        {
            if (_maTLDangChon == 0)
            {
                MessageBox.Show(
                    "Vui lòng chọn thể loại cần sửa!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            if (!KiemTraDuLieu())
                return;

            string ten = txtTenTheLoai.Text.Trim();

            if (await TenDaTonTai(ten, _maTLDangChon))
            {
                MessageBox.Show(
                    "Tên thể loại đã tồn tại!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            try
            {
                TheLoaiSach? theLoai =
                    await _context.TheLoaiSaches
                        .FindAsync(_maTLDangChon);

                if (theLoai == null)
                {
                    MessageBox.Show(
                        "Không tìm thấy thể loại!");

                    return;
                }

                theLoai.TenTheLoai = ten;

                theLoai.MoTa =
                    string.IsNullOrWhiteSpace(txtMoTa.Text)
                        ? null
                        : txtMoTa.Text.Trim();

                await _context.SaveChangesAsync();

                MessageBox.Show(
                    "Cập nhật thành công!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                await LoadData();

                LamMoiNhapLieu();
            }
            catch (DbUpdateException)
            {
                MessageBox.Show(
                    "Không thể cập nhật. Tên thể loại có thể đã tồn tại!",
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Có lỗi xảy ra!\n" + ex.Message,
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // =========================
        // XÓA
        // =========================
        private async void btnXoa_Click(
            object sender,
            EventArgs e)
        {
            if (_maTLDangChon == 0)
            {
                MessageBox.Show(
                    "Vui lòng chọn thể loại cần xóa!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            DialogResult result = MessageBox.Show(
                "Bạn có chắc chắn muốn xóa thể loại này?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result != DialogResult.Yes)
                return;

            try
            {
                TheLoaiSach? theLoai =
                    await _context.TheLoaiSaches
                        .FindAsync(_maTLDangChon);

                if (theLoai == null)
                {
                    MessageBox.Show(
                        "Không tìm thấy thể loại!");

                    return;
                }

                _context.TheLoaiSaches.Remove(theLoai);

                await _context.SaveChangesAsync();

                MessageBox.Show(
                    "Xóa thể loại thành công!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                await LoadData();

                LamMoiNhapLieu();
            }
            catch (DbUpdateException)
            {
                MessageBox.Show(
                    "Không thể xóa vì thể loại đang được dữ liệu khác tham chiếu!",
                    "Lỗi ràng buộc",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Có lỗi xảy ra!\n" + ex.Message,
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // =========================
        // TÌM KIẾM
        // =========================
        private async void btnTimKiem_Click(
            object sender,
            EventArgs e)
        {
            await LoadData(txtTimKiem.Text);
        }

        // =========================
        // LÀM MỚI
        // =========================
        private async void btnLamMoi_Click(
            object sender,
            EventArgs e)
        {
            txtTimKiem.Clear();

            LamMoiNhapLieu();

            await LoadData();
        }

        // =========================
        // RESET CONTROL
        // =========================
        private void LamMoiNhapLieu()
        {
            _maTLDangChon = 0;

            txtMaTL.Clear();
            txtTenTheLoai.Clear();
            txtMoTa.Clear();

            lblNgayTao.Text = "---";

            dgvTheLoaiSach.ClearSelection();

            txtTenTheLoai.Focus();
        }

        // =========================
        // CHỌN DÒNG DATAGRIDVIEW
        // =========================
        private void dgvTheLoaiSach_SelectionChanged(
            object sender,
            EventArgs e)
        {
            if (dgvTheLoaiSach.SelectedRows.Count == 0)
                return;

            if (dgvTheLoaiSach.SelectedRows[0]
                    .DataBoundItem is not TheLoaiSach theLoai)
            {
                return;
            }

            _maTLDangChon = theLoai.MaTl;

            txtMaTL.Text =
                theLoai.MaTl.ToString();

            txtTenTheLoai.Text =
                theLoai.TenTheLoai;

            txtMoTa.Text =
                theLoai.MoTa ?? "";

            lblNgayTao.Text =
                theLoai.NgayTao
                    .ToString("dd/MM/yyyy HH:mm:ss");
        }

        protected override void OnFormClosed(
            FormClosedEventArgs e)
        {
            _context.Dispose();

            base.OnFormClosed(e);
        }
    }
}