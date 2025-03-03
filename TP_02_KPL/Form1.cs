using System;
using System.Windows.Forms;

namespace TP_02_KPL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {
        }
        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "Halo, " + textBox1.Text + "!";
        }

    }
}
