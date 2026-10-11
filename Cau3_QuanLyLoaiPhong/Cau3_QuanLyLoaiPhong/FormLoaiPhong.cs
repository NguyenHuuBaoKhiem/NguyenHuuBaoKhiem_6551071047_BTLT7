using Cau3_QuanLyLoaiPhong.Models;
using Microsoft.EntityFrameworkCore;

namespace Cau3_QuanLyLoaiPhong
{
    public partial class FormLoaiPhong : Form
    {
        private readonly QuanLyLoaiPhongContext _context;

        private int _maLoaiDangChon = 0;

        public FormLoaiPhong()
        {
            InitializeComponent();

            _context = new QuanLyLoaiPhongContext();

            Load += FormLoaiPhong_Load;
        }

        private async void FormLoaiPhong_Load(
            object? sender,
            EventArgs e)
        {
            await LoadData();

            LamMoiNhapLieu();
        }

        private async Task LoadData()
        {
            dgvLoaiPhong.DataSource =
                await _context.LoaiPhongs
                    .AsNoTracking()
                    .OrderBy(x => x.MaLoai)
                    .ToListAsync();

            dgvLoaiPhong.ClearSelection();
        }

        private bool KiemTraDuLieu()
        {
            if (string.IsNullOrWhiteSpace(txtTenLoai.Text))
            {
                MessageBox.Show(
                    "Tên loại phòng không được để trống!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtTenLoai.Focus();

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

            try
            {
                LoaiPhong loai = new LoaiPhong
                {
                    TenLoai = txtTenLoai.Text.Trim(),

                    GiaMoiDem = nudGiaMoiDem.Value,

                    MoTa = string.IsNullOrWhiteSpace(txtMoTa.Text)
                        ? null
                        : txtMoTa.Text.Trim()
                };

                _context.LoaiPhongs.Add(loai);

                await _context.SaveChangesAsync();

                MessageBox.Show(
                    "Thêm loại phòng thành công!");

                await LoadData();

                LamMoiNhapLieu();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Có lỗi xảy ra!\n" + ex.Message);
            }
        }

        private async void btnSua_Click(
            object sender,
            EventArgs e)
        {
            if (_maLoaiDangChon == 0)
            {
                MessageBox.Show(
                    "Vui lòng chọn loại phòng cần sửa!");

                return;
            }

            if (!KiemTraDuLieu())
                return;

            try
            {
                LoaiPhong? loai =
                    await _context.LoaiPhongs
                        .FindAsync(_maLoaiDangChon);

                if (loai == null)
                    return;

                loai.TenLoai =
                    txtTenLoai.Text.Trim();

                loai.GiaMoiDem =
                    nudGiaMoiDem.Value;

                loai.MoTa =
                    string.IsNullOrWhiteSpace(txtMoTa.Text)
                        ? null
                        : txtMoTa.Text.Trim();

                await _context.SaveChangesAsync();

                MessageBox.Show(
                    "Cập nhật loại phòng thành công!");

                await LoadData();

                LamMoiNhapLieu();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Có lỗi xảy ra!\n" + ex.Message);
            }
        }

        private async void btnXoa_Click(
            object sender,
            EventArgs e)
        {
            if (_maLoaiDangChon == 0)
            {
                MessageBox.Show(
                    "Vui lòng chọn loại phòng cần xóa!");

                return;
            }

            DialogResult result =
                MessageBox.Show(
                    "Bạn có chắc muốn xóa loại phòng này?",
                    "Xác nhận",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

            if (result != DialogResult.Yes)
                return;

            try
            {
                LoaiPhong? loai =
                    await _context.LoaiPhongs
                        .FindAsync(_maLoaiDangChon);

                if (loai == null)
                    return;

                _context.LoaiPhongs.Remove(loai);

                await _context.SaveChangesAsync();

                MessageBox.Show(
                    "Xóa loại phòng thành công!");

                await LoadData();

                LamMoiNhapLieu();
            }
            catch (DbUpdateException)
            {
                MessageBox.Show(
                    "Không thể xóa vì loại phòng đang có phòng sử dụng!",
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

        private void dgvLoaiPhong_SelectionChanged(
            object sender,
            EventArgs e)
        {
            if (dgvLoaiPhong.SelectedRows.Count == 0)
                return;

            if (dgvLoaiPhong.SelectedRows[0].DataBoundItem
                is not LoaiPhong loai)
            {
                return;
            }

            _maLoaiDangChon = loai.MaLoai;

            txtMaLoai.Text =
                loai.MaLoai.ToString();

            txtTenLoai.Text =
                loai.TenLoai;

            nudGiaMoiDem.Value =
                loai.GiaMoiDem ?? 0;

            txtMoTa.Text =
                loai.MoTa ?? "";
        }

        private void LamMoiNhapLieu()
        {
            _maLoaiDangChon = 0;

            txtMaLoai.Clear();
            txtTenLoai.Clear();
            txtMoTa.Clear();

            nudGiaMoiDem.Value = 0;

            dgvLoaiPhong.ClearSelection();

            txtTenLoai.Focus();
        }

        protected override void OnFormClosed(
            FormClosedEventArgs e)
        {
            _context.Dispose();

            base.OnFormClosed(e);
        }
    }
}