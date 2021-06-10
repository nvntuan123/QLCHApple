using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using QLCHApple_DTO;

namespace QLCHApple_DAO
{
    public class KhachHang_DAO
    {
        public static System.ComponentModel.BindingList<KhachHang_DTO> loadDSKhachHang_DAO()
        {
            try
            {
                System.ComponentModel.BindingList<KhachHang_DTO> lstKH = new System.ComponentModel.BindingList<KhachHang_DTO>();
                string strSELECT = @"SELECT *
	                                FROM dbo.tblKhachHang
		                                WHERE dbo.tblKhachHang.TrangThai = 1";
                SqlConnection conn = DataProvider_DAO.taoKetNoi();
                SqlDataReader sdr = DataProvider_DAO.truyVanDuLieu(strSELECT, conn);

                while (sdr.Read())
                {
                    KhachHang_DTO KH = new KhachHang_DTO();
                    if (!sdr.IsDBNull(0))
                        KH.strMaKH = sdr["MaKH"].ToString();
                    else
                        KH.strMaKH = "";

                    if (!sdr.IsDBNull(1))
                        KH.strHoTenKH = sdr["HoTen"].ToString();
                    else
                        KH.strHoTenKH = "";

                    if (!sdr.IsDBNull(2))
                        KH.iCMNDKH = Convert.ToInt32(sdr["CMND"]);
                    else
                        KH.iCMNDKH = 0;

                    if (!sdr.IsDBNull(3))
                        KH.strSDTKH = sdr["SDT"].ToString();
                    else
                        KH.strSDTKH = "";

                    if (!sdr.IsDBNull(4))
                        KH.strEmailKH = sdr["Email"].ToString();
                    else
                        KH.strEmailKH = "";

                    if (!sdr.IsDBNull(5))
                        KH.dtNgaySinhKH = Convert.ToDateTime(sdr["NgaySinh"]);
                    else
                        KH.dtNgaySinhKH = DateTime.Now;

                    if (!sdr.IsDBNull(6))
                        KH.strGioiTinhKH = sdr["GioiTinh"].ToString();
                    else
                        KH.strGioiTinhKH = "";

                    if (!sdr.IsDBNull(7))
                        KH.strDiaChiKH = sdr["DiaChi"].ToString();
                    else
                        KH.strDiaChiKH = "";

                    if (!sdr.IsDBNull(8))
                        KH.strMaLoaiKH = sdr["MaLoaiKH"].ToString();
                    else
                        KH.strMaLoaiKH = "";

                    if (!sdr.IsDBNull(9))
                        KH.bTrangThai = Convert.ToBoolean(sdr["TrangThai"]);
                    else
                        KH.bTrangThai = false;

                    lstKH.Add(KH);
                }

                sdr.Close();
                conn.Close();

                return lstKH;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public static bool suaKhachHang_DAO(KhachHang_DTO _KHHienTai)
        {
            try
            {
                string strUpdateKH = @"UPDATE dbo.tblKhachHang SET HoTen = @HoTen, CMND = @CMND, SDT = @SDT, Email = @Email, NgaySinh = @NgaySinh, GioiTinh = @GioiTinh, DiaChi = @DiaChi, MaLoaiKH = @MaLoaiKH WHERE MaKH like '" + _KHHienTai.strMaKH + "'";
                List<SqlParameter> lstpar = new List<SqlParameter>();
                lstpar.Add(new SqlParameter("@HoTen", _KHHienTai.strHoTenKH));
                lstpar.Add(new SqlParameter("@CMND", _KHHienTai.iCMNDKH));
                lstpar.Add(new SqlParameter("@SDT", _KHHienTai.strSDTKH));
                lstpar.Add(new SqlParameter("@Email", _KHHienTai.strEmailKH));
                lstpar.Add(new SqlParameter("@NgaySinh", _KHHienTai.dtNgaySinhKH));
                lstpar.Add(new SqlParameter("@GioiTinh", _KHHienTai.strGioiTinhKH));
                lstpar.Add(new SqlParameter("@DiaChi", _KHHienTai.strDiaChiKH));
                lstpar.Add(new SqlParameter("@MaLoaiKH", _KHHienTai.strMaLoaiKH));

                if (_KHHienTai.iCMNDKH == 0)
                    lstpar[1].Value = DBNull.Value;

                if (lstpar[0].Value == null)
                    return false;

                foreach (var parCheck in lstpar)
                {
                    if (parCheck.Value == null)
                        parCheck.Value = DBNull.Value;
                }

                SqlConnection conn = DataProvider_DAO.taoKetNoi();
                bool bKq = DataProvider_DAO.thucThiCauLenh(strUpdateKH, lstpar.ToArray(), conn);
                conn.Close();

                return bKq;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static bool themKhachHang_DAO(KhachHang_DTO _KHHienTai)
        {
            try
            {
                string strInsertKH = @"INSERT INTO dbo.tblKhachHang(MaKH, HoTen, CMND, SDT,  Email,  NgaySinh, GioiTinh, DiaChi, MaLoaiKH, TrangThai) VALUES(@MaKH, @HoTen, @CMND, @SDT,  @Email,  @NgaySinh, @GioiTinh, @DiaChi, @MaLoaiKH, 1)";
                List<SqlParameter> lstpar = new List<SqlParameter>();
                lstpar.Add(new SqlParameter("@MaKH", _KHHienTai.strMaKH));
                lstpar.Add(new SqlParameter("@HoTen", _KHHienTai.strHoTenKH));
                lstpar.Add(new SqlParameter("@CMND", _KHHienTai.iCMNDKH));
                lstpar.Add(new SqlParameter("@SDT", _KHHienTai.strSDTKH));
                lstpar.Add(new SqlParameter("@Email", _KHHienTai.strEmailKH));
                lstpar.Add(new SqlParameter("@NgaySinh", _KHHienTai.dtNgaySinhKH));
                lstpar.Add(new SqlParameter("@GioiTinh", _KHHienTai.strGioiTinhKH));
                lstpar.Add(new SqlParameter("@DiaChi", _KHHienTai.strDiaChiKH));
                lstpar.Add(new SqlParameter("@MaLoaiKH", _KHHienTai.strMaLoaiKH));

                if (_KHHienTai.iCMNDKH == 0)
                    lstpar[2].Value = DBNull.Value;

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
            catch (Exception)
            {
                return false;
            }
        }

        public static bool xoaKhachHang_DAO(KhachHang_DTO kh)
        {
            try
            {
                string strUpdateTrangThai = @"UPDATE dbo.tblKhachHang SET TrangThai = 0 WHERE MaKH like '" + kh.strMaKH + "'";
                SqlConnection conn = DataProvider_DAO.taoKetNoi();
                bool bKq = DataProvider_DAO.thucThiCauLenh(strUpdateTrangThai, conn);
                conn.Close();
                return bKq;
            }
            catch (Exception)
            {
                return false;
            }
        }

        // Select khách hàng theo số điện thoại để kiểm tra xem lúc thêm hoặc sửa có bị trùng số điện thoại hay không.
        public static bool kiemTraKhachHangTrungSDT_DAO(KhachHang_DTO _KHHienTai)
        {
            try
            {
                System.ComponentModel.BindingList<KhachHang_DTO> lstKhachHangSDT = new System.ComponentModel.BindingList<KhachHang_DTO>();
                string strSelectSDT = @"SELECT *
	                                    FROM dbo.tblKhachHang
		                                    WHERE dbo.KhachHang.SDT = '" + _KHHienTai.strSDTKH + "' AND dbo.KhachHang.MaKH != '" + _KHHienTai.strMaKH + "'";
                SqlConnection conn = DataProvider_DAO.taoKetNoi();
                SqlDataReader sdr = DataProvider_DAO.truyVanDuLieu(strSelectSDT, conn);

                bool bKq = false;
                if (sdr.Read())
                {
                    bKq = true;
                }

                sdr.Close();
                conn.Close();

                return bKq;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static bool kiemTraKhachHangTrungCMND_DAO(KhachHang_DTO _KHHienTai)
        {
            try
            {
                System.ComponentModel.BindingList<KhachHang_DTO> lstKhachHangCMND = new System.ComponentModel.BindingList<KhachHang_DTO>();
                string strSelectCMND = @"SELECT *
	                                    FROM dbo.tblKhachHang
		                                    WHERE dbo.KhachHang.CMND = '" + _KHHienTai.iCMNDKH + "' AND dbo.KhachHang.MaKH != '" + _KHHienTai.strMaKH + "'";
                SqlConnection conn = DataProvider_DAO.taoKetNoi();
                SqlDataReader sdr = DataProvider_DAO.truyVanDuLieu(strSelectCMND, conn);

                bool bKq = false;
                if (sdr.Read())
                {
                    bKq = true;
                }

                sdr.Close();
                conn.Close();

                return bKq;
            }
            catch (Exception)
            {
                return false;
            }
        }

        // Lấy danh sách mã khách hàng.
        public static List<string> lstDSMaKH()
        {
            try
            {
                List<string> lstDS = new List<string>();
                string strSELECT = @"SELECT kh.MaKH
	                                FROM dbo.tblKhachHang kh";
                SqlConnection conn = DataProvider_DAO.taoKetNoi();
                SqlDataReader sdr = DataProvider_DAO.truyVanDuLieu(strSELECT, conn);

                while (sdr.Read())
                {
                    string str = "";
                    if (!sdr.IsDBNull(0))
                        str = sdr["MaKH"].ToString();
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
    }
}
