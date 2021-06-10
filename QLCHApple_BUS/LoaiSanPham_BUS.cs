using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLCHApple_DAO;
using QLCHApple_DTO;
using System.ComponentModel;

namespace QLCHApple_BUS
{
    public class LoaiSanPham_BUS
    {
        // Xử lý mã cao nhất.
        public static string layMaCaoNhat_BUS()
        {
            string _STR_MAX = HamChung.returnMaCaoNhat_BUS(LoaiSanPham_DAO.lstDSMaLSP());
            if (_STR_MAX == "1")
                return "LSP" + _STR_MAX;
            return _STR_MAX;
        }

        // Thêm dữ liệu.
        public static bool themLoaiSP_BUS(LoaiSanPham_DTO loaiSP)
        {
            return LoaiSanPham_DAO.themLoaiSP_DAO(loaiSP);
        }

        // Load danh sách loại sản phẩm.
        public static BindingList<LoaiSanPham_DTO> layDSLoaiSP_BUS()
        {
            return LoaiSanPham_DAO.layDSLoaiSP_DAO();
        }

        // Sửa dữ liệu.
        public static bool suaLoaiSP_BUS(LoaiSanPham_DTO loaiSP)
        {
            return LoaiSanPham_DAO.suaLoaiSP_DAO(loaiSP);
        }

        // Xóa dữ liệu (cập nhật trạng thái = 0).
        public static bool xoaLoaiSP_BUS(LoaiSanPham_DTO loaiSP)
        {
            return LoaiSanPham_DAO.xoaLoaiSP_DAO(loaiSP);
        }
    }
}
