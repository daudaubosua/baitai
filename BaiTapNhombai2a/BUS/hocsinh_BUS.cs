using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DTO;
using DAO;

namespace BUS
{
    public class hocsinh_BUS
    {
        //load hocsinh
        public static DataTable loadshocsinh()
        {

            return hocsinh_DAO.Loadhocsinh();
        }
    }
}
