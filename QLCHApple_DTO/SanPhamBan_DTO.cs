using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCHApple_DTO
{
    public class SanPhamBan_DTO
    {
        string _STR_MaSP;
        string _STR_TenSP;
        DateTime _DT_NamSX;
        string _STR_MaLoaiSP;
        decimal _DEC_DonGia;
        int _I_SoLuong;
        decimal _DEC_ThanhTien;
        bool _B_TrangThai;

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

        public string STR_TenSP
        {
            get
            {
                return _STR_TenSP;
            }

            set
            {
                _STR_TenSP = value;
            }
        }

        public DateTime DT_NamSX
        {
            get
            {
                return _DT_NamSX;
            }

            set
            {
                _DT_NamSX = value;
            }
        }

        public string STR_MaLoaiSP
        {
            get
            {
                return _STR_MaLoaiSP;
            }

            set
            {
                _STR_MaLoaiSP = value;
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

        public decimal DEC_ThanhTien
        {
            get
            {
                return _DEC_ThanhTien;
            }

            set
            {
                _DEC_ThanhTien = value;
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
