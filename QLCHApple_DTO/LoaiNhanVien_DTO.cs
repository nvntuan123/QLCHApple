using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCHApple_DTO
{
    public class LoaiNhanVien_DTO
    {
        private string _strMaLoaiNV;

        public string strMaLoaiNV
        {
            get { return _strMaLoaiNV; }
            set { _strMaLoaiNV = value; }
        }
        private string _strTenLoaiNV;

        public string strTenLoaiNV
        {
            get { return _strTenLoaiNV; }
            set { _strTenLoaiNV = value; }
        }
        private bool _bTrangThai;

        public bool bTrangThai
        {
            get { return _bTrangThai; }
            set { _bTrangThai = value; }
        }
    }
}
