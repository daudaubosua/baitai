using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DTO;
using System.Data;

namespace DAO
{
    public class hocsinh_DAO
    {
        //tao mot connectstion
        //SqlConnection con;
        //load hocsinh
        public static DataTable Loadhocsinh()
        {
            //khai bao cau truy vaasn
            DataTable dt = new DataTable();
            string struyvan = $"select * from hocsinh";
            using (SqlConnection conn = DataProvider.KetNoi())
            {
                SqlDataAdapter da = new SqlDataAdapter(struyvan, conn);
                da.Fill(dt);
            }
            return dt;
        }
    }
}
