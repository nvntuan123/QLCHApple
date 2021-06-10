using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCHApple_DTO
{
    public class LoaiKhachHang_DTO
    {
        private string _strMaLoaiKH;
        private string _strLoaiKH;
        private int _iPhanTramGG; // Phần trăm giảm giá.
        private bool _bTrangThai;

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

        public string strLoaiKH
        {
            get
            {
                return _strLoaiKH;
            }

            set
            {
                _strLoaiKH = value;
            }
        }

        public int iPhanTramGG
        {
            get
            {
                return _iPhanTramGG;
            }

            set
            {
                _iPhanTramGG = value;
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
