using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace QLCHApple_DAO
{
    class DataProvider_DAO
    {
        public static string strConnect = @"Data Source=DESKTOP-BKVBUBB\SQLEXPRESS;Initial Catalog=QLCHAPPLE1;Integrated Security=True";

        // Tạo đối tượng kết nối.
        public static SqlConnection taoKetNoi()
        {
            SqlConnection conn = new SqlConnection(strConnect);
            conn.Open();
            return conn;
        }

        // Thực thi câu truy vấn.
        public static SqlDataReader truyVanDuLieu(string strTruyVan, SqlConnection conn)
        {
            SqlCommand cmd = new SqlCommand(strTruyVan, conn);
            SqlDataReader sdr = cmd.ExecuteReader();
            return sdr;
        }

        // Thực thi câu truy vấn có parameters.
        public static SqlDataReader truyVanDuLieu(string strTruyVan, SqlParameter[] parameters, SqlConnection conn)
        {
            SqlCommand cmd = new SqlCommand(strTruyVan, conn);
            cmd.Parameters.AddRange(parameters);
            SqlDataReader sdr = cmd.ExecuteReader();
            return sdr;
        }

        // Thực thi câu lệnh cập nhật dữ liệu.
        public static bool thucThiCauLenh(string strTruyVan, SqlConnection conn)
        {
            SqlCommand cmd = new SqlCommand(strTruyVan, conn);
            int iKq = cmd.ExecuteNonQuery();
            return (iKq != 0);
        }

        // Thực thi câu lệnh cập nhật dữ liệu có parameters.
        public static bool thucThiCauLenh(string strTruyVan, SqlParameter[] parameters, SqlConnection conn)
        {
            SqlCommand cmd = new SqlCommand(strTruyVan, conn);
            cmd.Parameters.AddRange(parameters);
            int iKq = cmd.ExecuteNonQuery();
            return (iKq != 0);
        }
    }
}
