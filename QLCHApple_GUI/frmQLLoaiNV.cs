using QLCHApple_BUS;
using QLCHApple_DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLCHApple_GUI
{
    public partial class frmQLLoaiNV : Form
    {
        public frmQLLoaiNV()
        {
            InitializeComponent();
        }
        #region Properties
        BindingList<LoaiNhanVien_DTO> _lstLoaiNV = new BindingList<LoaiNhanVien_DTO>();
        LoaiNhanVien_DTO _LNVHienTai = null;
        int _iTrangThaiForm = 0; // 0: xem, 1: thêm, 2: sửa.

        NhanVien_DTO _NVDangNhap_frmQLLoaiNV = null;
        PhanQuyen_DTO _PQ_NVDangNhap = null;
        #endregion
        #region Methods
        public void setTrangThaiFrom()
        {
            txtMaLoaiNV.ReadOnly = true;
            switch (_iTrangThaiForm)
            {
                case 0:
                    if (_LNVHienTai == null)
                    {
                        btnSuaLoaiNV.Enabled = false;
                        btnXoaLoaiNV.Enabled = false;
                        txtMaLoaiNV.Text = "";
                        txtTenLoaiNV.Text = "";
                    }
                    else
                    {
                        if (_PQ_NVDangNhap.bThem)
                            btnThemLoaiNV.Enabled = true;
                        else
                            btnThemLoaiNV.Enabled = false;

                        if (_PQ_NVDangNhap.bXoa)
                            btnXoaLoaiNV.Enabled = true;
                        else
                            btnXoaLoaiNV.Enabled = false;

                        if (_PQ_NVDangNhap.bSua)
                            btnSuaLoaiNV.Enabled = true;
                        else
                            btnSuaLoaiNV.Enabled = false;
                    }
                    txtTenLoaiNV.ReadOnly = true;
                    btnLuuLoaiNV.Enabled = false;
                    break;
                case 1:
                    txtTenLoaiNV.ReadOnly = false;
                    txtMaLoaiNV.Text = LoaiNhanVien_BUS.layMaLNVCaoNhat_BUS();
                    txtTenLoaiNV.Text = "";

                    btnXoaLoaiNV.Enabled = false;
                    btnSuaLoaiNV.Enabled = false;
                    btnLuuLoaiNV.Enabled = true;
                    break;
                case 2:
                    txtTenLoaiNV.ReadOnly = false;
                    btnLuuLoaiNV.Enabled = true;
                    btnSuaLoaiNV.Enabled = true;
                    btnThemLoaiNV.Enabled = true;
                    break;
            }
        }

        private void loadThongTinChiTiet()
        {
            if (_LNVHienTai == null)
            {
                txtMaLoaiNV.Text = "";
                txtTenLoaiNV.Text = "";
            }
            else
            {
                txtMaLoaiNV.Text = _LNVHienTai.strMaLoaiNV;
                txtTenLoaiNV.Text = _LNVHienTai.strTenLoaiNV;
            }
        }

        private void layThongTinChiTiet()
        {
            if (_LNVHienTai == null)
            {
                _LNVHienTai = new LoaiNhanVien_DTO();
            }
            _LNVHienTai.strMaLoaiNV = txtMaLoaiNV.Text;
            _LNVHienTai.strTenLoaiNV = txtTenLoaiNV.Text;
        }
        #endregion
        #region Events
        private void frmQLLoaiNV_Load(object sender, EventArgs e)
        {
            this.Visible = false;
            Util.EndAnimate(this, Util.Effect.Slide, 150, 180);

            #region Xử lý phần quyền.
            _NVDangNhap_frmQLLoaiNV = frmHome.NVDangNhap_frmHome;

            if (_NVDangNhap_frmQLLoaiNV != null)
            {
                if (_NVDangNhap_frmQLLoaiNV.strMaLoaiNV != "")
                {
                    BindingList<PhanQuyen_DTO> _LSTPhanQuyen_DN = new BindingList<PhanQuyen_DTO>();
                    _LSTPhanQuyen_DN = PhanQuyen_BUS.loadDSPhanQuyen_TheoMaLoaiNV(_NVDangNhap_frmQLLoaiNV.strMaLoaiNV);
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
                            _lstLoaiNV = LoaiNhanVien_BUS.loadDSLoaiNhanVien_BUS();
                            gcDSLoaiNV.DataSource = _lstLoaiNV;

                            setTrangThaiFrom();
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

        private void gvDSLoaiNV_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {
            if (gvDSLoaiNV.SelectedRowsCount > 0)
                _LNVHienTai = (LoaiNhanVien_DTO)gvDSLoaiNV.GetRow(gvDSLoaiNV.FocusedRowHandle);
            else
                _LNVHienTai = null;

            loadThongTinChiTiet();
            _iTrangThaiForm = 0;
            setTrangThaiFrom();
        }

        private void btnThemLoaiNV_Click(object sender, EventArgs e)
        {
            _LNVHienTai = null;
            _iTrangThaiForm = 1;
            setTrangThaiFrom();
            txtMaLoaiNV.Focus();
        }

        private void btnXoaLoaiNV_Click(object sender, EventArgs e)
        {
            if (_LNVHienTai != null)
            {
                if (_LNVHienTai.strMaLoaiNV == _NVDangNhap_frmQLLoaiNV.strMaLoaiNV || _LNVHienTai.strMaLoaiNV == "LNV1")
                {
                    DevExpress.XtraEditors.XtraMessageBox.Show("Loại Nhân Viên Không Được Xóa!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    if (LoaiNhanVien_BUS.xoaLoaiNhanVien_BUS(_LNVHienTai))
                    {
                        _lstLoaiNV = LoaiNhanVien_BUS.loadDSLoaiNhanVien_BUS();
                        gcDSLoaiNV.DataSource = _lstLoaiNV;

                        DevExpress.XtraEditors.XtraMessageBox.Show("Xóa Thành Công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        if (_lstLoaiNV.Count == 0)
                            _LNVHienTai = null;
                        _iTrangThaiForm = 0;
                        setTrangThaiFrom();
                    }
                    else
                        DevExpress.XtraEditors.XtraMessageBox.Show("Xóa Thất Bại!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnSuaLoaiNV_Click(object sender, EventArgs e)
        {
            _iTrangThaiForm = 2;
            setTrangThaiFrom();
            txtMaLoaiNV.Focus();
        }

        private void btnLuuLoaiNV_Click(object sender, EventArgs e)
        {
            if (txtMaLoaiNV.Text == "")
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("Bạn Chưa Nhập Mã Loại Nhân Viên", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaLoaiNV.Focus();
            }
            else if (txtTenLoaiNV.Text == "")
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("Bạn Chưa Nhập Loại Nhân Viên", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenLoaiNV.Focus();
            }
            else
            {
                layThongTinChiTiet();

                if (LoaiNhanVien_BUS.kiemTraMaBiTrung_BUS(_LNVHienTai))
                {
                    DevExpress.XtraEditors.XtraMessageBox.Show("Trùng Mã!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (LoaiNhanVien_BUS.kiemTraTenBiTrung_BUS(_LNVHienTai))
                {
                    DevExpress.XtraEditors.XtraMessageBox.Show("Trùng Tên!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    bool bKq = false;

                    if (_iTrangThaiForm == 1)
                        bKq = LoaiNhanVien_BUS.themLoaiNhanVien_BUS(_LNVHienTai);
                    else
                        bKq = LoaiNhanVien_BUS.suaLoaiNhanVien_BUS(_LNVHienTai);

                    // Kiểm tra xem thêm được hay k?
                    if (!bKq)
                    {
                        DevExpress.XtraEditors.XtraMessageBox.Show("Lưu Thất Bại!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        // Xử lý phân quyên cho loại nhân viên. Khi thêm 1 loại nhân viên vào, mặc định cho quyền xem tất cả chức năng, nhưng không được chỉnh sửa.
                        if (_iTrangThaiForm == 1)
                        {
                            if (!LoaiNhanVien_BUS.themPhanQuyenChoLoaiNV(_LNVHienTai))
                                DevExpress.XtraEditors.XtraMessageBox.Show("Phân Quyền Thất Bại!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                        _lstLoaiNV = LoaiNhanVien_BUS.loadDSLoaiNhanVien_BUS();
                        gcDSLoaiNV.DataSource = _lstLoaiNV;
                        _iTrangThaiForm = 0;
                        setTrangThaiFrom();

                        DevExpress.XtraEditors.XtraMessageBox.Show("Lưu Thành Công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                }
            }
        }

        private void lblRefresh_Click(object sender, EventArgs e)
        {
            _iTrangThaiForm = 0;
            setTrangThaiFrom();
            _lstLoaiNV = LoaiNhanVien_BUS.loadDSLoaiNhanVien_BUS();
            gcDSLoaiNV.DataSource = _lstLoaiNV;
        }

        private void lblQuayLai_Click(object sender, EventArgs e)
        {
            Util.EndAnimate(this, Util.Effect.Slide, 150, 30);
            this.Close();
        }
        #endregion
    }
}