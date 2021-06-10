using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCHApple_DTO
{
    public class Frm_DTO
    {
        private string _strMaFrm;
        private string _strTenFrm;

        public string strMaFrm
        {
            get
            {
                return _strMaFrm;
            }

            set
            {
                _strMaFrm = value;
            }
        }

        public string strTenFrm
        {
            get
            {
                return _strTenFrm;
            }

            set
            {
                _strTenFrm = value;
            }
        }
    }
}
