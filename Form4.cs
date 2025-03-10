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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {

            Form1 main = new Form1();
            main.Show();
            Hide();

        }


        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            
            string input = textBox1.Text;
            if (string.IsNullOrWhiteSpace(input))
            {
                MessageBox.Show("Введите элементы массива через пробел.");
                return;
            }

            // Преобразуем строку в массив чисел
            double[] numbers;
            try
            {
                numbers = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                               .Select(double.Parse)
                               .ToArray();
            }
            catch (FormatException)
            {
                MessageBox.Show("Некорректный ввод. Убедитесь, что вы вводите только числа.");
                return;
            }

            // Очищаем ListBox перед выводом результата
            listBoxResults.Items.Clear();

            // выбранный radiobutton
            if (radioButtonMin.Checked)
            {
                double min = numbers.Min();
                listBoxResults.Items.Add($"{min}");
            }
            else if (radioButtonMax.Checked)
            {
                double max = numbers.Max();
                listBoxResults.Items.Add($"{max}");
            }
            else if (radioButtonAvg.Checked)
            {
                double avg = numbers.Average();
                listBoxResults.Items.Add($"{avg}");
            }
            else if (radioButtonSum.Checked)
            {
                double sum = numbers.Sum();
                listBoxResults.Items.Add($"{sum}");
            }
        }

        private void buttonBack_Click_1(object sender, EventArgs e)
        {
            Form1 main = new Form1();
            main.Show();
            Close();
        }
    }
}
