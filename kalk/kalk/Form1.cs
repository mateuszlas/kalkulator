using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kalk
{
    public partial class Form1 : Form
    {
        double variable;
        char sign;

        public Form1()
        {
            InitializeComponent();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("4");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("5");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("8");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("1");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("2");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("3");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("6");
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("7");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("9");
        }

        private void button15_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("0");
        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox1.AppendText(",");
        }

        private void button18_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            int textLength = textBox1.Text.Length;

            if (textLength > 0)

                textBox1.Text = textBox1.Text.Substring(0, textLength - 1);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            int textLength = textBox1.Text.Length;
           
            if (textLength > 0)

                if ((textBox1.Text[0]).Equals('-'))

                    textBox1.Text = textBox1.Text.Substring(1, textLength - 1);

                else textBox1.Text = "-" + textBox1.Text;

            else textBox1.Text = "-" + textBox1.Text;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            variable = double.Parse(textBox1.Text);

            sign = '+';

            textBox1.Text = "";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            variable = double.Parse(textBox1.Text);

            sign = '-';

            textBox1.Text = "";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            variable = double.Parse(textBox1.Text);

            sign = '*';

            textBox1.Text = "";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            variable = double.Parse(textBox1.Text);

            sign = '/';

            textBox1.Text = "";
        }

        private void button19_Click(object sender, EventArgs e)
        {
            switch (sign)
            {

                case '+':

                    textBox1.Text = (variable + double.Parse(textBox1.Text)).ToString();

                    break;

                case '-':

                    textBox1.Text = (variable - double.Parse(textBox1.Text)).ToString();

                    break;

                case '/':

                    if (textBox1.TextLength == 1 && textBox1.Text[0].Equals('0'))
                    {

                        textBox1.Text = "Błąd! Dzielenie przez zero!";

                    }

                    else
                    {

                        textBox1.Text = ((double)variable / double.Parse(textBox1.Text)).ToString();

                    }

                    break;

                case '*':

                    textBox1.Text = (variable * double.Parse(textBox1.Text)).ToString();

                    break;

            }
        }
    }
}
