using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using QLCHApple_DAO;
using QLCHApple_DTO;

namespace QLCHApple_BUS
{
    public class ChiTietModel_BUS
    {
        // Load danh sách cấu hình theo sản phẩm.
        public static BindingList<ChiTietModel_DTO> loadDSChiTietModel_BUS(SanPham_DTO _SP)
        {
            return ChiTietModel_DAO.loadDSChiTietModel_DAO(_SP);
        }

        // Thêm 1 cấu hình cho sản phẩm.
        public static bool addChiTietSP_BUS(ChiTietModel_DTO _CTSP)
        {
            return ChiTietModel_DAO.addChiTietSP_DAO(_CTSP);
        }

        // Xóa cấu hình của 1 sản phẩm.
        public static bool deleteChiTietSP_BUS(ChiTietModel_DTO _CTSP)
        {
            return ChiTietModel_DAO.deleteChiTietSP_DAO(_CTSP);
        }

        // Sửa thông tin chi tiết sản phẩm.
        public static bool updateChiTietSP_BUS(ChiTietModel_DTO _CTSP)
        {
            return ChiTietModel_DAO.updateChiTietSP_DAO(_CTSP);
        }

        // Kiểm tra trùng cấu hình trên 1 sản phẩm.
        public static bool checkMaSPandMaModel_BUS(ChiTietModel_DTO _CTSP)
        {
            return ChiTietModel_DAO.checkMaSPandMaModel_DAO(_CTSP);
        }
    }
}
