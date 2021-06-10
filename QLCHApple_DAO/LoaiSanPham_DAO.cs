using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using QLCHApple_DTO;
using System.ComponentModel;

namespace QLCHApple_DAO
{
    public class LoaiSanPham_DAO
    {
        // Lấy danh sách mã loại sản phẩm.
        public static List<string> lstDSMaLSP()
        {
            try
            {
                List<string> lstDS = new List<string>();
                string strSELECT = @"SELECT lsp.MaLoaiSP
	                                FROM dbo.tblLoaiSP lsp";
                SqlConnection conn = DataProvider_DAO.taoKetNoi();
                SqlDataReader sdr = DataProvider_DAO.truyVanDuLieu(strSELECT, conn);

                while (sdr.Read())
                {
                    string str = "";
                    if (!sdr.IsDBNull(0))
                        str = sdr["MaLoaiSP"].ToString();
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

        // Thêm dữ liệu.
        public static bool themLoaiSP_DAO(LoaiSanPham_DTO loaiSP)
        {
            try
            {
                string strInsetLSP = @"INSERT INTO dbo.tblLoaiSP
                                        ( MaLoaiSP ,
                                          TenLoaiSP ,
                                          TrangThai
                                        )
                                VALUES  ( @MaLoaiSP ,
                                          @TenLoaiSP ,
                                          1
                                        )";
                List<SqlParameter> lstpar = new List<SqlParameter>();
                lstpar.Add(new SqlParameter("@MaLoaiSP", loaiSP.strMaLoaiSP));
                lstpar.Add(new SqlParameter("@TenLoaiSP", loaiSP.strTenLoaiSP));

                if (lstpar[0].Value == null)
                {
                    return false;
                }

                foreach (var parCheck in lstpar)
                {
                    if (parCheck.Value == null)
                        parCheck.Value = DBNull.Value;
                }
                SqlConnection conn = DataProvider_DAO.taoKetNoi();
                bool bKq = DataProvider_DAO.thucThiCauLenh(strInsetLSP, lstpar.ToArray(), conn);
                conn.Close();

                return bKq;
            }
            catch (Exception)
            {
                return false;
            }
        }

        // Lấy dữ liệu.
        public static BindingList<LoaiSanPham_DTO> layDSLoaiSP_DAO()
        {
            try
            {
                string strSelect = @"SELECT *
	                                    FROM dbo.tblLoaiSP
		                                    WHERE TrangThai = 1";
                SqlConnection conn = DataProvider_DAO.taoKetNoi();
                SqlDataReader sdr = DataProvider_DAO.truyVanDuLieu(strSelect, conn);

                BindingList<LoaiSanPham_DTO> lstLoaiSP = new BindingList<LoaiSanPham_DTO>();
                while (sdr.Read())
                {
                    LoaiSanPham_DTO loaiSP = new LoaiSanPham_DTO();
                    if (!sdr.IsDBNull(0))
                        loaiSP.strMaLoaiSP = sdr["MaLoaiSP"].ToString();
                    else
                        loaiSP.strMaLoaiSP = "";

                    if (!sdr.IsDBNull(1))
                        loaiSP.strTenLoaiSP = sdr["TenLoaiSP"].ToString();
                    else
                        loaiSP.strTenLoaiSP = "";

                    if (!sdr.IsDBNull(2))
                        loaiSP.bTrangThaiLoaiSP = Convert.ToBoolean(sdr["TrangThai"]);
                    else
                        loaiSP.bTrangThaiLoaiSP = true;
                    lstLoaiSP.Add(loaiSP);
                }

                sdr.Close();
                conn.Close();

                return lstLoaiSP;
            }
            catch (Exception)
            {
                return null;
            }
        }

        // Sửa dữ liệu.
        public static bool suaLoaiSP_DAO(LoaiSanPham_DTO loaiSP)
        {
            try
            {
                string strUpdate = @"UPDATE dbo.tblLoaiSP SET TenLoaiSP = @TenLoaiSP WHERE MaLoaiSP = '" + loaiSP.strMaLoaiSP + "'";
                List<SqlParameter> lstpar = new List<SqlParameter>();
                lstpar.Add(new SqlParameter("@TenLoaiSP", loaiSP.strTenLoaiSP));

                foreach (var parCheck in lstpar)
                {
                    if (parCheck.Value == null)
                    {
                        parCheck.Value = DBNull.Value;
                    }
                }

                SqlConnection conn = DataProvider_DAO.taoKetNoi();
                bool bKq = DataProvider_DAO.thucThiCauLenh(strUpdate, lstpar.ToArray(), conn);
                conn.Close();

                return bKq;
            }
            catch (Exception)
            {
                return false;
            }
        }

        // Xóa loại sản phẩm (cập nhật trạng thái = 0)
        public static bool xoaLoaiSP_DAO(LoaiSanPham_DTO loaiSP)
        {
            try
            {
                string strUpdate = @"UPDATE dbo.tblLoaiSP SET TrangThai = 0 WHERE MaLoaiSP = '" + loaiSP.strMaLoaiSP + "'";
                SqlConnection conn = DataProvider_DAO.taoKetNoi();
                bool bKq = DataProvider_DAO.thucThiCauLenh(strUpdate, conn);
                conn.Close();
                return bKq;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
