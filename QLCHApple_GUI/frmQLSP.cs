using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using OfficeOpenXml;
using OfficeOpenXml.Style;
using QLCHApple_BUS;
using QLCHApple_DTO;

namespace QLCHApple_GUI
{
    public partial class frmQLSP : Form
    {
        public frmQLSP()
        {
            InitializeComponent();
        }
        #region Khai bao bien
        public BindingList<SanPham_DTO> lstSP = new BindingList<SanPham_DTO>(); // Sản phẩm như: tên(Iphone 6, 7, 7 plus,...), ảnh sản phẩm.
        public BindingList<LoaiSanPham_DTO> lstLoaiSP = new BindingList<LoaiSanPham_DTO>(); // Loại sản phẩm như: điện thoại, máy tính bàn(iMac), laptop(MacBook),...
        public BindingList<Model_DTO> lstModel = new BindingList<Model_DTO>(); // Model(Chip, RAM, ROM,...).
        public BindingList<IMEI_DTO> _LST_DSIMEI = new BindingList<IMEI_DTO>(); // Mã IMEI của điện thoại.

        private SanPham_DTO _SPHienTai = null; // Sản phẩm đang được chọn.
        int iTrangThaiForm = 0; // 0: là xem, 1: là thêm, 2: là sửa.

        NhanVien_DTO _NVDangNhap_frmQLSP = null;
        PhanQuyen_DTO _PQ_NVDangNhap = null;
        #endregion
        private void frmQLSP_Load(object sender, EventArgs e)
        {
            try
            {
                #region Designs form
                this.Visible = false;
                Util.EndAnimate(this, Util.Effect.Slide, 150, 180);

                this.CenterToScreen();
                #endregion

                #region Xử lý phần quyền.
                _NVDangNhap_frmQLSP = frmHome.NVDangNhap_frmHome;

                if (!frmHome.B_TrangThaiClickXem)
                {
                    if (_NVDangNhap_frmQLSP != null)
                    {
                        if (_NVDangNhap_frmQLSP.strMaLoaiNV != "")
                        {
                            BindingList<PhanQuyen_DTO> _LSTPhanQuyen_DN = new BindingList<PhanQuyen_DTO>();
                            _LSTPhanQuyen_DN = PhanQuyen_BUS.loadDSPhanQuyen_TheoMaLoaiNV(_NVDangNhap_frmQLSP.strMaLoaiNV);
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
                                    lstLoaiSP = LoaiSanPham_BUS.layDSLoaiSP_BUS();
                                    lstModel = Model_BUS.loadDSModel_BUS();

                                    cmbMaLoaiSP.Properties.NullText = "Loại Sản Phẩm";
                                    cmbMaLoaiSP.Properties.ValueMember = "strMaLoaiSP";
                                    cmbMaLoaiSP.Properties.DisplayMember = "strTenLoaiSP";
                                    cmbMaLoaiSP.Properties.DataSource = lstLoaiSP;
                                    cmbMaLoaiSP.Properties.Columns["colTenLoaiSP"].FieldName = "strTenLoaiSP";

                                    /*GridView danh sách sản phẩm*/
                                    lstSP = SanPham_BUS.loadDSSP_BUS();

                                    LookUpEdit_LoaiSP.DataSource = lstLoaiSP;
                                    LookUpEdit_LoaiSP.Columns["colMaLoaiSP"].FieldName = "strMaLoaiSP";
                                    LookUpEdit_LoaiSP.Columns["colTenLoaiSP"].FieldName = "strTenLoaiSP";

                                    gcDSSP.DataSource = lstSP;
                                    /*GridView danh sách sản phẩm*/

                                    setTrangThaiForm();
                                }
                            }
                        }
                    }
                }
                else
                {
                    btnThem.Enabled = false;
                    btnXoa.Enabled = false;
                    btnSua.Enabled = false;
                    btnLuu.Enabled = false;
                    lstLoaiSP = LoaiSanPham_BUS.layDSLoaiSP_BUS();
                    lstModel = Model_BUS.loadDSModel_BUS();

                    cmbMaLoaiSP.Properties.NullText = "Loại Sản Phẩm";
                    cmbMaLoaiSP.Properties.ValueMember = "strMaLoaiSP";
                    cmbMaLoaiSP.Properties.DisplayMember = "strTenLoaiSP";
                    cmbMaLoaiSP.Properties.DataSource = lstLoaiSP;
                    cmbMaLoaiSP.Properties.Columns["colTenLoaiSP"].FieldName = "strTenLoaiSP";

                    /*GridView danh sách sản phẩm*/
                    lstSP = SanPham_BUS.loadDSSP_BUS();

                    LookUpEdit_LoaiSP.DataSource = lstLoaiSP;
                    LookUpEdit_LoaiSP.Columns["colMaLoaiSP"].FieldName = "strMaLoaiSP";
                    LookUpEdit_LoaiSP.Columns["colTenLoaiSP"].FieldName = "strTenLoaiSP";

                    gcDSSP.DataSource = lstSP;
                    /*GridView danh sách sản phẩm*/
                }
                #endregion
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                this.Close();
            }
        }
        #region Load, lay thong tin du lieu.
        public void setTrangThaiForm()
        {
            txtMaSP.ReadOnly = true;
            txtSL.ReadOnly = true;
            switch (iTrangThaiForm)
            {
                case 0: // Xem
                    if (_SPHienTai == null)
                    {
                        btnXoa.Enabled = false;
                        btnSua.Enabled = false;
                    }
                    else
                    {
                        if (_PQ_NVDangNhap != null)
                        {
                            if (_PQ_NVDangNhap.bThem)
                                btnThem.Enabled = true;
                            else
                                btnThem.Enabled = false;

                            if (_PQ_NVDangNhap.bXoa)
                                btnXoa.Enabled = true;
                            else
                                btnXoa.Enabled = false;

                            if (_PQ_NVDangNhap.bSua)
                                btnSua.Enabled = true;
                            else
                                btnSua.Enabled = false;
                        }
                    }

                    txtTenSP.ReadOnly = true;
                    txtGiaBan.ReadOnly = true;
                    dtNamSX.ReadOnly = true;
                    cmbMaLoaiSP.ReadOnly = true;

                    btnLuu.Enabled = false;
                    break;
                case 1: // Thêm thì không thể xóa hoặc sửa thông tin sản phẩm.
                    txtTenSP.Text = string.Empty;
                    cmbMaLoaiSP.EditValue = null;
                    txtSL.Text = string.Empty;
                    txtGiaBan.Text = string.Empty;
                    dtNamSX.EditValue = null;

                    txtTenSP.ReadOnly = false;
                    cmbMaLoaiSP.ReadOnly = false;
                    txtGiaBan.ReadOnly = false;
                    dtNamSX.ReadOnly = false;

                    btnXoa.Enabled = false;
                    btnSua.Enabled = false;
                    btnLuu.Enabled = true;

                    break;
                case 2: // Sửa thì có thể thêm hoặc sửa thông tin sản phẩm
                    txtTenSP.ReadOnly = false;
                    cmbMaLoaiSP.ReadOnly = false;
                    txtGiaBan.ReadOnly = false;
                    dtNamSX.ReadOnly = false;

                    btnThem.Enabled = true;
                    btnXoa.Enabled = true;
                    btnLuu.Enabled = true;
                    break;
            }
        }

        private void loadThongTinChiTiet()
        {
            if (_SPHienTai == null)
            {
                txtMaSP.Text = string.Empty;
                txtTenSP.Text = string.Empty;
                cmbMaLoaiSP.SelectionStart = 0;
                txtSL.Text = string.Empty;
                txtGiaBan.Text = string.Empty;
                dtNamSX.DateTime = DateTime.Now;
            }
            else
            {
                txtMaSP.Text = _SPHienTai.strMaSP;
                txtTenSP.Text = _SPHienTai.strTenSP;
                cmbMaLoaiSP.EditValue = _SPHienTai.strMaLoaiSP;
                txtSL.Text = _SPHienTai.iSoLuong.ToString();
                txtGiaBan.Text = string.Format(new System.Globalization.CultureInfo("vi-VN"), "{0:#,##0.00 đ}", _SPHienTai.decGiaBan);
                dtNamSX.DateTime = _SPHienTai.dtNamSX;
            }
        }

        private void layThongTinChiTiet()
        {
            if (iTrangThaiForm == 1)
            {
                _SPHienTai = new SanPham_DTO();
            }
            _SPHienTai.strMaSP = txtMaSP.Text;
            _SPHienTai.strTenSP = txtTenSP.Text;
            _SPHienTai.strMaLoaiSP = cmbMaLoaiSP.GetColumnValue("strMaLoaiSP").ToString();
            if (txtGiaBan.Text == "")
                _SPHienTai.decGiaBan = 0;
            else
                _SPHienTai.decGiaBan = Convert.ToDecimal(txtGiaBan.Text);
            _SPHienTai.dtNamSX = dtNamSX.DateTime;
        }

        private void gvDSSP_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {
            if (gvDSSP.SelectedRowsCount > 0)
            {
                _SPHienTai = (SanPham_DTO)gvDSSP.GetRow(gvDSSP.FocusedRowHandle);
            }
            else
                _SPHienTai = null;

            loadThongTinChiTiet();
            iTrangThaiForm = 0;
            setTrangThaiForm();
        }

        private void txtGiaBan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || e.KeyChar > '9') && ((Keys)e.KeyChar != Keys.Back) && ((Keys)e.KeyChar != Keys.Enter))
            {
                e.Handled = true;
                txtGiaBan.Focus();
                DevExpress.XtraEditors.XtraMessageBox.Show("Bạn Không Được Nhập Chữ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion
        #region Xu Ly cac btn them xoa sua luu.
        private void btnThem_Click(object sender, EventArgs e)
        {
            _SPHienTai = null;
            iTrangThaiForm = 1;
            setTrangThaiForm();
            txtMaSP.Text = SanPham_BUS.layMaCaoNhatBangSP_BUS();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            iTrangThaiForm = 2;
            setTrangThaiForm();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (_SPHienTai != null)
            {
                DialogResult dlgHoiXoa = DevExpress.XtraEditors.XtraMessageBox.Show("Bạn Có Chắc Muốn Xóa Sản Phẩm Có Mã " + _SPHienTai.strMaSP, "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dlgHoiXoa == DialogResult.Yes)
                {
                    if (SanPham_BUS.kiemTraTonTaiIMEI_BUS(_SPHienTai))
                    {
                        DevExpress.XtraEditors.XtraMessageBox.Show("Không Xóa Được, Sản Phẩm Còn Tồn", "Thông Báo", DevExpress.Utils.DefaultBoolean.Default);
                    }
                    else
                    {
                        if (SanPham_BUS.capNhatTrangThaiSP_BUS(_SPHienTai))
                        {
                            lstSP = SanPham_BUS.loadDSSP_BUS();
                            gcDSSP.DataSource = lstSP;

                            if (lstSP.Count == 0)
                                _SPHienTai = null;
                            DevExpress.XtraEditors.XtraMessageBox.Show("Xóa Thành Công");
                            iTrangThaiForm = 0;
                            setTrangThaiForm();
                        }
                        else
                        {
                            DevExpress.XtraEditors.XtraMessageBox.Show("Xóa Thất Bại");
                        }
                    }
                }
            }
            else
                DevExpress.XtraEditors.XtraMessageBox.Show("Bạn Chưa Chọn Sản Phẩm, Sản Phẩm Còn Tồn", "Thông Báo", DevExpress.Utils.DefaultBoolean.Default);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtMaSP.Text == "")
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("Mã Sản Phẩm Chưa Có", "Thông Báo", DevExpress.Utils.DefaultBoolean.Default);
            }
            else if (txtTenSP.Text == "")
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("Bạn Chưa Nhập Tên Sản Phẩm", "Thông Báo", DevExpress.Utils.DefaultBoolean.Default);
                txtTenSP.Focus();
            }
            else if (cmbMaLoaiSP.ItemIndex < 0)
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("Bạn Chưa Chọn Loại Sản Phẩm", "Thông Báo", DevExpress.Utils.DefaultBoolean.Default);
                cmbMaLoaiSP.Select();
            }
            else if (dtNamSX.EditValue == null)
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("Bạn Chưa Chọn Năm Sản Xuất", "Thông Báo", DevExpress.Utils.DefaultBoolean.Default);
                dtNamSX.Focus();
            }
            else
            {
                layThongTinChiTiet();
                bool bKq1 = false;
                if (iTrangThaiForm == 1)
                    bKq1 = SanPham_BUS.themSanPham_BUS(_SPHienTai);
                else
                    bKq1 = SanPham_BUS.capNhatSanPham_BUS(_SPHienTai);

                if (bKq1)
                {
                    lstSP = SanPham_BUS.loadDSSP_BUS();
                    gcDSSP.DataSource = lstSP;
                    DevExpress.XtraEditors.XtraMessageBox.Show("Lưu Thành Công");
                    iTrangThaiForm = 0;
                    setTrangThaiForm();
                }
                else
                {
                    DevExpress.XtraEditors.XtraMessageBox.Show("Lưu thất bại");
                }
            }
        }
        #endregion
        #region Load MaIMEI va load cau hinh chi tiet theo san pham
        private void btnXemMaSN_Click(object sender, EventArgs e)
        {
            if (_SPHienTai != null)
            {
                frmIMEI frm = new frmIMEI();
                frm.STR_MaSP = _SPHienTai.strMaSP;
                frm.setTrangThaiFrm();
                frm.ShowDialog();
            }
        }

        private void btnCTSP_Click(object sender, EventArgs e)
        {
            if (_SPHienTai != null)
            {
                /* Có 2 cách mở thêm 1 form. 
                 * Cách 1: sử dụng Show() để mở. Cách này sẽ chạy những dòng lệnh phía dưới nó và có thể mở được nhiều form từ form cha và có thể thao tác được trên form cha.
                 * Cách 2: sử dụng ShowDoalog() để mở. Cách này sẽ không chạy những dòng lệnh phía dưới nó và chỉ mở được 1 form từ form cha và không thao tác được trên form cha.
                 */
                frmQLCTModel frm = new frmQLCTModel();
                frm.SPHienTai = _SPHienTai;
                frm.Show();
            }
            else
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("Bạn Chưa Chọn Sản Phẩm.");
            }    
        }
        #endregion
        #region Exit, Reset.
        private void lblRefresh_Click(object sender, EventArgs e)
        {
            lstSP = SanPham_BUS.loadDSSP_BUS();
            gcDSSP.DataSource = lstSP;
            iTrangThaiForm = 0;
            setTrangThaiForm();
        }

        private void lblQuayLai_Click(object sender, EventArgs e)
        {
            Util.EndAnimate(this, Util.Effect.Slide, 150, 30);
            this.Close();
        }
        #endregion
        #region Import, Export file Excel.
        private void btnImportExcel_Click(object sender, EventArgs e)
        {
            try
            {
                var _DLG_OpenExcel = new OpenFileDialog();
                _DLG_OpenExcel.Title = @"Import File Excel";
                //_DLG_OpenExcel.FileName =
                _DLG_OpenExcel.Filter = @"Microsoft Excel|*.xlsx";
                if (_DLG_OpenExcel.ShowDialog() == DialogResult.OK)
                {
                    //MessageBox.Show(Path.GetExtension(_DLG_OpenExcel.FileName)); // Lấy ra đuôi file. VD: abc.png => lấy ra tên đuôi file là .png
                    //MessageBox.Show(Path.GetFileName(_DLG_OpenExcel.FileName)); // Lấy ra tền file + đuôi file VD: abc.png => lấy hết là abc.png
                    //MessageBox.Show(Path.GetFileNameWithoutExtension(_DLG_OpenExcel.FileName)); // Lấy ra tên file k bao gồm đuôi file VD: abc.png => lấy phần abc.
                    string _STR_FileName = Path.GetFileName(_DLG_OpenExcel.FileName);
                    // Mở file excel
                    var package = new ExcelPackage(new FileInfo(_DLG_OpenExcel.FileName));

                    // Lấy ra sheet đầu tiên để thao tác.
                    ExcelWorksheet workSheet = package.Workbook.Worksheets[1];

                    BindingList<SanPham_DTO> _LST_DSSP_ImportExcel = new BindingList<SanPham_DTO>();
                    #region
                    // Duyệt tuần tự từ dòng thứ 2 đến dòng cuối cùng của file Excel.Vì Excel bắt đầu từ số 1 không phải số 0.
                    for (int i = workSheet.Dimension.Start.Row + 1; i < workSheet.Dimension.End.Row; ++i)
                    {
                        try
                        {
                            int j = 1; // Biến j như là cột.

                            string _STR_MaSP = "";
                            string _STR_TenSP = "";
                            DateTime _DT_NamSX = new DateTime();
                            string _STR_MaLoaiSP = "";
                            decimal _DEC_GiaBan = 0;

                            if (workSheet.Cells[i, j].Value == null || workSheet.Cells[i, (j + 1)].Value == null) // Kiem tra ma rong
                                continue;

                            // Kiem tra trung ma sp.
                            bool _B_CheckMaSP = false;
                            foreach (SanPham_DTO sp in lstSP)
                            {
                                if (sp.strMaSP == workSheet.Cells[i, j].Value.ToString())
                                {
                                    _B_CheckMaSP = true;
                                    break;
                                }
                            }

                            if (_B_CheckMaSP)
                                continue;

                            _STR_MaSP = workSheet.Cells[i, j++].Value.ToString();
                            _STR_TenSP = workSheet.Cells[i, j++].Value.ToString();

                            var _VAR_NamSX = workSheet.Cells[i, j++].Value;
                            if (_VAR_NamSX != null)
                                _DT_NamSX = (DateTime)_VAR_NamSX;

                            if (workSheet.Cells[i, j].Value != null)
                                _STR_MaLoaiSP = workSheet.Cells[i, j++].Value.ToString();
                            else
                                j++;

                            string _STR_GiaBan = "";
                            if (workSheet.Cells[i, j].Value != null)
                                _STR_GiaBan = workSheet.Cells[i, j++].Value.ToString();

                            bool _B_Check = false;
                            if (_STR_GiaBan != "")
                            {
                                foreach (char c in _STR_GiaBan.ToCharArray())
                                {
                                    if (c < '0' || c > '9')
                                    {
                                        _B_Check = true;
                                        break;
                                    }
                                }
                            }

                            if (!_B_Check && _STR_GiaBan != "")
                                _DEC_GiaBan = decimal.Parse(_STR_GiaBan);

                            //MessageBox.Show(_STR_MaSP);
                            //MessageBox.Show(_STR_TenSP);
                            //MessageBox.Show(_DT_NamSX.ToString());
                            //MessageBox.Show(_STR_MaLoaiSP);
                            //MessageBox.Show(_DEC_GiaBan.ToString());
                            SanPham_DTO _SP_ExcelAdd = new SanPham_DTO()
                            {
                                strMaSP = _STR_MaSP,
                                strTenSP = _STR_TenSP,
                                dtNamSX = _DT_NamSX,
                                strMaLoaiSP = _STR_MaLoaiSP,
                                decGiaBan = _DEC_GiaBan
                            };

                            //Add vao list.
                            lstSP.Add(_SP_ExcelAdd);

                            _LST_DSSP_ImportExcel.Add(_SP_ExcelAdd);
                        }
                        catch (Exception ex)
                        {
                            DevExpress.XtraEditors.XtraMessageBox.Show("Error" + ex, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    #endregion
                    if (_LST_DSSP_ImportExcel.Count > 0)
                    {
                        foreach (SanPham_DTO sp in _LST_DSSP_ImportExcel)
                        {
                            SanPham_BUS.themSanPham_BUS(sp);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("Error" + ex, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExportExcel_Click(object sender, EventArgs e)
        {
            try
            {
                if (gvDSSP.RowCount > 0)
                {
                    SaveFileDialog dialog = new SaveFileDialog();
                    dialog.Title = "Export File Excel";
                    dialog.FileName = "";
                    dialog.Filter = @"Micrsoft Excel|*.xlsx";

                    if (dialog.ShowDialog() == DialogResult.OK)
                    {
                        gvDSSP.ColumnPanelRowHeight = 40; // Chinh do cao cua row.
                        gvDSSP.OptionsPrint.AutoWidth = AutoSize;
                        gvDSSP.OptionsPrint.ShowPrintExportProgress = true;
                        gvDSSP.OptionsPrint.AllowCancelPrintExport = true;
                        DevExpress.XtraPrinting.XlsxExportOptions options = new DevExpress.XtraPrinting.XlsxExportOptions();
                        options.TextExportMode = DevExpress.XtraPrinting.TextExportMode.Text;
                        options.ExportMode = DevExpress.XtraPrinting.XlsxExportMode.SingleFile;
                        options.SheetName = "DSSP";
                        DevExpress.Export.ExportSettings.DefaultExportType = DevExpress.Export.ExportType.Default;
                        gvDSSP.ExportToXlsx(dialog.FileName, options);

                        if (File.Exists(dialog.FileName))
                        {
                            if (DevExpress.XtraEditors.XtraMessageBox.Show("Mở File Excel Vừa Tạo ?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            {
                                System.Diagnostics.Process.Start(dialog.FileName);
                            }
                        }
                    }
                }
            }
            catch
            {

            }
        }
        #endregion

        Point lastPoint;
        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void panel3_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }
    }
}
