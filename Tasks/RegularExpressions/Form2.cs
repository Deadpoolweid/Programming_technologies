using System;
using System.Text.RegularExpressions;
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
            _number = number;
            InitializeComponent();
        }

        private readonly int _number;

        private void Form2_Load(object sender, EventArgs e)
        {
            textBox2.Text = Expressions.GetExpression(_number);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string txt = @textBox1.Text;

            txt = @Regex.Replace(txt,@"\\","\\");
            Expressions.Change(_number,txt);
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
