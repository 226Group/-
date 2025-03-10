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
            // Получаем строку из textBox1 и разбиваем её на массив чисел
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

            // Проверяем, какой RadioButton выбран и выполняем соответствующее вычисление
            if (radioButtonMin.Checked)
            {
                double min = numbers.Min();
                listBoxResults.Items.Add($"Минимальное значение: {min}");
            }
            else if (radioButtonMax.Checked)
            {
                double max = numbers.Max();
                listBoxResults.Items.Add($"Максимальное значение: {max}");
            }
            else if (radioButtonAvg.Checked)
            {
                double avg = numbers.Average();
                listBoxResults.Items.Add($"Среднее значение: {avg}");
            }
            else if (radioButtonSum.Checked)
            {
                double sum = numbers.Sum();
                listBoxResults.Items.Add($"Сумма: {sum}");
            }
            else
            {
                MessageBox.Show("Выберите действие для вычисления.");
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            // Логика для кнопки "Назад" (например, закрыть форму или вернуться на предыдущий экран)
            this.Close(); // Закрывает текущее окно
        }
    }
}
