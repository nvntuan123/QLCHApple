using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCHApple_DTO
{
    public class KhachHang_DTO
    {
        private string _strMaKH;
        private string _strHoTenKH;
        private int _iCMNDKH;
        private string _strSDTKH;
        private string _strEmailKH;
        private DateTime _dtNgaySinhKH;
        private string _strGioiTinhKH;
        private string _strDiaChiKH;
        private string _strMaLoaiKH;
        private bool _bTrangThai;

        public string strMaKH
        {
            get
            {
                return _strMaKH;
            }

            set
            {
                _strMaKH = value;
            }
        }

        public string strHoTenKH
        {
            get
            {
                return _strHoTenKH;
            }

            set
            {
                _strHoTenKH = value;
            }
        }

        public int iCMNDKH
        {
            get
            {
                return _iCMNDKH;
            }

            set
            {
                _iCMNDKH = value;
            }
        }

        public string strSDTKH
        {
            get
            {
                return _strSDTKH;
            }

            set
            {
                _strSDTKH = value;
            }
        }

        public string strEmailKH
        {
            get
            {
                return _strEmailKH;
            }

            set
            {
                _strEmailKH = value;
            }
        }

        public DateTime dtNgaySinhKH
        {
            get
            {
                return _dtNgaySinhKH;
            }

            set
            {
                _dtNgaySinhKH = value;
            }
        }

        public string strGioiTinhKH
        {
            get
            {
                return _strGioiTinhKH;
            }

            set
            {
                _strGioiTinhKH = value;
            }
        }

        public string strDiaChiKH
        {
            get
            {
                return _strDiaChiKH;
            }

            set
            {
                _strDiaChiKH = value;
            }
        }

        public string strMaLoaiKH
        {
            get
            {
                return _strMaLoaiKH;
            }

            set
            {
                _strMaLoaiKH = value;
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
