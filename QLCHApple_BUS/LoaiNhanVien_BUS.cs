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
    public class LoaiNhanVien_BUS
    {
        public static BindingList<LoaiNhanVien_DTO> loadDSLoaiNhanVien_BUS()
        {
            return LoaiNhanVien_DAO.loadDSLoaiNhanVien_DAO();
        }

        public static bool xoaLoaiNhanVien_BUS(LoaiNhanVien_DTO _LNVHienTai)
        {
            return LoaiNhanVien_DAO.xoaLoaiNhanVien_DAO(_LNVHienTai);
        }

        public static bool themLoaiNhanVien_BUS(LoaiNhanVien_DTO _LNVHienTai)
        {
            return LoaiNhanVien_DAO.themLoaiNhanVien_DAO(_LNVHienTai);
        }

        public static bool suaLoaiNhanVien_BUS(LoaiNhanVien_DTO _LNVHienTai)
        {
            return LoaiNhanVien_DAO.suaLoaiNhanVien_DAO(_LNVHienTai);
        }

        public static string layMaLNVCaoNhat_BUS()
        {
            string _STR_MAX = HamChung.returnMaCaoNhat_BUS(LoaiNhanVien_DAO.lstDSMaLNV());
            if (_STR_MAX == "1")
                return "LNV" + _STR_MAX;
            return _STR_MAX;
        }

        // Phân quyền cho loại nhân viên khi mới thêm. Mặc định là được xem tất cả chức năng, nhưng không được chỉnh sửa.
        public static bool themPhanQuyenChoLoaiNV(LoaiNhanVien_DTO _LNV)
        {
            BindingList<Frm_DTO> _LST_DSFrm = new BindingList<Frm_DTO>();
            _LST_DSFrm = Frm_BUS.loadDSFrm_BUS();
            int _IN_LSTDSFrm = _LST_DSFrm.Count();
            for (int i = 0; i < _IN_LSTDSFrm; ++i)
            {
                PhanQuyen_DTO _PQ = new PhanQuyen_DTO();
                _PQ.strMaLoaiNV = _LNV.strMaLoaiNV;
                _PQ.strMaFrm = _LST_DSFrm[i].strMaFrm;
                if (_LST_DSFrm[i].strMaFrm != "frmPhanQuyen")
                    _PQ.bXem = true;
                if (!PhanQuyen_BUS.themPhanQuyen_BUS(_PQ))
                    return false;
            }

            return true;
        }

        public static bool kiemTraMaBiTrung_BUS(LoaiNhanVien_DTO _LNV)
        {
            return LoaiNhanVien_DAO.kiemTraMaBiTrung_DAO(_LNV);
        }

        public static bool kiemTraTenBiTrung_BUS(LoaiNhanVien_DTO _LNV)
        {
            return LoaiNhanVien_DAO.kiemTraTenBiTrung_DAO(_LNV);
        }
    }
}
