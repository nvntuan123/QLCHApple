using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCHApple_DTO
{
    public class IMEI_DTO
    {
        private string _STR_MaIMEI;
        private string _STR_MaSP;
        private int _I_MaHDN;
        private int _I_MaHDB;

        public string STR_MaIMEI
        {
            get
            {
                return _STR_MaIMEI;
            }

            set
            {
                _STR_MaIMEI = value;
            }
        }

        public string STR_MaSP
        {
            get
            {
                return _STR_MaSP;
            }

            set
            {
                _STR_MaSP = value;
            }
        }

        public int I_MaHDN
        {
            get
            {
                return _I_MaHDN;
            }

            set
            {
                _I_MaHDN = value;
            }
        }

        public int I_MaHDB
        {
            get
            {
                return _I_MaHDB;
            }

            set
            {
                _I_MaHDB = value;
            }
        }
    }
}
