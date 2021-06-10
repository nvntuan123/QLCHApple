using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace QLCHApple_GUI.Report
{
    public partial class rtpInHoaDonBan : DevExpress.XtraReports.UI.XtraReport
    {
        public rtpInHoaDonBan(int _I_MaHDBan)
        {
            InitializeComponent();
            dtbInHoaDonBanTableAdapter.Connection.ConnectionString = "Data Source=DESKTOP-K97AAEM;Initial Catalog=QLCHAPPLE1;Integrated Security=True";
            dtbInHoaDonBanTableAdapter.Connection = new System.Data.SqlClient.SqlConnection(dtbInHoaDonBanTableAdapter.Connection.ConnectionString);
            dtbInHoaDonBanTableAdapter.Fill(this.inHoaDonBan1.dtbInHoaDonBan, _I_MaHDBan);
        }
    }
}
