using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace forms_bán_cá
{
    public partial class mauhonuoica : Form
    {
        public mauhonuoica()
        {
            InitializeComponent();
        }

        private void label32_Click(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {
            thongtin phuckien = new thongtin();
            phuckien.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string gia = "150.000";
            string soluong = ("100");
            textBox1.Text = soluong;
            textBox2.Text = gia;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            trangchu phuckien = new trangchu();
            phuckien.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string gia = "200.000";
            string soluong = ("100");
            textBox1.Text = soluong;
            textBox2.Text = gia;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string gia = "100.000";
            string soluong = ("100");
            textBox1.Text = soluong;
            textBox2.Text = gia;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string gia = "200.000";
            string soluong = ("100");
            textBox1.Text = soluong;
            textBox2.Text = gia;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string gia = "150.000";
            string soluong = ("100");
            textBox1.Text = soluong;
            textBox2.Text = gia;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string gia = "50.000";
            string soluong = ("100");
            textBox1.Text = soluong;
            textBox2.Text = gia;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string gia = "200.000";
            string soluong = ("100");
            textBox1.Text = soluong;
            textBox2.Text = gia;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            string gia = "250.000";
            string soluong = ("100");
            textBox1.Text = soluong;
            textBox2.Text = gia;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            string gia = "50.000";
            string soluong = ("100");
            textBox1.Text = soluong;
            textBox2.Text = gia;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            string gia = "155.000";
            string soluong = ("100");
            textBox1.Text = soluong;
            textBox2.Text = gia;
        }
    }
}
