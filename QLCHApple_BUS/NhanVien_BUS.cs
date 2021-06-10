using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using QLCHApple_DTO;
using QLCHApple_DAO;

namespace QLCHApple_BUS
{
    public class NhanVien_BUS
    {
        // Load DS nhân viên.
        public static BindingList<NhanVien_DTO> loadDSNV_BUS()
        {
            return NhanVien_DAO.loadDSNV_DAO();
        }

        // Lấy ra mã cao nhất trong bảng nhân viên.
        public static string layMaNVCaoNhat_BUS()
        {
            string _STR_MAX = HamChung.returnMaCaoNhat_BUS(NhanVien_DAO.lstDSMaNV());
            if (_STR_MAX == "1")
                return "NV" + _STR_MAX;
            return _STR_MAX;
        }

        // Thêm 1 nhân viên.
        public static bool themNVien_BUS(NhanVien_DTO _NV)
        {
            return NhanVien_DAO.themNVien_DAO(_NV);
        }

        // Xóa nhân viên(cập nhật trạng thái = 0)
        public static bool xoaNVien_BUS(NhanVien_DTO nvien)
        {
            return NhanVien_DAO.xoaNVien_DAO(nvien);
        }

        // Cập nhật thông tin nhân viên.
        public static bool suaNV_BUS(NhanVien_DTO NVHienTai)
        {
            return NhanVien_DAO.suaNV_DAO(NVHienTai);
        }

        // Kiểm tra trùng số điện thoại.
        public static bool kiemTraTrungSDT_BUS(NhanVien_DTO _NV_KiemTraSDT, int _ITrangThaiForm) // Trùng sdt return true, không return false.
        {
            string _STR_MaNV = NhanVien_DAO.layMaNVTheoSDT_DAO(_NV_KiemTraSDT.strSDT);
            return kiemTraTrung(_NV_KiemTraSDT, _STR_MaNV, _ITrangThaiForm);
        }

        // Kiểm tra trùng CMND.
        public static bool kiemTraTrungCMND_BUS(NhanVien_DTO _NV_KiemTraCMND, int _ITrangThaiForm)
        {
            string _STR_MaNV = NhanVien_DAO.layMaNVTheoCMND_DAO(_NV_KiemTraCMND.strCMND);
            return kiemTraTrung(_NV_KiemTraCMND, _STR_MaNV, _ITrangThaiForm);
        }

        // Kiểm tra trúng email.
        public static bool kiemTraTrungEmail_BUS(NhanVien_DTO _NV_KiemTraEmail, int _ITrangThaiForm)
        {
            string _STR_MaNV = NhanVien_DAO.kiemTraTrungEmail_DAO(_NV_KiemTraEmail.strEmail);
            return kiemTraTrung(_NV_KiemTraEmail, _STR_MaNV, _ITrangThaiForm);
        }

        private static bool kiemTraTrung(NhanVien_DTO _NV_Check, string _STR_MaNVCheck, int _I_TrangThai)
        {
            if (_STR_MaNVCheck == "" || _I_TrangThai == 2 && _STR_MaNVCheck == _NV_Check.strMaNV)
            {
                return false;
            }
            return true;
        }
    }
}
