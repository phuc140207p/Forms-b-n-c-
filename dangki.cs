using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Xml.Serialization;

namespace forms_bán_cá
{
    public partial class dangki : Form
    {
        public dangki()
        {
            InitializeComponent();
        }
        public bool checAccount(String ac)//checkmat khau va ten tai khoan
        {
            return Regex.IsMatch(ac, "^[a-zA-Z]{6,24}$");
        }
        Modify modify = new Modify();

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("đã đăng kí thành công");
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
            string tentk = textBox_tentaikhoan.Text;
            string matkhau = textBox_matkhau.Text;
            string xnmatkhau = textBox_xnmatkhau.Text;
            if(checAccount(tentk)) { MessageBox.Show("vui lòng nhập mật khẩu dài khoảng 6-24 kí tự!");return; }
            if(checAccount(matkhau)) { MessageBox.Show("vui lòng nhập tên mật khẩu dài khoảng 6-24 kí tự!"); return; }
            if(xnmatkhau != xnmatkhau) { MessageBox.Show("vui lòng nhập lại mật khẩu");return; }
            try
            {
                string query = "Insert into taikhoan values('" + tentk + "','" + matkhau + "')";
                Modify.command(query);
            }
            {
            atch
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
