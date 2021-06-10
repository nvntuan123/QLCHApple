using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace QLCHApple_GUI.Report
{
    public partial class rptInHoaDonNhap : DevExpress.XtraReports.UI.XtraReport
    {
        public rptInHoaDonNhap(int _I_MaHDN)
        {
            InitializeComponent();
            dtbInHoaDonNhapTableAdapter.Connection.ConnectionString = "Data Source=DESKTOP-K97AAEM;Initial Catalog=QLCHAPPLE1;Integrated Security=True";
            dtbInHoaDonNhapTableAdapter.Connection = new System.Data.SqlClient.SqlConnection(dtbInHoaDonNhapTableAdapter.Connection.ConnectionString);
            dtbInHoaDonNhapTableAdapter.Fill(inHoaDonNhap1.dtbInHoaDonNhap, _I_MaHDN);
        }

    }
}
