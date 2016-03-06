using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Massives
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Input._Settings();
            Input.Generate();
            string text = Output.Out();
            string[] text1 = text.Split('\n');
            foreach (var t in text1)
            {
                textBox1.Text += t + Environment.NewLine;
            }
            comboBox1.SelectedIndex = 0;
            CreateChart();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n = comboBox1.SelectedIndex+1;
            if (n == 16)
            {
                BindChart();
                return;
            }
            Tasks tasks = new Tasks();
            string text = tasks.ExecuteTask(n, Data.array);
            //string[] lines = text.Split('\n');
            richTextBox1.Text = text;
        }

        private void CreateChart()
        {
            // Создаём новую область для построения графика
            ChartArea area = new ChartArea();
            // Даём ей имя (чтобы потом добавлять графики)
            area.Name = "myGraph";

            // Задаём левую и правую границы оси X
            area.AxisX.Minimum = 0;
            area.AxisX.Maximum = 10;

            // Определяем шаг сетки
            area.AxisX.MajorGrid.Interval = 1;

            // Добавляем область в диаграмму
            chart1.ChartAreas.Add(area);
            // Создаём объект для первого графика
            Series series1 = new Series();
            // Ссылаемся на область для построения графика
            series1.ChartArea = "myGraph";
            // Задаём тип графика - сплайны
            series1.ChartType = SeriesChartType.Column;
            // Указываем ширину линии графика
            series1.BorderWidth = 3;
            // Название графика для отображения в легенде
            series1.LegendText = "гистограмма";
            // Добавляем в список графиков диаграммы
            chart1.Series.Add(series1);
        }

        private void BindChart()
        {

            chart1.DataSource = Data.array;
            chart1.DataBind();
            int[] Xpoints = new int[10];
            int[] Ypoints = new int[10];

            for (int i = 0; i < Data.array.Length; i++)
            {
                Xpoints[i] = i + 1;
                Ypoints[i] = Data.array[i];
            }
            chart1.Series[0].Points.DataBindXY(Xpoints,Ypoints);
        }

        private void сгенерироватьНовыйМассивToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Input.Generate();
            textBox1.Text = Output.Out();
        }

        private void настрокиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            Settings settings = new Settings();
            settings.ShowDialog();
            Enabled = true;
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            MessageBox.Show("Массивы. Автор: Alex_Green ©.");
            this.Enabled = true;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 15)
            {
                chart1.BringToFront();
            }
            else
            {
                chart1.SendToBack();
            }
        }
    }
}
