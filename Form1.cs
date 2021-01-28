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
        string input = string.Empty;
        string first = string.Empty;
        string second = string.Empty;
        char operation;
        double answer = 0;
        public Calculator()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            KeyPress += Form1_KeyPress;
        }

        void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch((int)e.KeyChar)
            {
                case '1':
                    input += "1";
                    txtInput.Text = input;
                    break;

                case '2':
                    input += "2";
                    txtInput.Text = input;
                    break;

                case '3':
                    input += "3";
                    txtInput.Text = input;
                    break;

                case '4':
                    input += "4";
                    txtInput.Text = input;
                    break;

                case '5':
                    input += "5";
                    txtInput.Text = input;
                    break;

                case '6':
                    input += "6";
                    txtInput.Text = input;
                    break;

                case '7':
                    input += "7";
                    txtInput.Text = input;
                    break;

                case '8':
                    input += "8";
                    txtInput.Text = input;
                    break;

                case '9':
                    input += "9";
                    txtInput.Text = input;
                    break;

                case '0':
                    input += "0";
                    txtInput.Text = input;
                    break;

                case '.':
                    input += ".";
                    txtInput.Text = input;
                    break;

                case '+':
                    first = input;
                    operation = '+';
                    txtInput.Text += operation;
                    input = String.Empty;
                    break;

                case '-':
                    first = input;
                    operation = '-';
                    txtInput.Text += operation;
                    input = String.Empty;
                    break;

                case '*':
                    first = input;
                    operation = '*';
                    txtInput.Text += operation;
                    input = String.Empty;
                    break;

                case '/':
                    first = input;
                    operation = '/';
                    txtInput.Text += operation;
                    input = String.Empty;
                    break;

                case 'm':
                    txtInput.Text += txtPrevious.Text;
                    input = txtPrevious.Text;
                    break;

                case '=':
                    end();
                    break;
            }
        }

        private void btnSquareRoot_Click(object sender, EventArgs e)
        {
            txtPrevious.Text = "sqrt(" + txtInput.Text + ")";
            first = input;
            second = input;
            input = String.Empty;
            operation = 's';
            end();

        }

        private void btnSquared_Click(object sender, EventArgs e)
        {
            txtPrevious.Text = txtInput.Text + "^(2)";
            first = input;
            second = first;
            input = String.Empty;
            operation = '*';
            end();
        }

        private void btnMemorized_Click(object sender, EventArgs e)
        {
            txtInput.Text = txtPrevious.Text;
            input = txtPrevious.Text;
        }

        private void btnOneOver_Click(object sender, EventArgs e)
        {
            txtPrevious.Text = "1/" + input;
            first = "1";
            operation = '/';
            end();
        }

        private void btnClearEntry_Click(object sender, EventArgs e)
        {
            txtInput.Text = "";
            input = string.Empty;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtPrevious.Text = "";
            txtOutput.Text = "";
            txtInput.Text += "";
            input = string.Empty;
            first = string.Empty;
        }

        private void btnBackspace_Click(object sender, EventArgs e)
        {
            txtInput.Text = txtInput.Text.Remove(txtInput.Text.Length - 1, 1);
            input = input.Remove(input.Length - 1, 1);
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            first = input;
            txtInput.Text += '/';
            operation = '/';
            input = String.Empty;
        }

        private void btnSeven_Click(object sender, EventArgs e)
        {
            input += "7";
            txtInput.Text = input;
        }

        private void btnEight_Click(object sender, EventArgs e)
        {
            input += "8";
            txtInput.Text = input;
        }

        private void btnNine_Click(object sender, EventArgs e)
        {
            input += "9";
            txtInput.Text = input;
        }

        private void btnTimes_Click(object sender, EventArgs e)
        {
            first = input;
            txtInput.Text += '*';
            operation = '*';
            input = String.Empty;
        }

        private void btnFour_Click(object sender, EventArgs e)
        {
            input += "4";
            txtInput.Text = input;
        }

        private void btnFive_Click(object sender, EventArgs e)
        {
            input += "5";
            txtInput.Text = input;
        }

        private void btnSix_Click(object sender, EventArgs e)
        {
            input += "6";
            txtInput.Text = input;
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            first = input;
            txtInput.Text += '-';
            operation = '-';
            input = String.Empty;
        }

        private void btnOne_Click(object sender, EventArgs e)
        {
            input += "1";
            txtInput.Text = input;
        }

        private void btnTwo_Click(object sender, EventArgs e)
        {
            input += "2";
            txtInput.Text = input;
        }

        private void btnThree_Click(object sender, EventArgs e)
        {
            input += "3";
            txtInput.Text = input;
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            first = input;
            txtInput.Text += '+';
            operation = '+';
            input = String.Empty;
        }

        private void btnNegative_Click(object sender, EventArgs e)
        {
            input += "-";
            txtInput.Text = input;
        }

        private void btnZero_Click(object sender, EventArgs e)
        {
            input += "0";
            txtInput.Text = input;
        }

        private void btnDecimal_Click(object sender, EventArgs e)
        {
            input += ".";
            txtInput.Text = input;
            
        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            end();
            
        }
        private void end()
        {
            second = input;
            txtPrevious.Text = txtInput.Text;
            double Half1, Half2;
            double.TryParse(first, out Half1);
            double.TryParse(second, out Half2);

            switch (operation)
            {
                case '*':
                    answer = Half1 * Half2;
                    txtOutput.Text = answer.ToString();
                    txtInput.Text = "";
                    break;

                case '/':
                    answer = Half1 / Half2;
                    txtOutput.Text = answer.ToString();
                    txtInput.Text = "";
                    break;

                case '+':
                    answer = Half1 + Half2;
                    txtOutput.Text = answer.ToString();
                    txtInput.Text = "";
                    break;

                case '-':
                    answer = Half1 - Half2;
                    txtOutput.Text = answer.ToString();
                    txtInput.Text = "";
                    break;

                case 's':
                    answer = Math.Sqrt(Half1);
                    txtOutput.Text = answer.ToString();
                    txtInput.Text = "";
                    break;
            }
        }
    }
}
