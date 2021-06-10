using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLCHApple_DAO;
using QLCHApple_DTO;

namespace QLCHApple_BUS
{
    public class SanPham_BUS
    {
        // Load sản phẩm gồm 3 bảng(Sản phẩm, model, loại sản phẩm, serialnumber).
        public static System.ComponentModel.BindingList<SanPham_DTO> loadDSSP_BUS()
        {
            return SanPham_DAO.loadDSSP_DAO();
        }

        // Xử lý mã cao nhất từ bảng sản phẩm.
        public static string layMaCaoNhatBangSP_BUS()
        {
            string _STR_MAX = HamChung.returnMaCaoNhat_BUS(SanPham_DAO.lstDSMaSP());
            if (_STR_MAX == "1")
                return "SP" + _STR_MAX;
            return _STR_MAX;
        }

        public static bool themSanPham_BUS(SanPham_DTO SPHienTai)
        {
            return SanPham_DAO.themSanPham_DAO(SPHienTai);
        }

        public static bool capNhatSanPham_BUS(SanPham_DTO SPHienTai)
        {
            return SanPham_DAO.capNhatSanPham_DAO(SPHienTai);
        }

        // Cập nhật trạng thái sản phẩm.
        public static bool capNhatTrangThaiSP_BUS(SanPham_DTO sp)
        {
            return SanPham_DAO.capNhatTrangThaiSP_DAO(sp);
        }

        public static bool kiemTraTonTaiIMEI_BUS(SanPham_DTO sp)
        {
            return SanPham_DAO.kiemTraTonTaiIMEI_DAO(sp);
        }
    }
}
