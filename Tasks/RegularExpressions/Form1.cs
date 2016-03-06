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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Expressions.SaveExpressions();
        }

        private void Check(object sender, EventArgs e)
        {
            string regex1 = Expressions.regex1;
            string regex2 = Expressions.regex2;
            string regex3 = Expressions.regex3;
            string regex4 = Expressions.regex4;
            string regex5 = Expressions.regex5;
            string regex6 = Expressions.regex6;
            string regex7 = Expressions.regex7;
            string regex8 = Expressions.regex8;
            string regex9 = Expressions.regex9;
            string regex10 = Expressions.regex10;
            string regex11 = Expressions.regex11;
            string regex12 = Expressions.regex12;
            string regex13 = Expressions.regex13;
            string regex14 = Expressions.regex14;
            string regex15 = Expressions.regex15;
            string regex16 = Expressions.regex16;


            if (Regex.IsMatch(textBox1.Text, regex1))
            {
                textBox1.ForeColor = Color.Red;
            }
            else
            {
                textBox1.ForeColor = Color.Green;
            }

            if (Regex.IsMatch(textBox2.Text, regex2))
            {
                textBox2.ForeColor = Color.Green;
            }
            else
            {
                textBox2.ForeColor = Color.Red;
            }

            if (Regex.IsMatch(textBox3.Text, regex3))
            {
                textBox3.ForeColor = Color.Green;
            }
            else
            {
                textBox3.ForeColor = Color.Red;
            }

            if (Regex.IsMatch(textBox4.Text, regex4))
            {
                textBox4.ForeColor = Color.Green;
            }
            else
            {
                textBox4.ForeColor = Color.Red;
            }

            if (Regex.IsMatch(textBox5.Text, regex5))
            {
                textBox5.ForeColor = Color.Green;
            }
            else
            {
                textBox5.ForeColor = Color.Red;
            }

            if (Regex.IsMatch(textBox6.Text, regex6))
            {
                textBox6.ForeColor = Color.Green;
            }
            else
            {
                textBox6.ForeColor = Color.Red;
            }

            if (Regex.IsMatch(textBox7.Text, regex7))
            {
                textBox7.ForeColor = Color.Green;
            }
            else
            {
                textBox7.ForeColor = Color.Red;
            }

            if (Regex.IsMatch(textBox8.Text, regex8))
            {
                textBox8.ForeColor = Color.Green;
            }
            else
            {
                textBox8.ForeColor = Color.Red;
            }

            if (Regex.IsMatch(textBox9.Text, regex9))
            {
                textBox9.ForeColor = Color.Green;
            }
            else
            {
                textBox9.ForeColor = Color.Red;
            }

            if (Regex.IsMatch(textBox10.Text, regex10))
            {
                textBox10.ForeColor = Color.Green;
            }
            else
            {
                textBox10.ForeColor = Color.Red;
            }

            if (Regex.IsMatch(textBox11.Text, regex11))
            {
                textBox11.ForeColor = Color.Green;
            }
            else
            {
                textBox11.ForeColor = Color.Red;
            }

            if (Regex.IsMatch(textBox12.Text, regex12))
            {
                textBox12.ForeColor = Color.Green;
            }
            else
            {
                textBox12.ForeColor = Color.Red;
            }

            if (Regex.IsMatch(textBox13.Text, regex13))
            {
                textBox13.ForeColor = Color.Green;
            }
            else
            {
                textBox13.ForeColor = Color.Red;
            }


            if (Regex.IsMatch(textBox14.Text, regex14))
            {
                textBox14.ForeColor = Color.Red;
            }
            else
            {
                textBox14.ForeColor = Color.Green;
            }

            if (Regex.IsMatch(textBox15.Text, regex15))
            {
                textBox15.ForeColor = Color.Green;
            }
            else
            {
                textBox15.ForeColor = Color.Red;
            }


            if (Regex.IsMatch(textBox16.Text, regex16))
            {
                textBox16.ForeColor = Color.Red;
                //MessageBox.Show(@"Удалить повторения?", @"Предупреждение", MessageBoxButtons.YesNo);
                Regex.Replace("", textBox16.Text, regex16);
            }
            else
            {
                textBox16.ForeColor = Color.Green;

            }
        }

        private void RestoreAll(object sender, EventArgs e)
        {
            Expressions.RestoreExpressions();
            MessageBox.Show(@"Все выражения восстановлены.");
        }

        void Change(int number)
        {
            Form2 f = new Form2(number);
            this.Enabled = false;
            f.ShowDialog();
            this.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Change(1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Change(3);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Change(2);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Change(4);

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Change(5);

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Change(6);

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Change(7);

        }

        private void button8_Click(object sender, EventArgs e)
        {
            Change(8);

        }

        private void button9_Click(object sender, EventArgs e)
        {
            Change(9);

        }

        private void button10_Click(object sender, EventArgs e)
        {
            Change(10);

        }

        private void button11_Click(object sender, EventArgs e)
        {
            Change(11);

        }

        private void button12_Click(object sender, EventArgs e)
        {
            Change(12);

        }

        private void button13_Click(object sender, EventArgs e)
        {
            Change(13);

        }

        private void button14_Click(object sender, EventArgs e)
        {
            Change(14);

        }

        private void button15_Click(object sender, EventArgs e)
        {
            Change(15);

        }

        private void button16_Click(object sender, EventArgs e)
        {
            Change(16);

        }
    }
}
