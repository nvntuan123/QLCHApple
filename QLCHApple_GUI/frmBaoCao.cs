using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLCHApple_GUI
{
    public partial class frmBaoCao : Form
    {
        public frmBaoCao()
        {
            InitializeComponent();
        }

        private void lblQuayLai_Click(object sender, EventArgs e)
        {
            Util.EndAnimate(this, Util.Effect.Slide, 150, 30);
            this.Close();
        }

        private void checkSPTheoLoai_CheckedChanged(object sender, EventArgs e)
        {
            if (checkSPTheoLoai.Checked)
            {
                Util.EndAnimate(btnBaoCao, Util.Effect.Slide, 150, 30);
                
            }
            else
            {
                Util.EndAnimate(btnBaoCao, Util.Effect.Slide, 150, 30);
            }
        }

        private void frmBaoCao_Load(object sender, EventArgs e)
        {
            this.Visible = false;
            Util.EndAnimate(this, Util.Effect.Slide, 150, 180);
            btnBaoCao.Visible = false;
        }
    }
}
