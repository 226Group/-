using System;
using System.Linq;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Переходы_между_формами
{
    public partial class Form2 : Form
    {
        private Form1 parentForm;

        public Form2(Form1 parentForm) 
        {
            InitializeComponent();
            this.parentForm = parentForm; 
        }


        private void buttonGenerate_Click(object sender, EventArgs e)
        {

            int sum = 0;
            if (radioButtonEven.Checked)
            {
                sum = numbers.Where(n => n % 2 == 0).Sum();
            }
            else if (radioButtonOdd.Checked)
            {
                sum = numbers.Where(n => n % 2 != 0).Sum();
            }
            else if (radioButtonAll.Checked)
            {
                sum = numbers.Sum();
            }

            labelResult.Text = " " + sum;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }


        private void button2_Click(object sender, EventArgs e)
        {

            this.Close();
            parentForm.Show();
        }

        private void Form2_FormClosed(NumericUpDown sender, FormClosedEventArgs e)
        {

            parentForm.Show();
        }

        int[] numbers = new int[0];
        Random rand = new Random();

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            uint count = ((uint)(sender as NumericUpDown).Value);

            listBoxNumbers.Items.Clear(); 
            numbers = new int[count]; 

 
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = rand.Next(0, 11);
                listBoxNumbers.Items.Add(numbers[i].ToString());
            }
        }
    }
}
