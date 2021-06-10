using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLCHApple_BUS;
using QLCHApple_DTO;

namespace QLCHApple_GUI
{
    public partial class frmQLKH : Form
    {
        #region Xu ly du lieu Form
        public frmQLKH()
        {
            InitializeComponent();
        }

        BindingList<KhachHang_DTO> _lstKH = new BindingList<KhachHang_DTO>();
        BindingList<LoaiKhachHang_DTO> _lstLKH = new BindingList<LoaiKhachHang_DTO>();
        KhachHang_DTO _KHHienTai = null;
        int _iTrangThaiForm = 0; // 0: xem, 1: thêm, 2: sửa.

        // Xử lý trạng thái đăng nhập(Phân quyền).
        NhanVien_DTO _NVDangNhap_frmQLKH = null;
        PhanQuyen_DTO _PQ_NVDangNhap = null;

        private void frmQLKH_Load(object sender, EventArgs e)
        {
            this.Visible = false;
            Util.EndAnimate(this, Util.Effect.Slide, 150, 180);

            _NVDangNhap_frmQLKH = frmHome.NVDangNhap_frmHome;

            if (_NVDangNhap_frmQLKH != null && _NVDangNhap_frmQLKH.strMaLoaiNV != "")
            {
                BindingList<PhanQuyen_DTO> _LSTPhanQuyen_DN = new BindingList<PhanQuyen_DTO>();
                _LSTPhanQuyen_DN = PhanQuyen_BUS.loadDSPhanQuyen_TheoMaLoaiNV(_NVDangNhap_frmQLKH.strMaLoaiNV); // Load dữ liệu theo mã lnv từ bảng phân quyền.
                if (_LSTPhanQuyen_DN != null)
                {
                    /*Tìm kiếm phần quyền của form KH*/
                    bool bKq = false;
                    int _IN_LSTPhanQuyen_DN = _LSTPhanQuyen_DN.Count;
                    for (int i = 0; i < _IN_LSTPhanQuyen_DN; ++i)
                    {
                        if (_LSTPhanQuyen_DN[i].strMaFrm == this.Name)
                        {
                            _PQ_NVDangNhap = _LSTPhanQuyen_DN[i]; // Tìm được phần quyên theo form KH.
                            bKq = true;
                            break;
                        }
                    }

                    if (bKq) // Thực hiện load form
                    {
                        dteNgaySinh.EditValue = DateTime.Now.Date;
                        
                        _lstLKH = LoaiKhachHang_BUS.loadDSLoaiKhachHang_BUS();
                        cmbLoaiKhachHang.Properties.DataSource = _lstLKH;
                        
                        _lstKH = KhachHang_BUS.loadDSKhachHang_BUS();
                        gcDSKH.DataSource = _lstKH;
                        setTrangThaiFrom();
                    }
                    else
                    {
                        DevExpress.XtraEditors.XtraMessageBox.Show("Bạn không có quyên chỉnh sửa", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            else
                DevExpress.XtraEditors.XtraMessageBox.Show("Error", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void setTrangThaiFrom()
        {
            txtMaKH.ReadOnly = true;
            switch (_iTrangThaiForm)
            {
                case 0:
                    grpThongTinCTKH.Enabled = false;
                    btnLuu.Enabled = false;

                    if (_KHHienTai == null)
                    {
                        btnSuaKH.Enabled = false;
                        btnXoaKH.Enabled = false;
                    }
                    else
                    {
                        if (_PQ_NVDangNhap.bThem)
                            btnThemKH.Enabled = true;
                        else
                            btnThemKH.Enabled = false;

                        if (_PQ_NVDangNhap.bXoa)
                            btnXoaKH.Enabled = true;
                        else
                            btnXoaKH.Enabled = false;

                        if (_PQ_NVDangNhap.bSua)
                            btnSuaKH.Enabled = true;
                        else
                            btnSuaKH.Enabled = false;
                    }
                    break;
                case 1:
                    txtMaKH.Text = "";
                    txtTenKH.Text = "";
                    txtSDTKH.Text = "";
                    dteNgaySinh.EditValue = null;
                    cmbLoaiKhachHang.EditValue = null;
                    txtCMNDKH.Text = "";
                    txtDiaChi.Text = "";
                    txtEmailKH.Text = "";

                    radNam.Checked = false;
                    radNu.Checked = false;

                    grpThongTinCTKH.Enabled = true;

                    btnXoaKH.Enabled = false;
                    btnSuaKH.Enabled = false;
                    btnLuu.Enabled = true;
                    break;
                case 2:
                    grpThongTinCTKH.Enabled = true;
                    btnLuu.Enabled = true;
                    break;
            }
        }

        private void loadThongTinChiTiet()
        {
            if (_KHHienTai == null)
            {
                txtMaKH.Text = string.Empty;
                txtTenKH.Text = string.Empty;
                txtSDTKH.Text = string.Empty;
                txtEmailKH.Text = string.Empty;
                txtCMNDKH.Text = string.Empty;
                txtDiaChi.Text = string.Empty;
                dteNgaySinh.Text = DateTime.Now.ToString();
                radNam.Checked = false;
                radNu.Checked = false;
                cmbLoaiKhachHang.SelectionStart = 0;
            }
            else
            {
                txtMaKH.Text = _KHHienTai.strMaKH;
                txtTenKH.Text = _KHHienTai.strHoTenKH;
                txtSDTKH.Text = _KHHienTai.strSDTKH;
                txtEmailKH.Text = _KHHienTai.strEmailKH;
                txtCMNDKH.Text = _KHHienTai.iCMNDKH.ToString();
                txtDiaChi.Text = _KHHienTai.strDiaChiKH;
                dteNgaySinh.EditValue = (DateTime)_KHHienTai.dtNgaySinhKH.Date;
                
                if (_KHHienTai.strGioiTinhKH == "Nam")
                {
                    radNam.Checked = true;
                    radNu.Checked = false;
                }
                else
                {
                    radNam.Checked = false;
                    radNu.Checked = true;
                }
                cmbLoaiKhachHang.EditValue = _KHHienTai.strMaLoaiKH;
            }
        }

        private void layThongTinChiTiet()
        {
            if (_KHHienTai == null)
            {
                _KHHienTai = new KhachHang_DTO();
            }
            _KHHienTai.strMaKH = txtMaKH.Text;
            _KHHienTai.strHoTenKH = txtTenKH.Text;
            _KHHienTai.strSDTKH = txtSDTKH.Text;

            if (dteNgaySinh.EditValue == null)
                _KHHienTai.dtNgaySinhKH = DateTime.Now;
            else
                _KHHienTai.dtNgaySinhKH = (DateTime)dteNgaySinh.EditValue;

            _KHHienTai.strMaLoaiKH = cmbLoaiKhachHang.GetColumnValue("strMaLoaiKH").ToString();
            if (radNam.Checked)
            {
                _KHHienTai.strGioiTinhKH = radNam.Text;
            }
            else if (radNu.Checked)
            {
                _KHHienTai.strGioiTinhKH = radNu.Text;
            }
            _KHHienTai.strEmailKH = txtEmailKH.Text;
            _KHHienTai.strDiaChiKH = txtDiaChi.Text;
            if (txtCMNDKH.Text != "")
                _KHHienTai.iCMNDKH = Convert.ToInt32(txtCMNDKH.Text);
        }

        private void gvDSKH_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {
            if (gvDSKH.SelectedRowsCount > 0)
                _KHHienTai = (KhachHang_DTO)gvDSKH.GetRow(gvDSKH.FocusedRowHandle);
            else
                _KHHienTai = null;

            loadThongTinChiTiet();
            _iTrangThaiForm = 0;
            setTrangThaiFrom();
        }

        private void btnThemKH_Click(object sender, EventArgs e)
        {
            _KHHienTai = null;
            _iTrangThaiForm = 1;
            setTrangThaiFrom();
            txtMaKH.Text = KhachHang_BUS.layMaCaoNhatBangKH_BUS();
            txtTenKH.Focus();
        }

        private void btnXoaKH_Click(object sender, EventArgs e)
        {
            if (_KHHienTai != null)
            {
                if (KhachHang_BUS.xoaKhachHang_BUS(_KHHienTai))
                {
                    _lstKH = KhachHang_BUS.loadDSKhachHang_BUS();
                    gcDSKH.DataSource = _lstKH;

                    DevExpress.XtraEditors.XtraMessageBox.Show("Xóa Thành Công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    if (_lstKH.Count == 0)
                        _KHHienTai = null;
                    _iTrangThaiForm = 0;
                    setTrangThaiFrom();
                    
                }
                else
                    DevExpress.XtraEditors.XtraMessageBox.Show("Xóa Thất Bại!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                DevExpress.XtraEditors.XtraMessageBox.Show("Error", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnSuaKH_Click(object sender, EventArgs e)
        {
            _iTrangThaiForm = 2;
            setTrangThaiFrom();
            txtTenKH.Focus();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtMaKH.Text == "")
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("Error", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMaKH.Focus();
            }
            else if (txtTenKH.Text == "")
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("Bạn Chưa Nhập Tên Khách Hàng", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenKH.Focus();
            }
            else if (txtSDTKH.Text == "")
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("Bạn Chưa Nhập Số Điện Thoại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSDTKH.Focus();
            }
            else if (cmbLoaiKhachHang.EditValue == null)
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("Bạn Chưa Chọn Loại Khách Hàng", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbLoaiKhachHang.Focus();
            }
            else if (!(radNam.Checked) && !(radNu.Checked))
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("Bạn Chưa Chọn Giới Tính", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            //else if (dteNgaySinh.EditValue == null)
            //{
            //    DevExpress.XtraEditors.XtraMessageBox.Show("Bạn Chưa Chọn Ngày Sinh", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    dteNgaySinh.Focus();
            //}
            //else if (txtCMNDKH.Text == "")
            //{
            //    DevExpress.XtraEditors.XtraMessageBox.Show("Bạn Chưa Nhập CMND", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    txtCMNDKH.Focus();
            //}
            //else if (txtDiaChi.Text == "")
            //{
            //    DevExpress.XtraEditors.XtraMessageBox.Show("Bạn Chưa Nhập Địa Chỉ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    txtDiaChi.Focus();
            //}
            //else if (txtEmailKH.Text == "")
            //{
            //    DevExpress.XtraEditors.XtraMessageBox.Show("Bạn Chưa Nhập Email", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    txtEmailKH.Focus();
            //}
            else
            {
                layThongTinChiTiet();
                bool bKq = false;
                if (KhachHang_BUS.kiemTraTrungSDT_BUS(_KHHienTai))
                {
                    DevExpress.XtraEditors.XtraMessageBox.Show("Trùng Số Điện Thoại.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtSDTKH.Focus();
                }
                else if (KhachHang_BUS.kiemTraTrungCMND_BUS(_KHHienTai))
                {
                    DevExpress.XtraEditors.XtraMessageBox.Show("Trùng Chứng Minh Thư.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtCMNDKH.Focus();
                }
                else
                {
                    if (_iTrangThaiForm == 1) // Trang thai them.
                    {
                        bKq = KhachHang_BUS.themKhachHang_BUS(_KHHienTai);
                    }
                    else if (_iTrangThaiForm == 2) // Trang thai sua.
                    {
                        bKq = KhachHang_BUS.suaKhachHang_BUS(_KHHienTai);
                    }

                    if (!bKq)
                    {
                        DevExpress.XtraEditors.XtraMessageBox.Show("Lưu Thất Bại!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        _lstKH = KhachHang_BUS.loadDSKhachHang_BUS();
                        gcDSKH.DataSource = _lstKH;
                        _iTrangThaiForm = 0;
                        setTrangThaiFrom();
                        DevExpress.XtraEditors.XtraMessageBox.Show("Lưu Thành Công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void radNam_CheckedChanged(object sender, EventArgs e)
        {
            if (radNam.Checked)
            {
                radNu.Checked = false;
            }
        }

        private void radNu_CheckedChanged(object sender, EventArgs e)
        {
            if (radNu.Checked)
            {
                radNam.Checked = false;
            }
        }

        private void txtTenKH_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0' && e.KeyChar <= '9') && ((Keys)e.KeyChar != Keys.Back) && ((Keys)e.KeyChar != Keys.Enter))
            {
                e.Handled = true;
                txtTenKH.Focus();
                DevExpress.XtraEditors.XtraMessageBox.Show("Bạn Không Được Nhập Số", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtSDTKH_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || e.KeyChar > '9') && ((Keys)e.KeyChar != Keys.Back) && ((Keys)e.KeyChar != Keys.Enter))
            {
                e.Handled = true;
                txtSDTKH.Focus();
                DevExpress.XtraEditors.XtraMessageBox.Show("Bạn Không Được Nhập Chữ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtCMNDKH_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || e.KeyChar > '9') && ((Keys)e.KeyChar != Keys.Back) && ((Keys)e.KeyChar != Keys.Enter))
            {
                e.Handled = true;
                txtCMNDKH.Focus();
                DevExpress.XtraEditors.XtraMessageBox.Show("Bạn Không Được Nhập Chữ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion
        #region Designs Form
        private void lblRefresh_Click(object sender, EventArgs e)
        {
            setTrangThaiFrom();
            txtTenKH.Focus();
        }

        private void lblQuayLai_Click(object sender, EventArgs e)
        {
            Util.EndAnimate(this, Util.Effect.Roll, 150, 30);
            this.Close();
        }
        #endregion
    }
}
