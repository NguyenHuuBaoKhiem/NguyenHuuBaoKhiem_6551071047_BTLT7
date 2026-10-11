using Cau3_QuanLyLoaiPhong.Models;
using Microsoft.EntityFrameworkCore;

namespace Cau3_QuanLyLoaiPhong
{
    public partial class Form1 : Form
    {
        private readonly QuanLyLoaiPhongContext _context;

        private int _maPhongDangChon = 0;

        private string? _tenFileAnh;

        public Form1()
        {
            InitializeComponent();

            _context =
                new QuanLyLoaiPhongContext();

            Load += Form1_Load;
        }

        // ==============================
        // VIEW MODEL DATAGRID
        // ==============================
        private class PhongViewModel
        {
            public int MaPhong { get; set; }

            public Image? Anh { get; set; }

            public string SoPhong { get; set; } = "";

            public int? TangSo { get; set; }

            public int MaLoai { get; set; }

            public string TenLoai { get; set; } = "";

            public decimal? GiaMoiDem { get; set; }

            public string TinhTrang { get; set; } = "";

            public string? HinhAnh { get; set; }
        }

        private class LoaiPhongFilterItem
        {
            public int? MaLoai { get; set; }

            public string TenLoai { get; set; } = "";

            public override string ToString()
            {
                return TenLoai;
            }
        }

        // ==============================
        // LOAD FORM
        // ==============================
        private async void Form1_Load(
            object? sender,
            EventArgs e)
        {
            cboTinhTrang.Items.AddRange(
                new object[]
                {
                    "Trống",
                    "Đang ở",
                    "Đang dọn"
                });

            cboTinhTrang.SelectedIndex = 0;

            cboLocTinhTrang.Items.AddRange(
                new object[]
                {
                    "Tất cả",
                    "Trống",
                    "Đang ở",
                    "Đang dọn"
                });

            cboLocTinhTrang.SelectedIndex = 0;

            await LoadLoaiPhongCombos();

            await LoadData();

            LamMoiNhapLieu();
        }

        // ==============================
        // LOAD COMBO LOẠI PHÒNG
        // ==============================
        private async Task LoadLoaiPhongCombos()
        {
            List<LoaiPhong> ds =
                await _context.LoaiPhongs
                    .AsNoTracking()
                    .OrderBy(x => x.TenLoai)
                    .ToListAsync();

            cboLoaiPhong.DataSource = null;

            cboLoaiPhong.DataSource = ds;

            cboLoaiPhong.DisplayMember =
                "TenLoai";

            cboLoaiPhong.ValueMember =
                "MaLoai";

            List<LoaiPhongFilterItem> dsLoc =
                new List<LoaiPhongFilterItem>
                {
                    new LoaiPhongFilterItem
                    {
                        MaLoai = null,
                        TenLoai = "Tất cả"
                    }
                };

            dsLoc.AddRange(
                ds.Select(x =>
                    new LoaiPhongFilterItem
                    {
                        MaLoai = x.MaLoai,
                        TenLoai = x.TenLoai
                    }));

            cboLocLoaiPhong.DataSource = null;

            cboLocLoaiPhong.DataSource =
                dsLoc;

            cboLocLoaiPhong.DisplayMember =
                "TenLoai";
        }

        // ==============================
        // LOAD PHÒNG
        // ==============================
        private async Task LoadData()
        {
            try
            {
                IQueryable<Phong> query =
                    _context.Phongs
                        .AsNoTracking()
                        .Include(x =>
                            x.MaLoaiNavigation);

                // Lọc loại
                if (cboLocLoaiPhong.SelectedItem
                    is LoaiPhongFilterItem loaiLoc &&
                    loaiLoc.MaLoai.HasValue)
                {
                    int maLoai =
                        loaiLoc.MaLoai.Value;

                    query = query.Where(x =>
                        x.MaLoai == maLoai);
                }

                // Lọc tình trạng
                string tinhTrangLoc =
                    cboLocTinhTrang.SelectedItem?
                        .ToString()
                    ?? "Tất cả";

                if (tinhTrangLoc != "Tất cả")
                {
                    query = query.Where(x =>
                        x.TinhTrang == tinhTrangLoc);
                }

                List<Phong> ds =
                    await query
                        .OrderBy(x => x.MaPhong)
                        .ToListAsync();

                GiaiPhongAnhGrid();

                List<PhongViewModel> view =
                    ds.Select(x =>
                        new PhongViewModel
                        {
                            MaPhong =
                                x.MaPhong,

                            Anh =
                                LoadImageSafe(
                                    x.HinhAnh),

                            SoPhong =
                                x.SoPhong,

                            TangSo =
                                x.TangSo,

                            MaLoai =
                                x.MaLoai,

                            TenLoai =
                                x.MaLoaiNavigation?
                                    .TenLoai
                                ?? "",

                            GiaMoiDem =
                                x.MaLoaiNavigation?
                                    .GiaMoiDem,

                            TinhTrang =
                                x.TinhTrang ?? "",

                            HinhAnh =
                                x.HinhAnh
                        })
                    .ToList();

                dgvPhong.DataSource =
                    view;

                dgvPhong.ClearSelection();
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
        // THƯ MỤC IMAGES
        // ==============================
        private string GetImagesFolder()
        {
            string folder =
                Path.Combine(
                    AppContext.BaseDirectory,
                    "Images");

            if (!Directory.Exists(folder))
            {
                Directory.CreateDirectory(folder);
            }

            return folder;
        }

        // ==============================
        // LOAD ẢNH KHÔNG KHÓA FILE
        // ==============================
        private Image? LoadImageSafe(
            string? fileName)
        {
            if (string.IsNullOrWhiteSpace(fileName))
                return null;

            string path =
                Path.Combine(
                    GetImagesFolder(),
                    fileName);

            if (!File.Exists(path))
                return null;

            try
            {
                using Image temp =
                    Image.FromFile(path);

                return new Bitmap(temp);
            }
            catch
            {
                return null;
            }
        }

        // ==============================
        // HIỂN THỊ PICTUREBOX
        // ==============================
        private void HienThiAnh(
            string? fileName)
        {
            if (picAnh.Image != null)
            {
                picAnh.Image.Dispose();
                picAnh.Image = null;
            }

            picAnh.Image =
                LoadImageSafe(fileName);
        }

        // ==============================
        // CHỌN ẢNH
        // ==============================
        private void btnChonAnh_Click(
            object sender,
            EventArgs e)
        {
            using OpenFileDialog dialog =
                new OpenFileDialog();

            dialog.Filter =
                "Image files|*.jpg;*.jpeg;*.png;*.bmp";

            dialog.Title =
                "Chọn ảnh phòng";

            if (dialog.ShowDialog()
                != DialogResult.OK)
            {
                return;
            }

            try
            {
                string fileName =
                    DateTime.Now
                        .ToString("yyyyMMddHHmmssfff")
                    + "_"
                    + Path.GetFileName(
                        dialog.FileName);

                string destination =
                    Path.Combine(
                        GetImagesFolder(),
                        fileName);

                File.Copy(
                    dialog.FileName,
                    destination,
                    true);

                // Chỉ lưu TÊN FILE
                _tenFileAnh =
                    fileName;

                HienThiAnh(
                    _tenFileAnh);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Không thể chọn ảnh!\n"
                    + ex.Message);
            }
        }

        // ==============================
        // VALIDATE
        // ==============================
        private bool KiemTraDuLieu()
        {
            if (string.IsNullOrWhiteSpace(
                    txtSoPhong.Text))
            {
                MessageBox.Show(
                    "Số phòng không được để trống!");

                txtSoPhong.Focus();

                return false;
            }

            if (cboLoaiPhong.SelectedIndex == -1)
            {
                MessageBox.Show(
                    "Vui lòng chọn loại phòng!");

                return false;
            }

            if (cboTinhTrang.SelectedIndex == -1)
            {
                MessageBox.Show(
                    "Vui lòng chọn tình trạng!");

                return false;
            }

            return true;
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
                Phong phong = new Phong
                {
                    SoPhong =
                        txtSoPhong.Text.Trim(),

                    TangSo =
                        (int)nudTangSo.Value,

                    MaLoai =
                        Convert.ToInt32(
                            cboLoaiPhong
                                .SelectedValue),

                    TinhTrang =
                        cboTinhTrang
                            .SelectedItem!
                            .ToString(),

                    HinhAnh =
                        _tenFileAnh
                };

                _context.Phongs.Add(
                    phong);

                await _context
                    .SaveChangesAsync();

                MessageBox.Show(
                    "Thêm phòng thành công!");

                await LoadData();

                LamMoiNhapLieu();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Có lỗi xảy ra!\n"
                    + ex.Message);
            }
        }

        // ==============================
        // SỬA
        // ==============================
        private async void btnSua_Click(
            object sender,
            EventArgs e)
        {
            if (_maPhongDangChon == 0)
            {
                MessageBox.Show(
                    "Vui lòng chọn phòng cần sửa!");

                return;
            }

            if (!KiemTraDuLieu())
                return;

            try
            {
                Phong? phong =
                    await _context.Phongs
                        .FindAsync(
                            _maPhongDangChon);

                if (phong == null)
                    return;

                phong.SoPhong =
                    txtSoPhong.Text.Trim();

                phong.TangSo =
                    (int)nudTangSo.Value;

                phong.MaLoai =
                    Convert.ToInt32(
                        cboLoaiPhong
                            .SelectedValue);

                phong.TinhTrang =
                    cboTinhTrang
                        .SelectedItem!
                        .ToString();

                phong.HinhAnh =
                    _tenFileAnh;

                await _context
                    .SaveChangesAsync();

                MessageBox.Show(
                    "Cập nhật phòng thành công!");

                await LoadData();

                LamMoiNhapLieu();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Có lỗi xảy ra!\n"
                    + ex.Message);
            }
        }

        // ==============================
        // XÓA
        // ==============================
        private async void btnXoa_Click(
            object sender,
            EventArgs e)
        {
            if (_maPhongDangChon == 0)
            {
                MessageBox.Show(
                    "Vui lòng chọn phòng cần xóa!");

                return;
            }

            DialogResult result =
                MessageBox.Show(
                    "Bạn có chắc chắn muốn xóa phòng này?",
                    "Xác nhận xóa",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

            if (result != DialogResult.Yes)
                return;

            try
            {
                Phong? phong =
                    await _context.Phongs
                        .FindAsync(
                            _maPhongDangChon);

                if (phong == null)
                    return;

                _context.Phongs.Remove(
                    phong);

                await _context
                    .SaveChangesAsync();

                MessageBox.Show(
                    "Xóa phòng thành công!");

                await LoadData();

                LamMoiNhapLieu();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Có lỗi xảy ra!\n"
                    + ex.Message);
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
            if (cboLocLoaiPhong.Items.Count > 0)
                cboLocLoaiPhong.SelectedIndex = 0;

            if (cboLocTinhTrang.Items.Count > 0)
                cboLocTinhTrang.SelectedIndex = 0;

            LamMoiNhapLieu();

            await LoadData();
        }

        // ==============================
        // QUẢN LÝ LOẠI PHÒNG
        // ==============================
        private async void btnQuanLyLoaiPhong_Click(
            object sender,
            EventArgs e)
        {
            using FormLoaiPhong form =
                new FormLoaiPhong();

            form.ShowDialog(this);

            await LoadLoaiPhongCombos();

            await LoadData();

            LamMoiNhapLieu();
        }

        // ==============================
        // CHỌN DÒNG
        // ==============================
        private void dgvPhong_SelectionChanged(
            object sender,
            EventArgs e)
        {
            if (dgvPhong.SelectedRows.Count == 0)
                return;

            if (dgvPhong.SelectedRows[0]
                    .DataBoundItem
                is not PhongViewModel phong)
            {
                return;
            }

            _maPhongDangChon =
                phong.MaPhong;

            txtSoPhong.Text =
                phong.SoPhong;

            if (phong.TangSo.HasValue)
            {
                decimal tang =
                    phong.TangSo.Value;

                if (tang >= nudTangSo.Minimum &&
                    tang <= nudTangSo.Maximum)
                {
                    nudTangSo.Value =
                        tang;
                }
            }

            cboLoaiPhong.SelectedValue =
                phong.MaLoai;

            cboTinhTrang.SelectedItem =
                phong.TinhTrang;

            _tenFileAnh =
                phong.HinhAnh;

            HienThiAnh(
                _tenFileAnh);
        }

        // ==============================
        // RESET
        // ==============================
        private void LamMoiNhapLieu()
        {
            _maPhongDangChon = 0;

            txtSoPhong.Clear();

            nudTangSo.Value = 1;

            if (cboLoaiPhong.Items.Count > 0)
                cboLoaiPhong.SelectedIndex = 0;

            if (cboTinhTrang.Items.Count > 0)
                cboTinhTrang.SelectedIndex = 0;

            _tenFileAnh = null;

            HienThiAnh(null);

            dgvPhong.ClearSelection();

            txtSoPhong.Focus();
        }

        // ==============================
        // GIẢI PHÓNG ẢNH GRID
        // ==============================
        private void GiaiPhongAnhGrid()
        {
            if (dgvPhong.DataSource
                is List<PhongViewModel> oldList)
            {
                foreach (PhongViewModel item
                         in oldList)
                {
                    item.Anh?.Dispose();
                }
            }
        }

        // ==============================
        // ĐÓNG FORM
        // ==============================
        protected override void OnFormClosed(
            FormClosedEventArgs e)
        {
            GiaiPhongAnhGrid();

            if (picAnh.Image != null)
            {
                picAnh.Image.Dispose();
                picAnh.Image = null;
            }

            _context.Dispose();

            base.OnFormClosed(e);
        }
    }
}