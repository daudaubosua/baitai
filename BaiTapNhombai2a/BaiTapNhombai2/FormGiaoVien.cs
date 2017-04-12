using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using DTO1;
using BUS1;
using System.Collections.Generic;

namespace BaiTapNhombai2
{
    public partial class FormGiaoVien : Form
    {
        public FormGiaoVien()
        {
            InitializeComponent();
            Load += frmgiaovien_load;
        }
        private void frmgiaovien_load(object sender, EventArgs e)
        {
            //load du lieju cho control data gridview
            LoadDgvgiaovien();
        }

        private void LoadDgvgiaovien()
        {
            dgvgiaovien.DataSource = giaovien_BUS1.loadsgiaovien();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txttimkiem_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btntimkiem_Click(object sender, EventArgs e)
        {
            txttimkiemgv.Text = "";
        }
    }
}
