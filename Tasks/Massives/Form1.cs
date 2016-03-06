using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            Input.Generate();
            textBox1.Text = Output.Out();
            comboBox1.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n = comboBox1.SelectedIndex+1;

            Tasks tasks = new Tasks();
            string text = tasks.ExecuteTask(n, Data.array);
            textBox2.Text = text;
        }
    }
}
