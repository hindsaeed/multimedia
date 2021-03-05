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
    public partial class rlc : Form
    {
        public rlc(string input)
        {
            InitializeComponent();
            textBox1.Text = input;
            rlc_inc();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            label1.Text = textBox1.Text.Length.ToString();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            label2.Text = textBox2.Text.Length.ToString();
        }

        private void rlc_Load(object sender, EventArgs e)
        {

        }


        public void rlc_inc()
        {

            try
            {
                if (textBox1.Text == "")
                {
                    return;
                }
                String Solution = "";
                String code = textBox1.Text;
                char sesc = code[0];
                int count = 1;
                for (int i = 1; i < code.Length; i++)
                {
                    if (code[i] == sesc)
                    {
                        count++;
                        if (count > 9)
                        {
                            count = 9;
                        }
                    }
                    else
                    {
                        Solution += count.ToString() + sesc;
                        sesc = code[i];
                        count = 1;
                    }
                }
                Solution += count.ToString() + sesc;
                textBox2.Text = Solution;
            }
            catch (Exception ee)
            {

                MessageBox.Show(ee.Message.ToString());
            }
        }
    }
}
