using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCHApple_DTO
{
    public class SanPham_DTO
    {
        /* Những thuộc tính cần show ra form sản phẩm.
         * 1.MaSP(string).
         * 2.TenSP(string).
         * 3.LoaiSP(string).
         * 4.GiaBan(decimal).
         * 5.SoLuong(int).
         * 6.NamSX(date).
         */
        string _strMaSP;
        string _strTenSP;
        DateTime _dtNamSX;
        decimal _decGiaBan;
        string _strMaLoaiSP;
        int _iSoLuong;

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

        public string strTenSP
        {
            get
            {
                return _strTenSP;
            }

            set
            {
                _strTenSP = value;
            }
        }

        public DateTime dtNamSX
        {
            get
            {
                return _dtNamSX;
            }

            set
            {
                _dtNamSX = value;
            }
        }

        public decimal decGiaBan
        {
            get
            {
                return _decGiaBan;
            }

            set
            {
                _decGiaBan = value;
            }
        }

        public string strMaLoaiSP
        {
            get
            {
                return _strMaLoaiSP;
            }

            set
            {
                _strMaLoaiSP = value;
            }
        }

        public int iSoLuong
        {
            get
            {
                return _iSoLuong;
            }

            set
            {
                _iSoLuong = value;
            }
        }
    }
}
