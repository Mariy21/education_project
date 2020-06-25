using System;
using System.Windows.Forms;

namespace exam
{
    public partial class Main : Form
    {

        public int[] array = new int[25];
        private int min = -100;
        private int max = 100;
        public Main()
        {
            InitializeComponent();
            dataGridView_array.ColumnCount = array.Length;
            dataGridView_array.RowCount = 1;

            for (int i = 0; i < array.Length; i++)
            {
                dataGridView_array.Columns[i].Width = 29;
                dataGridView_array.Columns[i].ReadOnly = true;
            }
        }

        private void btn_toForm_Click(object sender, EventArgs e)
        {
            Second_Form _Form = new Second_Form();
            _Form.Show();
            Hide();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы уверены?", "Подтверждение", MessageBoxButtons.OKCancel) == DialogResult.OK)
                Close();
        }

        private void btn_graphClear_Click(object sender, EventArgs e)
        {
            chart_graph.Series[0].Points.Clear();
        }

        private void btn_rand_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(-100, 100);
                
                if (array[i] > min) 
                    min = array[i];
                
                if (array[i] < max) 
                    max = array[i];
                
                dataGridView_array.Rows[0].Cells[i].Value = array[i];
            }
        }

        private void btn_sort_Click(object sender, EventArgs e)
        {
            Array.Sort(array);
            Array.Reverse(array);
            for (int i = 0; i < array.Length; i++)
                    dataGridView_array.Rows[0].Cells[i].Value = array[i];
        }

        private void btn_graph_Click(object sender, EventArgs e)
        {
            int[] x = array;
            int[] y = new int[25];
            for (int i = 0; i < array.Length; i++)
            {
                y[i] = array[i];
                x[i] = i;
                chart_graph.ChartAreas[0].AxisY.MajorGrid.Interval = 1;
                chart_graph.ChartAreas[0].AxisX.MajorGrid.Interval = 2;
                chart_graph.Series[0].Points.DataBindXY(x, y);
            }
        }

        private void btn_task_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();

            int[] x = new int[25];

            for (int i = 0; i < array.Length; i++)
                x[i] = rnd.Next(-100, 100);
                
            int max = 0;
            int min = 0;

            for (int i = 0; i < x.Length; i++)            
                if (x[i] >= max)
                    max = x[i];

            for (int i = 0; i < x.Length; i++)
                if (x[i] <= min)
                    min = x[i];

            MessageBox.Show($"Максимальный элемент массива X : {max} \nМинимальный элемент массива X : {min}");

        }
    }
}
