using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Data.SqlClient;
using QLCHApple_DTO;

namespace QLCHApple_DAO
{
    public class LoaiNhanVien_DAO
    {
        // Lấy dữ liệu bảng loại nhân viên.
        public static BindingList<LoaiNhanVien_DTO> loadDSLoaiNhanVien_DAO()
        {
            try
            {
                BindingList<LoaiNhanVien_DTO> lstLNV = new BindingList<LoaiNhanVien_DTO>();
                string strSelect = @"SELECT *
	                                    FROM dbo.tblLoaiNhanVien
		                                    WHERE dbo.tblLoaiNhanVien.TrangThai = 1";

                SqlConnection conn = DataProvider_DAO.taoKetNoi();
                SqlDataReader sdr = DataProvider_DAO.truyVanDuLieu(strSelect, conn);

                while (sdr.Read())
                {
                    LoaiNhanVien_DTO lnv = new LoaiNhanVien_DTO();

                    if (!sdr.IsDBNull(0))
                        lnv.strMaLoaiNV = sdr["MaLoaiNV"].ToString();
                    else
                        lnv.strMaLoaiNV = "";

                    if (!sdr.IsDBNull(1))
                        lnv.strTenLoaiNV = sdr["LoaiNV"].ToString();
                    else
                        lnv.strTenLoaiNV = "";

                    if (!sdr.IsDBNull(2))
                        lnv.bTrangThai = Convert.ToBoolean(sdr["TrangThai"]);
                    else
                        lnv.bTrangThai = false;

                    lstLNV.Add(lnv);
                }

                sdr.Close();
                conn.Close();

                return lstLNV;
            }
            catch (Exception)
            {
                return null;
            }
        }

        // Lấy danh sách mã loại nhân viên.
        public static List<string> lstDSMaLNV()
        {
            try
            {
                List<string> lstDS = new List<string>();
                string strSELECT = @"SELECT lnv.MaLoaiNV
	                                FROM dbo.tblLoaiNhanVien lnv";
                SqlConnection conn = DataProvider_DAO.taoKetNoi();
                SqlDataReader sdr = DataProvider_DAO.truyVanDuLieu(strSELECT, conn);

                while (sdr.Read())
                {
                    string str = "";
                    if (!sdr.IsDBNull(0))
                        str = sdr["MaLoaiNV"].ToString();
                    lstDS.Add(str);
                }

                sdr.Close();
                conn.Close();

                return lstDS;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public static bool suaLoaiNhanVien_DAO(LoaiNhanVien_DTO _LNVHienTai)
        {
            string strUpdate = @"UPDATE dbo.tblLoaiNhanVien SET LoaiNV = @LoaiNV WHERE MaLoaiNV like '" + _LNVHienTai.strMaLoaiNV + "'";
            List<SqlParameter> lstpar = new List<SqlParameter>();
            lstpar.Add(new SqlParameter("@LoaiNV", _LNVHienTai.strTenLoaiNV));

            foreach (var parCheck in lstpar)
            {
                if (parCheck.Value == null)
                    parCheck.Value = DBNull.Value;
            }

            try
            {
                SqlConnection conn = DataProvider_DAO.taoKetNoi();
                bool bKq = DataProvider_DAO.thucThiCauLenh(strUpdate, lstpar.ToArray(), conn);
                conn.Close();

                return bKq;
            }
            catch
            {
                return false;
            }
        }

        public static bool themLoaiNhanVien_DAO(LoaiNhanVien_DTO _LNVHienTai)
        {
            string strInsert = @"INSERT INTO dbo.tblLoaiNhanVien(MaLoaiNV, LoaiNV, TrangThai) VALUES (@MaLoaiNV, @LoaiNV, 1)";
            List<SqlParameter> lstpar = new List<SqlParameter>();
            lstpar.Add(new SqlParameter("@MaLoaiNV", _LNVHienTai.strMaLoaiNV));
            lstpar.Add(new SqlParameter("@LoaiNV", _LNVHienTai.strTenLoaiNV));

            if (lstpar[0].Value == null)
                return false;

            foreach (var parCheck in lstpar)
            {
                if (parCheck.Value == null)
                    parCheck.Value = DBNull.Value;
            }

            try
            {
                SqlConnection conn = DataProvider_DAO.taoKetNoi();
                bool bKq = DataProvider_DAO.thucThiCauLenh(strInsert, lstpar.ToArray(), conn);
                conn.Close();

                return bKq;
            }
            catch
            {
                return false;
            }
        }

        public static bool xoaLoaiNhanVien_DAO(LoaiNhanVien_DTO _LNVHienTai)
        {
            try
            {
                string strUpdate = @"UPDATE dbo.tblLoaiNhanVien SET TrangThai = 0 WHERE MaLoaiNV = '" + _LNVHienTai.strMaLoaiNV + "'";
                SqlConnection conn = DataProvider_DAO.taoKetNoi();
                bool bKq = DataProvider_DAO.thucThiCauLenh(strUpdate, conn);
                conn.Close();

                return bKq;
            }
            catch
            {
                return false;
            }
        }

        public static bool kiemTraMaBiTrung_DAO(LoaiNhanVien_DTO _LNV)
        {
            try
            {
                bool _B_Check = false;
                string strSelect = @"SELECT TOP 1 MaLoaiNV
	                                FROM dbo.LoaiNhanVien lnv
		                                WHERE lnv.MaLoaiNV like '" + _LNV.strMaLoaiNV + "'";
                SqlConnection conn = DataProvider_DAO.taoKetNoi();
                SqlDataReader sdr = DataProvider_DAO.truyVanDuLieu(strSelect, conn);

                if (sdr.Read())
                    if (!sdr.IsDBNull(0))
                        _B_Check = true;

                sdr.Close();
                conn.Close();

                return _B_Check;
            }
            catch
            {
                return false;
            }
        }

        public static bool kiemTraTenBiTrung_DAO(LoaiNhanVien_DTO _LNV)
        {
            try
            {
                bool _B_Check = false;
                string strSelect = @"SELECT TOP 1 lnv.MaLoaiNV
	                                    FROM dbo.tblLoaiNhanVien lnv
		                                    WHERE lnv.LoaiNV like N'" + _LNV.strTenLoaiNV + "'";
                SqlConnection conn = DataProvider_DAO.taoKetNoi();
                SqlDataReader sdr = DataProvider_DAO.truyVanDuLieu(strSelect, conn);

                if (sdr.Read())
                    if (!sdr.IsDBNull(0))
                        _B_Check = true;

                sdr.Close();
                conn.Close();

                return _B_Check;
            }
            catch
            {
                return false;
            }
        }
    }
}
