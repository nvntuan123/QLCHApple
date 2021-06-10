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
using DevExpress.XtraGrid.Views.Layout;
using DevExpress.XtraGrid.Views.Layout.ViewInfo;
using System.Data.SqlClient;
using DevExpress.XtraReports.UI;
using QLCHApple_GUI.Report;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid.Drawing;

namespace QLCHApple_GUI
{
    public partial class frmQLBH : Form
    {
        public frmQLBH()
        {
            InitializeComponent();
        }
        #region Khai bao bien.
        private bool indicatorIcon = true;
        private BindingList<LoaiKhachHang_DTO> _LST_LoaiKH = new BindingList<LoaiKhachHang_DTO>();
        private BindingList<KhachHang_DTO> _LST_KhachHang = new BindingList<KhachHang_DTO>();
        private BindingList<SanPham_DTO> _LST_DSSP = new BindingList<SanPham_DTO>();
        private BindingList<SanPham_DTO> _LST_DSSPBan = new BindingList<SanPham_DTO>();
        private BindingList<CTHDBan_DTO> _LST_DSCTHDB = new BindingList<CTHDBan_DTO>();
        private BindingList<IMEI_DTO> _LST_DSIMEIBan = new BindingList<IMEI_DTO>();
        private BindingList<IMEI_DTO> _LST_DSIMEI_cmbChon = new BindingList<IMEI_DTO>();

        private KhachHang_DTO _KH_Select = null;
        private int _I_MaHDBMAX = 0;
        private SanPham_DTO _SP_Select = null;
        private decimal _DEC_TongTien = 0;
        NhanVien_DTO _NVDangNhap_frmQLBH = null;
        private bool canPrintBill = false;
        #endregion
        #region Designs form
        private void lblRefresh_Click(object sender, EventArgs e)
        {
            // Reset về trạng thái ban đầu.
            _LST_DSSPBan.Clear();
            _LST_DSIMEIBan.Clear();
            _LST_DSCTHDB.Clear();
            lookUpEdit_DSIMEI.EditValue = null;
            txtTongTien.Text = "";
            txtSoLuongBan.Text = "";
            _I_MaHDBMAX = HDBan_BUS.laymacaonhat();
            txtMaHDB.Text = _I_MaHDBMAX.ToString();
            gcDSSBan.DataSource = _LST_DSSPBan;
            lookUpEdit_MaLoaiKH.EditValue = null;
            _KH_Select = null;
            lookUpEdit_TimSDTKH.EditValue = null;

            _DEC_TongTien = 0;

            _LST_DSSP = SanPham_BUS.loadDSSP_BUS();
            cmbTenSPBan.Properties.DataSource = _LST_DSSP;
        }

        private void lblQuayLai_Click(object sender, EventArgs e)
        {
            Util.EndAnimate(this, Util.Effect.Slide, 150, 30);
            this.Close();
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
        private void frmQLBH_Load(object sender, EventArgs e)
        {
            #region Design Form
            this.Visible = false;
            Util.EndAnimate(this, Util.Effect.Slide, 150, 180);
            #endregion

            #region Xử lý thông tinh load form
            // Loai khach hang
            _LST_LoaiKH = LoaiKhachHang_BUS.loadDSLoaiKhachHang_BUS();
            lookUpEdit_MaLoaiKH.Properties.DataSource = _LST_LoaiKH;
            lookUpEdit_MaLoaiKH.Properties.Columns["colLoaiKH"].FieldName = "strLoaiKH";

            // Khach hang
            _LST_KhachHang = KhachHang_BUS.loadDSKhachHang_BUS();
            lookUpEdit_TimSDTKH.Properties.DataSource = _LST_KhachHang;
            lookUpEdit_TimSDTKH.Properties.Columns["colSDT_TimSDT"].FieldName = "strSDTKH";

            lookUpEdit_MaLoaiKH.ReadOnly = true;

            //Sản phẩm
            _LST_DSSP = SanPham_BUS.loadDSSP_BUS();
            cmbTenSPBan.Properties.DataSource = _LST_DSSP;
            cmbTenSPBan.Properties.Columns["ColTenSP"].FieldName = "strTenSP";

            //Lấy mã hdb cao nhất
            _I_MaHDBMAX = HDBan_BUS.laymacaonhat();
            txtMaHDB.Text = _I_MaHDBMAX.ToString();

            _LST_DSIMEI_cmbChon = IMEI_BUS.loadDSMaIMEI_BUS();
            lookUpEdit_DSIMEI.Properties.DataSource = _LST_DSIMEI_cmbChon;
            lookUpEdit_DSIMEI.Properties.Columns["colMaIMEI"].FieldName = "STR_MaIMEI";
            lookUpEdit_DSIMEI.Properties.Columns["colMaSP"].FieldName = "STR_MaSP";

            txtMaHDB.ReadOnly = true;
            txtTongTien.ReadOnly = true;
            txtTenKH.ReadOnly = true;
            lookUpEdit_DSIMEI.Enabled = false;

            if (frmHome.NVDangNhap_frmHome != null)
                _NVDangNhap_frmQLBH = frmHome.NVDangNhap_frmHome;
            #endregion
        }
        #region Lap va in hoa don
        private void btnLapHD_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMaHDB.Text == "")
                    DevExpress.XtraEditors.XtraMessageBox.Show("Error", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else if (_LST_DSCTHDB.Count == 0)
                    DevExpress.XtraEditors.XtraMessageBox.Show("Chưa Có Sản Phẩm Để Nhập Hàng", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else if (_KH_Select == null)
                    DevExpress.XtraEditors.XtraMessageBox.Show("Chưa Chọn Khách Hàng", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                {
                    if (_LST_DSIMEIBan.Count == 0)
                        DevExpress.XtraEditors.XtraMessageBox.Show("Tất Cả Sản Phẩm Chưa Có Mã IMEI", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                    {
                        // Kiểm tra xem có sản phẩm nào không có mã IMEI hay không, nếu có => bắt lỗi. Không thì chạy tiếp.
                        bool _B_Check = false;
                        foreach (SanPham_DTO sp in _LST_DSSPBan)
                        {
                            bool _B_Check1 = false;
                            foreach (IMEI_DTO IMEI in _LST_DSIMEIBan)
                            {
                                if (IMEI.STR_MaSP == sp.strMaSP && sp.iSoLuong != 0)
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
                            // Thong tin bang HDBan.
                            HDBan_DTO _HDBan = new HDBan_DTO();
                            _HDBan.I_MaHDB = _I_MaHDBMAX;
                            _HDBan.DT_NgayBan = DateTime.Now;
                            _HDBan.STR_MaNV = _NVDangNhap_frmQLBH.strMaNV;
                            //_HDBan.STR_MaNV = "NV1";
                            _HDBan.STR_MaKH = _KH_Select.strMaKH;
                            _HDBan.DEC_TongTien = Convert.ToDecimal(txtTongTien.Text);

                            bool _BCheck_HDN = false;
                            // Thêm vào bảng hóa đơn ban.
                            if (HDBan_BUS.themHDBan_BUS(_HDBan))
                                _BCheck_HDN = true;

                            // Bang CTHDBan.
                            bool _BCheck_CTHDBan = true;
                            foreach (CTHDBan_DTO cthb in _LST_DSCTHDB)
                            {
                                if (!CTHDBan_BUS.themCTHDBan_BUS(cthb))
                                {
                                    _BCheck_CTHDBan = false;
                                    break;
                                }
                            }

                            // Bang IMEI.
                            bool _BCheck_IMEI = true;
                            foreach (IMEI_DTO imei in _LST_DSIMEIBan)
                            {
                                if (!IMEI_BUS.themIMEIBan_BUS(imei))
                                {
                                    _BCheck_IMEI = false;
                                    break;
                                }
                            }
                            
                            if (_BCheck_HDN && _BCheck_CTHDBan && _BCheck_IMEI)
                            {
                                DevExpress.XtraEditors.XtraMessageBox.Show("Lập Hóa Đơn Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                                DevExpress.XtraEditors.XtraMessageBox.Show("Lập Hóa Đơn Thất Bại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                            DevExpress.XtraEditors.XtraMessageBox.Show("Một Số Sản Phẩm Chưa Có Mã IMEI", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (SqlException ex)
            {
                DevExpress.XtraEditors.XtraMessageBox.Show(ex.Message);
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
                rtpInHoaDonBan rptHDBan = new rtpInHoaDonBan(_I_MaHDBMAX);

                ReportPrintTool print = new ReportPrintTool(rptHDBan);
                rptHDBan.ShowPreviewDialog();
            }
        }
        #endregion
        #region Xy ly thong tin khach hang
        /*Tìm kiếm khách hàng*/
        private void lookUpEdit_TimSDTKH_EditValueChanged(object sender, EventArgs e)
        {
            if (lookUpEdit_TimSDTKH.EditValue != null)
            {
                _KH_Select = (KhachHang_DTO)lookUpEdit_TimSDTKH.GetSelectedDataRow(); // Lay ra khach hang dc chon o cmb tim sdt.
                lookUpEdit_MaLoaiKH.EditValue = _KH_Select.strMaLoaiKH;
                txtTenKH.Text = _KH_Select.strHoTenKH;
            }
        }
        /*Tìm kiếm khách hàng*/

        private void btnThemMoiSP_Click(object sender, EventArgs e)
        {
            frmQLKH frm = new frmQLKH();
            frm.ShowDialog();
            _LST_KhachHang = KhachHang_BUS.loadDSKhachHang_BUS();
            lookUpEdit_TimSDTKH.Properties.DataSource = _LST_KhachHang;
        }
        #endregion
        #region Xu ly thong tin san pham ban
        private void btnThemSPBan_Click(object sender, EventArgs e)
        {
            if(_SP_Select == null)
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("Bạn Chưa Chọn Sản Phẩm", "Thông Báo");
            }
            else
            {
                if (_SP_Select.iSoLuong == 0)
                {
                    DevExpress.XtraEditors.XtraMessageBox.Show("Sản Phẩm Hết Hàng", "Thông Báo");
                }
                else
                {
                    bool _B_check = false; // Mặc định là không trùng
                    int _I_DSSPBan = gvDSSPBan.RowCount;// lấy ra bao nhiêu dòng sp
                    for (int i = 0; i < _I_DSSPBan; i++)
                    {
                        if (gvDSSPBan.GetRowCellValue(i, "strMaSP").ToString() == _SP_Select.strMaSP)
                        {
                            _B_check = true;
                            break;
                        }
                    }
                    if (_B_check)
                    {
                        DevExpress.XtraEditors.XtraMessageBox.Show("Sản Phẩm Đã Có Trong Danh Sách", "Thông Báo");
                    }
                    else
                    {
                        if (_LST_DSSPBan == null)
                        {
                            _LST_DSSPBan = new BindingList<SanPham_DTO>();
                        }
                        if (_LST_DSCTHDB == null)
                        {
                            _LST_DSCTHDB = new BindingList<CTHDBan_DTO>();
                        }

                        CTHDBan_DTO _CTHDB = new CTHDBan_DTO();
                        _CTHDB.I_MaHDB = _I_MaHDBMAX;
                        _CTHDB.STR_MaSP = _SP_Select.strMaSP;
                        _CTHDB.DEC_DonGia = _SP_Select.decGiaBan;
                        _LST_DSCTHDB.Add(_CTHDB);

                        _LST_DSSPBan.Add(_SP_Select);
                        gcDSSBan.DataSource = _LST_DSSPBan;

                        // reset.
                        cmbTenSPBan.EditValue = null;
                        _SP_Select = null;
                        //MessageBox.Show(_LST_DSSPBan.Count.ToString() + ", " + _LST_DSCTHDB.Count.ToString());
                    }
                }
            }
        }

        private void btnXemCauHinhSP_Click(object sender, EventArgs e)
        {
            if(_SP_Select == null)
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("Bạn Chưa Chọn Sản Phẩm", "Thông Báo");
            }
            else
            {
                frmQLCTModel frm = new frmQLCTModel();
                frm.SPHienTai = _SP_Select;
                frm.ShowDialog();
            }
        }

        private void cmbTenSPBan_EditValueChanged(object sender, EventArgs e)
        {
            _SP_Select = (SanPham_DTO)cmbTenSPBan.GetSelectedDataRow();
        }

        private void btnXoaSPBan_Click(object sender, EventArgs e)
        {
            if(gvDSSPBan.SelectedRowsCount>0)
            {
                _SP_Select = (SanPham_DTO)gvDSSPBan.GetRow(gvDSSPBan.FocusedRowHandle);

                //b1: Xóa trên list DSSPBan
                if(_LST_DSSPBan.Count>0)
                {
                    foreach (SanPham_DTO sp in _LST_DSSPBan)
                    {
                        if(sp.strMaSP == _SP_Select.strMaSP)
                        {
                            _LST_DSSPBan.Remove(sp);
                            break;
                        }
                    }

                } 
                //b2: Xóa tren list DSCTHDBan
                if(_LST_DSCTHDB.Count>0)
                {
                    foreach(CTHDBan_DTO ct in _LST_DSCTHDB)
                    {
                        if(ct.STR_MaSP == _SP_Select.strMaSP)
                        {
                            _LST_DSCTHDB.Remove(ct);
                            break;
                        }
                    }
                }
                //b3: Xóa tren gridview
                gvDSSPBan.DeleteSelectedRows();

                // reset sp select
                _SP_Select = null;

               // MessageBox.Show(_LST_DSSPBan.Count.ToString() + ", " + _LST_DSCTHDB.Count.ToString());
            }
            else
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("Bạn Chưa Chọn Sản Phẩm", "Thông Báo");
            }
        }

        private void gvDSSPBan_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {
            if(gvDSSPBan.SelectedRowsCount>0)
            {
                SanPham_DTO _SP_Tam = (SanPham_DTO)gvDSSPBan.GetRow(gvDSSPBan.FocusedRowHandle);
                BindingList<IMEI_DTO> _LST_IMEITam = new BindingList<IMEI_DTO>();
                _LST_IMEITam = IMEI_BUS.loadDS_MaIMEI_TheoMaSP_BUS(_SP_Tam.strMaSP);                
                if (_LST_IMEITam.Count>0)
                {
                    lookUpEdit_DSIMEI.Enabled = true;
                    lookUpEdit_DSIMEI.Properties.DataSource = _LST_IMEITam;
                    int _I_N_LST_DSCTHDB = _LST_DSCTHDB.Count;
                    for (int i = 0; i < _I_N_LST_DSCTHDB; ++i)
                    {
                        if (_SP_Tam.strMaSP == _LST_DSCTHDB[i].STR_MaSP)
                        {
                            txtSoLuongBan.Text = _LST_DSCTHDB[i].I_SoLuong.ToString();
                            break;
                        }
                    }
                }
                else if (_LST_IMEITam.Count == 0)
                {
                    lookUpEdit_DSIMEI.Enabled = false;
                }
            }
        }
        #endregion
        #region Xu ly ma IMEI ban
        private void btnChonIMEI_Click(object sender, EventArgs e)
        {
            IMEI_DTO _IMEI_Temp = (IMEI_DTO)lookUpEdit_DSIMEI.GetSelectedDataRow();
            
            if (_IMEI_Temp == null)
                DevExpress.XtraEditors.XtraMessageBox.Show("Bạn Chưa Chọn Mã IMEI.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                if (_LST_DSIMEIBan == null)
                    _LST_DSIMEIBan = new BindingList<IMEI_DTO>();

                // Kiem tra trung ma IMEI ban.
                bool _B_Check = false; // Mac dinh la khong trung
                int _I_Count_LSTDSIMEIBan = _LST_DSIMEIBan.Count;
                for (int i = 0; i < _I_Count_LSTDSIMEIBan; ++i)
                {
                    if (_IMEI_Temp.STR_MaIMEI == _LST_DSIMEIBan[i].STR_MaIMEI)
                    {
                        _B_Check = true; // Trung
                        break;
                    }
                }

                if (_B_Check)
                {
                    DevExpress.XtraEditors.XtraMessageBox.Show("Trùng Mã IMEI.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    lookUpEdit_DSIMEI.Focus();
                }
                else
                {
                    _IMEI_Temp.I_MaHDB = _I_MaHDBMAX;

                    // Tính tổng tiền.
                    decimal _DEC_GiaBan = 0;
                    foreach (CTHDBan_DTO cthdb in _LST_DSCTHDB)
                    {
                        if (_IMEI_Temp.STR_MaSP == cthdb.STR_MaSP)
                        {
                            _DEC_GiaBan = cthdb.DEC_DonGia;
                            ++cthdb.I_SoLuong;
                            // Cập nhật số lượng bán.
                            txtSoLuongBan.Text = cthdb.I_SoLuong.ToString();
                            break;
                        }
                    }
                    _DEC_TongTien += _DEC_GiaBan;
                    txtTongTien.Text = _DEC_TongTien.ToString();
                    // Tính tổng tiền.

                    _LST_DSIMEIBan.Add(_IMEI_Temp);
                    gcDSMaIMEI.DataSource = _LST_DSIMEIBan;                    

                    lookUpEdit_DSIMEI.EditValue = null;
                }
            }
        }

        private void btnXoaIMEI_Click(object sender, EventArgs e)
        {
            if (gvDSMaIMEI.RowCount > 0)
            {
                if (gvDSMaIMEI.SelectedRowsCount > 0)
                {
                    IMEI_DTO _IMEI_Selected = (IMEI_DTO)gvDSMaIMEI.GetRow(gvDSMaIMEI.FocusedRowHandle);
                    _LST_DSIMEIBan.Remove(_IMEI_Selected);
                    gcDSMaIMEI.DataSource = _LST_DSIMEIBan;
                }
                else
                    DevExpress.XtraEditors.XtraMessageBox.Show("Bạn Chưa Chọn Mã IMEI để xóa.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                DevExpress.XtraEditors.XtraMessageBox.Show("Danh Sách Rỗng.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        #endregion
    }
}
