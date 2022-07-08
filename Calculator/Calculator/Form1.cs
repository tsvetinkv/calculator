using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        private double number;
        private double answer;
        private int count;
        private string decimalPlaces = "#.##";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Text = textBox2.Text + 2;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox2.Text = textBox2.Text + 6;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if(textBox2.Text != "")
            {
                this.number = double.Parse(textBox2.Text, CultureInfo.InvariantCulture);
                textBox2.Clear();
                textBox2.Focus();
                count = 1;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox2.Text = textBox2.Text + 4;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox2.Text = textBox2.Text + 5;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox2.Text = textBox2.Text + 1;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox2.Text = textBox2.Text + 3;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox2.Text = textBox2.Text + 7;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox2.Text = textBox2.Text + 8;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox2.Text = textBox2.Text + 9;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (textBox2.Text != "")
            {
                this.number = double.Parse(textBox2.Text, CultureInfo.InvariantCulture);
                textBox2.Clear();
                textBox2.Focus();
                count = 2;
            }
        }

        private void buttonmultiply_Click(object sender, EventArgs e)
        {
            if (textBox2.Text != "")
            {
                this.number = double.Parse(textBox2.Text, CultureInfo.InvariantCulture);
                textBox2.Clear();
                textBox2.Focus();
                count = 3;
            }
        }

        private void buttondivide_Click(object sender, EventArgs e)
        {
            if (textBox2.Text != "")
            {
                this.number = double.Parse(textBox2.Text, CultureInfo.InvariantCulture);
                textBox2.Clear();
                textBox2.Focus();
                count = 4;
            }
        }
        private void Compute(int count)
        {
            switch (count)
            {
                    case 1:
                    answer = number + double.Parse(textBox2.Text, CultureInfo.InvariantCulture);
                    textBox2.Text = answer.ToString(this.decimalPlaces, CultureInfo.InvariantCulture);
                    break;

                    case 2:
                    answer = number - double.Parse(textBox2.Text, CultureInfo.InvariantCulture);
                    textBox2.Text = answer.ToString(this.decimalPlaces, CultureInfo.InvariantCulture);
                    break;

                    case 3:
                    answer = number * double.Parse(textBox2.Text, CultureInfo.InvariantCulture);
                    textBox2.Text = answer.ToString(this.decimalPlaces, CultureInfo.InvariantCulture);
                    break;

                    case 4:
                    answer = number / double.Parse(textBox2.Text, CultureInfo.InvariantCulture);
                    textBox2.Text = answer.ToString(this.decimalPlaces, CultureInfo.InvariantCulture);
                    break;

                   default:
                    break; 

            }
        }

        private void buttonequal_Click(object sender, EventArgs e)
        {
            this.Compute(this.count);
        }

        private void buttonclear_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
            count = 0;
        }

        private void button10_Click_1(object sender, EventArgs e)
        {
            int c = textBox2.TextLength;
            int flag = 0;
            string text = textBox2.Text;
            for (int i = 0; i < c; i++)
            {
                if(text[i].ToString() == ".")
                {
                    flag = 1;
                    break;
                }
                else
                {
                    flag = 0;
                }
            }
            if(flag == 0)
            {
                textBox2.Text = textBox2.Text + ".";
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox2.Text = textBox2.Text + 10;
        }

        private void button11_Click_1(object sender, EventArgs e)
        {
            textBox2.Text = textBox2.Text + 0;
        }

        private void button12_Click_1(object sender, EventArgs e)
        {
            textBox2.Text = textBox2.Text + 10;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            this.decimalPlaces = "#.##";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            this.decimalPlaces = "#.####";

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            this.decimalPlaces = "#.######";

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            this.decimalPlaces = "#.########";

        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            this.decimalPlaces = "#.##########";

        }
    }
}
