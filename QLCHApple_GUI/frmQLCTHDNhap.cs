using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.Drawing;
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
    public partial class frmQLCTHDNhap : Form
    {
        public frmQLCTHDNhap()
        {
            InitializeComponent();
        }

        #region Khai Báo Biến
        private HDNhap_DTO _HDNhap = new HDNhap_DTO();
        public HDNhap_DTO HDNhap
        {
            get
            {
                return _HDNhap;
            }

            set
            {
                _HDNhap = value;
            }
        }

        BindingList<NhanVien_DTO> _LST_DSNhanVien = new BindingList<NhanVien_DTO>();
        BindingList<CTHDBan_DTO> _LST_DSCTHDBan = new BindingList<CTHDBan_DTO>();
        BindingList<SanPham_DTO> _LST_DSSPham_Ban = new BindingList<SanPham_DTO>(); // San pham
        BindingList<LoaiSanPham_DTO> _LST_DSLSP = new BindingList<LoaiSanPham_DTO>(); // Loai san pham
        #endregion

        private void frmPhanQuyen_Load(object sender, EventArgs e)
        {
            /*Designs Form*/
            this.Visible = false;
            Util.EndAnimate(this, Util.Effect.Slide, 150, 180);
            /*Designs Form*/

            if (_HDNhap != null)
            {
                // Load du lieu nhan vien.
                _LST_DSNhanVien = NhanVien_BUS.loadDSNV_BUS();
                loadDSNhanVien(_LST_DSNhanVien);

                // Load du lieu hoa don len grp.
                txtMaHDNhap.Text = _HDNhap.I_MaHDN.ToString();
                dtNgayLap.EditValue = _HDNhap.DT_NgayLap;
                lookUpEdit_TenNV.EditValue = _HDNhap.STR_MaNV;
                txtTongTien.Text = _HDNhap.DEC_TongTien.ToString();

                // Load du lieu loai san pham.
                _LST_DSLSP = LoaiSanPham_BUS.layDSLoaiSP_BUS();
                loadDSLoaiSanPham(_LST_DSLSP);

                // Load DS san pham vao gridview.
            }
        }

        #region Methods
        /*2 hàm có nhiệm vụ thêm cột STT*/
        private bool _B_indicatorIcon = true;

        private void gvPhanQuyen_CustomDrawRowIndicator(object sender, RowIndicatorCustomDrawEventArgs e)
        {
            try
            {
                GridView view = (GridView)sender;
                if (e.Info.IsRowIndicator && e.RowHandle >= 0)
                {
                    string sText = (e.RowHandle + 1).ToString();
                    Graphics gr = e.Info.Graphics;
                    gr.PageUnit = GraphicsUnit.Pixel;
                    GridView gridView = ((GridView)sender);
                    SizeF size = gr.MeasureString(sText, e.Info.Appearance.Font);
                    int nNewSize = Convert.ToInt32(size.Width) + GridPainter.Indicator.ImageSize.Width + 10;
                    if (gridView.IndicatorWidth < nNewSize)
                    {
                        gridView.IndicatorWidth = nNewSize;
                    }

                    e.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
                    e.Info.DisplayText = sText;
                }
                if (!_B_indicatorIcon)
                    e.Info.ImageIndex = -1;

                if (e.RowHandle == GridControl.InvalidRowHandle)
                {
                    Graphics gr = e.Info.Graphics;
                    gr.PageUnit = GraphicsUnit.Pixel;
                    GridView gridView = ((GridView)sender);
                    SizeF size = gr.MeasureString("STT", e.Info.Appearance.Font);
                    int nNewSize = Convert.ToInt32(size.Width) + GridPainter.Indicator.ImageSize.Width + 10;
                    if (gridView.IndicatorWidth < nNewSize)
                    {
                        gridView.IndicatorWidth = nNewSize;
                    }

                    e.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
                    e.Info.DisplayText = "STT";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void gvPhanQuyen_RowCountChanged(object sender, EventArgs e)
        {
            GridView gridview = ((GridView)sender);
            if (!gridview.GridControl.IsHandleCreated) return;
            Graphics gr = Graphics.FromHwnd(gridview.GridControl.Handle);
            SizeF size = gr.MeasureString(gridview.RowCount.ToString(), gridview.PaintAppearance.Row.GetFont());
            gridview.IndicatorWidth = Convert.ToInt32(size.Width + 0.999f) + GridPainter.Indicator.ImageSize.Width + 20;
        }
        /*2 hàm có nhiệm vụ thêm cột STT*/

        // Load du lieu nhan vien.
        void loadDSNhanVien(BindingList<NhanVien_DTO> _LST_DSNV)
        {
            lookUpEdit_TenNV.Properties.DataSource = _LST_DSNhanVien;
            lookUpEdit_TenNV.Properties.Columns["colTenNV"].FieldName = "strHoTen";
        }

        // Load du lieu loai san pham.
        void loadDSLoaiSanPham(BindingList<LoaiSanPham_DTO> _LST_DSLoaiSP)
        {
            LookUpEdit_LoaiSP.DataSource = _LST_DSLSP;
            LookUpEdit_LoaiSP.Columns["colMaLoaiSP"].FieldName = "strMaLoaiSP";
            LookUpEdit_LoaiSP.Columns["colTenLoaiSP"].FieldName = "strTenLoaiSP";
        }

        // Load DS san pham theo hdban.
        void loadDSSP_HDBan(int _I_MaHDB, BindingList<CTHDBan_DTO> _LST_DSCTHDBan, BindingList<SanPham_DTO> _LST_DSSP)
        {

        }
        #endregion

        #region Events
        private void lblQuayLai_Click(object sender, EventArgs e)
        {
            Util.EndAnimate(this, Util.Effect.Slide, 150, 30);
            this.Close();
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            
            //DevExpress.XtraEditors.XtraMessageBox.Show("Bạn Chưa Chọn Loại Nhân Viên", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnCTHDBan_Click(object sender, EventArgs e)
        {

        }
        #endregion
    }
}
