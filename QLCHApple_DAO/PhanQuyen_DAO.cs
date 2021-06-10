using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.ComponentModel;
using QLCHApple_DTO;

namespace QLCHApple_DAO
{
    public class PhanQuyen_DAO
    {
        public static BindingList<PhanQuyen_DTO> loadDSPhanQuyen_TheoMaLoaiNV_DAO(string _strMaLoaiNV)
        {
            BindingList<PhanQuyen_DTO> _lstPQ = new BindingList<PhanQuyen_DTO>();
            string strSELECT = @"SELECT DISTINCT pq.MaLoaiNV,
				                                pq.MaFrm,
                                                pq.fullCN,
				                                pq.Them,
				                                pq.Xoa,
				                                pq.Sua,
				                                pq.Xem
	                                FROM tblPhanQuyen pq
		                                WHERE pq.MaLoaiNV like '" + _strMaLoaiNV + "'";
            try
            {
                SqlConnection conn = DataProvider_DAO.taoKetNoi();
                SqlDataReader sdr = DataProvider_DAO.truyVanDuLieu(strSELECT, conn);

                while (sdr.Read())
                {
                    PhanQuyen_DTO _PQ = new PhanQuyen_DTO();
                    if (!sdr.IsDBNull(0))
                        _PQ.strMaLoaiNV = sdr["MaLoaiNV"].ToString();
                    else
                        _PQ.strMaLoaiNV = "";

                    if (!sdr.IsDBNull(1))
                        _PQ.strMaFrm = sdr["MaFrm"].ToString();
                    else
                        _PQ.strMaFrm = "";

                    if (!sdr.IsDBNull(2))
                        _PQ.bFull = Convert.ToBoolean(sdr["fullCN"]);
                    else
                        _PQ.bFull = false;

                    if (!sdr.IsDBNull(3))
                        _PQ.bThem = Convert.ToBoolean(sdr["Them"]);
                    else
                        _PQ.bThem = false;

                    if (!sdr.IsDBNull(4))
                        _PQ.bXoa = Convert.ToBoolean(sdr["Xoa"]);
                    else
                        _PQ.bXoa = false;

                    if (!sdr.IsDBNull(5))
                        _PQ.bSua = Convert.ToBoolean(sdr["Sua"]);
                    else
                        _PQ.bSua = false;

                    if (!sdr.IsDBNull(6))
                        _PQ.bXem = Convert.ToBoolean(sdr["Xem"]);
                    else
                        _PQ.bXem = false;

                    _lstPQ.Add(_PQ);
                }

                sdr.Close();
                conn.Close();
                return _lstPQ;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public static PhanQuyen_DTO loadPhanQuyen_TheoMaLoaiNVAndFrm_DAO(string _STR_MaLoaiNV, string _STR_MaFrm)
        {
            string strSELECT = @"SELECT *
	                                FROM tblPhanQuyen pq
		                                WHERE pq.MaFrm = '" + _STR_MaFrm + "' AND pq.MaLoaiNV = '" + _STR_MaLoaiNV + "'";
            try
            {
                PhanQuyen_DTO _PQ = new PhanQuyen_DTO();
                SqlConnection conn = DataProvider_DAO.taoKetNoi();
                SqlDataReader sdr = DataProvider_DAO.truyVanDuLieu(strSELECT, conn);

                if (sdr.Read())
                {
                    if (!sdr.IsDBNull(0))
                        _PQ.strMaLoaiNV = sdr["MaLoaiNV"].ToString();
                    else
                        _PQ.strMaLoaiNV = "";

                    if (!sdr.IsDBNull(1))
                        _PQ.strMaFrm = sdr["MaFrm"].ToString();
                    else
                        _PQ.strMaFrm = "";

                    if (!sdr.IsDBNull(2))
                        _PQ.bFull = Convert.ToBoolean(sdr["fullCN"]);
                    else
                        _PQ.bFull = false;

                    if (!sdr.IsDBNull(3))
                        _PQ.bThem = Convert.ToBoolean(sdr["Them"]);
                    else
                        _PQ.bThem = false;

                    if (!sdr.IsDBNull(4))
                        _PQ.bXoa = Convert.ToBoolean(sdr["Xoa"]);
                    else
                        _PQ.bXoa = false;

                    if (!sdr.IsDBNull(5))
                        _PQ.bSua = Convert.ToBoolean(sdr["Sua"]);
                    else
                        _PQ.bSua = false;

                    if (!sdr.IsDBNull(6))
                        _PQ.bXem = Convert.ToBoolean(sdr["Xem"]);
                    else
                        _PQ.bXem = false;
                }

                sdr.Close();
                conn.Close();
                return _PQ;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public static bool themPhanQuyen_DAO(PhanQuyen_DTO _PQ)
        {
            try
            {
                string _STR_INSERT = @"INSERT INTO dbo.tblPhanQuyen(MaLoaiNV, MaFrm, fullCN, Them, Xoa, Sua, Xem) VALUES(@MaLoaiNV, @MaFrm, @fullCN, @Them, @Xoa, @Sua, @Xem)";
                List<SqlParameter> _LST_Par = new List<SqlParameter>();
                _LST_Par.Add(new SqlParameter("@MaLoaiNV", _PQ.strMaLoaiNV));
                _LST_Par.Add(new SqlParameter("@MaFrm", _PQ.strMaFrm));
                _LST_Par.Add(new SqlParameter("@fullCN", _PQ.bFull));
                _LST_Par.Add(new SqlParameter("@Them", _PQ.bThem));
                _LST_Par.Add(new SqlParameter("@Xoa", _PQ.bXoa));
                _LST_Par.Add(new SqlParameter("@Sua", _PQ.bSua));
                _LST_Par.Add(new SqlParameter("@Xem", _PQ.bXem));

                SqlConnection conn = DataProvider_DAO.taoKetNoi();
                bool bKq = DataProvider_DAO.thucThiCauLenh(_STR_INSERT, _LST_Par.ToArray(), conn);

                conn.Close();

                return bKq;
            }
            catch
            {
                return false;
            }
        }

        public static bool suaPhanQuyen_DAO(PhanQuyen_DTO _PQ)
        {
            try
            {
                string _STR_INSERT = @"UPDATE dbo.tblPhanQuyen SET fullCN = @fullCN, Them = @Them, Xoa = @Xoa, Sua = @Sua, Xem = @Xem WHERE MaLoaiNV like '" + _PQ.strMaLoaiNV + "' AND MaFrm like '" + _PQ.strMaFrm + "'";
                List<SqlParameter> _LST_Par = new List<SqlParameter>();
                _LST_Par.Add(new SqlParameter("@fullCN", _PQ.bFull));
                _LST_Par.Add(new SqlParameter("@Them", _PQ.bThem));
                _LST_Par.Add(new SqlParameter("@Xoa", _PQ.bXoa));
                _LST_Par.Add(new SqlParameter("@Sua", _PQ.bSua));
                _LST_Par.Add(new SqlParameter("@Xem", _PQ.bXem));

                SqlConnection conn = DataProvider_DAO.taoKetNoi();

                bool bKq = DataProvider_DAO.thucThiCauLenh(_STR_INSERT, _LST_Par.ToArray(), conn);

                conn.Close();

                return bKq;
            }
            catch
            {
                return false;
            }
        }
    }
}
