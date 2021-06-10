using QLCHApple_DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCHApple_DAO
{
    public class CTHDNhap_DAO
    {
        public static bool themCTHDNhap_DAO(CTHDNhap_DTO _CTHDNhap)
        {
            try
            {
                string strInsert = @"INSERT INTO dbo.tblCTHDNhap(MaHDN, MaSP, SoLuong, DonGia) VALUES(@MaHDN, @MaSP, @SoLuong, @DonGia)";
                List<SqlParameter> lstpar = new List<SqlParameter>();
                lstpar.Add(new SqlParameter("@MaHDN", _CTHDNhap.I_MaHDN));
                lstpar.Add(new SqlParameter("@MaSP", _CTHDNhap.STR_MaSP));
                lstpar.Add(new SqlParameter("@SoLuong", _CTHDNhap.I_SoLuong));
                lstpar.Add(new SqlParameter("@DonGia", _CTHDNhap.DEC_DonGia));

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
    }
}
