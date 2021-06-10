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
    public partial class frmQLNV : Form
    {
        public frmQLNV()
        {
            InitializeComponent();
        }
        #region Properties
        BindingList<LoaiNhanVien_DTO> lstLoaiNV = new BindingList<LoaiNhanVien_DTO>();
        BindingList<NhanVien_DTO> lstNV = new BindingList<NhanVien_DTO>();
        NhanVien_DTO NVHienTai = null;
        int _iTrangThaiForm = 0; // 0: xem, 1: thêm, 2: sửa.

        NhanVien_DTO _NVDangNhap_frmQLNV = null;
        PhanQuyen_DTO _PQ_NVDangNhap = null;
        #endregion
        #region Methods
        public void _setTrangThaiForm()
        {
            txtMaNV.ReadOnly = true;
            switch (_iTrangThaiForm)
            {
                case 0:
                    grpThongTinCTNV.Enabled = false;
                    btnLuu.Enabled = false;

                    if (NVHienTai == null)
                    {
                        btnSuaNV.Enabled = false;
                        btnXoaNV.Enabled = false;
                    }
                    else
                    {
                        if (_PQ_NVDangNhap.bThem)
                            btnThemNV.Enabled = true;
                        else
                            btnThemNV.Enabled = false;

                        if (_PQ_NVDangNhap.bXoa)
                            btnXoaNV.Enabled = true;
                        else
                            btnXoaNV.Enabled = false;

                        if (_PQ_NVDangNhap.bSua)
                            btnSuaNV.Enabled = true;
                        else
                            btnSuaNV.Enabled = false;
                    }
                    break;
                case 1:
                    txtMaNV.Text = NhanVien_BUS.layMaNVCaoNhat_BUS();
                    txtTenNV.Text = "";
                    txtSDT.Text = "";
                    txtEmail.Text = "";
                    txtCMND.Text = "";
                    txtLuong.Text = "";
                    dteNgaySinh.EditValue = null;
                    cmbLoaiNV.EditValue = null;
                    radNam.Checked = false;
                    radNu.Checked = false;
                    txtMatkhau.Text = "";

                    grpThongTinCTNV.Enabled = true;

                    btnXoaNV.Enabled = false;
                    btnSuaNV.Enabled = false;
                    btnLuu.Enabled = true;
                    //Util.EndAnimate(btnLuu, Util.Effect.Slide, 150, 30);
                    break;
                case 2:
                    grpThongTinCTNV.Enabled = true;
                    btnLuu.Enabled = true;
                    break;
            }
        }

        private void loadThongTinChiTiet()
        {
            if (NVHienTai == null)
            {
                txtMaNV.Text = string.Empty;
                txtTenNV.Text = string.Empty;
                txtSDT.Text = string.Empty;
                txtEmail.Text = string.Empty;
                txtCMND.Text = string.Empty;
                txtLuong.Text = string.Empty;
                txtMatkhau.Text = string.Empty;
                dteNgaySinh.EditValue = null;
                cmbLoaiNV.EditValue = null;
                radNam.Checked = false;
                radNu.Checked = false;
            }
            else
            {
                txtMaNV.Text = NVHienTai.strMaNV;
                txtTenNV.Text = NVHienTai.strHoTen;
                txtSDT.Text = NVHienTai.strSDT;
                txtEmail.Text = NVHienTai.strEmail;
                txtCMND.Text = NVHienTai.strCMND;
                txtLuong.Text = NVHienTai.decLuongNgay.ToString();
                txtMatkhau.Text = NVHienTai.strMatKhau.ToString();
                dteNgaySinh.EditValue = NVHienTai.dtNgaySinh.Date;
                cmbLoaiNV.EditValue = NVHienTai.strMaLoaiNV;
                if (NVHienTai.strGioiTinh == "Nam")
                {
                    radNam.Checked = true;
                    radNu.Checked = false;
                }
                else
                {
                    radNam.Checked = false;
                    radNu.Checked = true;
                }
            }
        }

        private void layThongTinChiTiet()
        {
            if (NVHienTai == null)
            {
                NVHienTai = new NhanVien_DTO();
            }

            NVHienTai.strMaNV = txtMaNV.Text;
            NVHienTai.strHoTen = txtTenNV.Text;
            NVHienTai.strSDT = txtSDT.Text;
            NVHienTai.dtNgaySinh = (DateTime)dteNgaySinh.EditValue;
            NVHienTai.strEmail = txtEmail.Text;

            if (radNam.Checked)
            {
                NVHienTai.strGioiTinh = radNam.Text;
            }
            else if (radNu.Checked)
            {
                NVHienTai.strGioiTinh = radNu.Text;
            }

            NVHienTai.strMaLoaiNV = cmbLoaiNV.GetColumnValue("strMaLoaiNV").ToString();
            NVHienTai.strCMND = txtCMND.Text;
            NVHienTai.strMatKhau = txtMatkhau.Text;
            if (txtLuong.Text == "")
                NVHienTai.decLuongNgay = 0;
            else
                NVHienTai.decLuongNgay = Convert.ToDecimal(txtLuong.Text);
        }

        private bool kiemTraSDTTren10So(string _STR_SDT) // Tu 10 so tro len => true, nguoc lai false.
        {
            if (_STR_SDT.Length < 10)
                return false;
            return true;
        }

        private bool kiemTraCMNDTren9So(string _STR_CMND) // Tu 9 so tro len => true, nguoc lai false.
        {
            if (_STR_CMND.Length < 9)
                return false;
            return true;
        }

        private bool kiemTraEmailDungDinhDang(string _STR_Email) // Neu tim thay @gmail.com => true, nguoc lai false.
        {
            return (_STR_Email.IndexOf("@gmail.com") >= 0);
        }

        private bool kiemTraNhapKyTuChu(char _C_Kytu)
        {
            return ((_C_Kytu < '0' || _C_Kytu > '9') && ((Keys)_C_Kytu != Keys.Back) && ((Keys)_C_Kytu != Keys.Enter));
        }

        private bool kiemTraNhapKyTuSo(char _C_Kytu)
        {
            return (_C_Kytu >= '0' && _C_Kytu <= '9' && ((Keys)_C_Kytu != Keys.Back) && ((Keys)_C_Kytu != Keys.Enter));
        }

        private void _lst_loadDSNV()
        {
            lstNV = NhanVien_BUS.loadDSNV_BUS();
            if (lstNV.Count > 0)
            {
                foreach (NhanVien_DTO nv in lstNV)
                {
                    if (nv.strMaNV == "NV1")
                    {
                        lstNV.Remove(nv);
                        break;
                    }
                }
            }
            gcDSNV.DataSource = lstNV;
        }
        #endregion
        #region Events
        private void frmQLNV_Load(object sender, EventArgs e)
        {
            this.Visible = false;
            Util.EndAnimate(this, Util.Effect.Slide, 150, 180);

            #region Xử lý phần quyền.
            _NVDangNhap_frmQLNV = frmHome.NVDangNhap_frmHome;

            if (_NVDangNhap_frmQLNV != null)
            {
                if (_NVDangNhap_frmQLNV.strMaLoaiNV != "")
                {
                    BindingList<PhanQuyen_DTO> _LSTPhanQuyen_DN = new BindingList<PhanQuyen_DTO>();
                    _LSTPhanQuyen_DN = PhanQuyen_BUS.loadDSPhanQuyen_TheoMaLoaiNV(_NVDangNhap_frmQLNV.strMaLoaiNV);
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
                            dteNgaySinh.EditValue = DateTime.Now.Date;

                            lstLoaiNV = LoaiNhanVien_BUS.loadDSLoaiNhanVien_BUS();
                            cmbLoaiNV.Properties.NullText = "Loại Nhân Viên";
                            cmbLoaiNV.Properties.ValueMember = "strMaLoaiNV";
                            cmbLoaiNV.Properties.DisplayMember = "strTenLoaiNV";
                            cmbLoaiNV.Properties.DataSource = lstLoaiNV;
                            cmbLoaiNV.Properties.Columns["colMaLoaiNV"].FieldName = "strMaLoaiNV";
                            cmbLoaiNV.Properties.Columns["colTenLoaiNV"].FieldName = "strTenLoaiNV";

                            /*GridView danh sách nhân viên*/
                            lstNV = NhanVien_BUS.loadDSNV_BUS();

                            LookUpEdit_LoaiNV.DataSource = lstLoaiNV;
                            LookUpEdit_LoaiNV.Columns["colMaLoaiNV"].FieldName = "strMaLoaiNV";
                            LookUpEdit_LoaiNV.Columns["colTenLoaiNV"].FieldName = "strTenLoaiNV";

                            _lst_loadDSNV();
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

        private void gvDSNV_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {
            if (gvDSNV.SelectedRowsCount > 0)
                NVHienTai = (NhanVien_DTO)gvDSNV.GetRow(gvDSNV.FocusedRowHandle);
            else
                NVHienTai = null;

            loadThongTinChiTiet();
            _iTrangThaiForm = 0;
            _setTrangThaiForm();
        }

        private void btnThemNV_Click(object sender, EventArgs e)
        {
            NVHienTai = null;
            _iTrangThaiForm = 1;
            _setTrangThaiForm();
            txtTenNV.Focus();
        }

        private void btnSuaNV_Click(object sender, EventArgs e)
        {
            _iTrangThaiForm = 2;
            _setTrangThaiForm();
            txtTenNV.Focus();
        }

        private void btnXoaNV_Click(object sender, EventArgs e)
        {
            if (NVHienTai != null)
            {
                if (_NVDangNhap_frmQLNV.strMaNV != NVHienTai.strMaNV)
                {
                    if (NhanVien_BUS.xoaNVien_BUS(NVHienTai))
                    {
                        _lst_loadDSNV();
                        DevExpress.XtraEditors.XtraMessageBox.Show("Xóa Thành Công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        if (lstNV.Count == 0)
                            NVHienTai = null;
                        _iTrangThaiForm = 0;
                        _setTrangThaiForm();
                    }
                    else
                        DevExpress.XtraEditors.XtraMessageBox.Show("Xóa Thất Bại!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    DevExpress.XtraEditors.XtraMessageBox.Show("Không Được Xóa Chính Mình!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                DevExpress.XtraEditors.XtraMessageBox.Show("Error", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtMaNV.Text == "")
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("Bạn Chưa Nhập Mã Nhân Viên", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaNV.Focus();
            }
            else if (txtTenNV.Text == "")
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("Bạn Chưa Nhập Tên Nhân Viên", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenNV.Focus();
            }
            else if (txtSDT.Text == "")
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("Bạn Chưa Nhập Số Điện Thoại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSDT.Focus();
            }
            else if (dteNgaySinh.EditValue == null)
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("Bạn Chưa Chọn Ngày Sinh", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dteNgaySinh.Focus();
            }
            else if (!(radNam.Checked) && !(radNu.Checked))
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("Bạn Chưa Chọn Giới Tính", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (cmbLoaiNV.EditValue == null)
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("Bạn Chưa Chọn Loại Nhân Viên", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbLoaiNV.Focus();
            }
            else if (txtCMND.Text == "")
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("Bạn Chưa Nhập Chứng Minh Thư", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCMND.Focus();
            }
            else if (cmbLoaiNV.Text == "")
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("Bạn Chưa Chọn Chức Vụ Cho Nhân Viên", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbLoaiNV.Focus();
            }
            else if (txtMatkhau.Text == "")
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("Bạn Chưa Nhập Mật Khẩu Cho Nhân Viên", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMatkhau.Focus();
            }
            else
            {
                layThongTinChiTiet();

                if (!kiemTraSDTTren10So(NVHienTai.strSDT))
                    DevExpress.XtraEditors.XtraMessageBox.Show("Số Điện Thoại Phải Trên 9 Số!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else if (!kiemTraCMNDTren9So(NVHienTai.strCMND))
                    DevExpress.XtraEditors.XtraMessageBox.Show("CMND Phải Trên 8 Số!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else if (NVHienTai.strEmail != "" && !kiemTraEmailDungDinhDang(NVHienTai.strEmail))
                    DevExpress.XtraEditors.XtraMessageBox.Show("Email Phải Đúng Định Dạng: @gmail.com", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                {
                    if (NhanVien_BUS.kiemTraTrungSDT_BUS(NVHienTai, _iTrangThaiForm))
                    {
                        NVHienTai = null;
                        DevExpress.XtraEditors.XtraMessageBox.Show("Trùng Số Điện Thoại.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtSDT.Focus();
                    }
                    else if (NhanVien_BUS.kiemTraTrungCMND_BUS(NVHienTai, _iTrangThaiForm))
                    {
                        NVHienTai = null;
                        DevExpress.XtraEditors.XtraMessageBox.Show("Trùng Chứng Minh Thư.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtCMND.Focus();
                    }
                    else if (NVHienTai.strEmail != "" && NhanVien_BUS.kiemTraTrungEmail_BUS(NVHienTai, _iTrangThaiForm))
                    {
                        NVHienTai = null;
                        DevExpress.XtraEditors.XtraMessageBox.Show("Trùng Email.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtEmail.Focus();
                    }
                    else
                    {
                        bool bKq = false;
                        if (_iTrangThaiForm == 1)
                            bKq = NhanVien_BUS.themNVien_BUS(NVHienTai);
                        else
                            bKq = NhanVien_BUS.suaNV_BUS(NVHienTai);

                        if (!bKq)
                            DevExpress.XtraEditors.XtraMessageBox.Show("Lưu Thất Bại!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        else
                        {
                            _lst_loadDSNV();
                            _iTrangThaiForm = 0;
                            _setTrangThaiForm();
                            DevExpress.XtraEditors.XtraMessageBox.Show("Lưu Thành Công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
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

        private void txtTenNV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (kiemTraNhapKyTuSo(e.KeyChar))
            {
                e.Handled = true;
                txtTenNV.Focus();
                DevExpress.XtraEditors.XtraMessageBox.Show("Bạn Không Được Nhập Số", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (kiemTraNhapKyTuChu(e.KeyChar))
            {
                e.Handled = true;
                txtSDT.Focus();
                DevExpress.XtraEditors.XtraMessageBox.Show("Bạn Không Được Nhập Chữ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtCMND_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (kiemTraNhapKyTuChu(e.KeyChar))
            {
                e.Handled = true;
                txtCMND.Focus();
                DevExpress.XtraEditors.XtraMessageBox.Show("Bạn Không Được Nhập Chữ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (kiemTraNhapKyTuChu(e.KeyChar))
            {
                e.Handled = true;
                txtLuong.Focus();
                DevExpress.XtraEditors.XtraMessageBox.Show("Bạn Không Được Nhập Chữ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void lblQuayLai_Click(object sender, EventArgs e)
        {
            Util.EndAnimate(this, Util.Effect.Slide, 150, 30);
            this.Close();
        }

        private void lblRefresh_Click(object sender, EventArgs e)
        {
            _iTrangThaiForm = 0;
            _setTrangThaiForm();
            lstNV = NhanVien_BUS.loadDSNV_BUS();
            gcDSNV.DataSource = lstNV;
        }
        #endregion
    }
}
