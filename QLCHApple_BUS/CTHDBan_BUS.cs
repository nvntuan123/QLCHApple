using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLCHApple_DAO;
using QLCHApple_DTO;

namespace QLCHApple_BUS
{
    public class CTHDBan_BUS
    {
        public static bool themCTHDBan_BUS(CTHDBan_DTO _CTHDBan)
        {
            return CTHDBan_DAO.themCTHDBan_DAO(_CTHDBan);
        }

        public static bool delectCTHDTheoMaHDB_BUS(int _I_MaHDB)
        {
            return CTHDBan_DAO.delectCTHDTheoMaHDB_DAO(_I_MaHDB);
        }
    }
}
