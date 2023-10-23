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
    public partial class thongtin : Form
    {
        private string _message;
        public thongtin()
        {
            InitializeComponent();
        }
        public string Message
        {
            get { return _message; }
            set { _message = value; }
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            lblllll.Text = _message;
        }
        private void LoadData(string data)
        {

            
        }
      
        private void button1_Click(object sender, EventArgs e)
        {
           
           
        }

        private void txtdata_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void thongtin_Load(object sender, EventArgs e)
        {

        }

    }
    
}
