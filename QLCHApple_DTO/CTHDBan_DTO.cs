using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCHApple_DTO
{
    public class CTHDBan_DTO
    {
        private int _I_MaHDB;
        private string _STR_MaSP;
        private decimal _DEC_DonGia;
        private int _I_SoLuong;

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

        public decimal DEC_DonGia
        {
            get
            {
                return _DEC_DonGia;
            }

            set
            {
                _DEC_DonGia = value;
            }
        }

        public int I_SoLuong
        {
            get
            {
                return _I_SoLuong;
            }

            set
            {
                _I_SoLuong = value;
            }
        }
    }
}
