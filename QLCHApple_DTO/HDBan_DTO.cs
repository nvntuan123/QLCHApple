using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCHApple_DTO
{
    public class HDBan_DTO
    {
        private int _I_MaHDB;
        private DateTime _DT_NgayBan;
        private decimal _DEC_TongTien;
        private string _STR_MaNV;
        private string _STR_MaKH;
        private int _I_MaKM;
        private bool _B_TrangThai;

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

        public DateTime DT_NgayBan
        {
            get
            {
                return _DT_NgayBan;
            }

            set
            {
                _DT_NgayBan = value;
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

        public string STR_MaKH
        {
            get
            {
                return _STR_MaKH;
            }

            set
            {
                _STR_MaKH = value;
            }
        }

        public int I_MaKM
        {
            get
            {
                return _I_MaKM;
            }

            set
            {
                _I_MaKM = value;
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
