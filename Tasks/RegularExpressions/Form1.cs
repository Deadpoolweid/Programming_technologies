using System;
using System.Drawing;
using System.Text.RegularExpressions;
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
            string regex1 = Expressions.Regex1;
            string regex2 = Expressions.Regex2;
            string regex3 = Expressions.Regex3;
            string regex4 = Expressions.Regex4;
            string regex5 = Expressions.Regex5;
            string regex6 = Expressions.Regex6;
            string regex7 = Expressions.Regex7;
            string regex8 = Expressions.Regex8;
            string regex9 = Expressions.Regex9;
            string regex10 = Expressions.Regex10;
            string regex11 = Expressions.Regex11;
            string regex12 = Expressions.Regex12;
            string regex13 = Expressions.Regex13;
            string regex14 = Expressions.Regex14;
            string regex15 = Expressions.Regex15;
            string regex16 = Expressions.Regex16;


            textBox1.ForeColor = Regex.IsMatch(textBox1.Text, regex1) ? Color.Red : Color.Green;

            textBox2.ForeColor = Regex.IsMatch(textBox2.Text, regex2) ? Color.Green : Color.Red;

            textBox3.ForeColor = Regex.IsMatch(textBox3.Text, regex3) ? Color.Green : Color.Red;

            textBox4.ForeColor = Regex.IsMatch(textBox4.Text, regex4) ? Color.Green : Color.Red;

            textBox5.ForeColor = Regex.IsMatch(textBox5.Text, regex5) ? Color.Green : Color.Red;

            textBox6.ForeColor = Regex.IsMatch(textBox6.Text, regex6) ? Color.Green : Color.Red;

            textBox7.ForeColor = Regex.IsMatch(textBox7.Text, regex7) ? Color.Green : Color.Red;

            textBox8.ForeColor = Regex.IsMatch(textBox8.Text, regex8) ? Color.Green : Color.Red;

            textBox9.ForeColor = Regex.IsMatch(textBox9.Text, regex9) ? Color.Green : Color.Red;

            textBox10.ForeColor = Regex.IsMatch(textBox10.Text, regex10) ? Color.Green : Color.Red;

            textBox11.ForeColor = Regex.IsMatch(textBox11.Text, regex11) ? Color.Green : Color.Red;

            textBox12.ForeColor = Regex.IsMatch(textBox12.Text, regex12) ? Color.Green : Color.Red;

            textBox13.ForeColor = Regex.IsMatch(textBox13.Text, regex13) ? Color.Green : Color.Red;


            textBox14.ForeColor = Regex.IsMatch(textBox14.Text, regex14) ? Color.Red : Color.Green;

            textBox15.ForeColor = Regex.IsMatch(textBox15.Text, regex15) ? Color.Green : Color.Red;


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

        private void Change(int number)
        {
            Form2 f = new Form2(number);
            Enabled = false;
            f.ShowDialog();
            Enabled = true;
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
