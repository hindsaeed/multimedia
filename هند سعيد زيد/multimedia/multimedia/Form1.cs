using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace multimedia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            label1.Text = textBox1.Text.Length.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            rlc rlc = new rlc(textBox1.Text);
            rlc.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            rlc_de rlcd = new rlc_de(textBox1.Text);
            rlcd.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            shanon rlc = new shanon(textBox1.Text);
            rlc.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            huffman rlcd = new huffman(textBox1.Text);
            rlcd.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            adbtive_huffman rlcd = new adbtive_huffman(textBox1.Text);
            rlcd.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            var newForm = new dictionary_EN(textBox1.Text);
            newForm.Show();
        }
    }
}
