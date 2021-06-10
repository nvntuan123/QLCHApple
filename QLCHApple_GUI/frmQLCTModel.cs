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
    public partial class frmQLCTModel : Form
    {
        public frmQLCTModel()
        {
            InitializeComponent();
        }
        #region Properties
        private SanPham_DTO _SPHienTai;
        public SanPham_DTO SPHienTai
        {
            get
            {
                return _SPHienTai;
            }

            set
            {
                _SPHienTai = value;
            }
        }

        BindingList<ChiTietModel_DTO> _LST_ChiTietModel = new BindingList<ChiTietModel_DTO>();
        BindingList<Model_DTO> _LST_DSModel = new BindingList<Model_DTO>();
        int iTrangThaiForm = 0;
        ChiTietModel_DTO _CTSPHienTai = null;
        #endregion
        #region Methods
        /* Trạng thái form dựa vào bảng sản phẩm truyền dữ liệu qua là MaSP. */
        public void setTrangThaiForm()
        {
            grpThongTinSanPham.Enabled = false;
            switch (iTrangThaiForm)
            {
                case 0: // Xem
                    btnLuuCTModel.Enabled = false;
                    if (_CTSPHienTai == null)
                    {
                        btnSuaCTModel.Enabled = false;
                        btnXoaCTModel.Enabled = false;
                    }
                    else
                    {
                        if (frmHome.B_TrangThaiClickXem)
                        {
                            btnSuaCTModel.Enabled = false;
                            btnXoaCTModel.Enabled = false;
                        }
                        else
                        {
                            btnSuaCTModel.Enabled = true;
                            btnXoaCTModel.Enabled = true;
                        }
                    }

                    cmbModel.Enabled = false;
                    txtThongSo.Enabled = false;
                    mmeMoTa.ReadOnly = true;
                    break;
                case 1: // Thêm
                    cmbModel.EditValue = null;
                    txtThongSo.Text = "";
                    mmeMoTa.Text = "";

                    cmbModel.Enabled = true;
                    txtThongSo.Enabled = true;
                    mmeMoTa.ReadOnly = false;

                    btnXoaCTModel.Enabled = false;
                    btnSuaCTModel.Enabled = false;
                    btnLuuCTModel.Enabled = true;
                    break;
                case 2: // Sửa
                    txtThongSo.Enabled = true;
                    mmeMoTa.ReadOnly = false;

                    btnThemCTModel.Enabled = true;
                    btnXoaCTModel.Enabled = true;
                    btnLuuCTModel.Enabled = true;
                    break;
            }
        }

        private void loadThongTinChiTiet()
        {
            if (_CTSPHienTai == null)
            {
                cmbModel.EditValue = null;
                txtThongSo.Text = "";
                mmeMoTa.Text = "";
            }
            else
            {
                cmbModel.EditValue = _CTSPHienTai.strMaModel;
                txtThongSo.Text = _CTSPHienTai.strThongSoKyThuat;
                mmeMoTa.Text = _CTSPHienTai.strMota;
            }
        }

        private void layThongTinChiTiet()
        {
            if (_CTSPHienTai == null)
            {
                _CTSPHienTai = new ChiTietModel_DTO();
            }
            _CTSPHienTai.strMaModel = cmbModel.GetColumnValue("strMaModel").ToString();
            _CTSPHienTai.strThongSoKyThuat = txtThongSo.Text;
            _CTSPHienTai.strMota = mmeMoTa.Text;

            _CTSPHienTai.strMaSP = _SPHienTai.strMaSP;
        }

        private void loadThongTinSanPham()
        {
            // Load thông tin sản phẩm từ bảng sản phẩm qua bảng model.
            if (_SPHienTai == null)
            {
                txtMaSP.Text = "";
                txtTenSP.Text = "";
                txtSL.Text = "";
                txtGiaBan.Text = "";
                dtNamSX.DateTime = DateTime.Now;
            }
            else
            {
                txtMaSP.Text = _SPHienTai.strMaSP;
                txtTenSP.Text = _SPHienTai.strTenSP;
                txtSL.Text = _SPHienTai.iSoLuong.ToString();
                txtGiaBan.Text = _SPHienTai.decGiaBan.ToString();
                dtNamSX.DateTime = _SPHienTai.dtNamSX;
            }
        }
        #endregion
        #region Events
        private void frmQLCTModel_Load(object sender, EventArgs e)
        {
            /*Design form*/
            this.Visible = false;
            Util.EndAnimate(this, Util.Effect.Slide, 150, 180);
            /*Design form*/

            _LST_DSModel = Model_BUS.loadDSModel_BUS();
            cmbModel.Properties.DataSource = _LST_DSModel;
            cmbModel.Properties.Columns["colTenModel"].FieldName = "strTenModel";

            repositoryItemLookUpEdit_MaModel.DataSource = _LST_DSModel.ToList();
            repositoryItemLookUpEdit_MaModel.Columns["colTenModel"].FieldName = "strTenModel";

            _LST_ChiTietModel = ChiTietModel_BUS.loadDSChiTietModel_BUS(_SPHienTai);
            gcDSCTModel.DataSource = _LST_ChiTietModel;

            if (frmHome.B_TrangThaiClickXem)
            {
                btnThemCTModel.Enabled = false;
                btnXoaCTModel.Enabled = false;
                btnSuaCTModel.Enabled = false;
                btnLuuCTModel.Enabled = false;
                lblThemModel.Enabled = false;
            }
            else
            {
                setTrangThaiForm();
                loadThongTinSanPham();
            }
        }

        private void lblRefresh_Click(object sender, EventArgs e)
        {
            _LST_ChiTietModel = ChiTietModel_BUS.loadDSChiTietModel_BUS(_SPHienTai);
            gcDSCTModel.DataSource = _LST_ChiTietModel;

            _LST_DSModel = Model_BUS.loadDSModel_BUS();
            cmbModel.Properties.DataSource = _LST_DSModel;
            repositoryItemLookUpEdit_MaModel.DataSource = _LST_DSModel;

            iTrangThaiForm = 0;
            setTrangThaiForm();
        }

        private void lblQuayLai_Click(object sender, EventArgs e)
        {
            Util.EndAnimate(this, Util.Effect.Slide, 150, 30);
            this.Close();
        }

        private void gvDSCTModel_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {
            if (gvDSCTModel.SelectedRowsCount > 0)
                _CTSPHienTai = (ChiTietModel_DTO)gvDSCTModel.GetRow(gvDSCTModel.FocusedRowHandle);
            else
                _CTSPHienTai = null;

            loadThongTinChiTiet();
            iTrangThaiForm = 0;
            setTrangThaiForm();
        }

        private void btnXoaCTModel_Click(object sender, EventArgs e)
        {
            if (_CTSPHienTai != null)
            {
                DialogResult dlgHoiXoa = DevExpress.XtraEditors.XtraMessageBox.Show("Bạn Có Chắc Muốn Bỏ Cấu Hình Khỏi Sản Phẩm " + _SPHienTai.strMaSP, "Thông Báo",MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dlgHoiXoa == DialogResult.Yes)
                {
                    if (ChiTietModel_BUS.deleteChiTietSP_BUS(_CTSPHienTai))
                    {
                        _LST_ChiTietModel = ChiTietModel_BUS.loadDSChiTietModel_BUS(_SPHienTai);
                        gcDSCTModel.DataSource = _LST_ChiTietModel;
                        if (_LST_ChiTietModel.Count == 0)
                            _CTSPHienTai = null;
                        iTrangThaiForm = 0;
                        setTrangThaiForm();
                        DevExpress.XtraEditors.XtraMessageBox.Show("Xóa Thành Công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                        DevExpress.XtraEditors.XtraMessageBox.Show("Xóa Thất Bại!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
                DevExpress.XtraEditors.XtraMessageBox.Show("Chưa Chọn Cấu Hình", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnSuaCTModel_Click(object sender, EventArgs e)
        {
            iTrangThaiForm = 2;
            setTrangThaiForm(); 
        }

        private void btnThemCTModel_Click(object sender, EventArgs e)
        {
            _CTSPHienTai = null;
            iTrangThaiForm = 1;
            setTrangThaiForm();
        }

        private void btnLuuCTModel_Click(object sender, EventArgs e)
        {
            if (cmbModel.EditValue == null)
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("Bạn Chưa Chọn Model", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbModel.Focus();
            }
            else if (txtThongSo.Text == "")
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("Bạn Chưa Nhập Thông Số", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtThongSo.Focus();
            }
            else if (mmeMoTa.Text == "")
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("Bạn Chưa Nhập Mô Tả", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mmeMoTa.Focus();
            }
            else
            {
                layThongTinChiTiet();

                bool bKq = false, bKq1 = false;
                if (iTrangThaiForm == 1)
                {
                    if (ChiTietModel_BUS.checkMaSPandMaModel_BUS(_CTSPHienTai))
                    {
                        bKq1 = true;
                        DevExpress.XtraEditors.XtraMessageBox.Show("Sản Phẩm Đã Có Model Này!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                        bKq = ChiTietModel_BUS.addChiTietSP_BUS(_CTSPHienTai);
                }
                else if (iTrangThaiForm == 2)
                    bKq = ChiTietModel_BUS.updateChiTietSP_BUS(_CTSPHienTai);

                if (!bKq)
                {
                    if (iTrangThaiForm == 1 && !bKq1 || iTrangThaiForm == 2)
                        DevExpress.XtraEditors.XtraMessageBox.Show("Lưu Thất Bại!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    _LST_ChiTietModel = ChiTietModel_BUS.loadDSChiTietModel_BUS(_SPHienTai);
                    gcDSCTModel.DataSource = _LST_ChiTietModel;
                    iTrangThaiForm = 0;
                    setTrangThaiForm();
                    DevExpress.XtraEditors.XtraMessageBox.Show("Lưu Thành Công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void lblThemModel_Click(object sender, EventArgs e)
        {
            frmQLModel frm = new frmQLModel();
            frm.ShowDialog();

            // Reset lại danh sách Model.
            _LST_DSModel = Model_BUS.loadDSModel_BUS();
            cmbModel.Properties.DataSource = _LST_DSModel;
            repositoryItemLookUpEdit_MaModel.DataSource = _LST_DSModel;
        }
        #endregion

        Point LastPoint;
        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            LastPoint = new Point(e.X, e.Y);
        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - LastPoint.X;
                this.Top += e.Y - LastPoint.Y;
            }
        }
    }
}
