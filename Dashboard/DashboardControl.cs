using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCLBVoThuat
{
    public partial class DashboardControl : Form
    {
        public DashboardControl()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            SetInfor bm1 = new SetInfor();
            bm1.ShowDialog();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            BM2 bm2 = new BM2();
            bm2.ShowDialog();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            BM3 bm3 = new BM3();
            bm3.ShowDialog();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            BM4 bm4 = new BM4();
            bm4.ShowDialog();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            BM5 bm5 = new BM5();
            bm5.ShowDialog();
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            BM6 bm6 = new BM6();
            bm6.ShowDialog();
        }
    }
}
