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
    public partial class cathuysinh : Form
    {
        public cathuysinh()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String tenloaica = "Tỳ bà bướm ";
            String gia = "15.000";
            String nguongoc = "Cá Tỳ Bà Bướm thuộc dòng cá cảnh tương đối dễ nuôi, chúng có nguồn gốc ở Việt Nam chúng phân bổ ở các con sông, suối miền trung bộ. Cũng có tài liệu nói rằng chúng được tìm thấy ở khu vực dưới thác Khone trên sông Mekong.";
            textBox1.Text = tenloaica;
            textBox2.Text = gia;
            textBox4.Text = nguongoc;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            String tenloaica = "kim cương đỏ";
            String gia = "25.000";
            String nguongoc = "Cá kim cương đỏ có tên tiếng Anh là Jewel Fish thuộc họ Cichlidae có nguồn gốc tây châu Phi, được du nhập vào Việt Nam từ những năm 90, chúng còn có tên là hồng kim cương.";
            textBox1.Text = tenloaica;
            textBox2.Text = gia;
            textBox4.Text = nguongoc;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            String tenloaica = "Hồng kiếm koi";
            String gia = "20.000";
            String nguongoc = "Cá Hồng Mi Kiếm Koi có tên khoa học là Xiphophorus Helleri - là một giống cá cảnh nhiệt đới có nguồn gốc ở Nam Mỹ.";
            textBox1.Text = tenloaica;
            textBox2.Text = gia;
            textBox4.Text = nguongoc;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            String tenloaica = "Hồng mi Ấn Độ";
            String gia = "100.000";
            String nguongoc = "Do có nguồn gốc từ Ấn Độ, nên ở Việt Nam, dòng cá này còn được người chơi gọi với cái tên Cá Hồng Mi Ấn Độ.";
            textBox1.Text = tenloaica;
            textBox2.Text = gia;
            textBox4.Text = nguongoc;

        }

        private void button5_Click(object sender, EventArgs e)
        {
            String tenloaica = "Diếc anh đào";
            String gia = "15.000";
            String nguongoc = "Cá Diếc Anh Đào là loài cá nước ngọt thuộc họ Cyprinidae (cá chép). Nó có nguồn gốc từ Sri Lanka và du nhập sang Mexico và Colombia. Cá Diếc Anh Đào được thương mại hoá trong ngành cá cảnh vào những năm 1929";
            textBox1.Text = tenloaica;
            textBox2.Text = gia;
            textBox4.Text = nguongoc;

        }

        private void button10_Click(object sender, EventArgs e)
        {
            String tenloaica = "TT Châu Phi";
            String gia = "50.000";
            String nguongoc = "Nguồn gốc cá tai tượng Châu Phi\r\nCá tai tượng châu Phi được tìm thấy ở các vùng của Nam Mỹ, bao gồm Argentina, Brazil, Colombia, Paraguay, Peru, Uruguay và Venezuela.";
            textBox1.Text = tenloaica;
            textBox2.Text = gia;
            textBox4.Text = nguongoc;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            String tenloaica = "Neon";
            String gia = "10.000";
            String nguongoc = "Cá neon vua, cá neon đỏ hay cá tetra hồng y (Paracheirodon axelrodi) là một loài cá nước ngọt thuộc họ Characidae, bộ Cá chép mỡ. Nó có nguồn gốc từ thượng nguồn sông Orinoco và sông Negro ở Nam Mỹ.";
            textBox1.Text = tenloaica;
            textBox2.Text = gia;
            textBox4.Text = nguongoc;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            String tenloaica = "cá cầu vòng xanh";
            String gia = "5.000";
            String nguongoc = "Cá la hán có nguồn gốc xuất xứ từ Malaysia, được lai tạo từ cá hồng két cùng dòng cá hiếm ở Mỹ. ";
            textBox1.Text = tenloaica;
            textBox2.Text = gia;
            textBox4.Text = nguongoc;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            String tenloaica = "Bống mắt tre";
            String gia = "5.000";
            String nguongoc = "Có nguồn gốc từ Thái Lan và Indonesia. Thông thường, chúng được tìm thấy ở các cửa sông và đầm lầy. Ngoài tên gọi là Cá Bống Mắt Tre, chúng còn được gọi là Cá Bống Ong. Như tên gọi của nó, loài này có ngoại hình tương tự như ong vò vẽ. ";
            textBox1.Text = tenloaica;
            textBox2.Text = gia;
            textBox4.Text = nguongoc;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            String tenloaica = "Cá chuột ";
            String gia = "15.000";
            String nguongoc = "là một loài cá Corydoras nhỏ thuộc họ cá (Callichthyidae). Loài này có nguồn gốc từ lưu vực sông Xingu ở Brasil ";
            textBox1.Text = tenloaica;
            textBox2.Text = gia;
            textBox4.Text = nguongoc;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            thongtin phuckien = new thongtin();
            phuckien.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            thongtin phuckien = new thongtin();
            phuckien.Show();
        }
    }
    }
    

