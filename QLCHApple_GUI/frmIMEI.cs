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
    public partial class frmIMEI : Form
    {
        public frmIMEI()
        {
            InitializeComponent();
        }

        BindingList<IMEI_DTO> _LST_DSIMEI_TheoSP = new BindingList<IMEI_DTO>();
        public int iTrangThaiFrm = 0;
        private string _STR_MaSP = "";

        public string STR_MaSP
        {
            get
            {
                return _STR_MaSP;
            }

            set
            {
                _STR_MaSP = value;
            }
        }

        private void frmSuaSN_Load(object sender, EventArgs e)
        {
            _LST_DSIMEI_TheoSP = IMEI_BUS.loadDS_MaIMEI_TheoMaSP_BUS(_STR_MaSP);
            gcDSIMEI.DataSource = _LST_DSIMEI_TheoSP;
        }

        public void setTrangThaiFrm()
        {
            if (iTrangThaiFrm == 0) // Xem
            {
                btnCapNhat.Enabled = false;
                txtNhapSN.ReadOnly = true;
                panelCapNhat.Visible = false;
                //btnCapNhat.Visible = false;
                //txtNhapSN.Visible = false;
                //labelControl1.Visible = false;
                //this.Size = new Size(343, 382);
                this.Text = "Xem Mã IEMI";
            }
            else if (iTrangThaiFrm == 1) // Thêm
            {

            }
            //else if (iTrangThaiFrm == 2) // Sửa.
            //{
            //    if (lstSN == null)
            //    {
            //        lstSN = new List<SerialNumber_DTO>();
            //    }
            //    lstSN = SerialNumber_BUS.layDSSerialNumber();
            //    gcSN.DataSource = lstSN;
            //    btnCapNhat.Enabled = true;
            //    txtNhapSN.ReadOnly = false;
            //}
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (txtNhapSN.Text == "")
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("Bạn Chưa Nhập Mã IMEI", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNhapSN.Focus();
            }
            else
            {
                if (iTrangThaiFrm == 1)
                {
                    
                }
                //else if (iTrangThaiFrm == 2)
                //{
                //    MessageBox.Show("Ahihi");
                //    bool bKq = SerialNumber_BUS.capNhatSerialNumber_BUS(txtNhapSN.Text, strMaSP, decGiaNhap);
                //    MessageBox.Show("Ahihi1");
                //    lstSN = SerialNumber_BUS.layDSSerialNumberTheoMaSP_BUS(strMaSP);
                //    MessageBox.Show("Ahih2");
                //    gcSN.DataSource = lstSN;
                //    MessageBox.Show("Ahihi3");
                //    if (bKq)
                //    {
                //        DevExpress.XtraEditors.XtraMessageBox.Show("Sửa Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //    }
                //    else
                //    {
                //        DevExpress.XtraEditors.XtraMessageBox.Show("Sửa Thất Bại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //    }
                //}
            }
        }

        void loadSNLenText()
        {
            
        }

        private void gvSN_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {
            

            loadSNLenText();
        }

        private void lblQuayLai_Click(object sender, EventArgs e)
        {
            Util.EndAnimate(this, Util.Effect.Slide, 150, 30);
            this.Close();
        }

        private void gcSN_Load(object sender, EventArgs e)
        {
            this.Visible = false;
            Util.EndAnimate(this, Util.Effect.Slide, 150, 180);
        }
    }
}
