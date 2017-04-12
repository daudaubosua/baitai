using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTapNhombai2
{
    public partial class frmchinh : Form
    {
        public frmchinh()
        {
            InitializeComponent();
        }

        private void quảnLsyGiáoViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormGiaoVien frmgiaovien = new FormGiaoVien();
            frmgiaovien.Show();

        }

        private void quảnLýHọcSinhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fromquanlyhocsinh frmquanlyhocsinh = new fromquanlyhocsinh();
            frmquanlyhocsinh.Show();

        }
    }
}
