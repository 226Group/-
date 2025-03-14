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


    int[,] array = new int[0,0];
        private void buttonFillArray_Click(object sender, EventArgs e)
        {
            int rows = (int)numericUpDown1.Value;
            int cols = (int)numericUpDown2.Value;
            
            array = new int[rows, cols];
            Random rand = new Random();

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    array[i, j] = rand.Next(100); 
                }
            }
            //Array.Copy(array,new_array,);
            //better type systems eliminate runtime errors faster

            //for (int i = 0; i < rows; i++)
            //{
            //    for (int j = 0; j < cols; j++)
            //    {
            //        int? x = (int?)array.GetValue(i, j);
            //        if (x.HasValue)
            //        {
            //            new_array.SetValue(x.Value, new int[] { i, j });
            //        }
            //    }
            //}
            //this.array = new_array;


            DisplayArray();
        }

        private void DisplayArray()
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();

            for (int j = 0; j < array.GetLength(1); j++)
            {
                dataGridView1.Columns.Add($"Column{j}", $"Столбец {j + 1}");
            }


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
            if (array.Length == 0)
            {
                MessageBox.Show("Таблица пуста. Заполните массив сначала.");
                return;
            }

            
            for (int i = 0; i < array.GetLength(0); i++)
            {
                int count = 0;

                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[i,j] % 2 == 0)
                    {
                        count++;
                    }
                }

            if (!dataGridView1.Columns.Contains("CountEvenNumbers"))
            {
                dataGridView1.Columns.Add("CountEvenNumbers", "Количество четных");
            }
            dataGridView1.Rows[i].Cells["CountEvenNumbers"].Value = count;
            }
        }

        private void buttonSumInRow_Click(object sender, EventArgs e)
        {
            if (array.Length == 0)
            {
                MessageBox.Show("Таблица пуста. Заполните массив сначала.");
                return;
            }

            for (int i = 0; i < array.GetLength(0); i++)
            {

                int min = int.MaxValue; // мин = макс значение

                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[i,j] < min)
                    {
                        min = array[i, j]; // Обновляем минимум
                    }
                }

                if (!dataGridView1.Columns.Contains("MinInRow"))
                {
                    dataGridView1.Columns.Add("MinInRow", "Минимальное число");
                }

                dataGridView1.Rows[i].Cells["MinInRow"].Value = min;

            
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

    }

}