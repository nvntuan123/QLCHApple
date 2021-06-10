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
    public partial class frmQLHoaDonBan : Form
    {
        public frmQLHoaDonBan()
        {
            InitializeComponent();
        }

        #region Khai Báo Biến
        BindingList<NhanVien_DTO> _LST_DSNhanVien = new BindingList<NhanVien_DTO>();
        BindingList<KhachHang_DTO> _LST_DSKhachHang = new BindingList<KhachHang_DTO>();
        BindingList<HDBan_DTO> _LST_DSHDBanFromToDate = new BindingList<HDBan_DTO>();
        HDBan_DTO _HDBan_HienTai = null;
        #endregion

        private void frmPhanQuyen_Load(object sender, EventArgs e)
        {
            /*Designs Form*/
            this.Visible = false;
            Util.EndAnimate(this, Util.Effect.Slide, 150, 180);
            /*Designs Form*/

            _LST_DSNhanVien = NhanVien_BUS.loadDSNV_BUS();
            _LST_DSKhachHang = KhachHang_BUS.loadDSKhachHang_BUS();

            LookUpEdit_gvColMaNV.DataSource = _LST_DSNhanVien;
            LookUpEdit_gvColMaNV.Columns["colTenNV"].FieldName = "strHoTen";
            LookUpEdit_gvColMaKH.DataSource = _LST_DSKhachHang;
            LookUpEdit_gvColMaKH.Columns["colTenKH"].FieldName = "strHoTenKH";

            loadDateTimePickerHDBan();
            loadDSHDBanFormToDate((DateTime)dtFromDate.EditValue, (DateTime)dtToDate.EditValue);
            setTrangThaiForm();
        }

        #region Methods
        /*2 hàm có nhiệm vụ thêm cột STT*/
        private bool _B_indicatorIcon = true;
        private void gv_CustomDrawRowIndicator(object sender, RowIndicatorCustomDrawEventArgs e)
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

        private void gv_RowCountChanged(object sender, EventArgs e)
        {
            GridView gridview = ((GridView)sender);
            if (!gridview.GridControl.IsHandleCreated) return;
            Graphics gr = Graphics.FromHwnd(gridview.GridControl.Handle);
            SizeF size = gr.MeasureString(gridview.RowCount.ToString(), gridview.PaintAppearance.Row.GetFont());
            gridview.IndicatorWidth = Convert.ToInt32(size.Width + 0.999f) + GridPainter.Indicator.ImageSize.Width + 20;
        }
        /*2 hàm có nhiệm vụ thêm cột STT*/

        private void loadDSHDBanFormToDate(DateTime _DT_FromDate, DateTime _DT_ToDate)
        {
            _LST_DSHDBanFromToDate = HDBan_BUS._LST_DSHDBan_FromToDate_BUS(_DT_FromDate, _DT_ToDate);
            gcDSHoaDon.DataSource = _LST_DSHDBanFromToDate;
        }

        private void loadDateTimePickerHDBan()
        {
            DateTime _DT_Today = DateTime.Now;
            dtFromDate.EditValue = new DateTime(_DT_Today.Year, _DT_Today.Month, 1); // Đưa ngày đầu của tháng hiện tại.

            /* CT: + tháng lên 1 rồi từ đi 1 ngày của tháng đã cộng.
             * VD: Hiện tại là tháng 1. Thì dòng trên mình đưa về ngày đầu tháng là 1/1
             *      Sau đó mình + thêm 1 tháng tức là 1/2.
             *      Rồi mình trừ đi 1 ngày của tháng tháng 2 hiện tại => cuối tháng 1.
             */
            dtToDate.EditValue = dtFromDate.DateTime.AddMonths(1).AddDays(-1);
        }

        private void loadDSHoaDon()
        {
            _LST_DSHDBanFromToDate = HDBan_BUS.loadDSHDBan_BUS();
            gcDSHoaDon.DataSource = _LST_DSHDBanFromToDate;
        }

        private void loadThongTinHoaDon()
        {
            if (_HDBan_HienTai != null)
            {
                txtMaHDB.Text = _HDBan_HienTai.I_MaHDB.ToString();
                dtNgayBan.EditValue = _HDBan_HienTai.DT_NgayBan;
                lookUpEdit_TenNV.EditValue = _HDBan_HienTai.STR_MaNV;
                lookUpEdit_TenKH.EditValue = _HDBan_HienTai.STR_MaKH;
                txtTongTien.Text = _HDBan_HienTai.DEC_TongTien.ToString();
            }
            else
            {
                txtMaHDB.Text = "";
                dtNgayBan.EditValue = null;
                lookUpEdit_TenNV.EditValue = null;
                lookUpEdit_TenKH.EditValue = null;
                txtTongTien.Text = "";
            }
        }

        private void layThongTinHoaDon()
        {
            if (_HDBan_HienTai == null)
                _HDBan_HienTai = new HDBan_DTO();

            _HDBan_HienTai.I_MaHDB = Convert.ToInt32(txtMaHDB.Text);
            _HDBan_HienTai.DT_NgayBan = (DateTime)(dtNgayBan.EditValue);
            _HDBan_HienTai.STR_MaNV = lookUpEdit_TenNV.EditValue.ToString();
            _HDBan_HienTai.STR_MaKH = lookUpEdit_TenKH.EditValue.ToString();
            _HDBan_HienTai.DEC_TongTien = Convert.ToDecimal(txtTongTien.Text);
        }

        void setTrangThaiForm()
        {
            txtMaHDB.ReadOnly = true;
            txtTongTien.ReadOnly = true;
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
            if (dtFromDate.EditValue != null && dtToDate.EditValue != null)
            {
                loadDSHDBanFormToDate((DateTime)dtFromDate.EditValue, (DateTime)dtToDate.EditValue);
            }

            //DevExpress.XtraEditors.XtraMessageBox.Show("Bạn Chưa Chọn Loại Nhân Viên", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnCTHDBan_Click(object sender, EventArgs e)
        {
            if (gvDSHoaDon.RowCount > 0)
            {
                if (gvDSHoaDon.SelectedRowsCount > 0)
                {
                    frmQLCTHDBan frm = new frmQLCTHDBan();
                    frm.HDBan = (HDBan_DTO)gvDSHoaDon.GetRow(gvDSHoaDon.FocusedRowHandle);
                    frm.ShowDialog();
                }
                else
                    DevExpress.XtraEditors.XtraMessageBox.Show("Bạn Chưa Chọn Sản Phẩm", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                DevExpress.XtraEditors.XtraMessageBox.Show("Danh Sách Rỗng", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnXoaHDBan_Click(object sender, EventArgs e)
        {
            //layThongTinHoaDon();
            if (_HDBan_HienTai != null)
            {
                // Update trạng thái hóa đơn bán = 0.
                if (!HDBan_BUS.updateTrangThaiHDBan_BUS(_HDBan_HienTai))
                {
                    DevExpress.XtraEditors.XtraMessageBox.Show("Error", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                // Update MaHDB ở bảng IMEI = NULL
                if (!IMEI_BUS.updateMaHDBinIMEI_BUS(_HDBan_HienTai.I_MaHDB))
                {
                    DevExpress.XtraEditors.XtraMessageBox.Show("Error", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // DELETE CTHDBan theo MaSP.
                if (!CTHDBan_BUS.delectCTHDTheoMaHDB_BUS(_HDBan_HienTai.I_MaHDB))
                {
                    DevExpress.XtraEditors.XtraMessageBox.Show("Error", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else
                DevExpress.XtraEditors.XtraMessageBox.Show("Bạn Chưa Chọn Hóa Đơn", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnUpdateHDBan_Click(object sender, EventArgs e)
        {
            if (dtNgayBan.EditValue == null)
                DevExpress.XtraEditors.XtraMessageBox.Show("Bạn Chưa Chọn Ngày", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (lookUpEdit_TenNV.EditValue == null)
                DevExpress.XtraEditors.XtraMessageBox.Show("Bạn Chưa Chọn Nhân Viên", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (lookUpEdit_TenKH.EditValue == null)
                DevExpress.XtraEditors.XtraMessageBox.Show("Bạn Chưa Chọn Nhân Viên", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                layThongTinHoaDon();
                if (_HDBan_HienTai != null)
                {
                    if (HDBan_BUS.updateHDBan_BUS(_HDBan_HienTai))
                    {
                        dtFromDate.EditValue = null;
                        dtToDate.EditValue = null;
                        loadDSHoaDon();
                        DevExpress.XtraEditors.XtraMessageBox.Show("Cập Nhật Hóa Đơn Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                        DevExpress.XtraEditors.XtraMessageBox.Show("Cập Nhật Hóa Đơn Thất Bại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void gvDSHoaDon_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {
            if (gvDSHoaDon.SelectedRowsCount > 0)
            {
                _HDBan_HienTai = (HDBan_DTO)gvDSHoaDon.GetRow(gvDSHoaDon.FocusedRowHandle);
                loadThongTinHoaDon();
            }
        }

        private void btnTatCaHoaDon_Click(object sender, EventArgs e)
        {
            dtFromDate.EditValue = null;
            dtToDate.EditValue = null;
            loadDSHoaDon();
        }
        #endregion
    }
}
