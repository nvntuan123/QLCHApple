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
    public class Model_DAO
    {
        #region
        // Load dữ liệu bảng model.
        public static BindingList<Model_DTO> loadDSModel_DAO()
        {
            BindingList<Model_DTO> lstModel = new BindingList<Model_DTO>();
            string strSelect = @"SELECT * FROM dbo.tblModel WHERE TrangThai = 1";
            SqlConnection conn = DataProvider_DAO.taoKetNoi();
            SqlDataReader sdr = DataProvider_DAO.truyVanDuLieu(strSelect, conn);

            while (sdr.Read())
            {
                Model_DTO Model = new Model_DTO();

                if (!sdr.IsDBNull(0))
                    Model.strMaModel = sdr["MaModel"].ToString();
                else
                    Model.strMaModel = "";

                if (!sdr.IsDBNull(1))
                    Model.strTenModel = sdr["TenModel"].ToString();
                else
                    Model.strTenModel = "";

                if (!sdr.IsDBNull(2))
                    Model.bTrangThai = Convert.ToBoolean(sdr["TrangThai"]);
                else
                    Model.bTrangThai = false;

                lstModel.Add(Model);
            }

            sdr.Close();
            conn.Close();

            return lstModel;
        }

        // Lấy danh sách mã model.
        public static List<string> lstDSMaModel()
        {
            try
            {
                List<string> lstDS = new List<string>();
                string strSELECT = @"SELECT md.MaModel
	                                FROM dbo.tblModel md";
                SqlConnection conn = DataProvider_DAO.taoKetNoi();
                SqlDataReader sdr = DataProvider_DAO.truyVanDuLieu(strSELECT, conn);

                while (sdr.Read())
                {
                    string str = "";
                    if (!sdr.IsDBNull(0))
                        str = sdr["MaModel"].ToString();
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

        // Xóa dữ liệu trong form (nghĩa là update trạng thái model = 0).
        public static bool updateTrangThaiModel_DAO(Model_DTO md)
        {
            try
            {
                string strUpdateTrangThai = @"UPDATE dbo.tblModel SET TrangThai = 0 WHERE MaModel = '" + md.strMaModel + "'";
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

        // Sửa model.
        public static bool suaModel_DAO(Model_DTO md)
        {
            try
            {
                string strUpdateModel = @"UPDATE dbo.tblModel SET TenModel = @TenModel WHERE MaModel = '" + md.strMaModel + "'";
                List<SqlParameter> lstpar = new List<SqlParameter>();
                lstpar.Add(new SqlParameter("@TenModel", md.strTenModel));

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

        // Thêm 1 phần tử vào bảng model.
        public static bool themModel_DAO(Model_DTO md)
        {
            string strInsertModel = @"INSERT INTO dbo.tblModel(MaModel, TenModel, TrangThai) VALUES (@MaModel, @TenModel, 1)";
            List<SqlParameter> lstpar = new List<SqlParameter>();
            lstpar.Add(new SqlParameter("@MaModel", md.strMaModel));
            lstpar.Add(new SqlParameter("@TenModel", md.strTenModel));

            if (lstpar[0].Value == null)
                return false;

            foreach (var parCheck in lstpar)
            {
                if (parCheck.Value == null)
                    parCheck.Value = DBNull.Value;
            }

            SqlConnection conn = DataProvider_DAO.taoKetNoi();
            bool bKq = DataProvider_DAO.thucThiCauLenh(strInsertModel, lstpar.ToArray(), conn);
            conn.Close();

            return bKq;
        }

        public static bool kiemTraTrungMaCTModel_DAO(string _STR_MaModel)
        {
            try
            {
                string _STR_SELECT = @"SELECT TOP 1 MaModel
	                                        FROM tblChiTietModel
		                                        WHERE MaModel = '" + _STR_MaModel + "'";
                SqlConnection conn = DataProvider_DAO.taoKetNoi();
                SqlDataReader sdr = DataProvider_DAO.truyVanDuLieu(_STR_SELECT, conn);

                bool bKq = false;
                if (sdr.Read())
                    bKq = true;

                sdr.Close();
                conn.Close();
                return bKq;
            }
            catch (Exception)
            {
                return true;
            }
        }
        #endregion
    }
}
