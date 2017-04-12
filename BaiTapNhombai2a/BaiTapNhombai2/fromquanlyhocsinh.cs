using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using BUS;
using DTO;

namespace BaiTapNhombai2
{
    public partial class fromquanlyhocsinh : Form
    {
        public fromquanlyhocsinh()
        {
            InitializeComponent();
        }
        //DataView dv;

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txttimkiem_Click(object sender, EventArgs e)
        {
            txttimkiem.Text = "";

        }

        private void btthem_Click(object sender, EventArgs e)
        {

        }

        private void frmquanlyhocsinh_load(object sender, EventArgs e)
        {
            //load du lieju cho control data gridview
            LoadDgvhocsinh();
        }
        private void LoadDgvhocsinh()
        {
            dgvdanhsachhocsinh.DataSource = hocsinh_BUS.loadshocsinh();  
        }

        private void txttimkiemgv_TextChanged(object sender, EventArgs e)
        {
           
        }
    }
}
