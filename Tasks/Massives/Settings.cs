using System;
using System.Windows.Forms;

namespace Massives
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Input._Settings(int.Parse(textBox1.Text),int.Parse(textBox2.Text));
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
