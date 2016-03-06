using System;
using System.Windows.Forms;
using RE = RegularExpressions;
using M = Massives;

namespace Launcher
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                RE.Form1 form1 = new RE.Form1();
                Visible = false;
                form1.ShowDialog();
                Visible = true;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                M.Form1 form1 = new M.Form1();
                Visible = false;
                form1.ShowDialog();
                Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
