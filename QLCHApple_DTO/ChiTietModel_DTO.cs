using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCHApple_DTO
{
    public class ChiTietModel_DTO
    {
        private string _strMaSP;
        private string _strMaModel;
        private string _strThongSoKyThuat;
        private string _strMoTa;

        public string strMaSP
        {
            get
            {
                return _strMaSP;
            }

            set
            {
                _strMaSP = value;
            }
        }

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

        public string strThongSoKyThuat
        {
            get
            {
                return _strThongSoKyThuat;
            }

            set
            {
                _strThongSoKyThuat = value;
            }
        }

        public string strMota
        {
            get
            {
                return _strMoTa;
            }

            set
            {
                _strMoTa = value;
            }
        }
    }
}
