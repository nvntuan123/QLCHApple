using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using QLCHApple_DAO;
using QLCHApple_DTO;

namespace QLCHApple_BUS
{
    public class Frm_BUS
    {
        public static BindingList<Frm_DTO> loadDSFrm_BUS()
        {
            return Frm_DAO.loadDSFrm();
        }
    }
}
