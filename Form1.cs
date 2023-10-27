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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void gIỚITHIỆUToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gioithieu gioithieu = new gioithieu();
            gioithieu.Show();
        }

        private void kIÊNTHỨCNUICÁToolStripMenuItem_Click(object sender, EventArgs e)
        {
            kienthucnuoica kienthucnuoica = new kienthucnuoica();
            kienthucnuoica.Show();
        }

        private void mẪUHỒNUICÁToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mauhonuoica mauhonuoica = new mauhonuoica();
            mauhonuoica.Show();
        }

        private void vToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cathuysinh cathuysinh = new cathuysinh();
            cathuysinh.Show();
        }

        private void cÁRỒNGToolStripMenuItem_Click(object sender, EventArgs e)
        {
            casanmoi casanmoi = new casanmoi();
            casanmoi.Show();
        }

        private void cÁToolStripMenuItem_Click(object sender, EventArgs e)
        {
            caloccanh caloccanh = new caloccanh();
            caloccanh.Show();
        }

        private void cÁCOIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cakoi cakoi = new cakoi();
            cakoi.Show();
        }

        private void tHOÁTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == "phuckien" && textBox2.Text =="2222")
            {
                trangchu hello = new trangchu();
                hello.Show();
                this.Hide();



            }    
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dangki dangki = new dangki();
            dangki.Show();
            this.Hide();
        }
    }
}
