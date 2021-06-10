using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCHApple_DTO
{
    public class HDNhap_DTO
    {
        private int _I_MaHDN;
        private string _STR_MaNV;
        private DateTime _DT_NgayLap;
        private decimal _DEC_TongTien;
        private bool _B_TrangThai;

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

        public string STR_MaNV
        {
            get
            {
                return _STR_MaNV;
            }

            set
            {
                _STR_MaNV = value;
            }
        }

        public DateTime DT_NgayLap
        {
            get
            {
                return _DT_NgayLap;
            }

            set
            {
                _DT_NgayLap = value;
            }
        }

        public decimal DEC_TongTien
        {
            get
            {
                return _DEC_TongTien;
            }

            set
            {
                _DEC_TongTien = value;
            }
        }

        public bool B_TrangThai
        {
            get
            {
                return _B_TrangThai;
            }

            set
            {
                _B_TrangThai = value;
            }
        }
    }
}
