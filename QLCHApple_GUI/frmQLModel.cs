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
using System.Threading;

namespace QLCHApple_GUI
{
    public partial class frmQLModel : Form
    {
        public frmQLModel()
        {
            InitializeComponent();
        }

        public void StartForm()
        {
            Application.Run(new frmSplash());
        }

        #region Properties
        BindingList<Model_DTO> _LST_DSModel = new BindingList<Model_DTO>();
        int _I_TrangThaiForm = 0;
        Model_DTO _MODEL_HienTai = null;
        #endregion
        #region Methods
        /* Trạng thái form dựa vào bảng sản phẩm truyền dữ liệu qua là MaSP. */
        public void _setTrangThaiForm()
        {
            txtMaModel.ReadOnly = true;
            switch (_I_TrangThaiForm)
            {
                case 0: // Xem
                    btnLuuModel.Enabled = false;
                    if (_MODEL_HienTai == null)
                    {
                        btnSuaLModel.Enabled = false;
                        btnXoaModel.Enabled = false;
                    }
                    else
                    {
                        btnSuaLModel.Enabled = true;
                        btnXoaModel.Enabled = true;
                    }

                    txtTenModel.Enabled = false;
                    break;
                case 1: // Thêm
                    txtTenModel.Text = "";

                    txtTenModel.Enabled = true;

                    btnXoaModel.Enabled = false;
                    btnSuaLModel.Enabled = false;
                    btnLuuModel.Enabled = true;
                    break;
                case 2: // Sửa
                    txtTenModel.Enabled = true;

                    btnThemModel.Enabled = true;
                    btnXoaModel.Enabled = true;
                    btnLuuModel.Enabled = true;
                    break;
            }
        }

        private void loadThongTinChiTiet()
        {
            if (_MODEL_HienTai == null)
            {
                txtMaModel.Text = "";
                txtTenModel.Text = "";
            }
            else
            {
                txtMaModel.Text = _MODEL_HienTai.strMaModel;
                txtTenModel.Text = _MODEL_HienTai.strTenModel;
            }
        }

        private void layThongTinChiTiet()
        {
            if (_MODEL_HienTai == null)
            {
                _MODEL_HienTai = new Model_DTO();
            }
            _MODEL_HienTai.strMaModel = txtMaModel.Text;
            _MODEL_HienTai.strTenModel = txtTenModel.Text;
        }

        #endregion

        #region Events
        private void frmQLModel_Load(object sender, EventArgs e)
        {
            /*Design form*/
            this.Visible = false;
            Util.EndAnimate(this, Util.Effect.Slide, 150, 180);
            /*Design form*/

            repositoryItemLookUpEdit_MaModel.DataSource = _LST_DSModel.ToList();
            repositoryItemLookUpEdit_MaModel.Columns["colTenModel"].FieldName = "strTenModel";

            _LST_DSModel = Model_BUS.loadDSModel_BUS();
            gcDSModel.DataSource = _LST_DSModel;

            _setTrangThaiForm();
        }

        private void lblRefresh_Click(object sender, EventArgs e)
        {
            _LST_DSModel = Model_BUS.loadDSModel_BUS();
            gcDSModel.DataSource = _LST_DSModel;
            _I_TrangThaiForm = 0;
            _setTrangThaiForm();
        }

        private void lblQuayLai_Click(object sender, EventArgs e)
        {
            Util.EndAnimate(this, Util.Effect.Slide, 150, 30);
            this.Close();
        }

        private void gvDSCTModel_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {
            if (gvDSCTModel.SelectedRowsCount > 0)
                _MODEL_HienTai = (Model_DTO)gvDSCTModel.GetRow(gvDSCTModel.FocusedRowHandle);
            else
                _MODEL_HienTai = null;

            loadThongTinChiTiet();
            _I_TrangThaiForm = 0;
            _setTrangThaiForm();
        }

        private void btnXoaModel_Click(object sender, EventArgs e)
        {
            if (_MODEL_HienTai != null)
            {
                DialogResult dlgHoiXoa = DevExpress.XtraEditors.XtraMessageBox.Show("Bạn Có Chắc Chắn Muốn Xóa", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dlgHoiXoa == DialogResult.Yes)
                {
                    if (Model_BUS.kiemTraTrungMaCTModel_DAO(_MODEL_HienTai.strMaModel))
                    {
                        DevExpress.XtraEditors.XtraMessageBox.Show("Model Có Trong Sản Phẩm!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        if (Model_BUS.updateTrangThaiModel_BUS(_MODEL_HienTai))
                        {
                            _LST_DSModel = Model_BUS.loadDSModel_BUS();
                            gcDSModel.DataSource = _LST_DSModel;
                            if (_LST_DSModel.Count == 0)
                                _MODEL_HienTai = null;
                            _I_TrangThaiForm = 0;
                            _setTrangThaiForm();
                            DevExpress.XtraEditors.XtraMessageBox.Show("Xóa Thành Công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                            DevExpress.XtraEditors.XtraMessageBox.Show("Xóa Thất Bại!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            else
                DevExpress.XtraEditors.XtraMessageBox.Show("Chưa Chọn Cấu Hình", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnSuaLModel_Click(object sender, EventArgs e)
        {
            _I_TrangThaiForm = 2;
            _setTrangThaiForm();
        }

        private void btnThemModel_Click(object sender, EventArgs e)
        {
            _MODEL_HienTai = null;
            _I_TrangThaiForm = 1;
            _setTrangThaiForm();
            txtMaModel.Text = Model_BUS.layMaCaoNhat_BUS();
            txtTenModel.Focus();
        }

        private void btnLuuModel_Click(object sender, EventArgs e)
        {
            if (txtTenModel.Text == "")
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("Bạn Chưa Nhập Tên Model", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenModel.Focus();
            }
            else
            {
                layThongTinChiTiet();

                bool bKq = false;
                if (_I_TrangThaiForm == 1)
                    bKq = Model_BUS.themModel_BUS(_MODEL_HienTai);
                else if (_I_TrangThaiForm == 2)
                    bKq = Model_BUS.suaModel_BUS(_MODEL_HienTai);

                if (!bKq)
                {
                    DevExpress.XtraEditors.XtraMessageBox.Show("Lưu Thất Bại!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    _LST_DSModel = Model_BUS.loadDSModel_BUS();
                    gcDSModel.DataSource = _LST_DSModel;
                    _I_TrangThaiForm = 0;
                    _setTrangThaiForm();
                    DevExpress.XtraEditors.XtraMessageBox.Show("Lưu Thành Công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        #endregion

        Point lastPoint;
        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }
    }
}
