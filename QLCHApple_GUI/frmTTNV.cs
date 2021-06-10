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
    public partial class frmTTNV : Form
    {
        public frmTTNV()
        {
            InitializeComponent();
        }


        private void frmTTNV_Load(object sender, EventArgs e)
        {
            this.Visible = false;
            Util.EndAnimate(this, Util.Effect.Slide, 150, 180);

            NhanVien_DTO nvDangNhap = frmDangNhap.nvDangNhap_ToanCuc;
            if (nvDangNhap != null)
            {
                lblMaNV.Text = nvDangNhap.strMaNV;
                lblHoTen.Text = nvDangNhap.strHoTen;
                lblGioiTinh.Text = nvDangNhap.strGioiTinh;
                lblCMND.Text = nvDangNhap.strCMND;
                lblEmail.Text = nvDangNhap.strEmail;
                lblNgaySinh.Text = nvDangNhap.dtNgaySinh.ToString("dd/MM/yyyy");
                lblSDT.Text = nvDangNhap.strSDT;
            }
        }

        private void lblQuayLai_Click(object sender, EventArgs e)
        {
            Util.EndAnimate(this, Util.Effect.Slide, 150, 30);
            this.Close();
        }
    }
}
