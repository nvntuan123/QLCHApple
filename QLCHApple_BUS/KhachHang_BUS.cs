using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLCHApple_DAO;
using QLCHApple_DTO;

namespace QLCHApple_BUS
{
    public class KhachHang_BUS
    {
        public static System.ComponentModel.BindingList<KhachHang_DTO> loadDSKhachHang_BUS()
        {
            return KhachHang_DAO.loadDSKhachHang_DAO();
        }

        // Xử lý mã cao nhất từ bảng sản phẩm.
        public static string layMaCaoNhatBangKH_BUS()
        {
            string _STR_MAX = HamChung.returnMaCaoNhat_BUS(KhachHang_DAO.lstDSMaKH());
            if (_STR_MAX == "1")
                return "KH" + _STR_MAX;
            return _STR_MAX;
        }

        public static bool xoaKhachHang_BUS(KhachHang_DTO kh)
        {
            return KhachHang_DAO.xoaKhachHang_DAO(kh);
        }

        public static bool themKhachHang_BUS(KhachHang_DTO _KHHienTai)
        {
            return KhachHang_DAO.themKhachHang_DAO(_KHHienTai);
        }

        public static bool suaKhachHang_BUS(KhachHang_DTO _KHHienTai)
        {
            return KhachHang_DAO.suaKhachHang_DAO(_KHHienTai);
        }

        // Kiểm tra xem có trùng số điện thoại hay không nếu trùng trả về true, không trả về false.
        public static bool kiemTraTrungSDT_BUS(KhachHang_DTO _KHHienTai)
        {
            return KhachHang_DAO.kiemTraKhachHangTrungSDT_DAO(_KHHienTai);
        }

        public static bool kiemTraTrungCMND_BUS(KhachHang_DTO _KHHienTai)
        {
            return KhachHang_DAO.kiemTraKhachHangTrungCMND_DAO(_KHHienTai);
        }
    }
}
