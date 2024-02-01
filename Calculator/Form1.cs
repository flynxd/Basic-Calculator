using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Calculator : Form
    {

        decimal answer;
        string firstNumber = "";
        string secondNumber = "";
        string action = "";
        bool numberCount = true;
        bool clearDetect = true;
        public Calculator()
        {
            InitializeComponent();
        }

        private void buttonOne_Click(object sender, EventArgs e)
        {
            if (numberCount && clearDetect)
            {
                firstNumber += "1";
                textBox1.Text = firstNumber;
            }
            else if (clearDetect)
            {
                secondNumber += "1";
                textBox1.Text = secondNumber;
            }
        }

        private void buttonTwo_Click(object sender, EventArgs e)
        {
            if (numberCount && clearDetect)
            {
                firstNumber += "2";
                textBox1.Text = firstNumber;
            }
            else if (clearDetect)
            {
                secondNumber += "2";
                textBox1.Text = secondNumber;
            }
        }

        private void buttonThree_Click(object sender, EventArgs e)
        {
            if (numberCount && clearDetect)
            {
                firstNumber += "3";
                textBox1.Text = firstNumber;
            }
            else if (clearDetect)
            {
                secondNumber += "3";
                textBox1.Text = secondNumber;
            }
        }

        private void buttonFour_Click(object sender, EventArgs e)
        {
            if (numberCount && clearDetect)
            {
                firstNumber += "4";
                textBox1.Text = firstNumber;
            }
            else if (clearDetect)
            {
                secondNumber += "4";
                textBox1.Text = secondNumber;
            }
        }

        private void buttonFive_Click(object sender, EventArgs e)
        {
            if (numberCount && clearDetect)
            {
                firstNumber += "5";
                textBox1.Text = firstNumber;
            }
            else if (clearDetect)
            {
                secondNumber += "5";
                textBox1.Text = secondNumber;
            }
        }

        private void buttonSix_Click(object sender, EventArgs e)
        {
            if (numberCount && clearDetect)
            {
                firstNumber += "6";
                textBox1.Text = firstNumber;
            }
            else if (clearDetect)
            {
                secondNumber += "6";
                textBox1.Text = secondNumber;
            }
        }

        private void buttonSeven_Click(object sender, EventArgs e)
        {
            if (numberCount && clearDetect)
            {
                firstNumber += "7";
                textBox1.Text = firstNumber;
            }
            else if (clearDetect)
            {
                secondNumber += "7";
                textBox1.Text = secondNumber;
            }
        }

        private void buttonEight_Click(object sender, EventArgs e)
        {
            if (numberCount && clearDetect)
            {
                firstNumber += "8";
                textBox1.Text = firstNumber;
            }
            else if (clearDetect)
            {
                secondNumber += "8";
                textBox1.Text = secondNumber;
            }
        }

        private void buttonNine_Click(object sender, EventArgs e)
        {
            if (numberCount && clearDetect)
            {
                firstNumber += "9";
                textBox1.Text = firstNumber;
            }
            else if (clearDetect)
            {
                secondNumber += "9";
                textBox1.Text = secondNumber;
            }
        }

        private void buttonZero_Click(object sender, EventArgs e)
        {
            if (numberCount)
            {
                firstNumber += "0";
                textBox1.Text = firstNumber;
            }
            else if (clearDetect)
            {
                secondNumber += "0";
                textBox1.Text = secondNumber;
            }
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            if (firstNumber != "" && clearDetect)
            {
                textBox1.Text = "+";
                action = "+";
                numberCount = false;
            }
        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            if (firstNumber != "" && clearDetect)
            {
                textBox1.Text = "-";
                action = "-";
                numberCount = false;
            }
        }

        private void buttonTimes_Click(object sender, EventArgs e)
        {
            if (firstNumber != "" && clearDetect)
            {
                textBox1.Text = "X";
                action = "*";
                numberCount = false;
            }
        }

        private void buttonDivide_Click(object sender, EventArgs e)
        {
            if (firstNumber != "" && clearDetect)
            {
                textBox1.Text = "/";
                action = "/";
                numberCount = false;
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            firstNumber = "";
            secondNumber = "";
            action = "";
            numberCount = true;
            clearDetect = true;
            answer = 0;
            textBox1.Text = "";
        }

        private void buttonEquals_Click(object sender, EventArgs e)
        {
            if (firstNumber != "" && secondNumber != "" && action != "")
            {

                switch (action)
                {
                    case "+":
                        {
                            answer = Convert.ToDecimal(firstNumber) + Convert.ToDecimal(secondNumber);
                            answer = Math.Round(answer, 2);
                        }
                        break;
                    case "-":
                        {
                            answer = Convert.ToDecimal(firstNumber) - Convert.ToDecimal(secondNumber);
                            answer = Math.Round(answer, 2);
                        }
                        break;
                    case "*":
                        {
                            answer = Convert.ToDecimal(firstNumber) * Convert.ToDecimal(secondNumber);
                            answer = Math.Round(answer, 2);
                        }
                        break;
                    case "/":
                        {
                            answer = Convert.ToDecimal(firstNumber) / Convert.ToDecimal(secondNumber);
                            answer = Math.Round(answer, 2);
                        }
                        break;

                }

                textBox1.Text = Convert.ToString(answer);
                clearDetect = false;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

    }
}
