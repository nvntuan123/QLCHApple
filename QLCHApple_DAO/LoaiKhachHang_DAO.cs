using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using QLCHApple_DTO;

namespace QLCHApple_DAO
{
    public class LoaiKhachHang_DAO
    {
        public static System.ComponentModel.BindingList<LoaiKhachHang_DTO> loadDSLoaiKhachHang_DAO()
        {
            System.ComponentModel.BindingList<LoaiKhachHang_DTO> lstLoaiKH = new System.ComponentModel.BindingList<LoaiKhachHang_DTO>();
            string strSELECT = @"SELECT *
	                                FROM dbo.tblLoaiKhachHang
		                                WHERE dbo.tblLoaiKhachHang.TrangThai = 1";
            SqlConnection conn = DataProvider_DAO.taoKetNoi();
            SqlDataReader sdr = DataProvider_DAO.truyVanDuLieu(strSELECT, conn);

            while (sdr.Read())
            {
                LoaiKhachHang_DTO loaiKH = new LoaiKhachHang_DTO();
                if (!sdr.IsDBNull(0))
                    loaiKH.strMaLoaiKH = sdr["MaLoaiKH"].ToString();
                else
                    loaiKH.strMaLoaiKH = "";

                if (!sdr.IsDBNull(1))
                    loaiKH.strLoaiKH = sdr["LoaiKH"].ToString();
                else
                    loaiKH.strLoaiKH = "";

                if (!sdr.IsDBNull(2))
                    loaiKH.iPhanTramGG = Convert.ToInt32(sdr["PhanTramGG"]);
                else
                    loaiKH.iPhanTramGG = 0;

                if (!sdr.IsDBNull(3))
                    loaiKH.bTrangThai = Convert.ToBoolean(sdr["TrangThai"]);
                else
                    loaiKH.bTrangThai = false;

                lstLoaiKH.Add(loaiKH);
            }

            sdr.Close();
            conn.Close();

            return lstLoaiKH;
        }

        // Lấy danh sách mã loại khách hàng.
        public static List<string> lstDSMaLoaiKH()
        {
            try
            {
                List<string> lstDS = new List<string>();
                string strSELECT = @"SELECT lkh.MaLoaiKH
	                                FROM dbo.tblLoaiKhachHang lkh";
                SqlConnection conn = DataProvider_DAO.taoKetNoi();
                SqlDataReader sdr = DataProvider_DAO.truyVanDuLieu(strSELECT, conn);

                while (sdr.Read())
                {
                    string str = "";
                    if (!sdr.IsDBNull(0))
                        str = sdr["MaLoaiKH"].ToString();
                    lstDS.Add(str);
                }

                sdr.Close();
                conn.Close();

                return lstDS;
            }
            catch
            {
                return null;
            }
        }

        // Thêm dữ liệu vào bảng loại khách hàng.
        public static bool themLoaiKhachHang_DAO(LoaiKhachHang_DTO lkh)
        {
            try
            {
                string strInsertLKH = @"INSERT INTO dbo.tblLoaiKhachHang(MaLoaiKH, LoaiKH, PhanTramGG, TrangThai) VALUES(@MaLoaiKH, @LoaiKH, @PhanTramGG, 1)";
                List<SqlParameter> lstpar = new List<SqlParameter>();
                lstpar.Add(new SqlParameter("@MaLoaiKH", lkh.strMaLoaiKH));
                lstpar.Add(new SqlParameter("@LoaiKH", lkh.strLoaiKH));
                lstpar.Add(new SqlParameter("@PhanTramGG", lkh.iPhanTramGG));

                if (lstpar[0].Value == null)
                    return false;

                foreach (var parCheck in lstpar)
                {
                    if (parCheck.Value == null)
                        parCheck.Value = DBNull.Value;
                }

                SqlConnection conn = DataProvider_DAO.taoKetNoi();
                bool bKq = DataProvider_DAO.thucThiCauLenh(strInsertLKH, lstpar.ToArray(), conn);
                conn.Close();

                return bKq;
            }
            catch (Exception)
            {
                return false;
            }
        }

        // Xóa dữ liệu trong form (nghĩa là update trạng thái loại khách hàng = 0).
        public static bool updateTrangThaiLKH_DAO(LoaiKhachHang_DTO lkh)
        {
            try
            {
                string strUpdateTrangThai = @"UPDATE dbo.tblLoaiKhachHang SET TrangThai = 0 WHERE MaLoaiKH like '" + lkh.strMaLoaiKH + "'";
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

        // Sửa loại khách hàng.
        public static bool suaLoaiKhachHang_DAO(LoaiKhachHang_DTO lkh)
        {
            try
            {
                string strUpdateLKH = @"UPDATE dbo.tblLoaiKhachHang SET LoaiKH = @LoaiKH, PhanTramGG = @PhanTramGG WHERE MaLoaiKH like '" + lkh.strMaLoaiKH + "'";
                List<SqlParameter> lstpar = new List<SqlParameter>();
                lstpar.Add(new SqlParameter("@LoaiKH", lkh.strLoaiKH));
                lstpar.Add(new SqlParameter("@PhanTramGG", lkh.iPhanTramGG));

                foreach (var parCheck in lstpar)
                {
                    if (parCheck.Value == null)
                        parCheck.Value = DBNull.Value;
                }

                SqlConnection conn = DataProvider_DAO.taoKetNoi();
                bool bKq = DataProvider_DAO.thucThiCauLenh(strUpdateLKH, lstpar.ToArray(), conn);
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
