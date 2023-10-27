using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;

namespace forms_bán_cá
{
    public partial class dangki : Form
    {
        private static string stringconnection = @"Data Source=DESKTOP-Q4PGA0S;Initial Catalog=""lưu thông tin"";Integrated Security=True";
 
        private void dangki_Load(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("đã đăng kí thành công");
            
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }
    }
}
