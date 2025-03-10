using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Переходы_между_формами
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(this);
            form2.Show(); 
            this.Hide(); 
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3(this);
            form3.Show(); 
            this.Hide(); 
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Form4 main = new Form4();
            main.Show();
            Hide();
        }
    }
}