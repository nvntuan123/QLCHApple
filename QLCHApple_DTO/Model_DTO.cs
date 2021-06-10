using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCHApple_DTO
{
    public class Model_DTO
    {
        string _strMaModel;
        string _strTenModel;
        bool _bTrangThai;

        public string strMaModel
        {
            get
            {
                return _strMaModel;
            }

            set
            {
                _strMaModel = value;
            }
        }

        public string strTenModel
        {
            get
            {
                return _strTenModel;
            }

            set
            {
                _strTenModel = value;
            }
        }

        public bool bTrangThai
        {
            get
            {
                return _bTrangThai;
            }

            set
            {
                _bTrangThai = value;
            }
        }
    }
}
