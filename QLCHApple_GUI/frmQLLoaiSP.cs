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
    public partial class frmQLLoaiSP : Form
    {
        #region Xử lý dữ liệu Form
        public frmQLLoaiSP()
        {
            InitializeComponent();
        }

        BindingList<LoaiSanPham_DTO> lstDSLoaiSP = new BindingList<LoaiSanPham_DTO>();
        LoaiSanPham_DTO LoaiSPHienTai = null;
        int iTrangThai = 0;

        NhanVien_DTO _NVDangNhap_frmQLLoaiSP = null;
        PhanQuyen_DTO _PQ_NVDangNhap = null;

        private void frmQLLoaiSP_Load(object sender, EventArgs e)
        {
            this.Visible = false;
            Util.EndAnimate(this, Util.Effect.Slide, 150, 180);

            #region Xử lý phần quyền.
            _NVDangNhap_frmQLLoaiSP = frmHome.NVDangNhap_frmHome;

            if (_NVDangNhap_frmQLLoaiSP != null)
            {
                if (_NVDangNhap_frmQLLoaiSP.strMaLoaiNV != "")
                {
                    BindingList<PhanQuyen_DTO> _LSTPhanQuyen_DN = new BindingList<PhanQuyen_DTO>();
                    _LSTPhanQuyen_DN = PhanQuyen_BUS.loadDSPhanQuyen_TheoMaLoaiNV(_NVDangNhap_frmQLLoaiSP.strMaLoaiNV);
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
                            lstDSLoaiSP = LoaiSanPham_BUS.layDSLoaiSP_BUS();
                            gcDSLoaiSP.DataSource = lstDSLoaiSP;

                            setTrangThai();
                        }
                        else
                        {
                            DevExpress.XtraEditors.XtraMessageBox.Show("Bạn không có quyên chỉnh sửa", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            #endregion
        }

        private void setTrangThai()
        {
            txtMaLoaiSP.ReadOnly = true;
            switch (iTrangThai)
            {
                case 0: // Xem.
                    {
                        txtTenLoaiSP.ReadOnly = true;
                        btnThemLoaiSP.Enabled = true;
                        
                        if (lstDSLoaiSP.Count == 0)
                        {
                            btnSuaLoaiSP.Enabled = false;
                            btnXoaLoaiSP.Enabled = false;
                            txtMaLoaiSP.Text = "";
                            txtTenLoaiSP.Text = "";
                        }
                        else
                        {
                            if (_PQ_NVDangNhap.bThem)
                                btnThemLoaiSP.Enabled = true;
                            else
                                btnThemLoaiSP.Enabled = false;

                            if (_PQ_NVDangNhap.bXoa)
                                btnXoaLoaiSP.Enabled = true;
                            else
                                btnXoaLoaiSP.Enabled = false;

                            if (_PQ_NVDangNhap.bSua)
                                btnSuaLoaiSP.Enabled = true;
                            else
                                btnSuaLoaiSP.Enabled = false;
                        }

                        btnLuuLoaiSP.Enabled = false;
                        break;
                    }
                case 1: // Thêm.
                    {
                        txtTenLoaiSP.ReadOnly = false;
                        txtTenLoaiSP.Text = "";
                        btnSuaLoaiSP.Enabled = false;
                        btnXoaLoaiSP.Enabled = false;
                        btnLuuLoaiSP.Enabled = true;
                        break;
                    }
                case 2: // Sửa
                    {
                        txtTenLoaiSP.ReadOnly = false;
                        btnThemLoaiSP.Enabled = true;
                        btnXoaLoaiSP.Enabled = true;
                        btnLuuLoaiSP.Enabled = true;
                        break;
                    }
            }
        }

        private void gvDSLoaiSP_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {
            if (gvDSLoaiSP.SelectedRowsCount > 0)
            {
                LoaiSPHienTai = (LoaiSanPham_DTO)gvDSLoaiSP.GetRow(gvDSLoaiSP.FocusedRowHandle);
            }
            else
                LoaiSPHienTai = null;

            iTrangThai = 0;
            setTrangThai();
            loadThongTinChiTiet();
        }

        private void loadThongTinChiTiet()
        {
            if (LoaiSPHienTai == null)
            {
                txtMaLoaiSP.Text = "";
                txtTenLoaiSP.Text = "";
            }
            else
            {
                txtMaLoaiSP.Text = LoaiSPHienTai.strMaLoaiSP;
                txtTenLoaiSP.Text = LoaiSPHienTai.strTenLoaiSP;
            }
        }

        private void btnThemLoaiSP_Click(object sender, EventArgs e)
        {
            LoaiSPHienTai = null;
            iTrangThai = 1;
            setTrangThai();
            txtMaLoaiSP.Text = LoaiSanPham_BUS.layMaCaoNhat_BUS();
        }

        private void btnXoaLoaiSP_Click(object sender, EventArgs e)
        {
            if (LoaiSPHienTai != null)
            {
                DialogResult dlgHoiXoa = DevExpress.XtraEditors.XtraMessageBox.Show("Bạn Có Chắc Muốn Xóa Loại SP " + LoaiSPHienTai.strMaLoaiSP, "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dlgHoiXoa == DialogResult.Yes)
                {
                    if (LoaiSanPham_BUS.xoaLoaiSP_BUS(LoaiSPHienTai))
                    {
                        lstDSLoaiSP = LoaiSanPham_BUS.layDSLoaiSP_BUS();
                        gcDSLoaiSP.DataSource = lstDSLoaiSP;

                        if (lstDSLoaiSP.Count == 0)
                            LoaiSPHienTai = null;
                        DevExpress.XtraEditors.XtraMessageBox.Show("Xóa Thành Công");
                        iTrangThai = 0;
                        setTrangThai();
                    }
                    else
                    {
                        DevExpress.XtraEditors.XtraMessageBox.Show("Xóa Thất Bại");
                    }
                }
            }
            else
                DevExpress.XtraEditors.XtraMessageBox.Show("Chưa Chọn Loại Sản Phẩm!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnSuaLoaiSP_Click(object sender, EventArgs e)
        {
            iTrangThai = 2;
            setTrangThai();
        }

        private void btnLuuLoaiSP_Click(object sender, EventArgs e)
        {
            if (txtMaLoaiSP.Text == "")
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("Error!");
            }
            else if (txtTenLoaiSP.Text == "")
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("Bạn Chưa Nhập Tên Loại Sản Phẩm", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTenLoaiSP.Focus();
            }
            else
            {
                layThongTinChiTiet();
                bool bCheck = false;
                if (iTrangThai == 1) // Thêm
                {
                    bCheck = LoaiSanPham_BUS.themLoaiSP_BUS(LoaiSPHienTai);
                }
                else if (iTrangThai == 2) // Sửa
                {
                    bCheck = LoaiSanPham_BUS.suaLoaiSP_BUS(LoaiSPHienTai);
                }

                if (bCheck)
                {
                    lstDSLoaiSP = LoaiSanPham_BUS.layDSLoaiSP_BUS();
                    gcDSLoaiSP.DataSource = lstDSLoaiSP;
                    iTrangThai = 0;
                    setTrangThai();

                    DevExpress.XtraEditors.XtraMessageBox.Show("Lưu Thành Công.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    DevExpress.XtraEditors.XtraMessageBox.Show("Lưu Thất Bại.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void layThongTinChiTiet()
        {
            if (iTrangThai == 1)
            {
                LoaiSPHienTai = new LoaiSanPham_DTO();
            }
            LoaiSPHienTai.strMaLoaiSP = txtMaLoaiSP.Text;
            LoaiSPHienTai.strTenLoaiSP = txtTenLoaiSP.Text;
        }
        #endregion

        #region Designs Form
        private void lblQuayLai_Click(object sender, EventArgs e)
        {
            Util.EndAnimate(this, Util.Effect.Slide, 150, 30);
            this.Close();
        }

        private void lblRefresh_Click(object sender, EventArgs e)
        {

        }
        #endregion
    }
}
