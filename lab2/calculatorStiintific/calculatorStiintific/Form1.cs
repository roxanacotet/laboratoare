using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculatorStiintific
{
  
    public partial class CalculatorApp : Form
    {
        double FirstNumber;
        string operation;
        public CalculatorApp()
        {
            InitializeComponent();

            result.KeyDown += result_KeyDown;
            result.KeyPress += new KeyPressEventHandler(result_KeyPress);
            result.KeyUp += result_KeyUp;
        }

        private void equal_Click(object sender, EventArgs e)
        {
            double SecondNumber;
            SecondNumber = Double.Parse(result.Text);
            if(operation == "+")
            {
                result.Text = Convert.ToString(FirstNumber + SecondNumber);
            }

            if (operation == "-")
            {
                if (SecondNumber > FirstNumber)
                {
                    result.Text = Convert.ToString(FirstNumber - SecondNumber).Substring(1) + "-";
                }
                else
                {
                    result.Text = Convert.ToString(FirstNumber - SecondNumber);
                }
            }
            
            if(operation == "*")
            {
                result.Text = Convert.ToString(FirstNumber * SecondNumber);

            }

            if(operation == "/")
            {
                if(SecondNumber == 0)
                {
                    result.Text = "Wrong operation!";
                }
                else
                {
                    result.Text = Convert.ToString(FirstNumber / SecondNumber);
                }
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            FirstNumber = Double.Parse(result.Text);
            result.Text = "0";
            operation = "*";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void result_KeyUp(object sender, KeyEventArgs e)
        {
            //result.AppendText($"keyUp code: {e.KeyCode}, value: {e.KeyValue}, modifiers: {e.Modifiers}" + "\r\n");
        }

        private void result_KeyDown(object sender, KeyEventArgs e)
        {
            //result.AppendText($"KeyDown code: {e.KeyCode}, value: {e.KeyValue}, modifiers: {e.Modifiers}" + "\r\n");
        }

        private void result_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                result.Text += Convert.ToString(e.KeyChar);
            }

            if(Convert.ToString(e.KeyChar) == "/")
            {
                result.Text += Convert.ToString(e.KeyChar);
                operation = "/";
            }

            if(Convert.ToString(e.KeyChar) == "+")
            {
                result.Text += Convert.ToString(e.KeyChar);
                operation = "+";
            }

            if (Convert.ToString(e.KeyChar) == "-")
            {
                result.Text += Convert.ToString(e.KeyChar);
                operation = "-";
            }
            
            if(Convert.ToString(e.KeyChar) == "*")
            {
                result.Text += Convert.ToString(e.KeyChar);
                operation = "*";
            }

            if (Convert.ToString(e.KeyChar) == "=")
               {
                    // 3 * 5
                    char[] operators = { '+', '-', '*', '/' };
                    Double SecondNumber;
                    string[] numbers = result.Text.Split(operators);
                    FirstNumber = Convert.ToDouble(numbers[0]);
                    SecondNumber = Convert.ToDouble(numbers[1]);
                if (operation == "+")
                {
                    result.Text = Convert.ToString(FirstNumber + SecondNumber);
                }

                if (operation == "-")
                {
                    if (SecondNumber > FirstNumber)
                    {
                        result.Text = Convert.ToString(FirstNumber - SecondNumber).Substring(1) + "-";
                    }
                    else
                    {
                        result.Text = Convert.ToString(FirstNumber - SecondNumber);
                    }
                }

                if (operation == "*")
                {
                    result.Text = Convert.ToString(FirstNumber * SecondNumber);

                }

                if (operation == "/")
                {
                    if (SecondNumber == 0)
                    {
                        result.Text = "Wrong operation!";
                    }
                    else
                    {
                        result.Text = Convert.ToString(FirstNumber / SecondNumber);
                    }
                }

            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(result.Text == "0")
            {
                result.Text = "2";
            }
            else
            {
                result.Text = result.Text + "2";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if(result.Text == "0")
            {
                result.Text = "4";
            }
            else
            {
                result.Text = result.Text + "4";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(result.Text == "0")
            {
                result.Text = "1";
            }
            else
            {
                result.Text = result.Text + "1";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(result.Text == "0")
            {
                result.Text = "3";
            }
            else
            {
                result.Text = result.Text + "3";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if(result.Text == "0")
            {
                result.Text = "5";
            }
            else
            {
                result.Text = result.Text + "5";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if(result.Text == "0")
            {
                result.Text = "6";
            }
            else
            {
                result.Text = result.Text + "6";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if(result.Text == "0")
            {
                result.Text = "7";
            }
            else
            {
                result.Text = result.Text + "7";
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if(result.Text == "0")
            {
                result.Text = "8";
            }
            else
            {
                result.Text = result.Text + "8";
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (result.Text == "0")
            {
                result.Text = "9";
            }
            else
            {
                result.Text = result.Text + "9";
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if(result.Text == "0")
            {
                result.Text = "0";
            }
            else
            {
                result.Text = result.Text + "0";
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if(result.Text != null && !result.Text.Contains("."))
            {
                result.Text = result.Text + ".";
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if(result.Text != null)
            {
                result.Text = result.Text.Remove(result.Text.Length - 1);
            }
            else
            {
                result.Text = "0";
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            FirstNumber = Double.Parse(result.Text);
            result.Text = "0";
            operation = "+";
              
        }

        private void button13_Click(object sender, EventArgs e)
        {
            FirstNumber = Double.Parse(result.Text);
            result.Text = "0";
            operation = "/";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            FirstNumber = Double.Parse(result.Text);
            result.Text = "0";
            operation = "-";
        }
    }
}
