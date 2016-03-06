using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegularExpressions
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public Form2(int number)
        {
            this.number = number;
            InitializeComponent();
        }

        private int number;

        private void Form2_Load(object sender, EventArgs e)
        {
            textBox2.Text = Expressions.GetExpression(number);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string txt = @textBox1.Text;

            txt = @Regex.Replace(txt,@"\\","\\");
            Expressions.Change(number,txt);
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
