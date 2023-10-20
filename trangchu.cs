using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace forms_bán_cá
{
    public partial class trangchu : Form
    {
        public trangchu()
        {
            InitializeComponent();
        }

        private void gIỚITHIỆUToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gioithieu phuckien = new gioithieu();
            phuckien.Show();
            this.Hide();
        }

        private void tHOÁTToolStripMenuItem_Click(object sender, EventArgs e)
        {
           this.Close();
        }

        private void vToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cathuysinh phuckien = new cathuysinh();
            phuckien.Show();
            this.Hide();
        }

        private void cÁRỒNGToolStripMenuItem_Click(object sender, EventArgs e)
        {
            casanmoi phuckien = new casanmoi();
            phuckien.Show(); this.Hide();
        }

        private void cÁToolStripMenuItem_Click(object sender, EventArgs e)
        {
            caloccanh phuckien = new caloccanh();
            phuckien.Show();
            this.Hide();
        }

        private void cÁCOIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cakoi phuckien = new cakoi();
            phuckien.Show();
            this.Hide();
        }
    }
}
