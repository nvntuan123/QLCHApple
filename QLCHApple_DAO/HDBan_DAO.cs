using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.ComponentModel;
using QLCHApple_DTO;

namespace QLCHApple_DAO
{
    public class HDBan_DAO
    {
        public static int Laymacaonhat_DAO()
        {
            int _imacaonhat = 0;
            string _STR_select = @"select max(MaHDB) AS MACAONHAT from tblHDBan";
            SqlConnection conn = DataProvider_DAO.taoKetNoi();
            SqlDataReader sdr = DataProvider_DAO.truyVanDuLieu(_STR_select, conn);
            if(sdr.Read())
            {
                if(!sdr.IsDBNull(0))
                {
                    _imacaonhat = Convert.ToInt32(sdr["MACAONHAT"]);
                }
            }
            conn.Close();
            return _imacaonhat;
        }

        // Thêm 1 hóa đơn bán vào sql(bảng tblHDNhap).
        public static bool themHDBan_DAO(HDBan_DTO _HDBan)
        {
            try
            {
                string strInsertKH = @"INSERT INTO dbo.tblHDBan(MaHDB, NgayBan, TongTien, MaNV, MaKH, MaKM, TrangThai) VALUES(@MaHDB, CONVERT(datetime, @NgayBan, 103), @TongTien, @MaNV, @MaKH, @MaKM, 1)";
                List<SqlParameter> lstpar = new List<SqlParameter>();
                lstpar.Add(new SqlParameter("@MaHDB", _HDBan.I_MaHDB));
                lstpar.Add(new SqlParameter("@NgayBan", _HDBan.DT_NgayBan));
                lstpar.Add(new SqlParameter("@TongTien", _HDBan.DEC_TongTien));
                lstpar.Add(new SqlParameter("@MaNV", _HDBan.STR_MaNV));
                lstpar.Add(new SqlParameter("@MaKH", _HDBan.STR_MaKH));
                lstpar.Add(new SqlParameter("@MaKM", _HDBan.I_MaKM));

                if ((int)lstpar[5].Value == 0)
                    lstpar[5].Value = DBNull.Value;

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

        // Lay ra danh sach hoa don ban tu ngay A -> ngay B
        public static BindingList<HDBan_DTO> _LST_DSHDBan_FromToDate_DAO(DateTime _DT_FromDate, DateTime _DT_ToDate)
        {
            BindingList<HDBan_DTO> _LST_DSHDBan = new BindingList<HDBan_DTO>();
            string _STR_PRO = @"EXEC dbo.USP_GetHDBanDate @FromDate, @ToDate";

            List<SqlParameter> _LST_PAR = new List<SqlParameter>();
            _LST_PAR.Add(new SqlParameter("@FromDate", _DT_FromDate));
            _LST_PAR.Add(new SqlParameter("@ToDate", _DT_ToDate));

            SqlConnection conn = DataProvider_DAO.taoKetNoi();
            SqlDataReader sdr = DataProvider_DAO.truyVanDuLieu(_STR_PRO, _LST_PAR.ToArray(), conn);

            while (sdr.Read())
            {
                HDBan_DTO _HDBan = new HDBan_DTO();
                if (!sdr.IsDBNull(0))
                    _HDBan.I_MaHDB = Convert.ToInt32(sdr["MaHDB"]);
                else
                    break;

                if (!sdr.IsDBNull(1))
                    _HDBan.DT_NgayBan = Convert.ToDateTime(sdr["NgayBan"]);
                else
                    break;

                if (!sdr.IsDBNull(2))
                    _HDBan.STR_MaNV = sdr["MaNV"].ToString();
                else
                    _HDBan.STR_MaNV = "";

                if (!sdr.IsDBNull(3))
                    _HDBan.STR_MaKH = sdr["MaKH"].ToString();
                else
                    _HDBan.STR_MaKH = "";

                if (!sdr.IsDBNull(4))
                    _HDBan.DEC_TongTien = Convert.ToDecimal(sdr["TongTien"]);
                else
                    _HDBan.DEC_TongTien = 0;

                if (!sdr.IsDBNull(5))
                    _HDBan.B_TrangThai = Convert.ToBoolean(sdr["TrangThai"]);
                else
                    _HDBan.B_TrangThai = false;
                _LST_DSHDBan.Add(_HDBan);
            }

            sdr.Close();
            conn.Close();

            return _LST_DSHDBan;
        }

        public static bool updateTrangThaiHDBan_DAO(HDBan_DTO _HDB)
        {
            try
            {
                bool _B_Check = false;
                string _STR_UPDATE = @"UPDATE tblHDBan SET TrangThai = 0 WHERE MaHDB = '" + _HDB.I_MaHDB + "'";
                SqlConnection conn = DataProvider_DAO.taoKetNoi();
                _B_Check = DataProvider_DAO.thucThiCauLenh(_STR_UPDATE, conn);

                conn.Close();
                return _B_Check;
            }
            catch
            {
                return false;
            }
        }

        public static bool updateHDBan_DAO(HDBan_DTO _HDB)
        {
            try
            {
                bool _B_Check = false;
                string _STR_UPDATE = @"UPDATE tblHDBan SET NgayBan = CONVERT(datetime, @NgayBan, 103), TongTien = @TongTien, MaNV = @MaNV, MaKH = @MaKH WHERE MaHDB = '" + _HDB.I_MaHDB + "'";
                List<SqlParameter> _LST_Par = new List<SqlParameter>();
                _LST_Par.Add(new SqlParameter("@NgayBan", _HDB.DT_NgayBan));
                _LST_Par.Add(new SqlParameter("@TongTien", _HDB.DEC_TongTien));
                _LST_Par.Add(new SqlParameter("@MaNV", _HDB.STR_MaNV));
                _LST_Par.Add(new SqlParameter("@MaKH", _HDB.STR_MaKH));
                
                SqlConnection conn = DataProvider_DAO.taoKetNoi();

                _B_Check = DataProvider_DAO.thucThiCauLenh(_STR_UPDATE, _LST_Par.ToArray(), conn);
                conn.Close();
                return _B_Check;
            }
            catch
            {
                return false;
            }
        }

        public static BindingList<HDBan_DTO> loadDSHDBan_DAO()
        {
            BindingList<HDBan_DTO> _LST_HDBan = new BindingList<HDBan_DTO>();
            try
            {
                string _STR_SELECT = @"SELECT *
	                                    FROM tblHDBan
		                                    WHERE TrangThai = 1";

                SqlConnection conn = DataProvider_DAO.taoKetNoi();
                SqlDataReader sdr = DataProvider_DAO.truyVanDuLieu(_STR_SELECT, conn);

                while (sdr.Read())
                {
                    HDBan_DTO _HDban = new HDBan_DTO();

                    if (!sdr.IsDBNull(0))
                        _HDban.I_MaHDB = Convert.ToInt32(sdr["MaHDB"]);
                    else
                        break;

                    if (!sdr.IsDBNull(1))
                        _HDban.DT_NgayBan = Convert.ToDateTime(sdr["NgayBan"]);

                    if (!sdr.IsDBNull(2))
                        _HDban.DEC_TongTien = Convert.ToDecimal(sdr["TongTien"]);

                    if (!sdr.IsDBNull(3))
                        _HDban.STR_MaNV = sdr["MaNV"].ToString();

                    if (!sdr.IsDBNull(4))
                        _HDban.STR_MaKH = sdr["MaKH"].ToString();

                    if (!sdr.IsDBNull(5))
                        _HDban.I_MaKM = Convert.ToInt32(sdr["MaKM"]);

                    if (!sdr.IsDBNull(6))
                        _HDban.B_TrangThai = Convert.ToBoolean(sdr["TrangThai"]);

                    _LST_HDBan.Add(_HDban);
                }

                sdr.Close();
                conn.Close();
                return _LST_HDBan;
            }
            catch
            {
                return _LST_HDBan;
            }
        }
    }
}
