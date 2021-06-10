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
    public class PhanQuyen_BUS
    {
        public static BindingList<PhanQuyen_DTO> loadDSPhanQuyen_TheoMaLoaiNV(string _strMaLoaiNV)
        {
            return PhanQuyen_DAO.loadDSPhanQuyen_TheoMaLoaiNV_DAO(_strMaLoaiNV);
        }

        public static PhanQuyen_DTO loadPhanQuyen_TheoMaLoaiNVAndFrm_BUS(string _STR_MaLoaiNV, string _STR_MaFrm)
        {
            return PhanQuyen_DAO.loadPhanQuyen_TheoMaLoaiNVAndFrm_DAO(_STR_MaLoaiNV, _STR_MaFrm);
        }

        // Thêm 1 phần tử.
        public static bool themPhanQuyen_BUS(PhanQuyen_DTO _PQ)
        {
            return PhanQuyen_DAO.themPhanQuyen_DAO(_PQ);
        }

        // Thêm nhiều phần tử.
        public static bool themNhieuPhanQuyen_BUS(BindingList<PhanQuyen_DTO> _LST_DSPhanQuyen)
        {
            int _IN_lstDSPhanQuyen = _LST_DSPhanQuyen.Count;
            for (int _I = 0; _I < _IN_lstDSPhanQuyen; ++_I)
            {
                if (!PhanQuyen_DAO.themPhanQuyen_DAO(_LST_DSPhanQuyen[_I]))
                    return false;
            }
            return true;
        }

        // Sửa nhiều phần tử.
        public static bool suaNhieuPhanQuyen_BUS(BindingList<PhanQuyen_DTO> _LST_DSPhanQuyen)
        {
            int _IN_lstDSPhanQuyen = _LST_DSPhanQuyen.Count;
            for (int _I = 0; _I < _IN_lstDSPhanQuyen; ++_I)
            {
                if (!PhanQuyen_DAO.suaPhanQuyen_DAO(_LST_DSPhanQuyen[_I]))
                    return false;
            }
            return true;
        }
    }
}
