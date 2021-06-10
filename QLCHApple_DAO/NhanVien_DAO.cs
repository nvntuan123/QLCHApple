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
    public class NhanVien_DAO
    {
        // Lấy dữ liệu danh sách nhân viên từ sql(bảng NhanVien).
        public static BindingList<NhanVien_DTO> loadDSNV_DAO()
        {
            BindingList<NhanVien_DTO> lstNV = new System.ComponentModel.BindingList<NhanVien_DTO>();
            string strSelect = @"SELECT DISTINCT nv.MaNV,
				                                nv.HoTen,
                                                nv.SDT,
                                                nv.NgaySinh,
                                                nv.GioiTinh,
                                                nv.Email,
                                                nv.MatKhau,
                                                nv.CMND,
                                                nv.MaLoaiNV,
                                                nv.LuongNgay,
				                                nv.TrangThai
	                                FROM dbo.tblNhanVien nv, dbo.tblLoaiNhanVien lnv
		                                WHERE nv.MaLoaiNV = lnv.MaLoaiNV and nv.TrangThai = 1";
            try
            {
                SqlConnection conn = DataProvider_DAO.taoKetNoi();
                SqlDataReader sdr = DataProvider_DAO.truyVanDuLieu(strSelect, conn);

                while (sdr.Read())
                {
                    NhanVien_DTO nv = new NhanVien_DTO();
                    if (!sdr.IsDBNull(0))
                        nv.strMaNV = sdr["MaNV"].ToString();
                    else
                        nv.strMaNV = "";

                    if (!sdr.IsDBNull(1))
                        nv.strHoTen = sdr["HoTen"].ToString();
                    else
                        nv.strHoTen = "";

                    if (!sdr.IsDBNull(2))
                        nv.strSDT = sdr["SDT"].ToString();
                    else
                        nv.strSDT = "";

                    if (!sdr.IsDBNull(3))
                        nv.dtNgaySinh = Convert.ToDateTime(sdr["NgaySinh"]);
                    else
                        nv.dtNgaySinh = DateTime.Now;

                    if (!sdr.IsDBNull(4))
                        nv.strGioiTinh = sdr["GioiTinh"].ToString();
                    else
                        nv.strGioiTinh = "";

                    if (!sdr.IsDBNull(5))
                        nv.strEmail = sdr["Email"].ToString();
                    else
                        nv.strEmail = "";

                    if (!sdr.IsDBNull(6))
                        nv.strMatKhau = sdr["MatKhau"].ToString();
                    else
                        nv.strMatKhau = "";

                    if (!sdr.IsDBNull(7))
                        nv.strCMND = sdr["CMND"].ToString();
                    else
                        nv.strCMND = "";
                    if (!sdr.IsDBNull(8))
                        nv.strMaLoaiNV = sdr["MaLoaiNV"].ToString();
                    else
                        nv.strMaLoaiNV = "";

                    if (!sdr.IsDBNull(9))
                        nv.decLuongNgay = Convert.ToDecimal(sdr["LuongNgay"]);
                    else
                        nv.decLuongNgay = 0;

                    if (!sdr.IsDBNull(10))
                        nv.bTrangThai = Convert.ToBoolean(sdr["TrangThai"]);
                    else
                        nv.bTrangThai = true;

                    lstNV.Add(nv);
                }

                sdr.Close();
                conn.Close();

                return lstNV;
            }
            catch
            {
                return null;
            }
        }

        // Lấy danh sách mã nhân viên.
        public static List<string> lstDSMaNV()
        {
            try
            {
                List<string> lstDS = new List<string>();
                string strSELECT = @"SELECT nv.MaNV
	                                FROM dbo.tblNhanVien nv";
                SqlConnection conn = DataProvider_DAO.taoKetNoi();
                SqlDataReader sdr = DataProvider_DAO.truyVanDuLieu(strSELECT, conn);

                while (sdr.Read())
                {
                    string str = "";
                    if (!sdr.IsDBNull(0))
                        str = sdr["MaNV"].ToString();
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

        // Thêm 1 nhân viên vào sql(bảng NhanVien).
        public static bool themNVien_DAO(NhanVien_DTO _NV)
        {
            //try
            //{
                string strInsertKH = @"INSERT INTO dbo.tblNhanVien(MaNV, HoTen, SDT, NgaySinh, GioiTinh, Email, MatKhau, CMND, MaLoaiNV, LuongNgay, TrangThai) VAlUES(@MaNV, @HoTen, @SDT, @NgaySinh, @GioiTinh, @Email, @MatKhau, @CMND, @MaLoaiNV, @LuongNgay, 1)";
                List<SqlParameter> lstpar = new List<SqlParameter>();
                lstpar.Add(new SqlParameter("@MaNV", _NV.strMaNV));
                lstpar.Add(new SqlParameter("@HoTen", _NV.strHoTen));
                lstpar.Add(new SqlParameter("@SDT", _NV.strSDT));
                lstpar.Add(new SqlParameter("@NgaySinh", _NV.dtNgaySinh));
                lstpar.Add(new SqlParameter("@GioiTinh", _NV.strGioiTinh));
                lstpar.Add(new SqlParameter("@Email", _NV.strEmail));
                lstpar.Add(new SqlParameter("@MatKhau", _NV.strMatKhau));
                lstpar.Add(new SqlParameter("@CMND", _NV.strCMND));
                lstpar.Add(new SqlParameter("@MaLoaiNV", _NV.strMaLoaiNV));
                lstpar.Add(new SqlParameter("@LuongNgay", _NV.decLuongNgay));

                if (_NV.strEmail == "")
                    lstpar[5].Value = DBNull.Value;

                if (_NV.decLuongNgay == 0)
                    lstpar[9].Value = DBNull.Value;

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
            //}
            //catch
            //{
            //    return false;
            //}
        }

        // Cập nhật dữ liệu cho nhân viên được truyền vào.
        public static bool suaNV_DAO(NhanVien_DTO _NV)
        {
            try
            {
                string strUpdateKH = @"UPDATE dbo.tblNhanVien SET HoTen = @HoTen, CMND = @CMND, SDT = @SDT, Email = @Email, NgaySinh = @NgaySinh, GioiTinh = @GioiTinh, LuongNgay = @LuongNgay, MaLoaiNV = @MaLoaiNV, MatKhau = @MatKhau WHERE MaNV like '" + _NV.strMaNV + "'";
                List<SqlParameter> lstpar = new List<SqlParameter>();
                lstpar.Add(new SqlParameter("@HoTen", _NV.strHoTen));
                lstpar.Add(new SqlParameter("@SDT", _NV.strSDT));
                lstpar.Add(new SqlParameter("@NgaySinh", _NV.dtNgaySinh));
                lstpar.Add(new SqlParameter("@GioiTinh", _NV.strGioiTinh));
                lstpar.Add(new SqlParameter("@Email", _NV.strEmail));
                lstpar.Add(new SqlParameter("@MatKhau", _NV.strMatKhau));
                lstpar.Add(new SqlParameter("@CMND", _NV.strCMND));
                lstpar.Add(new SqlParameter("@MaLoaiNV", _NV.strMaLoaiNV));
                lstpar.Add(new SqlParameter("@LuongNgay", _NV.decLuongNgay));

                if (_NV.strEmail == "")
                    lstpar[4].Value = DBNull.Value;

                if (_NV.decLuongNgay == 0)
                    lstpar[8].Value = DBNull.Value;

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
            catch
            {
                return false;
            }
        }

        // Cập nhật trạng thái nhân viên = false;
        public static bool xoaNVien_DAO(NhanVien_DTO nvien)
        {
            try
            {
                string strUpdateTrangThai = @"UPDATE dbo.tblNhanVien SET TrangThai = 0 WHERE MaNV like '" + nvien.strMaNV + "'";
                SqlConnection conn = DataProvider_DAO.taoKetNoi();
                bool bKq = DataProvider_DAO.thucThiCauLenh(strUpdateTrangThai, conn);
                conn.Close();

                return bKq;
            }
            catch
            {
                return false;
            }
        }

        // Lấy mã nv với sdt.
        public static string layMaNVTheoSDT_DAO(string _STR_SDT)
        {
            try
            {
                string _STR_SELECT = @"SELECT top 1 manv
	                                    FROM tblNhanVien nv
		                                    WHERE nv.SDT = '" + _STR_SDT + "'";
                SqlConnection conn = DataProvider_DAO.taoKetNoi();
                SqlDataReader sdr = DataProvider_DAO.truyVanDuLieu(_STR_SELECT, conn);

                string _STR_MaNV = "";
                if (sdr.Read())
                    if (!sdr.IsDBNull(0))
                        _STR_MaNV = sdr["manv"].ToString();
                sdr.Close();
                conn.Close();

                return _STR_MaNV;
            }
            catch
            {
                return "";
            }
        }

        // Lấy mã nv với cmnd.
        public static string layMaNVTheoCMND_DAO(string _STR_CMND)
        {
            try
            {
                string _STR_SELECT = @"SELECT top 1 manv
	                                    FROM tblNhanVien nv
		                                    WHERE nv.CMND = '" + _STR_CMND + "'";
                SqlConnection conn = DataProvider_DAO.taoKetNoi();
                SqlDataReader sdr = DataProvider_DAO.truyVanDuLieu(_STR_SELECT, conn);

                string _STR_MaNV = "";
                if (sdr.Read())
                    if (!sdr.IsDBNull(0))
                        _STR_MaNV = sdr["manv"].ToString();
                sdr.Close();
                conn.Close();

                return _STR_MaNV;
            }
            catch
            {
                return "";
            }
        }

        // Kiem tra trung email.
        public static string kiemTraTrungEmail_DAO(string _STR_Email)
        {
            string _STR_MaNV = ""; // Khong trung.
            try
            {
                string _STR_SELECT = @"SELECT TOP 1 MaNV
	                                    FROM tblNhanVien
		                                    WHERE Email like '" + _STR_Email + "'";
                SqlConnection conn = DataProvider_DAO.taoKetNoi();
                SqlDataReader sdr = DataProvider_DAO.truyVanDuLieu(_STR_SELECT, conn);

                if (sdr.Read())
                    if (!sdr.IsDBNull(0))
                        _STR_MaNV = sdr["MaNV"].ToString();

                sdr.Close();
                conn.Close();
                return _STR_MaNV;
            }
            catch
            {
                return _STR_MaNV;
            }
        }
    }
}
