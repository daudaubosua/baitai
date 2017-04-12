using System.Data;
using DTO1;
using System.Data.SqlClient;
using DAO1;

namespace BUS1
{
    public class giaovien_BUS1
    {
        private static object giaovien_DAO1;

        //LOAD giao vien
        public static DataTable loadsgiaovien()
        {
            //khai bao cau truy vaasn
            DataTable dt = new DataTable();
            string struyvan = $"select * from giaovien";
            using (SqlConnection conn = DataProvider1.KetNoi())
            {
                SqlDataAdapter da = new SqlDataAdapter(struyvan, conn);
                da.Fill(dt);
            }
            return dt;
        }
    }
}
