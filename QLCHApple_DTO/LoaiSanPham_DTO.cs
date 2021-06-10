using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCHApple_DTO
{
    public class LoaiSanPham_DTO
    {
        private string _strMaLoaiSP;

        public string strMaLoaiSP
        {
            get { return _strMaLoaiSP; }
            set { _strMaLoaiSP = value; }
        }
        private string _strTenLoaiSP;

        public string strTenLoaiSP
        {
            get { return _strTenLoaiSP; }
            set { _strTenLoaiSP = value; }
        }
        private bool _bTrangThaiLoaiSP;

        public bool bTrangThaiLoaiSP
        {
            get { return _bTrangThaiLoaiSP; }
            set { _bTrangThaiLoaiSP = value; }
        }
    }
}
