using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DAO
{
    public class DataProvider
    {
        //ket noi
        public static SqlConnection KetNoi()
        {
            String sChuoiKetNoi = @"Data Source=.\SQLEXPRESS;Initial Catalog=quanlihocsinh;Integrated Security=True";
            SqlConnection con = new SqlConnection(sChuoiKetNoi);
            con.Open();
            return con;
        }
       //dong ket noi
       public static void DongKetNoi(SqlConnection con)
        {
            con.Close();
        } 
        //Lay datatable
      public static DataTable LayDataTable(string sTruyVan,SqlConnection con)
        {
            SqlDataAdapter da = new SqlDataAdapter(sTruyVan, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        } 
        public static bool ThucThiTruyVanNionQuery(string sTruyVan,SqlConnection con)
        {
           
            try
            {
                SqlCommand com = new SqlCommand(sTruyVan, con);
                com.ExecuteNonQuery();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
