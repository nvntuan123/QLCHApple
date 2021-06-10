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
using System.Globalization;
using QLCHApple_GUI.Report;
using DevExpress.XtraReports.UI;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.Drawing;
using DevExpress.XtraGrid;

namespace QLCHApple_GUI
{
    public partial class frmQLNH : Form
    {
        #region Khai báo biến
        private bool indicatorIcon = true;
        private BindingList<SanPham_DTO> _LST_cmbTenSP = new BindingList<SanPham_DTO>();
        private BindingList<SanPham_DTO> _LST_SPChon = new BindingList<SanPham_DTO>(); // Sau khi thêm phải reset lại.
        private BindingList<IMEI_DTO> _LST_IMEI = new BindingList<IMEI_DTO>(); // Reset
        private BindingList<CTHDNhap_DTO> _LST_CTHDNhap = new BindingList<CTHDNhap_DTO>(); // Reset
        private BindingList<LoaiSanPham_DTO> _LST_LoaiSP = new BindingList<LoaiSanPham_DTO>();
        private SanPham_DTO _SP_SELECT = null; // Reset
        private int _I_MaHDN_MAX = 0; // Reset
        private decimal _DEC_TongTien = 0; // Reset
        NhanVien_DTO _NVDangNhap_frmQLNH = null;
        private bool canPrintBill = false;
        #endregion
        public frmQLNH()
        {
            InitializeComponent();
        }

        private void frmQLNH_Load(object sender, EventArgs e)
        {
            #region Designs FormLoad
            this.Visible = false;
            Util.EndAnimate(this, Util.Effect.Slide, 150, 180);
            #endregion

            _LST_cmbTenSP = SanPham_BUS.loadDSSP_BUS();
            cmbTenSP.Properties.DataSource = _LST_cmbTenSP;
            cmbTenSP.Properties.Columns["colTenSP"].FieldName = "strTenSP";
            cmbTenSP.Properties.Columns["colGiaBan"].FieldName = "decGiaBan";

            _LST_LoaiSP = LoaiSanPham_BUS.layDSLoaiSP_BUS();
            LookUpEdit_LoaiSP.DataSource = _LST_LoaiSP;
            LookUpEdit_LoaiSP.Columns["colMaLoaiSP"].FieldName = "strMaLoaiSP";
            LookUpEdit_LoaiSP.Columns["colTenLoaiSP"].FieldName = "strTenLoaiSP";
            
            _I_MaHDN_MAX = HDNhap_BUS.layHDNhap_CaoNhat_BUS();
            txtMaHDN.Text = _I_MaHDN_MAX.ToString();
            txtMaHDN.ReadOnly = true;
            txtSLTon.ReadOnly = true;
            txtSLNhap.ReadOnly = true;
            txtTongTien.ReadOnly = true;

            if (frmHome.NVDangNhap_frmHome != null)
                _NVDangNhap_frmQLNH = frmHome.NVDangNhap_frmHome;
        }
        #region Lập, In HD.
        private void btnLapHD_Click(object sender, EventArgs e)
        {
            if (txtMaHDN.Text == "")
                DevExpress.XtraEditors.XtraMessageBox.Show("Error", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (_LST_CTHDNhap.Count == 0)
                DevExpress.XtraEditors.XtraMessageBox.Show("Chưa Có Sản Phẩm Để Nhập Hàng", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                if (_LST_IMEI.Count == 0)
                    DevExpress.XtraEditors.XtraMessageBox.Show("Tất Cả Sản Phẩm Chưa Có Mã IMEI", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                {
                    // Kiểm tra xem có sản phẩm nào không có mã IMEI hay không, nếu có => bắt lỗi. Không thì chạy tiếp.
                    bool _B_Check = false;
                    foreach (SanPham_DTO sp in _LST_SPChon)
                    {
                        bool _B_Check1 = false;
                        foreach (IMEI_DTO IMEI in _LST_IMEI)
                        {
                            if (IMEI.STR_MaSP == sp.strMaSP)
                            {
                                _B_Check1 = true;
                                break;
                            }
                        }

                        if (!_B_Check1)
                            _B_Check = true;
                    }

                    if (!_B_Check)
                    {
                        HDNhap_DTO _HDNhap = new HDNhap_DTO();
                        _HDNhap.I_MaHDN = _I_MaHDN_MAX;
                        _HDNhap.STR_MaNV = _NVDangNhap_frmQLNH.strMaNV;
                        //_HDNhap.STR_MaNV = "NV1";
                        _HDNhap.DT_NgayLap = DateTime.Now;
                        _HDNhap.DEC_TongTien = _DEC_TongTien;

                        bool _BCheck_HDN = false;
                        // Thêm vào bảng hóa đơn nhập.
                        if (HDNhap_BUS.themHDNhap_BUS(_HDNhap))
                            _BCheck_HDN = true;

                        // Thêm vào bảng chi tiết hóa đơn nhập.
                        bool _BCheck_CTHDNhap = true;
                        foreach (CTHDNhap_DTO cthn in _LST_CTHDNhap)
                        {
                            if (!CTHDNhap_BUS.themCTHDNhap_BUS(cthn))
                            {
                                _BCheck_CTHDNhap = false;
                                break;
                            }
                        }

                        // Thêm vào bảng IMEI.
                        bool _BCheck_IMEI = true;
                        foreach (IMEI_DTO imei in _LST_IMEI)
                        {
                            if (!IMEI_BUS.themIMEINhap_BUS(imei))
                            {
                                _BCheck_IMEI = false;
                                break;
                            }
                        }

                        if (_BCheck_HDN && _BCheck_CTHDNhap && _BCheck_IMEI)
                        {
                            DevExpress.XtraEditors.XtraMessageBox.Show("Lập Hóa Đơn Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            canPrintBill = true;
                        }
                        else
                            DevExpress.XtraEditors.XtraMessageBox.Show("Lập Hóa Đơn Thất Bại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                        DevExpress.XtraEditors.XtraMessageBox.Show("Một Số Sản Phẩm Chưa Có Mã IMEI", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnInHD_Click(object sender, EventArgs e)
        {
            if (!canPrintBill)
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("Phải lập hóa đơn", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                rptInHoaDonNhap rptHoaDonNhap = new rptInHoaDonNhap(_I_MaHDN_MAX);
                ReportPrintTool print = new ReportPrintTool(rptHoaDonNhap);
                print.ShowPreviewDialog();
                canPrintBill = false;
            }
        }

        private void btnXoaHD_Click(object sender, EventArgs e)
        {
            // Reset về trạng thái ban đầu.
            _LST_SPChon.Clear();
            _LST_IMEI.Clear();
            _LST_CTHDNhap.Clear();
            txtGiaNhap.Text = "";
            txtNhapMaIMEI.Text = "";
            txtSLNhap.Text = "";
            txtSLTon.Text = "";
            txtTongTien.Text = "";
            _I_MaHDN_MAX = HDNhap_BUS.layHDNhap_CaoNhat_BUS();
            txtMaHDN.Text = _I_MaHDN_MAX.ToString();
            gcDSSPNhap.DataSource = _LST_SPChon;

            _DEC_TongTien = 0;

            _LST_cmbTenSP = SanPham_BUS.loadDSSP_BUS();
            cmbTenSP.Properties.DataSource = _LST_cmbTenSP;
        }
        #endregion
        #region Xử lý SP
        private void btnThemMoiSP_Click(object sender, EventArgs e)
        {
            frmQLSP frm = new frmQLSP();
            frm.ShowDialog();
            _LST_cmbTenSP = SanPham_BUS.loadDSSP_BUS();
            cmbTenSP.Properties.DataSource = _LST_cmbTenSP;
        }

        private void btnXemCauHinhSP_Click(object sender, EventArgs e)
        {
            if (_SP_SELECT == null)
                DevExpress.XtraEditors.XtraMessageBox.Show("Bạn Chưa Chọn Sản Phẩm", "Thông Báo");
            else
            {
                frmQLCTModel frm = new frmQLCTModel();
                frm.SPHienTai = _SP_SELECT;
                frm.ShowDialog();
            }
        }

        private void btnThemSP_Click(object sender, EventArgs e)
        {
            if (_SP_SELECT == null)
                DevExpress.XtraEditors.XtraMessageBox.Show("Bạn Chưa Chọn Sản Phẩm", "Thông Báo");
            else if (txtGiaNhap.Text == "")
                DevExpress.XtraEditors.XtraMessageBox.Show("Bạn Chưa Nhập Giá", "Thông Báo");
            else
            {
                // Kiem trung san pham.
                bool _B_Check = false;
                int _I_NgvDSSPNhap = gvDSSPNhap.RowCount;
                for (int i = 0; i < _I_NgvDSSPNhap; ++i)
                {
                    if (gvDSSPNhap.GetRowCellValue(i, "strMaSP").ToString() == _SP_SELECT.strMaSP)
                    {
                        _B_Check = true;
                        break;
                    }
                }

                if (_B_Check) // Trung
                    DevExpress.XtraEditors.XtraMessageBox.Show("Sản Phẩm Đã Có Trong Danh Sách", "Thông Báo");
                else // Khong trung
                {
                    if (_LST_SPChon == null)
                        _LST_SPChon = new BindingList<SanPham_DTO>();
                    if (_LST_CTHDNhap == null)
                        _LST_CTHDNhap = new BindingList<CTHDNhap_DTO>();
                    
                    CTHDNhap_DTO _CTHDNhap = new CTHDNhap_DTO();
                    _CTHDNhap.I_MaHDN = _I_MaHDN_MAX;
                    _CTHDNhap.STR_MaSP = _SP_SELECT.strMaSP;
                    _CTHDNhap.DEC_DonGia = Convert.ToDecimal(txtGiaNhap.Text);
                    _LST_CTHDNhap.Add(_CTHDNhap);
                    
                    _LST_SPChon.Add(_SP_SELECT); // Them vao list
                    // Khi gán datasource của gridcontrol cho list, nếu xóa dữ liệu hoặc thao tác trên gridview thì list sẽ thay đổi theo.
                    gcDSSPNhap.DataSource = _LST_SPChon; // Update gridview.

                    _SP_SELECT = null; // Reset san pham.
                    txtGiaNhap.Text = "";
                    cmbTenSP.EditValue = null;
                }
            }
        }

        private void btnXoaSP_Click(object sender, EventArgs e)
        {
            if (gvDSSPNhap.RowCount > 0)
            {
                if (gvDSSPNhap.SelectedRowsCount > 0)
                {
                    DialogResult dlgHoiXoa = DevExpress.XtraEditors.XtraMessageBox.Show("Bạn Chắc Chắn Muốn Xóa", "Thông Báo", MessageBoxButtons.YesNo);
                    if (dlgHoiXoa == DialogResult.Yes)
                    {
                        _LST_CTHDNhap.RemoveAt(gvDSSPNhap.FocusedRowHandle);
                        gvDSSPNhap.DeleteSelectedRows();
                    }
                }
                else
                    DevExpress.XtraEditors.XtraMessageBox.Show("Bạn Chưa Chọn Sản Phẩm", "Thông Báo");
            }
            else
                DevExpress.XtraEditors.XtraMessageBox.Show("Danh Sách Rỗng", "Thông Báo");
        }

        private void cmbTenSP_EditValueChanged(object sender, EventArgs e)
        {
            txtGiaNhap.Text = "";
            _SP_SELECT = (SanPham_DTO)cmbTenSP.GetSelectedDataRow();
        }
        #endregion
        #region Xử lý IMEI
        private void gvDSSPNhap_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {
            if (gvDSSPNhap.SelectedRowsCount > 0)
            {
                txtSLTon.Text = gvDSSPNhap.GetRowCellValue(gvDSSPNhap.FocusedRowHandle, "iSoLuong").ToString();
                txtGiaNhap.Text = _LST_CTHDNhap[gvDSSPNhap.FocusedRowHandle].DEC_DonGia.ToString();

                string _STR_MaSP = gvDSSPNhap.GetRowCellValue(gvDSSPNhap.FocusedRowHandle, "strMaSP").ToString();
                BindingList<IMEI_DTO> _LST_IMEITemp = new BindingList<IMEI_DTO>();
                _LST_IMEITemp = _LST_IMEI;
                gcDSMaIMEI.DataSource = _LST_IMEITemp;

                int _I_CountSP = 0;
                int _I_NLST_IMEITemp = _LST_IMEITemp.Count;
                for (int i = 0; i < _I_NLST_IMEITemp; ++i)
                {
                    if (_LST_IMEITemp[i].STR_MaSP == _STR_MaSP)
                        ++_I_CountSP;
                }
                txtSLNhap.Text = _I_CountSP.ToString();
            }

            if (gvDSSPNhap.RowCount == 0)
                txtSLTon.Text = "";
        }

        private void btnSuaGiaNhap_Click(object sender, EventArgs e)
        {
            if (gvDSSPNhap.RowCount > 0)
            {
                if (gvDSSPNhap.SelectedRowsCount > 0)
                {
                    if (txtGiaNhap.Text != "")
                    {
                        int _I_nLSTCTHDNhap = _LST_CTHDNhap.Count;
                        if (_I_nLSTCTHDNhap > 0)
                        {
                            for (int i = 0; i < _I_nLSTCTHDNhap; ++i)
                            {
                                if (_LST_CTHDNhap[i].STR_MaSP == gvDSSPNhap.GetRowCellValue(gvDSSPNhap.FocusedRowHandle, "strMaSP").ToString())
                                {
                                    _LST_CTHDNhap[i].DEC_DonGia = Convert.ToDecimal(txtGiaNhap.Text);
                                    DevExpress.XtraEditors.XtraMessageBox.Show("Cập Nhật Giá Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    break;
                                }
                            }
                        }
                    }
                    else
                        DevExpress.XtraEditors.XtraMessageBox.Show("Bạn Chưa Nhập Giá!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    DevExpress.XtraEditors.XtraMessageBox.Show("Chưa Chọn Sản Phẩm!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                DevExpress.XtraEditors.XtraMessageBox.Show("Danh Sách Không Có Sản Phẩm!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnThemIMEI_Click(object sender, EventArgs e)
        {
            if (_LST_IMEI == null)
                _LST_IMEI = new BindingList<IMEI_DTO>();

            if (gvDSSPNhap.SelectedRowsCount > 0)
            {
                if (txtNhapMaIMEI.Text == "")
                    DevExpress.XtraEditors.XtraMessageBox.Show("Bạn Chưa Nhập Mã IMEI", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                {
                    bool bCheck = false;
                    foreach (IMEI_DTO IM in _LST_IMEI)
                    {
                        if (IM.STR_MaIMEI == txtNhapMaIMEI.Text)
                        {
                            bCheck = true;
                            break;
                        }
                    }

                    if (bCheck)
                    {
                        DevExpress.XtraEditors.XtraMessageBox.Show("Trùng Mã IMEI", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtNhapMaIMEI.Focus();
                    }
                    else
                    {
                        // Kiểm tra trùng mã IMEI trong dtb.
                        if (IMEI_BUS.kiemTraTrungMaIEMI_BUS(txtNhapMaIMEI.Text))
                        {
                            DevExpress.XtraEditors.XtraMessageBox.Show("Trùng Mã IMEI", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txtNhapMaIMEI.Focus();
                        }
                        else
                        {
                            IMEI_DTO _IMEI_Temp = new IMEI_DTO();
                            _IMEI_Temp.STR_MaSP = gvDSSPNhap.GetRowCellValue(gvDSSPNhap.FocusedRowHandle, "strMaSP").ToString();
                            _IMEI_Temp.STR_MaIMEI = txtNhapMaIMEI.Text;
                            _IMEI_Temp.I_MaHDN = _I_MaHDN_MAX;
                            _LST_IMEI.Add(_IMEI_Temp);

                            // Tính tổng tiền.
                            decimal _DEC_GiaNhap = 0;                            
                            foreach (CTHDNhap_DTO cthdn in _LST_CTHDNhap)
                            {
                                if (_IMEI_Temp.STR_MaSP == cthdn.STR_MaSP)
                                {
                                    _DEC_GiaNhap = cthdn.DEC_DonGia;
                                    ++cthdn.I_SoLuong;
                                }
                            }
                            _DEC_TongTien += _DEC_GiaNhap;
                            txtTongTien.Text = _DEC_TongTien.ToString();
                            // Tính tổng tiền.

                            txtNhapMaIMEI.Text = "";
                            BindingList<IMEI_DTO> _LST_IMEITemp = new BindingList<IMEI_DTO>();
                            _LST_IMEITemp = _LST_IMEI;
                            gcDSMaIMEI.DataSource = _LST_IMEITemp;
                            // Cập nhật cho text SLNhap, giá tiền nhập.
                            txtSLNhap.Text = _LST_IMEITemp.Count.ToString();
                            txtSLTon.Text = gvDSSPNhap.GetRowCellValue(gvDSSPNhap.FocusedRowHandle, "iSoLuong").ToString();
                            txtGiaNhap.Text = _LST_CTHDNhap[gvDSSPNhap.FocusedRowHandle].DEC_DonGia.ToString();
                        }                        
                    }
                }
            }
            else
                DevExpress.XtraEditors.XtraMessageBox.Show("Chọn Sản Phẩm Để Thêm Mã IMEI", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnXoaIMEI_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem danh sách có mã imei nào hay không.
            if (gvDSMaIMEI.RowCount > 0) // Nếu có => làm chạy tiếp
            {
                // Kiểm xem ng dùng có chọn phần tử trong danh sách.
                if (gvDSMaIMEI.SelectedRowsCount > 0) // Nếu có => Xóa Mã IMEI đang chọn.
                {
                    DialogResult dlgHoiXoa = DevExpress.XtraEditors.XtraMessageBox.Show("Bạn Chắc Chắn Muốn Xóa", "Thông Báo", MessageBoxButtons.YesNo);
                    if (dlgHoiXoa == DialogResult.Yes)
                    {
                        _LST_IMEI.RemoveAt(gvDSMaIMEI.FocusedRowHandle); // Xóa IMEI trên list.
                        gvDSMaIMEI.DeleteSelectedRows(); // Xóa trên gridview(giao diện).
                    }
                }
                else // Nếu không => báo lỗi.
                    DevExpress.XtraEditors.XtraMessageBox.Show("Bạn Chưa Chọn Mã IMEI Để Xóa", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else // Nếu không => báo lỗi.
                DevExpress.XtraEditors.XtraMessageBox.Show("Không Có IMEI Để Xóa", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            // Reset về trạng thái ban đầu.
            _LST_SPChon.Clear();
            _LST_IMEI.Clear();
            _LST_CTHDNhap.Clear();
            txtGiaNhap.Text = "";
            txtNhapMaIMEI.Text = "";
            txtSLNhap.Text = "";
            txtSLTon.Text = "";
            txtTongTien.Text = "";
            _I_MaHDN_MAX = HDNhap_BUS.layHDNhap_CaoNhat_BUS();
            txtMaHDN.Text = _I_MaHDN_MAX.ToString();
            gcDSSPNhap.DataSource = _LST_SPChon;

            _DEC_TongTien = 0;

            _LST_cmbTenSP = SanPham_BUS.loadDSSP_BUS();
            cmbTenSP.Properties.DataSource = _LST_cmbTenSP;
        }

        /*2 hàm có nhiệm vụ thêm cột STT*/
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
                if (!indicatorIcon)
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
        #endregion
    }
}
