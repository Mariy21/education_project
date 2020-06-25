using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exam
{
    public partial class Second_Form : Form
    {
        public Second_Form()
        {
            InitializeComponent();
        }

        private void справкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Данная программа предназначена для работы с одномерными массивами", "Справка");
        }

        private void примичаниеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Разработанная программа помогла понять разработчику (т.е. мне) особенности внутреннего представления ,способов генерации и вывода одномерных массивов , научиться выполнять объявления инициализирующих генерацию и вывод массивов при решении задач на языке C#", "Примечание разработчику");
        }

        private void btn_toForm_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            main.Show();
            Hide();
        }
    }
}
