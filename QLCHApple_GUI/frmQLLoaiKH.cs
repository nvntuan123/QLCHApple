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
    public partial class frmQLLoaiKH : Form
    {
        #region Xu ly du lieu Form
        public frmQLLoaiKH()
        {
            InitializeComponent();
        }

        BindingList<LoaiKhachHang_DTO> lstLoaiKhachHang = new BindingList<LoaiKhachHang_DTO>();
        LoaiKhachHang_DTO _LoaiKHHienTai = null;
        int _iTrangThaiForm = 0;

        NhanVien_DTO _NVDangNhap_frmQLLoaiKH = null;
        PhanQuyen_DTO _PQ_NVDangNhap = null;

        private void frmQLLoaiNV_Load(object sender, EventArgs e)
        {
            this.Visible = false;
            Util.EndAnimate(this, Util.Effect.Slide, 150, 180);

            #region Xử lý phần quyền.
            _NVDangNhap_frmQLLoaiKH = frmHome.NVDangNhap_frmHome;

            if (_NVDangNhap_frmQLLoaiKH != null)
            {
                if (_NVDangNhap_frmQLLoaiKH.strMaLoaiNV != "")
                {
                    BindingList<PhanQuyen_DTO> _LSTPhanQuyen_DN = new BindingList<PhanQuyen_DTO>();
                    _LSTPhanQuyen_DN = PhanQuyen_BUS.loadDSPhanQuyen_TheoMaLoaiNV(_NVDangNhap_frmQLLoaiKH.strMaLoaiNV);
                    if (_LSTPhanQuyen_DN != null)
                    {
                        bool bKq = false;
                        int _IN_LSTPhanQuyen_DN = _LSTPhanQuyen_DN.Count;
                        for (int i = 0; i < _IN_LSTPhanQuyen_DN; ++i)
                        {
                            if (_LSTPhanQuyen_DN[i].strMaFrm == this.Name)
                            {
                                _PQ_NVDangNhap = _LSTPhanQuyen_DN[i];
                                bKq = true;
                                break;
                            }
                        }

                        if (bKq)
                        {
                            lstLoaiKhachHang = LoaiKhachHang_BUS.loadDSLoaiKhachHang_BUS();
                            gcDSLoaiKH.DataSource = lstLoaiKhachHang;
                            setTrangThaiForm();
                        }
                        else
                        {
                            DevExpress.XtraEditors.XtraMessageBox.Show("Bạn không có quyền chỉnh sửa", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            #endregion            
        }

        public void setTrangThaiForm()
        {
            txtMaLoaiKH.ReadOnly = true;
            switch (_iTrangThaiForm)
            {
                case 0: // Xem.
                    if (_LoaiKHHienTai == null)
                    {
                        btnSuaLoaiKH.Enabled = false;
                        btnXoaLoaiKH.Enabled = false;
                    }
                    else
                    {
                        if (_PQ_NVDangNhap.bThem)
                            btnThemLoaiKH.Enabled = true;
                        else
                            btnThemLoaiKH.Enabled = false;

                        if (_PQ_NVDangNhap.bXoa)
                            btnXoaLoaiKH.Enabled = true;
                        else
                            btnXoaLoaiKH.Enabled = false;

                        if (_PQ_NVDangNhap.bSua)
                            btnSuaLoaiKH.Enabled = true;
                        else
                            btnSuaLoaiKH.Enabled = false;
                    }
                    txtLoaiKH.ReadOnly = true;
                    txtPhanTramGG.ReadOnly = true;
                    btnLuuLoaiKH.Enabled = false;
                    break;
                case 1: // Thêm.
                    txtLoaiKH.ReadOnly = false;
                    txtPhanTramGG.ReadOnly = false;
                    txtLoaiKH.Text = "";
                    txtPhanTramGG.Text = "";

                    btnXoaLoaiKH.Enabled = false;
                    btnSuaLoaiKH.Enabled = false;
                    btnLuuLoaiKH.Enabled = true;
                    break;
                case 2: // Sửa.
                    txtLoaiKH.ReadOnly = false;
                    txtPhanTramGG.ReadOnly = false;

                    btnLuuLoaiKH.Enabled = true;
                    btnSuaLoaiKH.Enabled = true;
                    btnThemLoaiKH.Enabled = true;
                    break;
            }
        }

        private void gvDSLoaiNV_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {
            if (gvDSLoaiKH.SelectedRowsCount > 0)
                _LoaiKHHienTai = (LoaiKhachHang_DTO)gvDSLoaiKH.GetRow(gvDSLoaiKH.FocusedRowHandle);
            else
                _LoaiKHHienTai = null;

            loadThongTinChiTiet();
            _iTrangThaiForm = 0;
            setTrangThaiForm();
        }

        private void loadThongTinChiTiet()
        {
            if (_LoaiKHHienTai == null)
            {
                txtMaLoaiKH.Text = "";
                txtLoaiKH.Text = "";
                txtPhanTramGG.Text = "";
            }
            else
            {
                txtMaLoaiKH.Text = _LoaiKHHienTai.strMaLoaiKH;
                txtLoaiKH.Text = _LoaiKHHienTai.strLoaiKH;
                txtPhanTramGG.Text = _LoaiKHHienTai.iPhanTramGG.ToString();
            }
        }

        private void btnThemLoaiKH_Click(object sender, EventArgs e)
        {
            _LoaiKHHienTai = null;
            _iTrangThaiForm = 1;
            setTrangThaiForm();
            txtMaLoaiKH.Text = LoaiKhachHang_BUS.layMaCaoNhatBangLKH_BUS();
            lblRefresh.Enabled = true;
        }

        private void btnXoaLoaiKH_Click(object sender, EventArgs e)
        {
            if (LoaiKhachHang_BUS.updateTrangThaiLKH_BUS(_LoaiKHHienTai))
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("Xóa Thành Công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                lstLoaiKhachHang = LoaiKhachHang_BUS.loadDSLoaiKhachHang_BUS();
                gcDSLoaiKH.DataSource = lstLoaiKhachHang;
                _iTrangThaiForm = 0;
                setTrangThaiForm();
            }
            else
                DevExpress.XtraEditors.XtraMessageBox.Show("Xóa Thất Bại!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnSuaLoaiKH_Click(object sender, EventArgs e)
        {
            _iTrangThaiForm = 2;
            setTrangThaiForm();
            txtLoaiKH.Focus();
        }

        private void btnLuuLoaiNV_Click(object sender, EventArgs e)
        {
            if (txtMaLoaiKH.Text == "")
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("Error", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMaLoaiKH.Focus();
            }
            else if (txtLoaiKH.Text == "")
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("Bạn Chưa Nhập Loại Khách Hàng", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtLoaiKH.Focus();
            }
            else if (txtPhanTramGG.Text == "")
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("Bạn Chưa Nhập Phần Trăm Giảm Giá", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPhanTramGG.Focus();
            }
            else
            {
                layThongTinChiTiet();

                bool bKq = false;
                if (_iTrangThaiForm == 1)
                {
                    bKq = LoaiKhachHang_BUS.themLoaiKhachHang_BUS(_LoaiKHHienTai);
                }
                else if (_iTrangThaiForm == 2)
                    bKq = LoaiKhachHang_BUS.suaLoaiKhachHang_BUS(_LoaiKHHienTai);

                if (!bKq)
                {
                    DevExpress.XtraEditors.XtraMessageBox.Show("Lưu Thất Bại!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    lstLoaiKhachHang = LoaiKhachHang_BUS.loadDSLoaiKhachHang_BUS();
                    gcDSLoaiKH.DataSource = lstLoaiKhachHang;
                    _iTrangThaiForm = 0;
                    setTrangThaiForm();
                    DevExpress.XtraEditors.XtraMessageBox.Show("Lưu Thành Công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void layThongTinChiTiet()
        {
           if (_LoaiKHHienTai == null)
            {
                _LoaiKHHienTai = new LoaiKhachHang_DTO();
            }
            _LoaiKHHienTai.strMaLoaiKH = txtMaLoaiKH.Text;
            _LoaiKHHienTai.strLoaiKH = txtLoaiKH.Text;
            _LoaiKHHienTai.iPhanTramGG = int.Parse(txtPhanTramGG.Text);
        }

        private void txtPhanTramGG_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || e.KeyChar > '9') && ((Keys)e.KeyChar != Keys.Back) && ((Keys)e.KeyChar != Keys.Enter))
            {
                e.Handled = true;
                txtPhanTramGG.Focus();
                DevExpress.XtraEditors.XtraMessageBox.Show("Bạn Không Được Nhập Chữ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion
        #region Designs Form
        private void lblRefresh_Click(object sender, EventArgs e)
        {
            if (gvDSLoaiKH.SelectedRowsCount > 0)
                _LoaiKHHienTai = (LoaiKhachHang_DTO)gvDSLoaiKH.GetRow(gvDSLoaiKH.FocusedRowHandle);
            else
                _LoaiKHHienTai = null;

            loadThongTinChiTiet();
            _iTrangThaiForm = 0;
            setTrangThaiForm();
        }

        private void lblQuayLai_Click(object sender, EventArgs e)
        {
            Util.EndAnimate(this, Util.Effect.Slide, 150, 30);
            this.Close();
        }
        #endregion
    }
}
