using Cau4_QuanLyLichKham.Models;
using Microsoft.EntityFrameworkCore;

namespace Cau4_QuanLyLichKham
{
    public partial class FormBacSi : Form
    {
        private readonly QuanLyLichKhamContext _context;

        private int _maBSDangChon = 0;

        public FormBacSi()
        {
            InitializeComponent();

            _context =
                new QuanLyLichKhamContext();

            Load += FormBacSi_Load;
        }

        private async void FormBacSi_Load(
            object? sender,
            EventArgs e)
        {
            await LoadData();

            LamMoiNhapLieu();
        }

        private async Task LoadData()
        {
            dgvBacSi.DataSource =
                await _context.Set<BacSi>()
                    .AsNoTracking()
                    .OrderBy(x => x.MaBs)
                    .ToListAsync();

            dgvBacSi.ClearSelection();
        }

        private bool KiemTraDuLieu()
        {
            if (string.IsNullOrWhiteSpace(
                    txtHoTen.Text))
            {
                MessageBox.Show(
                    "Họ tên bác sĩ không được để trống!");

                txtHoTen.Focus();

                return false;
            }

            return true;
        }

        private async void btnThem_Click(
            object sender,
            EventArgs e)
        {
            if (!KiemTraDuLieu())
                return;

            BacSi bacSi = new BacSi
            {
                HoTen =
                    txtHoTen.Text.Trim(),

                ChuyenKhoa =
                    string.IsNullOrWhiteSpace(
                        txtChuyenKhoa.Text)
                    ? null
                    : txtChuyenKhoa.Text.Trim(),

                Sdt =
                    string.IsNullOrWhiteSpace(
                        txtSDT.Text)
                    ? null
                    : txtSDT.Text.Trim()
            };

            _context.Set<BacSi>()
                .Add(bacSi);

            await _context
                .SaveChangesAsync();

            MessageBox.Show(
                "Thêm bác sĩ thành công!");

            await LoadData();

            LamMoiNhapLieu();
        }

        private async void btnSua_Click(
            object sender,
            EventArgs e)
        {
            if (_maBSDangChon == 0)
            {
                MessageBox.Show(
                    "Vui lòng chọn bác sĩ cần sửa!");

                return;
            }

            if (!KiemTraDuLieu())
                return;

            BacSi? bacSi =
                await _context.Set<BacSi>()
                    .FindAsync(
                        _maBSDangChon);

            if (bacSi == null)
                return;

            bacSi.HoTen =
                txtHoTen.Text.Trim();

            bacSi.ChuyenKhoa =
                string.IsNullOrWhiteSpace(
                    txtChuyenKhoa.Text)
                ? null
                : txtChuyenKhoa.Text.Trim();

            bacSi.Sdt =
                string.IsNullOrWhiteSpace(
                    txtSDT.Text)
                ? null
                : txtSDT.Text.Trim();

            await _context
                .SaveChangesAsync();

            MessageBox.Show(
                "Cập nhật bác sĩ thành công!");

            await LoadData();

            LamMoiNhapLieu();
        }

        private async void btnXoa_Click(
            object sender,
            EventArgs e)
        {
            if (_maBSDangChon == 0)
            {
                MessageBox.Show(
                    "Vui lòng chọn bác sĩ cần xóa!");

                return;
            }

            DialogResult result =
                MessageBox.Show(
                    "Bạn có chắc muốn xóa bác sĩ này?",
                    "Xác nhận",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

            if (result != DialogResult.Yes)
                return;

            try
            {
                BacSi? bacSi =
                    await _context.Set<BacSi>()
                        .FindAsync(
                            _maBSDangChon);

                if (bacSi == null)
                    return;

                _context.Set<BacSi>()
                    .Remove(bacSi);

                await _context
                    .SaveChangesAsync();

                MessageBox.Show(
                    "Xóa bác sĩ thành công!");

                await LoadData();

                LamMoiNhapLieu();
            }
            catch (DbUpdateException)
            {
                MessageBox.Show(
                    "Không thể xóa vì bác sĩ đang có lịch khám!",
                    "Lỗi ràng buộc",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private async void btnLamMoi_Click(
            object sender,
            EventArgs e)
        {
            LamMoiNhapLieu();

            await LoadData();
        }

        private void dgvBacSi_SelectionChanged(
            object sender,
            EventArgs e)
        {
            if (dgvBacSi.SelectedRows.Count == 0)
                return;

            if (dgvBacSi.SelectedRows[0]
                    .DataBoundItem
                is not BacSi bacSi)
            {
                return;
            }

            _maBSDangChon =
                bacSi.MaBs;

            txtMaBS.Text =
                bacSi.MaBs.ToString();

            txtHoTen.Text =
                bacSi.HoTen;

            txtChuyenKhoa.Text =
                bacSi.ChuyenKhoa ?? "";

            txtSDT.Text =
                bacSi.Sdt ?? "";
        }

        private void LamMoiNhapLieu()
        {
            _maBSDangChon = 0;

            txtMaBS.Clear();
            txtHoTen.Clear();
            txtChuyenKhoa.Clear();
            txtSDT.Clear();

            dgvBacSi.ClearSelection();

            txtHoTen.Focus();
        }

        protected override void OnFormClosed(
            FormClosedEventArgs e)
        {
            _context.Dispose();

            base.OnFormClosed(e);
        }
    }
}