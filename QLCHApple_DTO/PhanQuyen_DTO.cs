using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCHApple_DTO
{
    public class PhanQuyen_DTO
    {
        private string _strMaLoaiNV;
        private string _strMaFrm;
        private bool _bFull;
        private bool _bThem;
        private bool _bXoa;
        private bool _bSua;
        private bool _bXem;

        public string strMaLoaiNV
        {
            get
            {
                return _strMaLoaiNV;
            }

            set
            {
                _strMaLoaiNV = value;
            }
        }

        public string strMaFrm
        {
            get
            {
                return _strMaFrm;
            }

            set
            {
                _strMaFrm = value;
            }
        }

        public bool bFull
        {
            get
            {
                return _bFull;
            }

            set
            {
                _bFull = value;
            }
        }

        public bool bThem
        {
            get
            {
                return _bThem;
            }

            set
            {
                _bThem = value;
            }
        }

        public bool bXoa
        {
            get
            {
                return _bXoa;
            }

            set
            {
                _bXoa = value;
            }
        }

        public bool bSua
        {
            get
            {
                return _bSua;
            }

            set
            {
                _bSua = value;
            }
        }

        public bool bXem
        {
            get
            {
                return _bXem;
            }

            set
            {
                _bXem = value;
            }
        }
    }
}
