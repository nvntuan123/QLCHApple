using QLCHApple_DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCHApple_DAO
{
    public class HDNhap_DAO
    {
        public static int layHDNhap_CaoNhat_DAO()
        {
            int _I_MaCaoNhat = 0;
            string _STR_SELECT = @"SELECT MAX(MaHDN) as MaHDNMAX
	                                    FROM dbo.tblHDNhap";
            SqlConnection conn = DataProvider_DAO.taoKetNoi();
            SqlDataReader sdr = DataProvider_DAO.truyVanDuLieu(_STR_SELECT, conn);

            if (sdr.Read())
            {
                if (!sdr.IsDBNull(0))
                    _I_MaCaoNhat = Convert.ToInt32(sdr["MaHDNMAX"]);
            }

            sdr.Close();
            conn.Close();

            return _I_MaCaoNhat;
        }

        // Thêm 1 hóa đơn nhập vào sql(bảng tblHDNhap).
        public static bool themHDNhap_DAO(HDNhap_DTO _HDNhap)
        {
            try
            {
                string strInsertKH = @"INSERT INTO dbo.tblHDNhap(MaHDN, MaNV, NgayLap, TongTien, TrangThai) VALUES(@MaHDN, @MaNV, CONVERT(datetime, @NgayLap, 103), @TongTien, 1)";
                List<SqlParameter> lstpar = new List<SqlParameter>();
                lstpar.Add(new SqlParameter("@MaHDN", _HDNhap.I_MaHDN));
                lstpar.Add(new SqlParameter("@MaNV", _HDNhap.STR_MaNV));
                lstpar.Add(new SqlParameter("@NgayLap", _HDNhap.DT_NgayLap));
                lstpar.Add(new SqlParameter("@TongTien", _HDNhap.DEC_TongTien));

                if (lstpar[0].Value == null)
                    return false;

                foreach (var parCheck in lstpar)
                {
                    if (parCheck.Value == null)
                        parCheck.Value = DBNull.Value;
                }

                SqlConnection conn = DataProvider_DAO.taoKetNoi();

                bool bKq = DataProvider_DAO.thucThiCauLenh(strInsertKH, lstpar.ToArray(), conn);

                conn.Close();

                return bKq;
            }
            catch
            {
                return false;
            }
        }

        // Lay ra danh sach hoa don nhap tu ngay A -> ngay B
        public static BindingList<HDNhap_DTO> _LST_DSHDNhap_FromToDate_DAO(DateTime _DT_FromDate, DateTime _DT_ToDate)
        {
            BindingList<HDNhap_DTO> _LST_DSHDBan = new BindingList<HDNhap_DTO>();
            string _STR_PRO = @"EXEC dbo.USP_GetHDNhapDate @FromDate, @ToDate";

            List<SqlParameter> _LST_PAR = new List<SqlParameter>();
            _LST_PAR.Add(new SqlParameter("@FromDate", _DT_FromDate));
            _LST_PAR.Add(new SqlParameter("@ToDate", _DT_ToDate));

            SqlConnection conn = DataProvider_DAO.taoKetNoi();
            SqlDataReader sdr = DataProvider_DAO.truyVanDuLieu(_STR_PRO, _LST_PAR.ToArray(), conn);

            while (sdr.Read())
            {
                HDNhap_DTO _HDNhap = new HDNhap_DTO();
                if (!sdr.IsDBNull(0))
                    _HDNhap.I_MaHDN = Convert.ToInt32(sdr["MaHDN"]);
                else
                    break;

                if (!sdr.IsDBNull(1))
                    _HDNhap.STR_MaNV = sdr["MaNV"].ToString();
                else
                    _HDNhap.STR_MaNV = "";

                if (!sdr.IsDBNull(2))
                    _HDNhap.DT_NgayLap = Convert.ToDateTime(sdr["NgayLap"]);
                else
                    break;

                if (!sdr.IsDBNull(3))
                    _HDNhap.DEC_TongTien = Convert.ToDecimal(sdr["TongTien"]);
                else
                    _HDNhap.DEC_TongTien = 0;

                if (!sdr.IsDBNull(4))
                    _HDNhap.B_TrangThai = Convert.ToBoolean(sdr["TrangThai"]);
                else
                    _HDNhap.B_TrangThai = false;
                _LST_DSHDBan.Add(_HDNhap);
            }

            sdr.Close();
            conn.Close();

            return _LST_DSHDBan;
        }
    }
}
