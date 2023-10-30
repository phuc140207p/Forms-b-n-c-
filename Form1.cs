using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
        Modify modify = new Modify();

        private void button1_Click(object sender, EventArgs e)
        {
 
            String tendn = textBox_taikhoan.Text;
            String matkhau = textBox_matkhau.Text;
            if (tendn.Trim() =="") { MessageBox.Show("Vui lòng nhập tên tài khoản!"); }
            else if (matkhau.Trim() =="") {MessageBox.Show("vui lòng nhập mật khẩu!"); }
            else
            {
                String query = "select * from taikhoan where tentaikhoan = '" +tendn+ "' and Matkhau = '"+matkhau+"' ";
                if(modify.taikhoans(query).Count>0)
                {
                    MessageBox.Show("đăng nhập thành công!");
                }
                else
                {
                    MessageBox.Show("tên đăng nhập hoặc mật khẩu không đúng!");
                }
                if (textBox_taikhoan.Text == "phuckien" && textBox_matkhau.Text == "2222")
                {
                    trangchu hello = new trangchu();
                    hello.Show();
                    this.Hide();

                }
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
