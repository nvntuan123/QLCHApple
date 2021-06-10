using DevExpress.XtraEditors;
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
using DevExpress.XtraSplashScreen;

namespace QLCHApple_GUI
{
    public partial class frmHome : Form
    {
        
        public frmHome()
        {
            //Thread t = new Thread(new ThreadStart(StartForm));
            //t.Start();
            //Thread.Sleep(5000);
            //t.Abort();

            InitializeComponent();
        }
        #region Properties.
        BindingList<LoaiNhanVien_DTO> lstLoaiNV = new BindingList<LoaiNhanVien_DTO>();
        PhanQuyen_DTO _PQ_NVDangNhap = null;
        static NhanVien_DTO _NVDangNhap_frmHome = null;
        public static NhanVien_DTO NVDangNhap_frmHome
        {
            get
            {
                return _NVDangNhap_frmHome;
            }

            set
            {
                _NVDangNhap_frmHome = value;
            }
        }

        bool bTrangThaiDangNhap = false; // Mặc định là chưa đăng nhập.

        private static bool _B_TrangThaiClickXem = false;
        public static bool B_TrangThaiClickXem
        {
            get
            {
                return _B_TrangThaiClickXem;
            }

            set
            {
                _B_TrangThaiClickXem = value;
            }
        }
        #endregion
        #region Methods.
        private void setTrangThaiDangNhap(bool bTrangThai, NhanVien_DTO nv)
        {
            bTrangThaiDangNhap = bTrangThai;
            _NVDangNhap_frmHome = nv;

            if (bTrangThaiDangNhap)
            {
                Util.EndAnimate(panUser, Util.Effect.Slide, 150, 180);

                lblHienThi_Ten.Visible = true;
                lblHienThi_Ten.Text = _NVDangNhap_frmHome.strHoTen;

                if (lstLoaiNV == null)
                    lstLoaiNV = new BindingList<LoaiNhanVien_DTO>();

                lstLoaiNV = LoaiNhanVien_BUS.loadDSLoaiNhanVien_BUS();

                foreach (LoaiNhanVien_DTO lnv in lstLoaiNV)
                {
                    if (_NVDangNhap_frmHome.strMaLoaiNV == lnv.strMaLoaiNV)
                    {
                        lblHienThi_ChucVu.Text = lnv.strTenLoaiNV;
                        break;
                    }
                }

                if (panelMenu.Size.Width != 38)
                {
                    panUser.Visible = true;
                    lblHienThi_Ten.Visible = true;
                    lblHienThi_ChucVu.Visible = true;
                }
                lblDangNhap.Text = "Đăng Xuất";
                lblDangNhap.ToolTip = "Đăng Xuất";
            }
            else
            {
                Util.EndAnimate(panUser, Util.Effect.Slide, 150, 30);
                lblDangNhap.Text = "Đăng Nhập";
                lblHienThi_ChucVu.Text = "";
                lblHienThi_Ten.Text = "";
            }
        }

        public void StartForm()
        {
            Application.Run(new frmSplash());
        }
        #endregion
        #region Events
        private void frmHome_Load(object sender, EventArgs e)
        {
            this.Visible = false;
            Util.EndAnimate(this, Util.Effect.Center, 150, 180);

            timer1.Start();
            //lstLoaiNV = LoaiNhanVien_BUS.layDSLoaiNV_BUS();

            panUser.Visible = false;
            //lblHienThi_ChucVu.Visible = false;
            //lblHienThi_Ten.Visible = false;

            //tileItemModel.Visible = false;
        }

        private void lblDangNhap_Click(object sender, EventArgs e)
        {
            if (!bTrangThaiDangNhap)
            {
                frmDangNhap frm = new frmDangNhap();
                frm.dangNhap = setTrangThaiDangNhap;
                frm.ShowDialog();
            }
            else
            {
                setTrangThaiDangNhap(false, null);
            }
        }

        private void tileItemQLLoaiNV_ItemClick(object sender, TileItemEventArgs e)
        {
            if (bTrangThaiDangNhap)
            {
                frmQLLoaiNV frm = new frmQLLoaiNV();
                _PQ_NVDangNhap = PhanQuyen_BUS.loadPhanQuyen_TheoMaLoaiNVAndFrm_BUS(NVDangNhap_frmHome.strMaLoaiNV, frm.Name);

                if (_PQ_NVDangNhap.bThem == false && _PQ_NVDangNhap.bSua == false && _PQ_NVDangNhap.bXoa == false && _PQ_NVDangNhap.bXem == false)
                    XtraMessageBox.Show("Chức Năng Này Bạn Không Có Quyền", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    frm.ShowDialog();
            }
            else
            {
                XtraMessageBox.Show("Bạn Chưa Đăng Nhập, Xin Vui Lòng Đăng Nhập", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void tileItemTTNV_ItemClick(object sender, TileItemEventArgs e)
        {
            if (bTrangThaiDangNhap)
            {
                frmTTNV frm = new frmTTNV();
                frm.ShowDialog();
            }
            else
            {
                XtraMessageBox.Show("Bạn Chưa Đăng Nhập, Xin Vui Lòng Đăng Nhập", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void tileItemThongKeBaoCao_ItemClick(object sender, TileItemEventArgs e)
        {
            if (bTrangThaiDangNhap)
            {
                frmBaoCao frm = new frmBaoCao();                
                frm.ShowDialog();
            }
            else
            {
                XtraMessageBox.Show("Bạn Chưa Đăng Nhập, Xin Vui Lòng Đăng Nhập", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void tileItemQLLoaiSP_ItemClick(object sender, TileItemEventArgs e)
        {
            if (bTrangThaiDangNhap)
            {
                frmQLLoaiSP frm = new frmQLLoaiSP();
                _PQ_NVDangNhap = PhanQuyen_BUS.loadPhanQuyen_TheoMaLoaiNVAndFrm_BUS(NVDangNhap_frmHome.strMaLoaiNV, frm.Name);

                if (_PQ_NVDangNhap.bThem == false && _PQ_NVDangNhap.bSua == false && _PQ_NVDangNhap.bXoa == false && _PQ_NVDangNhap.bXem == false)
                    XtraMessageBox.Show("Chức Năng Này Bạn Không Có Quyền", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    frm.ShowDialog();
            }
            else
            {
                XtraMessageBox.Show("Bạn Chưa Đăng Nhập, Xin Vui Lòng Đăng Nhập", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void tileItemModel_ItemClick(object sender, TileItemEventArgs e)
        {
            if (bTrangThaiDangNhap)
            {
                frmQLCTModel frm = new frmQLCTModel();
                _PQ_NVDangNhap = PhanQuyen_BUS.loadPhanQuyen_TheoMaLoaiNVAndFrm_BUS(NVDangNhap_frmHome.strMaLoaiNV, frm.Name);

                if (_PQ_NVDangNhap.bThem == false && _PQ_NVDangNhap.bSua == false && _PQ_NVDangNhap.bXoa == false && _PQ_NVDangNhap.bXem == false)
                    XtraMessageBox.Show("Chức Năng Này Bạn Không Có Quyền", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    frm.ShowDialog();
            }
            else
            {
                XtraMessageBox.Show("Bạn Chưa Đăng Nhập, Xin Vui Lòng Đăng Nhập", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void tileItemQLBH_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            if (bTrangThaiDangNhap)
            {
                frmQLBH frm = new frmQLBH();
                _PQ_NVDangNhap = PhanQuyen_BUS.loadPhanQuyen_TheoMaLoaiNVAndFrm_BUS(NVDangNhap_frmHome.strMaLoaiNV, frm.Name);

                if (_PQ_NVDangNhap.bThem == false && _PQ_NVDangNhap.bSua == false && _PQ_NVDangNhap.bXoa == false && _PQ_NVDangNhap.bXem == false)
                    XtraMessageBox.Show("Chức Năng Này Bạn Không Có Quyền", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    frm.ShowDialog();
            }
            else
            {
                XtraMessageBox.Show("Bạn Chưa Đăng Nhập, Xin Vui Lòng Đăng Nhập", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void tileItemQLNH_ItemClick(object sender, TileItemEventArgs e)
        {
            if (bTrangThaiDangNhap)
            {
                frmQLNH frm = new frmQLNH();
                _PQ_NVDangNhap = PhanQuyen_BUS.loadPhanQuyen_TheoMaLoaiNVAndFrm_BUS(NVDangNhap_frmHome.strMaLoaiNV, frm.Name);

                if (_PQ_NVDangNhap.bThem == false && _PQ_NVDangNhap.bSua == false && _PQ_NVDangNhap.bXoa == false && _PQ_NVDangNhap.bXem == false)
                    XtraMessageBox.Show("Chức Năng Này Bạn Không Có Quyền", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    frm.ShowDialog();
            }
            else
            {
                XtraMessageBox.Show("Bạn Chưa Đăng Nhập, Xin Vui Lòng Đăng Nhập", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void tileItemPhanQuyen_ItemClick(object sender, TileItemEventArgs e)
        {
            if (bTrangThaiDangNhap)
            {
                frmPhanQuyen frm = new frmPhanQuyen();
                _PQ_NVDangNhap = PhanQuyen_BUS.loadPhanQuyen_TheoMaLoaiNVAndFrm_BUS(NVDangNhap_frmHome.strMaLoaiNV, frm.Name);

                if (_PQ_NVDangNhap.bFull || _PQ_NVDangNhap.bThem || _PQ_NVDangNhap.bXoa || _PQ_NVDangNhap.bSua || _PQ_NVDangNhap.bXem)
                    frm.ShowDialog();
                else
                    XtraMessageBox.Show("Chức Năng Này Bạn Không Có Quyền", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                XtraMessageBox.Show("Bạn Chưa Đăng Nhập, Xin Vui Lòng Đăng Nhập", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void tileItemQLNV_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            if (bTrangThaiDangNhap)
            {
                frmQLNV frm = new frmQLNV();
                _PQ_NVDangNhap = PhanQuyen_BUS.loadPhanQuyen_TheoMaLoaiNVAndFrm_BUS(NVDangNhap_frmHome.strMaLoaiNV, frm.Name);

                if (_PQ_NVDangNhap.bThem == false && _PQ_NVDangNhap.bSua == false && _PQ_NVDangNhap.bXoa == false && _PQ_NVDangNhap.bXem == false)
                    XtraMessageBox.Show("Chức Năng Này Bạn Không Có Quyền", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    frm.ShowDialog();
            }
            else
            {
                XtraMessageBox.Show("Bạn Chưa Đăng Nhập, Xin Vui Lòng Đăng Nhập", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void tileItemQLKH_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            if (bTrangThaiDangNhap)
            {
                frmQLKH frm = new frmQLKH();
                _PQ_NVDangNhap = PhanQuyen_BUS.loadPhanQuyen_TheoMaLoaiNVAndFrm_BUS(NVDangNhap_frmHome.strMaLoaiNV, frm.Name);

                if (_PQ_NVDangNhap.bThem == false && _PQ_NVDangNhap.bSua == false && _PQ_NVDangNhap.bXoa == false && _PQ_NVDangNhap.bXem == false)
                    XtraMessageBox.Show("Chức Năng Này Bạn Không Có Quyền", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    frm.ShowDialog();
            }
            else
            {
                XtraMessageBox.Show("Bạn Chưa Đăng Nhập, Xin Vui Lòng Đăng Nhập", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void tileItemQLLoaiKH_ItemClick(object sender, TileItemEventArgs e)
        {
            if (bTrangThaiDangNhap)
            {
                frmQLLoaiKH frm = new frmQLLoaiKH();
                _PQ_NVDangNhap = PhanQuyen_BUS.loadPhanQuyen_TheoMaLoaiNVAndFrm_BUS(NVDangNhap_frmHome.strMaLoaiNV, frm.Name);

                if (_PQ_NVDangNhap.bThem == false && _PQ_NVDangNhap.bSua == false && _PQ_NVDangNhap.bXoa == false && _PQ_NVDangNhap.bXem == false)
                    XtraMessageBox.Show("Chức Năng Này Bạn Không Có Quyền", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    frm.ShowDialog();
            }
            else
            {
                XtraMessageBox.Show("Bạn Chưa Đăng Nhập, Xin Vui Lòng Đăng Nhập", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void tileItemXemSP_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            frmQLSP frm = new frmQLSP();
            _B_TrangThaiClickXem = true;
            frm.ShowDialog();
        }

        private void tileItemQLSP_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            if (bTrangThaiDangNhap)
            {
                frmQLSP frm = new frmQLSP();
                _PQ_NVDangNhap = PhanQuyen_BUS.loadPhanQuyen_TheoMaLoaiNVAndFrm_BUS(NVDangNhap_frmHome.strMaLoaiNV, frm.Name);

                if (_PQ_NVDangNhap.bThem == false && _PQ_NVDangNhap.bSua == false && _PQ_NVDangNhap.bXoa == false && _PQ_NVDangNhap.bXem == false)
                    XtraMessageBox.Show("Chức Năng Này Bạn Không Có Quyền", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                {
                    _B_TrangThaiClickXem = false;
                    frm.ShowDialog();
                }
            }
            else
            {
                XtraMessageBox.Show("Bạn Chưa Đăng Nhập, Xin Vui Lòng Đăng Nhập", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void tileItemThongTinPhanMem_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            XtraMessageBox.Show(tileItemNgayGio.RowCount.ToString());
        }

        private void tileItemQLHDBan_ItemClick(object sender, TileItemEventArgs e)
        {
            if (bTrangThaiDangNhap)
            {
                frmQLHoaDonBan frm = new frmQLHoaDonBan();
                _PQ_NVDangNhap = PhanQuyen_BUS.loadPhanQuyen_TheoMaLoaiNVAndFrm_BUS(NVDangNhap_frmHome.strMaLoaiNV, frm.Name);

                if (_PQ_NVDangNhap.bThem == false && _PQ_NVDangNhap.bSua == false && _PQ_NVDangNhap.bXoa == false && _PQ_NVDangNhap.bXem == false)
                    XtraMessageBox.Show("Chức Năng Này Bạn Không Có Quyền", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    frm.ShowDialog();
            }
            else
            {
                XtraMessageBox.Show("Bạn Chưa Đăng Nhập, Xin Vui Lòng Đăng Nhập", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void tileItemQLHDNhap_ItemClick(object sender, TileItemEventArgs e)
        {
            if (bTrangThaiDangNhap)
            {
                frmQLHoaDonNhap frm = new frmQLHoaDonNhap();
                _PQ_NVDangNhap = PhanQuyen_BUS.loadPhanQuyen_TheoMaLoaiNVAndFrm_BUS(NVDangNhap_frmHome.strMaLoaiNV, frm.Name);

                if (_PQ_NVDangNhap.bThem == false && _PQ_NVDangNhap.bSua == false && _PQ_NVDangNhap.bXoa == false && _PQ_NVDangNhap.bXem == false)
                    XtraMessageBox.Show("Chức Năng Này Bạn Không Có Quyền", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    frm.ShowDialog();
            }
            else
            {
                XtraMessageBox.Show("Bạn Chưa Đăng Nhập, Xin Vui Lòng Đăng Nhập", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            tileItemNgayGio.Elements[0].Text = string.Format("{0:HH:mm:ss }", DateTime.Now);
            tileItemNgayGio.Elements[1].Text = string.Format("{0:MM/yyyy}", DateTime.Now);
            tileItemNgayGio.Elements[3].Text = string.Format("{0:dd}", DateTime.Now);
            tileItemNgayGio.Elements[2].Text = string.Format("{0:dddd}", DateTime.Now);
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            if (panelMenu.Size.Width == 38)
            {
                panelMenu.Size = new Size(210, 60);
                if (bTrangThaiDangNhap)
                {
                    lblHienThi_ChucVu.Visible = true;
                }
                else
                {
                    lblHienThi_ChucVu.Visible = false;
                }
            }
            else
            {
                panelMenu.Size = new Size(38, 60);
                lblHienThi_ChucVu.Visible = false;
            }
        }

        private void lblThongTin_Click(object sender, EventArgs e)
        {
            frmTTPM frm = new frmTTPM();
            frm.ShowDialog();
        }

        private void lblThoat_Click(object sender, EventArgs e)
        {
            Util.EndAnimate(this, Util.Effect.Center, 150, 180);
            Application.Exit();
        }
        #endregion
    }
}
