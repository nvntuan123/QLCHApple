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
    public partial class frmPhanQuyen : Form
    {
        #region Khai Bao Bien
        private bool indicatorIcon = true;
        private BindingList<Frm_DTO> _LSTFrm = new BindingList<Frm_DTO>();
        private BindingList<PhanQuyen_DTO> _LSTPhanQuyen = new BindingList<PhanQuyen_DTO>();
        private BindingList<LoaiNhanVien_DTO> _LSTLoaiNV = new BindingList<LoaiNhanVien_DTO>();
        private NhanVien_DTO _NVDangNhap_frmPhanQuyen = null;
        #endregion
        public frmPhanQuyen()
        {
            InitializeComponent();
        }
        #region Xy Ly Du Lieu Form
        private void frmPhanQuyen_Load(object sender, EventArgs e)
        {
            this.Visible = false;
            Util.EndAnimate(this, Util.Effect.Slide, 150, 180);
            // Xet phan quyen.
            _NVDangNhap_frmPhanQuyen = frmHome.NVDangNhap_frmHome;

            if (_NVDangNhap_frmPhanQuyen != null)
            {
                // Kiểm tra xem có quyền sửa hay k.
                // Nếu không thì không cho thao tác.
                // Nếu có thì ngược lại.
                if (_NVDangNhap_frmPhanQuyen.strMaLoaiNV != "")
                {
                    BindingList<PhanQuyen_DTO> _LSTPhanQuyen_DN = new BindingList<PhanQuyen_DTO>();
                    _LSTPhanQuyen_DN = PhanQuyen_BUS.loadDSPhanQuyen_TheoMaLoaiNV(_NVDangNhap_frmPhanQuyen.strMaLoaiNV);
                    if (_LSTPhanQuyen_DN != null)
                    {
                        _LSTFrm = Frm_BUS.loadDSFrm_BUS();
                        repositoryItemLookUpEdit_Frm.DataSource = _LSTFrm;
                        repositoryItemLookUpEdit_Frm.Columns["colMaFrm"].FieldName = "strMaFrm";
                        repositoryItemLookUpEdit_Frm.Columns["colTenFrm"].FieldName = "strTenFrm";

                        _LSTLoaiNV = LoaiNhanVien_BUS.loadDSLoaiNhanVien_BUS();
                        // Loại bỏ tài khoản là admin hệ thống và tài khoản đăng nhập.
                        int _I_Dem = 0; // Đếm số lần loại bỏ nhân viên.
                        int _I_NLSTLoaiNV = _LSTLoaiNV.Count;
                        //MessageBox.Show(_LSTLoaiNV.Count.ToString());
                        for (int i = 0; i < _I_NLSTLoaiNV; ++i)
                        {
                            if (_LSTLoaiNV[i].strMaLoaiNV == "LNV1" || _LSTLoaiNV[i].strMaLoaiNV == _NVDangNhap_frmPhanQuyen.strMaLoaiNV)
                            {
                                if (_I_Dem == 2)
                                    break;
                                else
                                {
                                    _LSTLoaiNV.RemoveAt(i);
                                    ++_I_Dem;
                                    --_I_NLSTLoaiNV;
                                    --i;
                                }
                            }
                        }
                        // Loại bỏ tài khoản là admin hệ thống và tài khoản đăng nhập.

                        cmbLoaiNV.Properties.NullText = "Loại Nhân Viên";
                        cmbLoaiNV.Properties.ValueMember = "strMaLoaiNV";
                        cmbLoaiNV.Properties.DisplayMember = "strTenLoaiNV";
                        cmbLoaiNV.Properties.DataSource = _LSTLoaiNV;
                        cmbLoaiNV.Properties.Columns["colMaLoaiNV"].FieldName = "strMaLoaiNV";
                        cmbLoaiNV.Properties.Columns["colTenLoaiNV"].FieldName = "strTenLoaiNV";
                    }
                }
            }
        }    

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (cmbLoaiNV.EditValue != null)
            {
                BindingList<PhanQuyen_DTO> _LST_DSPhanQuyen = new BindingList<PhanQuyen_DTO>();
                int iN_PhanQuyen = gvPhanQuyen.RowCount;
                for (int i = 0; i < iN_PhanQuyen; ++i)
                {
                    PhanQuyen_DTO _PQ = new PhanQuyen_DTO();
                    _PQ.strMaLoaiNV = gvPhanQuyen.GetRowCellValue(i, "strMaLoaiNV").ToString();
                    _PQ.strMaFrm = gvPhanQuyen.GetRowCellValue(i, "strMaFrm").ToString();

                    _PQ.bThem = (bool)gvPhanQuyen.GetRowCellValue(i, "bThem");
                    _PQ.bXoa = (bool)gvPhanQuyen.GetRowCellValue(i, "bXoa");
                    _PQ.bSua = (bool)gvPhanQuyen.GetRowCellValue(i, "bSua");
                    _PQ.bXem = (bool)gvPhanQuyen.GetRowCellValue(i, "bXem");
                    if (_PQ.bThem && _PQ.bXoa && _PQ.bSua && _PQ.bXem)
                        _PQ.bFull = true;

                    _LST_DSPhanQuyen.Add(_PQ);
                }

                if (PhanQuyen_BUS.suaNhieuPhanQuyen_BUS(_LST_DSPhanQuyen))
                {
                    DevExpress.XtraEditors.XtraMessageBox.Show("Lưu Thành Công");
                }
                else
                {
                    DevExpress.XtraEditors.XtraMessageBox.Show("Bạn Chưa Chọn Loại Nhân Viên", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cmbLoaiNV.Focus();
                }
            }
            else
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("Bạn Chưa Chọn Loại Nhân Viên");
            }
        }

        private void chkFull_Them_gvPQ_CheckedChanged(object sender, EventArgs e)
        {
            //if (chkFull_Them_gvPQ.Checked)
            //{
            //    int _IN_gvPhanQuyen = gvPhanQuyen.RowCount;
            //    for (int _i = 0; _i < _IN_gvPhanQuyen; ++_i)
            //    {
            //        gvPhanQuyen.SetRowCellValue(_i, "bThem", true);
            //    }
            //}
            //else
            //{
            //    int _IN_gvPhanQuyen = gvPhanQuyen.RowCount;
            //    for (int _i = 0; _i < _IN_gvPhanQuyen; ++_i)
            //    {
            //        
            //        gvPhanQuyen.SetRowCellValue(_i, "bThem", false);
            //    }
            //}
        }

        private void chkFull_Xoa_gvPQ_CheckedChanged(object sender, EventArgs e)
        {
            //if (chkFull_Xoa_gvPQ.Checked)
            //{
            //    int _IN_gvPhanQuyen = gvPhanQuyen.RowCount;
            //    for (int _i = 0; _i < _IN_gvPhanQuyen; ++_i)
            //    {
            //        gvPhanQuyen.SetRowCellValue(_i, "bXoa", true);
            //    }
            //}
            //else
            //{
            //    int _IN_gvPhanQuyen = gvPhanQuyen.RowCount;
            //    for (int _i = 0; _i < _IN_gvPhanQuyen; ++_i)
            //    {
            //        gvPhanQuyen.SetRowCellValue(_i, "bXoa", false);
            //    }
            //}
        }

        private void chkFull_Sua_gvPQ_CheckedChanged(object sender, EventArgs e)
        {
            //if (chkFull_Sua_gvPQ.Checked)
            //{
            //    int _IN_gvPhanQuyen = gvPhanQuyen.RowCount;
            //    for (int _i = 0; _i < _IN_gvPhanQuyen; ++_i)
            //    {
            //        gvPhanQuyen.SetRowCellValue(_i, "bSua", true);
            //    }
            //}
            //else
            //{
            //    int _IN_gvPhanQuyen = gvPhanQuyen.RowCount;
            //    for (int _i = 0; _i < _IN_gvPhanQuyen; ++_i)
            //    {
            //        gvPhanQuyen.SetRowCellValue(_i, "bSua", false);
            //    }
            //}
        }

        private void chkFull_Xem_gvPQ_CheckedChanged(object sender, EventArgs e)
        {
            //if (chkFull_Xem_gvPQ.Checked)
            //{
            //    int _IN_gvPhanQuyen = gvPhanQuyen.RowCount;
            //    for (int _i = 0; _i < _IN_gvPhanQuyen; ++_i)
            //    {
            //        gvPhanQuyen.SetRowCellValue(_i, "bXem", true);
            //    }
            //}
            //else
            //{
            //    int _IN_gvPhanQuyen = gvPhanQuyen.RowCount;
            //    for (int _i = 0; _i < _IN_gvPhanQuyen; ++_i)
            //    {
            //        gvPhanQuyen.SetRowCellValue(_i, "bXem", false);
            //    }
            //}
        }

        private void cmbLoaiNV_EditValueChanged(object sender, EventArgs e)
        {
            if (cmbLoaiNV.EditValue != null)
            {
                string _STR_MaLoaiNV = cmbLoaiNV.EditValue.ToString();
                if (_STR_MaLoaiNV == _NVDangNhap_frmPhanQuyen.strMaLoaiNV)
                {
                    DevExpress.XtraEditors.XtraMessageBox.Show("Bạn Không Cần Phân Quyền Cho Chính Mình", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cmbLoaiNV.EditValue = null;
                }
                else
                {
                    _LSTPhanQuyen = PhanQuyen_BUS.loadDSPhanQuyen_TheoMaLoaiNV(cmbLoaiNV.EditValue.ToString());

                    if (_LSTPhanQuyen != null && _NVDangNhap_frmPhanQuyen != null)
                    {
                        if (_NVDangNhap_frmPhanQuyen != null)
                        {
                            gcPhanQuyen.DataSource = _LSTPhanQuyen;

                            bool _BThem = true;
                            bool _BXoa = true;
                            bool _BSua = true;
                            bool _BXem = true;
                            int _IN_gvPhanQuyen = gvPhanQuyen.RowCount;
                            for (int _i = 0; _i < _IN_gvPhanQuyen; ++_i)
                            {
                                if ((bool)gvPhanQuyen.GetRowCellValue(_i, "bThem") == false)
                                {
                                    _BThem = false;
                                }

                                if ((bool)gvPhanQuyen.GetRowCellValue(_i, "bXoa") == false)
                                {
                                    _BXoa = false;
                                }

                                if ((bool)gvPhanQuyen.GetRowCellValue(_i, "bSua") == false)
                                {
                                    _BSua = false;
                                }

                                if ((bool)gvPhanQuyen.GetRowCellValue(_i, "bXem") == false)
                                {
                                    _BXem = false;
                                }
                            }

                            chkFull_Them_gvPQ.Checked = _BThem;
                            chkFull_Xoa_gvPQ.Checked = _BXoa;
                            chkFull_Sua_gvPQ.Checked = _BSua;
                            chkFull_Xem_gvPQ.Checked = _BXem;
                        }
                    }
                    else
                    {
                        DevExpress.XtraEditors.XtraMessageBox.Show("Error", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void chkFull_Them_gvPQ_EditValueChanged(object sender, EventArgs e)
        {
            
        }
        #endregion
        #region Design
        /*2 hàm có nhiệm vụ thêm cột STT*/
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

        private void gvPhanQuyen_RowCountChanged(object sender, EventArgs e)
        {
            GridView gridview = ((GridView)sender);
            if (!gridview.GridControl.IsHandleCreated) return;
            Graphics gr = Graphics.FromHwnd(gridview.GridControl.Handle);
            SizeF size = gr.MeasureString(gridview.RowCount.ToString(), gridview.PaintAppearance.Row.GetFont());
            gridview.IndicatorWidth = Convert.ToInt32(size.Width + 0.999f) + GridPainter.Indicator.ImageSize.Width + 20;
        }
        /*2 hàm có nhiệm vụ thêm cột STT*/

        private void lblQuayLai_Click(object sender, EventArgs e)
        {
            Util.EndAnimate(this, Util.Effect.Slide, 150, 30);
            this.Close();
        }
#endregion
    }
}
