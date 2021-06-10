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
    public partial class frmQLHoaDonNhap : Form
    {
        public frmQLHoaDonNhap()
        {
            InitializeComponent();
        }

        #region Properties
        BindingList<NhanVien_DTO> _LST_DSNhanVien = new BindingList<NhanVien_DTO>();
        BindingList<HDNhap_DTO> _LST_DSHDNhapFromToDate = new BindingList<HDNhap_DTO>();
        #endregion

        private void frmPhanQuyen_Load(object sender, EventArgs e)
        {
            /*Designs Form*/
            this.Visible = false;
            Util.EndAnimate(this, Util.Effect.Slide, 150, 180);
            /*Designs Form*/

            _LST_DSNhanVien = NhanVien_BUS.loadDSNV_BUS();

            LookUpEdit_gvColMaNV.DataSource = _LST_DSNhanVien;
            LookUpEdit_gvColMaNV.Columns["colTenNV"].FieldName = "strHoTen";

            loadDateTimePickerHDBNhap();
            loadDSHDNhapFormToDate((DateTime)dtFromDate.EditValue, (DateTime)dtToDate.EditValue);
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

        void loadDSHDNhapFormToDate(DateTime _DT_FromDate, DateTime _DT_ToDate)
        {
            _LST_DSHDNhapFromToDate = HDNhap_BUS._LST_DSHDNhap_FromToDate_BUS(_DT_FromDate, _DT_ToDate);
            gcDSHDNhap.DataSource = _LST_DSHDNhapFromToDate;
        }

        void loadDateTimePickerHDBNhap()
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
                loadDSHDNhapFormToDate((DateTime)dtFromDate.EditValue, (DateTime)dtToDate.EditValue);
            }

            //DevExpress.XtraEditors.XtraMessageBox.Show("Bạn Chưa Chọn Loại Nhân Viên", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnCTHDNhap_Click(object sender, EventArgs e)
        {
            if (gvDSHDNhap.RowCount > 0)
            {
                if (gvDSHDNhap.SelectedRowsCount > 0)
                {
                    frmQLCTHDNhap frm = new frmQLCTHDNhap();
                    frm.HDNhap = (HDNhap_DTO)gvDSHDNhap.GetRow(gvDSHDNhap.FocusedRowHandle);
                    frm.ShowDialog();
                }
                else
                    DevExpress.XtraEditors.XtraMessageBox.Show("Bạn Chưa Chọn Sản Phẩm", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                DevExpress.XtraEditors.XtraMessageBox.Show("Danh Sách Rỗng", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        #endregion
    }
}
