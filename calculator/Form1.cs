using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator
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

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var textBoxResult = textBox3.Text;
            
                if (textBoxResult != "")
            {
                var textBoxLastChar = textBoxResult[textBoxResult.Length - 1];
                var textBoxFirstChar = textBoxResult[0];
                if (textBoxFirstChar != '-' && (textBoxResult.Contains("+") || textBoxResult.Contains("*") || textBoxResult.Contains("/") || textBoxResult.Contains("-")))
                {
                    if (textBoxLastChar == '/' || textBoxLastChar == '*' || textBoxLastChar == '+' ||
                   textBoxLastChar == '-')
                    {
                        textBox3.Text = textBox3.Text.Remove(textBox3.Text.Length - 1);
                        textBox3.Text += "+";
                    }
                    else
                    {
                        button15_Click(this, new EventArgs());
                    }

                }
                else
                {
                    textBox3.Text += "+";
                }
            }
           

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var textBoxResult = textBox3.Text;
            
            if (textBoxResult != "")
            {
                var textBoxLastChar = textBoxResult[textBoxResult.Length - 1];
                var textBoxFirstChar = textBoxResult[0];
                if (textBoxFirstChar != '-' && (textBoxResult.Contains("+") || textBoxResult.Contains("*") || textBoxResult.Contains("/") || textBoxResult.Contains("-")))
                {
                    if (textBoxLastChar == '/' || textBoxLastChar == '*' || textBoxLastChar == '+' ||
                   textBoxLastChar == '-')
                    {
                        textBox3.Text = textBox3.Text.Remove(textBox3.Text.Length - 1);
                        textBox3.Text += "-";
                    }
                    else
                    {
                        button15_Click(this, new EventArgs());
                    }

                }
                else
                {
                    textBox3.Text += "-";
                }
            }
         
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string a = "1";
            textBox3.Text += a;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            string a = "7";
            textBox3.Text += a;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            string a = "9";
            textBox3.Text += a;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            string a = "2";
            textBox3.Text += a;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string a = "3";
            textBox3.Text += a;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string a = "4";
            textBox3.Text += a;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string a = "5";
            textBox3.Text += a;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            string a = "6";
            textBox3.Text += a;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            string a = "8";
            textBox3.Text += a;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            string a = "0";
            textBox3.Text += a;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            // TODO: fix errors with negative numbers
             
            var textBoxResult = textBox3.Text;
           
            if (textBoxResult != "")
            {
                var textBoxLastChar = textBoxResult[textBoxResult.Length - 1];
                var textBoxFirstChar = textBoxResult[0];
                if (textBoxFirstChar != '-' && (textBoxResult.Contains("+") || textBoxResult.Contains("*") || textBoxResult.Contains("/") || textBoxResult.Contains("-")))
                {
                    if (textBoxLastChar == '/' || textBoxLastChar == '*' || textBoxLastChar == '+' ||
                   textBoxLastChar == '-')
                    {
                        textBox3.Text = textBox3.Text.Remove(textBox3.Text.Length - 1);
                        textBox3.Text += "*";
                    }
                    else
                    {
                        button15_Click(this, new EventArgs());
                    }

                }
                else
                {
                    textBox3.Text += "*";
                }
            }
          
        }

        private void button14_Click(object sender, EventArgs e)
        {
            var textBoxResult = textBox3.Text;
            
            if (textBoxResult != "")
            {
                var textBoxLastChar = textBoxResult[textBoxResult.Length - 1];
                var textBoxFirstChar = textBoxResult[0];
                if (textBoxFirstChar != '-' && (textBoxResult.Contains("+") || textBoxResult.Contains("*") || textBoxResult.Contains("/") || textBoxResult.Contains("-")))
                {
                    if (textBoxLastChar == '/' || textBoxLastChar == '*' || textBoxLastChar == '+' ||
                   textBoxLastChar == '-')
                    {
                        textBox3.Text = textBox3.Text.Remove(textBox3.Text.Length - 1);
                        textBox3.Text += "/";
                    }
                    else{
                        button15_Click(this, new EventArgs());
                    }

                }
                else
                {
                        textBox3.Text += "/";
                }

            }



        }

        private void button15_Click(object sender, EventArgs e)
        {
            var readyToResult = textBox3.Text;
            var textBoxLength = textBox3.Text.Length;
            for (int i = 0; i < readyToResult.Length; i++)
            {
                switch (readyToResult[i]) {
                    case  '+':
                        double result = 0;
                        foreach( var split in readyToResult.Split('+'))
                        {
                            result += Convert.ToDouble(split);
                        }
             
                        textBox3.Text = Convert.ToString(result);
                        break;
                    case '-':
                        double resultMinus = 0;
                        foreach (var split in readyToResult.Split('-'))
                        {
                            resultMinus -= Convert.ToDouble(split);
                        }

                        textBox3.Text = Convert.ToString(resultMinus);
                        break;
                    case '*':
                        double resultMulti = 1;
                        foreach (var split in readyToResult.Split('*'))
                        {
                            resultMulti *= Convert.ToDouble(split);
                        }

                        textBox3.Text = Convert.ToString(resultMulti);
                        break;
                    case '/':
                        double resultDivision = Convert.ToDouble(readyToResult.Split('/')[0]);
                        foreach (var split in readyToResult.Split('/'))
                        {
                            if (split != readyToResult.Split('/')[0])
                            {
                                resultDivision /= Convert.ToDouble(split);

                            }
                            
                        }

                        textBox3.Text = Convert.ToString(resultDivision);
                        break;
                }
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            //accept to input only numbers ,  "," and Backspace
            char number = e.KeyChar;
          
            if (!Char.IsDigit(number) && number != 8 && number != 44) 
            {
                e.Handled = true;
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox3.Text = "";
        }

        private void textBox3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button15_Click(this, new EventArgs());
            }
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            textBox3.Text = Convert.ToString(number);
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            
        }
    }
}
