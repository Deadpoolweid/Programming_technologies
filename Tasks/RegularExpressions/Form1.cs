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

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void Check(object sender, EventArgs e)
        {
            string regex1 = "^\\D$";
            if (Regex.IsMatch(textBox1.Text, regex1))
            {
                textBox1.ForeColor = Color.Red;
            }
            else
            {
                textBox1.ForeColor = Color.Green;
            }

            string regex2 = "^([-+]?(?:\\d+|\\d*(?:\\.\\d+)?(?:[Ee][+-]?\\d+)?))?([-+])?(\\d+|\\d*(?:\\.\\d+)?(?:[Ee][+-]?\\d+)?)?[ij]$";
            if (Regex.IsMatch(textBox2.Text, regex2))
            {
                textBox2.ForeColor = Color.Green;
            }
            else
            {
                textBox2.ForeColor = Color.Red;
            }

            string regex3 = "^[0-9]+[\\,\\.][0-9][0-9]$";
            if (Regex.IsMatch(textBox3.Text, regex3))
            {
                textBox3.ForeColor = Color.Green;
            }
            else
            {
                textBox3.ForeColor = Color.Red;
            }

            string regex4 = "^[-]?\\d+$";
            if (Regex.IsMatch(textBox4.Text, regex4))
            {
                textBox4.ForeColor = Color.Green;
            }
            else
            {
                textBox4.ForeColor = Color.Red;
            }

            string regex5 = "^[\\d]{6}$";
            if (Regex.IsMatch(textBox5.Text, regex5))
            {
                textBox5.ForeColor = Color.Green;
            }
            else
            {
                textBox5.ForeColor = Color.Red;
            }

            string regex6 = "^[A-Z][a-z]* obl., g. [A-Z][a-z]+, ul. [A-Z][a-z]+, d. [0-9]+$";
            if (Regex.IsMatch(textBox6.Text, regex6))
            {
                textBox6.ForeColor = Color.Green;
            }
            else
            {
                textBox6.ForeColor = Color.Red;
            }

            string regex7 = "^<(([^>]|\\n)*)>$";
            if (Regex.IsMatch(textBox7.Text, regex7))
            {
                textBox7.ForeColor = Color.Green;
            }
            else
            {
                textBox7.ForeColor = Color.Red;
            }

            string regex8 = "(https?:\\/\\/)?(www\\.)?[-а-яa-z0-9_\\.]{2,}\\.(рф|[a-z]{2,6})((\\/[-а-яa-z0-9_]\\/|[-а-яa-z0-9_]{2,}" + 
                "\\.(рф|[a-z]{2,6}))|(\\/[-а-яa-z0-9_]\\/[-а-яa-z0-9_]{2,}\\.(рф|[a-z]{2,6})))(\\?[a-z0-9_]{2,}=[-0-9]{1,})?(\\&[a-z0-9_]{2,}=[-0-9]{1,})?";
            if (Regex.IsMatch(textBox8.Text, regex8))
            {
                textBox8.ForeColor = Color.Green;
            }
            else
            {
                textBox8.ForeColor = Color.Red;
            }

            string regex9 = "([A-Z][a-z]+ ){2}([A-Z][a-z]+)";
            if (Regex.IsMatch(textBox9.Text, regex9))
            {
                textBox9.ForeColor = Color.Green;
            }
            else
            {
                textBox9.ForeColor = Color.Red;
            }

            string regex10 = "^[+]?[78][ ]?[(]?\\d{3}[)]?[ ]?\\d{2}[ ]*[-]?[ ]*[\\d]{2}[ ]*[-]?[ ]*[\\d]{3}$";
            if (Regex.IsMatch(textBox10.Text, regex10))
            {
                textBox10.ForeColor = Color.Green;
            }
            else
            {
                textBox10.ForeColor = Color.Red;
            }

            string regex11 = "^([a-z0-9_-]+\\.)*[a-z0-9_-]+@[a-z0-9_-]+(\\.[a-z0-9_-]+)*\\.[a-z]{2,6}$";
            if (Regex.IsMatch(textBox11.Text, regex11))
            {
                textBox11.ForeColor = Color.Green;
            }
            else
            {
                textBox11.ForeColor = Color.Red;
            }

            string regex12 = "^([a-z0-9_-]+\\.)*[a-z0-9_-]+@[a-z0-9_-]+(\\.[a-z0-9_-]+)*\\.ru$";
            if (Regex.IsMatch(textBox12.Text, regex12))
            {
                textBox12.ForeColor = Color.Green;
            }
            else
            {
                textBox12.ForeColor = Color.Red;
            }

            string regex13 = "^[\\d]{1,2}[./][\\d]{1,2}[./][\\d]{1,4}$";
            if (Regex.IsMatch(textBox13.Text, regex13))
            {
                textBox13.ForeColor = Color.Green;
            }
            else
            {
                textBox13.ForeColor = Color.Red;
            }

            string regex14 = "жы|шы|чя|щя|чю|щю/ig";
            if (Regex.IsMatch(textBox14.Text, regex14))
            {
                textBox14.ForeColor = Color.Red;
            }
            else
            {
                textBox14.ForeColor = Color.Green;
            }

            string regex15 = "^[\\d\\s]+$";
            if (Regex.IsMatch(textBox15.Text, regex15))
            {
                textBox15.ForeColor = Color.Green;
            }
            else
            {
                textBox15.ForeColor = Color.Red;
            }

            string regex16 = "\\s(\\w+\\s)\\1";
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
    }
}
