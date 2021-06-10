using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.ComponentModel;
using QLCHApple_DTO;

namespace QLCHApple_DAO
{
    public class Frm_DAO
    {
        public static BindingList<Frm_DTO> loadDSFrm()
        {
            BindingList<Frm_DTO> lstFrm = new BindingList<Frm_DTO>();
            string strSELECT = @"SELECT *
	                                FROM tblFrm";

            SqlConnection conn = DataProvider_DAO.taoKetNoi();
            SqlDataReader sdr = DataProvider_DAO.truyVanDuLieu(strSELECT, conn);

            while (sdr.Read())
            {
                Frm_DTO f = new Frm_DTO();
                if (!sdr.IsDBNull(0))
                    f.strMaFrm = sdr["MaFrm"].ToString();
                else
                    f.strMaFrm = "";

                if (!sdr.IsDBNull(1))
                    f.strTenFrm = sdr["TenFrm"].ToString();
                else
                    f.strTenFrm = "";
                lstFrm.Add(f);
            }

            sdr.Close();
            conn.Close();

            return lstFrm;
        }
    }
}
