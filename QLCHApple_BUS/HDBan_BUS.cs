using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLCHApple_DAO;
using QLCHApple_DTO;
using System.ComponentModel;

namespace QLCHApple_BUS
{
    public class HDBan_BUS
    {
        public static int laymacaonhat()
        {
            return HDBan_DAO.Laymacaonhat_DAO() + 1;
        }

        public static bool themHDBan_BUS(HDBan_DTO _HDBan)
        {
            return HDBan_DAO.themHDBan_DAO(_HDBan);
        }

        // Lay ra danh sach hoa don ban tu ngay A -> ngay B
        public static BindingList<HDBan_DTO> _LST_DSHDBan_FromToDate_BUS(DateTime _DT_FromDate, DateTime _DT_ToDate)
        {
            return HDBan_DAO._LST_DSHDBan_FromToDate_DAO(_DT_FromDate, _DT_ToDate);
        }

        public static bool updateTrangThaiHDBan_BUS(HDBan_DTO _HDB)
        {
            return HDBan_DAO.updateTrangThaiHDBan_DAO(_HDB);
        }

        public static bool updateHDBan_BUS(HDBan_DTO _HDB)
        {
            return HDBan_DAO.updateHDBan_DAO(_HDB);
        }

        public static BindingList<HDBan_DTO> loadDSHDBan_BUS()
        {
            return HDBan_DAO.loadDSHDBan_DAO();
        }
    }
}
