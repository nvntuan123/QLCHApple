using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLCHApple_DTO;
using System.Data.SqlClient;
using System.ComponentModel;

namespace QLCHApple_DAO
{
    public class IMEI_DAO
    {
        public static bool themIMEINhap_DAO(IMEI_DTO _IMEI)
        {
            try
            {
                string strInsertKH = @"INSERT INTO dbo.tblIMEI(MaIMEI, MaSP, MaHDN, MaHDB) VALUES(@MaIMEI, @MaSP, @MaHDN, @MaHDB)";
                List<SqlParameter> lstpar = new List<SqlParameter>();
                lstpar.Add(new SqlParameter("@MaIMEI", _IMEI.STR_MaIMEI));
                lstpar.Add(new SqlParameter("@MaSP", _IMEI.STR_MaSP));
                lstpar.Add(new SqlParameter("@MaHDN", _IMEI.I_MaHDN));
                lstpar.Add(new SqlParameter("@MaHDB", _IMEI.I_MaHDB));

                if ((int)lstpar[2].Value == 0)
                    lstpar[2].Value = null;

                if ((int)lstpar[3].Value == 0)
                    lstpar[3].Value = null;

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

        public static bool themIMEIBan_DAO(IMEI_DTO _IMEI)
        {
            try
            {
                string strUpdateModel = @"UPDATE tblIMEI SET MaHDB = @MaHDB WHERE MaIMEI = '" + _IMEI.STR_MaIMEI + "'";
                List<SqlParameter> lstpar = new List<SqlParameter>();
                lstpar.Add(new SqlParameter("@MaHDB", _IMEI.I_MaHDB));

                foreach (var parCheck in lstpar)
                {
                    if (parCheck.Value == null)
                        parCheck.Value = DBNull.Value;
                }

                SqlConnection conn = DataProvider_DAO.taoKetNoi();
                bool bKq = DataProvider_DAO.thucThiCauLenh(strUpdateModel, lstpar.ToArray(), conn);
                conn.Close();

                return bKq;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static bool kiemTraTrungMaIMEI_DAO(string _STR_MaIMEI)
        {
            string _STR_SELECT = @"SELECT *
	                                FROM dbo.tblIMEI
		                                WHERE MaIMEI = '" + _STR_MaIMEI + "'";
            SqlConnection conn = DataProvider_DAO.taoKetNoi();
            SqlDataReader sdr = DataProvider_DAO.truyVanDuLieu(_STR_SELECT, conn);

            bool _BCheck = false;

            if (sdr.Read())
            {
                if (!sdr.IsDBNull(0))
                    _BCheck = true;
            }

            sdr.Close();
            conn.Close();

            return _BCheck;
        }

        public static BindingList<IMEI_DTO> loadDS_MaIMEI_TheoMaSP_DAO(string _STR_MaSP)
        {
            BindingList<IMEI_DTO> _LST_MaIMEI = new BindingList<IMEI_DTO>();

            string _STR_SELECT = @"SELECT *
	                                    FROM tblIMEI
		                                    WHERE MaSP = '" + _STR_MaSP + "' AND MaHDB IS NULL";
            SqlConnection conn = DataProvider_DAO.taoKetNoi();
            SqlDataReader sdr = DataProvider_DAO.truyVanDuLieu(_STR_SELECT, conn);

            while (sdr.Read())
            {
                IMEI_DTO _IMEI = new IMEI_DTO();
                if (!sdr.IsDBNull(0))
                    _IMEI.STR_MaIMEI = sdr["MaIMEI"].ToString();
                else
                    _IMEI.STR_MaIMEI = "";

                if (!sdr.IsDBNull(1))
                    _IMEI.STR_MaSP = sdr["MaSP"].ToString();
                else
                    _IMEI.STR_MaSP = "";

                if (!sdr.IsDBNull(2))
                    _IMEI.I_MaHDN = Convert.ToInt32(sdr["MaHDN"]);
                else
                    _IMEI.I_MaHDN = 0;

                if (!sdr.IsDBNull(3))
                    _IMEI.I_MaHDB = Convert.ToInt32(sdr["MaHDB"]);
                else
                    _IMEI.I_MaHDB = 0;
                _LST_MaIMEI.Add(_IMEI);
            }

            sdr.Close();
            conn.Close();
            return _LST_MaIMEI;
        }

        public static int demSoLuongTonKhoTheoSP_DAO(string _STR_MaSP)
        {
            int _I_SoLuongTon = 0;
            string _STR_SELECT = @"SELECT COUNT(tblIMEI.MaIMEI) AS SoLuongTon
	                                    FROM tblIMEI
		                                    WHERE tblIMEI.MaHDB IS NULL AND tblIMEI.MaSP = '" + _STR_MaSP + "'";
            SqlConnection conn = DataProvider_DAO.taoKetNoi();
            SqlDataReader sdr = DataProvider_DAO.truyVanDuLieu(_STR_SELECT, conn);

            if (sdr.Read())
            {
                if (!sdr.IsDBNull(0))
                    _I_SoLuongTon = Convert.ToInt32(sdr["SoLuongTon"]);
            }

            sdr.Close();
            conn.Close();
            return _I_SoLuongTon;
        }

        public static BindingList<IMEI_DTO> loadDSMaIMEI_DAO()
        {
            BindingList<IMEI_DTO> _LST_MaIMEI = new BindingList<IMEI_DTO>();

            string _STR_SELECT = @"SELECT *
	                                    FROM tblIMEI
		                                    WHERE MaHDB IS NULL";
            try
            {
                SqlConnection conn = DataProvider_DAO.taoKetNoi();
                SqlDataReader sdr = DataProvider_DAO.truyVanDuLieu(_STR_SELECT, conn);

                while (sdr.Read())
                {
                    IMEI_DTO im = new IMEI_DTO();
                    if (!sdr.IsDBNull(0))
                        im.STR_MaIMEI = sdr["MaIMEI"].ToString();
                    else
                        im.STR_MaIMEI = "";

                    if (!sdr.IsDBNull(1))
                        im.STR_MaSP = sdr["MaSP"].ToString();
                    else
                        im.STR_MaSP = "";

                    if (!sdr.IsDBNull(2))
                        im.I_MaHDN = Convert.ToInt32(sdr["MaHDN"]);
                    else
                        im.I_MaHDN = 0;

                    if (!sdr.IsDBNull(3))
                        im.I_MaHDB = Convert.ToInt32(sdr["MaHDB"]);
                    else
                        im.I_MaHDB = 0;
                    _LST_MaIMEI.Add(im);
                }

                sdr.Close();
                conn.Close();

                return _LST_MaIMEI;
            }
            catch
            {
                return _LST_MaIMEI;
            }
        }

        public static bool updateMaHDBinIMEI_DAO(int _I_MaHDB)
        {
            try
            {
                bool _B_Check = false;
                string _STR_UPDATE = @"UPDATE tblIMEI SET MaHDB = NULL WHERE tblIMEI.MaHDB = '" + _I_MaHDB + "'";

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

        public static BindingList<IMEI_DTO> loadDSIMEIThaoHDB_DAO(string _STR_MaSP, int _I_MaHDB)
        {
            BindingList<IMEI_DTO> _LST_DSIMEI = new BindingList<IMEI_DTO>();
            try
            {
                string _STR_SELECT = @"SELECT DISTINCT im.MaIMEI, im.MaSP, im.MaHDN, im.MaHDB
	                                        FROM tblIMEI im, tblSanPham sp, tblHDBan hdb
		                                        WHERE hdb.MaHDB = im.MaHDB AND sp.MaSP = im.MaSP AND hdb.MaHDB = '" + _I_MaHDB + "' AND sp.MaSP = '" + _STR_MaSP + "'";

                SqlConnection conn = DataProvider_DAO.taoKetNoi();
                SqlDataReader sdr = DataProvider_DAO.truyVanDuLieu(_STR_SELECT, conn);

                while (sdr.Read())
                {
                    IMEI_DTO _IMEI = new IMEI_DTO();

                    if (!sdr.IsDBNull(0))
                        _IMEI.STR_MaIMEI = sdr["MaIMEI"].ToString();

                    if (!sdr.IsDBNull(1))
                        _IMEI.STR_MaSP = sdr["MaSP"].ToString();

                    if (!sdr.IsDBNull(2))
                        _IMEI.I_MaHDN = Convert.ToInt32(sdr["MaHDN"]);

                    if (!sdr.IsDBNull(3))
                        _IMEI.I_MaHDB = Convert.ToInt32(sdr["MaHDB"]);

                    _LST_DSIMEI.Add(_IMEI);
                }

                sdr.Close();
                conn.Close();
                return _LST_DSIMEI;
            }
            catch
            {
                return _LST_DSIMEI;
            }
        }
    }
}
