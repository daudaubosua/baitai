using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DTO;
namespace DTO
{
    public class hocsinh_DTO
    {
        private int ima;

        public int Ima
        {
            get
            {
                return ima;
            }

            set
            {
                ima = value;
            }
        }
        private string shoten;
        public string Shoten
        {
            get
            {
                return shoten;
            }
            set
            {
                shoten = value;
            }
        }
        private DateTime dtngaysinh;
        public DateTime Dtngaysinh
        {
            get
            {
                return dtngaysinh;
            }

            set
            {
                dtngaysinh = value;
            }
        }
        private string sgioitinh;
        public string Sgioitinh
        {
            get
            {
                return sgioitinh;
            }

            set
            {
                sgioitinh = value;
            }
        }
        private string sdiachi;
        public string Sdiachi
        {
            get
            {
                return sdiachi;
            }

            set
            {
                sdiachi = value;
            }
        }
        private int ilop;
        public int Ilop
        {
            get
            {
                return ilop;
            }

            set
            {
                ilop = value;
            }
        }
        private string shocluc;
        public string Shocluc
        {
            get
            {
                return shocluc;
            }

            set
            {
                shocluc = value;
            }
        }
        private string shanhkiem;
        public string Shanhkiem
        {
            get
            {
                return shanhkiem;
            }

            set
            {
                shanhkiem = value;
            }
        }
        private string schucvu;
        public string Schucvu
        {
            get
            {
                return schucvu;
            }

            set
            {
                schucvu = value;
            }
        }
        private int igiaovienchunhiem;
        public int Igiaovienchunhiem
        {
            get
            {
                return igiaovienchunhiem;
            }

            set
            {
                igiaovienchunhiem = value;
            }
        }     
    }
}