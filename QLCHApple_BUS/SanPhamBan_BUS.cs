using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLCHApple_DAO;
using QLCHApple_DTO;

namespace QLCHApple_BUS
{
    public class SanPhamBan_BUS
    {
        public static BindingList<SanPhamBan_DTO> loadDSSanPhamBan_MaHDB_BUS(int _I_MaHDB)
        {
            return SanPhamBan_DAO.loadDSSanPhamBan_MaHDB_DAO(_I_MaHDB);
        }
    }
}
