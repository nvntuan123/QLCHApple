using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using QLCHApple_DTO;

namespace QLCHApple_DAO
{
    public class SanPhamBan_DAO
    {
        public static BindingList<SanPhamBan_DTO> loadDSSanPhamBan_MaHDB_DAO(int _I_MaHDB)
        {
            BindingList<SanPhamBan_DTO> _LST_DSSPBan = new BindingList<SanPhamBan_DTO>();
            //try
            //{
                string _STR_SELECT = @"SELECT DISTINCT sp.MaSP, sp.TenSP, sp.NamSX, sp.MaLoaiSP, cthdb.DonGia, cthdb.SoLuong, cthdb.DonGia * cthdb.SoLuong AS ThanhTien, sp.TrangThai
	                                    FROM tblSanPham sp, tblHDBan hdb, tblCTHDBan cthdb
		                                    WHERE hdb.MaHDB = cthdb.MaHDB AND sp.MaSP = cthdb.MaSP AND hdb.MaHDB = '" + _I_MaHDB + "'";

                SqlConnection conn = DataProvider_DAO.taoKetNoi();
                SqlDataReader sdr = DataProvider_DAO.truyVanDuLieu(_STR_SELECT, conn);

                while (sdr.Read())
                {
                    SanPhamBan_DTO _SPBan = new SanPhamBan_DTO();

                    if (!sdr.IsDBNull(0))
                        _SPBan.STR_MaSP = sdr["MaSP"].ToString();
                    else
                        break;

                    if (!sdr.IsDBNull(1))
                        _SPBan.STR_TenSP = sdr["TenSP"].ToString();

                    if (!sdr.IsDBNull(2))
                        _SPBan.DT_NamSX = Convert.ToDateTime(sdr["NamSX"]);

                    if (!sdr.IsDBNull(3))
                        _SPBan.STR_MaLoaiSP = sdr["MaLoaiSP"].ToString();

                    if (!sdr.IsDBNull(4))
                        _SPBan.DEC_DonGia = Convert.ToDecimal(sdr["DonGia"]);

                    if (!sdr.IsDBNull(5))
                        _SPBan.I_SoLuong = Convert.ToInt32(sdr["SoLuong"]);

                    if (!sdr.IsDBNull(6))
                        _SPBan.DEC_ThanhTien = Convert.ToDecimal(sdr["ThanhTien"]);

                    if (!sdr.IsDBNull(7))
                        _SPBan.B_TrangThai = Convert.ToBoolean(sdr["TrangThai"]);

                    _LST_DSSPBan.Add(_SPBan);
                }

                sdr.Close();
                conn.Close();
                return _LST_DSSPBan;
            //}
            //catch
            //{
            //    return _LST_DSSPBan;
            //}
        }
    }
}
