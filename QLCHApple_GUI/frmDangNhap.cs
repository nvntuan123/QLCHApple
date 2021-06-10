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
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }

        public delegate void DangNhap(bool bTrangThai, NhanVien_DTO nvDangNhap);
        public DangNhap dangNhap;
        public static NhanVien_DTO nvDangNhap_ToanCuc = null;

        BindingList<NhanVien_DTO> lstNV = new BindingList<NhanVien_DTO>();
        public static NhanVien_DTO nvSelected = null;

        private void frmDangNhap_Load(object sender, EventArgs e)
        {
            this.Visible = false;
            Util.EndAnimate(this, Util.Effect.Center, 150, 180);
            
            txtTaiKhoan.TabIndex = 0;
            txtPassword.TabIndex = 1;
            btnDangNhap.TabIndex = 2;
            btnThoat.TabIndex = 3;

            lblError.Visible = false;
            txtTaiKhoan.Focus();

            lstNV = NhanVien_BUS.loadDSNV_BUS();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (txtTaiKhoan.Text == string.Empty)
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("Bạn chưa nhập tài khoản", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                lblError.Location = new Point(241, 82);
                lblError.Visible = true;
                txtTaiKhoan.Focus();
            }
            else if (txtPassword.Text == string.Empty)
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("Bạn chưa nhập mật khẩu", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                lblError.Location = new Point(241, 138);
                lblError.Visible = true;
                txtPassword.Focus();
            }
            else
            {
                lblError.Visible = false;

                nvSelected = new NhanVien_DTO(); // Khởi tạo.
                bool bCheckTK = false, bCheckMK = false;

                foreach (NhanVien_DTO nv in lstNV)
                {
                    if (txtTaiKhoan.Text == nv.strSDT)
                    {
                        bCheckTK = true;
                        if (txtPassword.Text == nv.strMatKhau)
                        {
                            bCheckMK = true;
                        }
                    }

                    if (bCheckTK && bCheckMK)
                    {
                        nvSelected = nv;
                        nvDangNhap_ToanCuc = nv;
                        break;
                    }
                }

                if (bCheckTK && bCheckMK)
                {
                    if (dangNhap != null)
                    {
                        dangNhap(true, nvSelected);
                        this.Close();
                    }
                }
                else if (!bCheckTK)
                {
                    DevExpress.XtraEditors.XtraMessageBox.Show("Sai Tài Khoản!", "Thông Báo");
                    lblError.Visible = true;
                    lblError.Location = new Point(241, 82);
                    txtTaiKhoan.Focus();
                }
                else if (!bCheckMK)
                {
                    DevExpress.XtraEditors.XtraMessageBox.Show("Sai Mật Khẩu!", "Thông Báo");
                    lblError.Visible = true;
                    lblError.Location = new Point(241, 138);
                    txtPassword.Focus();
                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Util.EndAnimate(this, Util.Effect.Center, 150, 30);
            this.Close();
        }

        Point lastPoint;
        private void frmDangNhap_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void frmDangNhap_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }
    }
}
