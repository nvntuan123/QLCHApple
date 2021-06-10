using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLCHApple_DAO;
using QLCHApple_DTO;

namespace QLCHApple_BUS
{
    public class CTHDNhap_BUS
    {
        public static bool themCTHDNhap_BUS(CTHDNhap_DTO _CTHDNhap)
        {
            return CTHDNhap_DAO.themCTHDNhap_DAO(_CTHDNhap);
        }
    }
}
