using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using QLCHApple_DAO;
using QLCHApple_DTO;
using System.ComponentModel;

namespace QLCHApple_BUS
{
    public class IMEI_BUS
    {
        public static bool themIMEINhap_BUS(IMEI_DTO _IMEI)
        {
            return IMEI_DAO.themIMEINhap_DAO(_IMEI);
        }

        public static bool kiemTraTrungMaIEMI_BUS(string _STR_MaIMEI)
        {
            return IMEI_DAO.kiemTraTrungMaIMEI_DAO(_STR_MaIMEI);
        }

        public static BindingList<IMEI_DTO> loadDS_MaIMEI_TheoMaSP_BUS(string _STR_MaSP)
        {
            return IMEI_DAO.loadDS_MaIMEI_TheoMaSP_DAO(_STR_MaSP);
        }

        public static int demSoLuongTonKhoTheoSP_BUS(string _STR_MaSP)
        {
            return IMEI_DAO.demSoLuongTonKhoTheoSP_DAO(_STR_MaSP);
        }

        public static BindingList<IMEI_DTO> loadDSMaIMEI_BUS()
        {
            return IMEI_DAO.loadDSMaIMEI_DAO();
        }

        public static bool themIMEIBan_BUS(IMEI_DTO _IMEI)
        {
            return IMEI_DAO.themIMEIBan_DAO(_IMEI);
        }

        public static bool updateMaHDBinIMEI_BUS(int _I_MaHDB)
        {
            return IMEI_DAO.updateMaHDBinIMEI_DAO(_I_MaHDB);
        }

        public static BindingList<IMEI_DTO> loadDSIMEIThaoHDB_BUS(string _STR_MaSP, int _I_MaHDB)
        {
            return IMEI_DAO.loadDSIMEIThaoHDB_DAO(_STR_MaSP, _I_MaHDB);
        }
    }
}
