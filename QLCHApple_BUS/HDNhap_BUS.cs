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
    public class HDNhap_BUS
    {
        // Lấy ra mã cao nhất trong bảng hóa đơn nhập.
        public static int layHDNhap_CaoNhat_BUS()
        {
            return HDNhap_DAO.layHDNhap_CaoNhat_DAO() + 1;
        }

        public static bool themHDNhap_BUS(HDNhap_DTO _HDNhap)
        {
            return HDNhap_DAO.themHDNhap_DAO(_HDNhap);
        }

        // Lay ra danh sach hoa nhap ban tu ngay A -> ngay B
        public static BindingList<HDNhap_DTO> _LST_DSHDNhap_FromToDate_BUS(DateTime _DT_FromDate, DateTime _DT_ToDate)
        {
            return HDNhap_DAO._LST_DSHDNhap_FromToDate_DAO(_DT_FromDate, _DT_ToDate);
        }
    }
}
