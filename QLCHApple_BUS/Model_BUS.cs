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
    public class Model_BUS
    {
        public static BindingList<Model_DTO> loadDSModel_BUS()
        {
            return Model_DAO.loadDSModel_DAO();
        }

        public static string layMaCaoNhat_BUS()
        {
            string _STR_MAX = HamChung.returnMaCaoNhat_BUS(Model_DAO.lstDSMaModel());
            if (_STR_MAX == "1")
                return "MD" + _STR_MAX;
            return _STR_MAX;
        }

        public static bool themModel_BUS(Model_DTO md)
        {
            return Model_DAO.themModel_DAO(md);
        }

        public static bool suaModel_BUS(Model_DTO md)
        {
            return Model_DAO.suaModel_DAO(md);
        }

        public static bool updateTrangThaiModel_BUS(Model_DTO md)
        {
            return Model_DAO.updateTrangThaiModel_DAO(md);
        }

        public static bool kiemTraTrungMaCTModel_DAO(string _STR_Model)
        {
            return Model_DAO.kiemTraTrungMaCTModel_DAO(_STR_Model);
        }
    }
}
