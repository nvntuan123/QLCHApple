using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLCHApple_DAO;
using QLCHApple_DTO;

namespace QLCHApple_BUS
{
    public class LoaiKhachHang_BUS
    {
        public static System.ComponentModel.BindingList<LoaiKhachHang_DTO> loadDSLoaiKhachHang_BUS()
        {
            return LoaiKhachHang_DAO.loadDSLoaiKhachHang_DAO();
        }

        // Xử lý mã cao nhất từ bảng sản phẩm.
        public static string layMaCaoNhatBangLKH_BUS()
        {
            string _STR_MAX = HamChung.returnMaCaoNhat_BUS(LoaiKhachHang_DAO.lstDSMaLoaiKH());
            if (_STR_MAX == "1")
                return "LKH" + _STR_MAX;
            return _STR_MAX;
        }

        // Thêm dữ liệu vào bảng loại khách hàng.
        public static bool themLoaiKhachHang_BUS(LoaiKhachHang_DTO lkh)
        {
            return LoaiKhachHang_DAO.themLoaiKhachHang_DAO(lkh);
        }

        public static bool suaLoaiKhachHang_BUS(LoaiKhachHang_DTO lkh)
        {
            return LoaiKhachHang_DAO.suaLoaiKhachHang_DAO(lkh);
        }

        public static bool updateTrangThaiLKH_BUS(LoaiKhachHang_DTO lkh)
        {
            return LoaiKhachHang_DAO.updateTrangThaiLKH_DAO(lkh);
        }
    }
}
