using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using QLCHApple_DTO;

namespace QLCHApple_DAO
{
    public class ChiTietModel_DAO
    {
        // Load danh sách cấu hình theo sản phẩm.
        public static BindingList<ChiTietModel_DTO> loadDSChiTietModel_DAO(SanPham_DTO _SP)
        {
            try
            {
                string _STR_SELECT = @"SELECT DISTINCT *
	                                        FROM dbo.tblChiTietModel
		                                        WHERE dbo.tblChiTietModel.MaSP like '" + _SP.strMaSP + "'";
                BindingList<ChiTietModel_DTO> _LST_CTSP = new BindingList<ChiTietModel_DTO>();

                SqlConnection conn = DataProvider_DAO.taoKetNoi();
                SqlDataReader sdr = DataProvider_DAO.truyVanDuLieu(_STR_SELECT, conn);

                while (sdr.Read())
                {
                    ChiTietModel_DTO _CTSP = new ChiTietModel_DTO();
                    if (!sdr.IsDBNull(0))
                        _CTSP.strMaSP = sdr["MaSP"].ToString();
                    else
                        _CTSP.strMaSP = "";

                    if (!sdr.IsDBNull(1))
                        _CTSP.strMaModel = sdr["MaModel"].ToString();
                    else
                        _CTSP.strMaModel = "";

                    if (!sdr.IsDBNull(2))
                        _CTSP.strThongSoKyThuat = sdr["ThongSoKyThuat"].ToString();
                    else
                        _CTSP.strThongSoKyThuat = "";

                    if (!sdr.IsDBNull(3))
                        _CTSP.strMota = sdr["MoTa"].ToString();
                    else
                        _CTSP.strMota = "";

                    _LST_CTSP.Add(_CTSP);
                }

                sdr.Close();
                conn.Close();

                return _LST_CTSP;
            }
            catch (Exception)
            {
                return null;
            }
        }

        // Thêm 1 cấu hình cho sản phẩm.
        public static bool addChiTietSP_DAO(ChiTietModel_DTO _CTSP)
        {
            try
            {
                string _STR_INSET = @"INSERT INTO dbo.tblChiTietModel(MaModel, MaSP, ThongSoKyThuat, MoTa) VALUES(@MaModel, @MaSP, @ThongSoKyThuat, @MoTa)";
                List<SqlParameter> _LST_Par = new List<SqlParameter>();
                _LST_Par.Add(new SqlParameter("@MaModel", _CTSP.strMaModel));
                _LST_Par.Add(new SqlParameter("@MaSP", _CTSP.strMaSP));
                _LST_Par.Add(new SqlParameter("@ThongSoKyThuat", _CTSP.strThongSoKyThuat));
                _LST_Par.Add(new SqlParameter("@MoTa", _CTSP.strMota));

                SqlConnection conn = DataProvider_DAO.taoKetNoi();
                bool bKq = DataProvider_DAO.thucThiCauLenh(_STR_INSET, _LST_Par.ToArray(), conn);
                conn.Close();

                return bKq;
            }
            catch (Exception)
            {
                return false;
            }
        }

        // Xóa cấu hình của 1 sản phẩm.
        public static bool deleteChiTietSP_DAO(ChiTietModel_DTO _CTSP)
        {
            try
            {
                string _STR_DELECT = @"DELETE FROM dbo.tblChiTietModel WHERE dbo.tblChiTietModel.MaModel = '" + _CTSP.strMaModel + "' and dbo.tblChiTietModel.MaSP = '" + _CTSP.strMaSP + "'";
                SqlConnection conn = DataProvider_DAO.taoKetNoi();
                bool bKq = DataProvider_DAO.thucThiCauLenh(_STR_DELECT, conn);
                conn.Close();
                return bKq;
            }
            catch (Exception)
            {
                return false;
            }
        }

        // Sửa thông tin chi tiết sản phẩm.
        public static bool updateChiTietSP_DAO(ChiTietModel_DTO _CTSP)
        {
            try
            {
                string _STR_UPDATE = @"UPDATE dbo.tblChiTietModel SET ThongSoKyThuat = @ThongSoKyThuat, MoTa = @Mota WHERE dbo.tblChiTietModel.MaModel like '" + _CTSP.strMaModel + "' and dbo.tblChiTietModel.MaSP like '" + _CTSP.strMaSP + "'";

                List<SqlParameter> _LST_Par = new List<SqlParameter>();
                _LST_Par.Add(new SqlParameter("@ThongSoKyThuat", _CTSP.strThongSoKyThuat));
                _LST_Par.Add(new SqlParameter("@MoTa", _CTSP.strMota));

                SqlConnection conn = DataProvider_DAO.taoKetNoi();
                bool bKq = DataProvider_DAO.thucThiCauLenh(_STR_UPDATE, _LST_Par.ToArray(), conn);
                conn.Close();

                return bKq;
            }
            catch (Exception)
            {
                return false;
            }
        }

        // Kiểm tra trùng cấu hình trên 1 sản phẩm.
        public static bool checkMaSPandMaModel_DAO(ChiTietModel_DTO _CTSP)
        {
            try
            {
                string _STR_SELECT = @"SELECT *
	                                        FROM dbo.tblChiTietModel ctmd
		                                        WHERE ctmd.MaModel = '" + _CTSP.strMaModel + "' AND ctmd.MaSP = '" + _CTSP.strMaSP + "'";

                SqlConnection conn = DataProvider_DAO.taoKetNoi();
                SqlDataReader sdr = DataProvider_DAO.truyVanDuLieu(_STR_SELECT, conn);

                bool bKq = false; // Mac dinh khong trung.
                if (sdr.Read())
                    bKq = true; // Trung.

                sdr.Close();
                conn.Close();

                return bKq;
            }
            catch (Exception)
            {
                return true;
            }
        }
    }
}
