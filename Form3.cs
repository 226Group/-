using System;
using System.Windows.Forms;

namespace Переходы_между_формами
{
    public partial class Form3 : Form
    {
        private Form1 parentForm; 

        public Form3(Form1 parentForm) 
        {
            InitializeComponent();
            this.parentForm = parentForm;
            this.FormClosed += new FormClosedEventHandler(Form3_FormClosed); 
        }
        private void button3_Click(object sender, EventArgs e)
        {

            Form1 main = new Form1();
            main.Show();
            Hide();

        }

        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit(); 
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void buttonFillArray_Click(object sender, EventArgs e)
        {
            int rows = (int)numericUpDown1.Value;
            int cols = (int)numericUpDown2.Value;

            int[,] array = new int[rows, cols];
            Random rand = new Random();

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    array[i, j] = rand.Next(100); 
                }
            }

            DisplayArray(array);
        }

        private void DisplayArray(int[,] array)
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();

            for (int j = 0; j < array.GetLength(1); j++)
            {
                dataGridView1.Columns.Add($"Column{j}", $"Столбец {j + 1}");
            }

            // Минимум в строке
            dataGridView1.Columns.Add("MinInRow", "Минимум в строке");

            for (int i = 0; i < array.GetLength(0); i++)
            {
                var row = new DataGridViewRow();
                row.CreateCells(dataGridView1);

                for (int j = 0; j < array.GetLength(1); j++)
                {
                    row.Cells[j].Value = array[i, j];
                }

                dataGridView1.Rows.Add(row);
            }
        }

        private void buttonCountEvenNumbers_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("Таблица пуста. Заполните массив сначала.");
                return;
            }

            if (!dataGridView1.Columns.Contains("CountEvenNumbers"))
            {
                dataGridView1.Columns.Add("CountEvenNumbers", "Количество четных");
            }

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                int count = 0;
                bool isEmptyRow = true; // проверка пустой строки

                for (int j = 0; j < dataGridView1.Columns.Count; j++)
                {
                    if (dataGridView1.Columns[j].HeaderText.StartsWith("Столбец")) // Проверка заголовка
                    {
                        if (int.TryParse(dataGridView1.Rows[i].Cells[j].Value?.ToString(), out int cellValue))
                        {
                            isEmptyRow = false; // Строка не пустая
                            if (cellValue % 2 == 0)
                            {
                                count++;
                            }
                        }
                    }
                }

                if (!isEmptyRow) // Если строка не пустая пишем результат
                {
                    dataGridView1.Rows[i].Cells["CountEvenNumbers"].Value = count;
                }
                else
                {
                    dataGridView1.Rows[i].Cells["CountEvenNumbers"].Value = "Пустая строка";
                }
            }
        }

        private void buttonSumInRow_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("Таблица пуста. Заполните массив сначала.");
                return;
            }

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                int min = int.MaxValue; // мин = макс значение
                bool isEmptyRow = true; // проверка пустой строки

                for (int j = 0; j < dataGridView1.Columns.Count; j++)
                {
                    if (dataGridView1.Columns[j].HeaderText.StartsWith("Столбец")) // Проверка заголовка
                    {
                        if (int.TryParse(dataGridView1.Rows[i].Cells[j].Value?.ToString(), out int cellValue))
                        {
                            isEmptyRow = false; // Строка не пустая
                            if (cellValue < min)
                            {
                                min = cellValue; // Обновляем минимум
                            }
                        }
                    }
                }

                if (!isEmptyRow) // Если строка не пустая  пишем результат
                {
                    dataGridView1.Rows[i].Cells["MinInRow"].Value = min;
                }

            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonCountEvenNumbers_Click_1(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("Таблица пуста. Заполните массив сначала.");
                return;
            }

            // проверка есть ли "CountEvenNumbers"
            if (!dataGridView1.Columns.Contains("CountEvenNumbers"))
            {
                dataGridView1.Columns.Add("CountEvenNumbers", "Количество четных");
            }

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                int count = 0;
                bool isEmptyRow = true; // Флаг для проверки пустой строки

                for (int j = 0; j < dataGridView1.Columns.Count; j++)
                {
                    if (dataGridView1.Columns[j].HeaderText.StartsWith("Столбец")) // Проверка заголовка
                    {
                        if (int.TryParse(dataGridView1.Rows[i].Cells[j].Value?.ToString(), out int cellValue))
                        {
                            isEmptyRow = false; // Строка не пустая
                            if (cellValue % 2 == 0)
                            {
                                count++;
                            }
                        }
                    }
                }

                if (!isEmptyRow) // Если строка не пустая пишем результат
                {
                    dataGridView1.Rows[i].Cells["CountEvenNumbers"].Value = count;
                }

            }


        }
    }

}