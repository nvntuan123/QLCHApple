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
    public class SanPham_DAO
    {
        // Load dữ liệu từ 3 bảng Sản phẩm, model, serialnumber.
        public static BindingList<SanPham_DTO> loadDSSP_DAO()
        {
            string strSelect = @"SELECT DISTINCT dbo.tblSanPham.MaSP,
				                                dbo.tblSanPham.TenSP,
				                                dbo.tblLoaiSP.MaLoaiSP,
				                                dbo.tblSanPham.GiaBan,
				                                (SELECT COUNT(tblIMEI.MaIMEI)
					                                FROM tblIMEI
						                                WHERE tblIMEI.MaHDB IS NULL AND tblIMEI.MaSP = tblSanPham.MaSP) AS SoLuong,
				                                dbo.tblSanPham.NamSX
	                                FROM dbo.tblSanPham, dbo.tblLoaiSP
		                                WHERE  dbo.tblLoaiSP.MaLoaiSP = dbo.tblSanPham.MaLoaiSP
				                                AND dbo.tblSanPham.TrangThai = 1
				                                AND dbo.tblLoaiSP.TrangThai = 1
			                                GROUP BY dbo.tblSanPham.MaSP,
					                                dbo.tblSanPham.TenSP,
					                                dbo.tblLoaiSP.MaLoaiSP,
					                                dbo.tblSanPham.GiaBan,
					                                dbo.tblSanPham.NamSX";
            SqlConnection conn = DataProvider_DAO.taoKetNoi();
            SqlDataReader sdr = DataProvider_DAO.truyVanDuLieu(strSelect, conn);

            BindingList<SanPham_DTO> lstSP = new BindingList<SanPham_DTO>();
            while (sdr.Read())
            {
                SanPham_DTO SP = new SanPham_DTO();
                if (!sdr.IsDBNull(0))
                    SP.strMaSP = sdr["MaSP"].ToString();
                else
                    SP.strMaSP = "";

                if (!sdr.IsDBNull(1))
                    SP.strTenSP = sdr["TenSP"].ToString();
                else
                    SP.strTenSP = "";

                if (!sdr.IsDBNull(2))
                    SP.strMaLoaiSP = sdr["MaLoaiSP"].ToString();
                else
                    SP.strMaLoaiSP = "";

                if (!sdr.IsDBNull(3))
                    SP.decGiaBan = Convert.ToDecimal(sdr["GiaBan"]);
                else
                    SP.decGiaBan = 0;

                if (!sdr.IsDBNull(4))
                    SP.iSoLuong = Convert.ToInt32(sdr["SoLuong"]);
                else
                    SP.iSoLuong = 0;

                if (!sdr.IsDBNull(5))
                    SP.dtNamSX = Convert.ToDateTime(sdr["NamSX"]);
                else
                    SP.dtNamSX = DateTime.Now;

                lstSP.Add(SP);
            }

            sdr.Close();
            conn.Close();

            return lstSP;
        }

        // Lấy danh sách mã sản phẩm.
        public static List<string> lstDSMaSP()
        {
            List<string> lstDS = new List<string>();
            string strSELECT = @"SELECT sp.MaSP
	                                FROM dbo.tblSanPham sp";
            SqlConnection conn = DataProvider_DAO.taoKetNoi();
            SqlDataReader sdr = DataProvider_DAO.truyVanDuLieu(strSELECT, conn);

            while (sdr.Read())
            {
                string str = "";
                if (!sdr.IsDBNull(0))
                    str = sdr["MaSP"].ToString();
                lstDS.Add(str);
            }

            sdr.Close();
            conn.Close();

            return lstDS;
        }

        // Thêm sản phẩm.
        public static bool themSanPham_DAO(SanPham_DTO sp)
        {
            try
            {
                string strINSERT = @"INSERT INTO dbo.tblSanPham(MaSP, TenSP, GiaBan, NamSX, MaLoaiSP, TrangThai) VALUES(@MaSP, @TenSP, @GiaBan, @NamSX, @MaLoaiSP, 1)";

                List<SqlParameter> lstPar = new List<SqlParameter>();
                lstPar.Add(new SqlParameter("@MaSP", sp.strMaSP));
                lstPar.Add(new SqlParameter("@TenSP", sp.strTenSP));
                lstPar.Add(new SqlParameter("@GiaBan", sp.decGiaBan));
                lstPar.Add(new SqlParameter("@NamSX", sp.dtNamSX));
                lstPar.Add(new SqlParameter("@MaLoaiSP", sp.strMaLoaiSP));

                if (lstPar[0] == null)
                    return false;

                foreach (var parCheck in lstPar)
                {
                    if (parCheck.Value == null)
                        parCheck.Value = DBNull.Value;
                }

                SqlConnection conn = DataProvider_DAO.taoKetNoi();
                bool bkq = DataProvider_DAO.thucThiCauLenh(strINSERT, lstPar.ToArray(), conn);
                conn.Close();

                return bkq;
            }
            catch (Exception)
            {
                return false;
            }
            
        }

        // Cập nhật thông tin sản phẩm.
        public static bool capNhatSanPham_DAO(SanPham_DTO sp)
        {
            try
            {
                string strUPDATE = @"UPDATE dbo.tblSanPham SET TenSP = @TenSP, GiaBan = @GiaBan, NamSX = @NamSX, MaLoaiSP = @MaLoaiSP WHERE dbo.tblSanPham.MaSP like '" + sp.strMaSP + "'";
                List<SqlParameter> lstPar = new List<SqlParameter>();
                lstPar.Add(new SqlParameter("@MaSP", sp.strMaSP));
                lstPar.Add(new SqlParameter("@TenSP", sp.strTenSP));
                lstPar.Add(new SqlParameter("@GiaBan", sp.decGiaBan));
                lstPar.Add(new SqlParameter("@NamSX", sp.dtNamSX));
                lstPar.Add(new SqlParameter("@MaLoaiSP", sp.strMaLoaiSP));

                SqlConnection conn = DataProvider_DAO.taoKetNoi();
                bool bkq = DataProvider_DAO.thucThiCauLenh(strUPDATE, lstPar.ToArray(), conn);
                conn.Close();

                return bkq;
            }
            catch (Exception)
            {
                return false;
            }
        }

        // Cập nhật trạng thái sản phẩm.
        public static bool capNhatTrangThaiSP_DAO(SanPham_DTO sp)
        {
            try
            {
                string strUPDATE_TrangThai = @"UPDATE dbo.tblSanPham SET TrangThai = 0 WHERE dbo.tblSanPham.MaSP like '" + sp.strMaSP + "'";
                SqlConnection conn = DataProvider_DAO.taoKetNoi();
                bool bKq = DataProvider_DAO.thucThiCauLenh(strUPDATE_TrangThai, conn);
                conn.Close();
                return bKq;
            }
            catch (Exception)
            {
                return false;
            }
        }

        // Kiểm tra mã IMEI của sản phẩm.
        public static bool kiemTraTonTaiIMEI_DAO(SanPham_DTO sp)
        {
            try
            {
                string strSELECT = @"SELECT *
	                                FROM tblSanPham sp, tblIMEI imei
		                                WHERE sp.MaSP = imei.MaSP AND sp.MaSP like '" + sp.strMaSP + "'";
                SqlConnection conn = DataProvider_DAO.taoKetNoi();
                SqlDataReader sdr = DataProvider_DAO.truyVanDuLieu(strSELECT, conn);

                bool bKq = false;
                while (sdr.Read())
                    bKq = true;

                sdr.Close();
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
