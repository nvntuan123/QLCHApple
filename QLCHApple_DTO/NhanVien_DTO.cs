using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCHApple_DTO
{
    public class NhanVien_DTO
    {
        private string _strMaNV;

        public string strMaNV
        {
            get { return _strMaNV; }
            set { _strMaNV = value; }
        }
        private string _strHoTen;

        public string strHoTen
        {
            get { return _strHoTen; }
            set { _strHoTen = value; }
        }
        private string _strSDT;

        public string strSDT
        {
            get { return _strSDT; }
            set { _strSDT = value; }
        }
        private DateTime _dtNgaySinh;

        public DateTime dtNgaySinh
        {
            get { return _dtNgaySinh; }
            set { _dtNgaySinh = value; }
        }
        private string _strGioiTinh;

        public string strGioiTinh
        {
            get { return _strGioiTinh; }
            set { _strGioiTinh = value; }
        }
        private string _strEmail;

        public string strEmail
        {
            get { return _strEmail; }
            set { _strEmail = value; }
        }
        private string _strMatKhau;

        public string strMatKhau
        {
            get { return _strMatKhau; }
            set { _strMatKhau = value; }
        }
        private string _strCMND;

        public string strCMND
        {
            get { return _strCMND; }
            set { _strCMND = value; }
        }
        private string _strMaLoaiNV;

        public string strMaLoaiNV
        {
            get { return _strMaLoaiNV; }
            set { _strMaLoaiNV = value; }
        }
        private bool _bTrangThai;

        public bool bTrangThai
        {
            get { return _bTrangThai; }
            set { _bTrangThai = value; }
        }
        private decimal _decLuongNgay;

        public decimal decLuongNgay
        {
            get { return _decLuongNgay; }
            set { _decLuongNgay = value; }
        }
    }
}
