using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using QLCHApple_DTO;

namespace QLCHApple_DAO
{
    public class CTHDBan_DAO
    {
        public static bool themCTHDBan_DAO(CTHDBan_DTO _CTHDBan)
        {
            try
            {
                string strInsert = @"INSERT INTO dbo.tblCTHDBan(MaHDB, MaSP, SoLuong, DonGia) VALUES(@MaHDB, @MaSP, @SoLuong, @DonGia)";
                List<SqlParameter> lstpar = new List<SqlParameter>();
                lstpar.Add(new SqlParameter("@MaHDB", _CTHDBan.I_MaHDB));
                lstpar.Add(new SqlParameter("@MaSP", _CTHDBan.STR_MaSP));
                lstpar.Add(new SqlParameter("@SoLuong", _CTHDBan.I_SoLuong));
                lstpar.Add(new SqlParameter("@DonGia", _CTHDBan.DEC_DonGia));

                if (lstpar[0].Value == null)
                    return false;

                foreach (var parCheck in lstpar)
                {
                    if (parCheck.Value == null)
                        parCheck.Value = DBNull.Value;
                }

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

        public static bool delectCTHDTheoMaHDB_DAO(int _I_MaHDB)
        {
            try
            {
                bool _B_Check = false;
                string _STR_DELETE = @"DELETE tblCTHDBan WHERE tblCTHDBan.MaHDB = '" + _I_MaHDB + "'";
                SqlConnection conn = DataProvider_DAO.taoKetNoi();

                _B_Check = DataProvider_DAO.thucThiCauLenh(_STR_DELETE, conn);
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
