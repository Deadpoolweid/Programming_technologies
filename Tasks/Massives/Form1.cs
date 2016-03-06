using System;
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
            string text = tasks.ExecuteTask(n, Data.Array);
            //string[] lines = text.Split('\n');
            richTextBox1.Text = text;
        }

        private void CreateChart()
        {
            // Создаём новую область для построения графика
            ChartArea area = new ChartArea
            {
                // Даём ей имя (чтобы потом добавлять графики)
                Name = "myGraph",
                AxisX =
                {
                    // Задаём левую и правую границы оси X
                    Minimum = 0,
                    Maximum = 10,
                    // Определяем шаг сетки
                    MajorGrid = {Interval = 1}
                }
            };




            

            // Добавляем область в диаграмму
            chart1.ChartAreas.Add(area);
            // Создаём объект для первого графика
            Series series1 = new Series
            {
                ChartArea = "myGraph",
                ChartType = SeriesChartType.Column,
                BorderWidth = 3,
                LegendText = "гистограмма"
            };
            chart1.Series.Add(series1);
        }

        private void BindChart()
        {

            chart1.DataSource = Data.Array;
            chart1.DataBind();
            int[] xpoints = new int[10];
            int[] ypoints = new int[10];

            for (int i = 0; i < Data.Array.Length; i++)
            {
                xpoints[i] = i + 1;
                ypoints[i] = Data.Array[i];
            }
            chart1.Series[0].Points.DataBindXY(xpoints,ypoints);
        }

        private void сгенерироватьНовыйМассивToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Input.Generate();
            string text = Output.Out();
            string[] text1 = text.Split('\n');
            textBox1.Text = "";
            foreach (var t in text1)
            {
                textBox1.Text += t + Environment.NewLine;
            }
        }

        private void настрокиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Enabled = false;
            Settings settings = new Settings();
            settings.ShowDialog();
            Enabled = true;
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Enabled = false;
            MessageBox.Show(@"Массивы. Автор: Alex_Green ©.");
            Enabled = true;
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
