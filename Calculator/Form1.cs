using controls;
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
        private decimal? firstNumber;
        private decimal? secondNumber;
        private string mathOperator = "+";
        private bool operatorUsed = false;
        public Form1()
        {
            InitializeComponent();
        }

        #region Number Button Event Handler
        private void cEditBox1_Click(object sender, EventArgs e)
        {

        }

        private void cBtn2_Click(object Sender, EventArgs e)
        {
            cBtn btnNumber = (cBtn)Sender;
            addToDisplay(btnNumber.Label);
        }

        private void num1_Click(object Sender, EventArgs e)
        {
            cBtn btnNumber = (cBtn)Sender;
            addToDisplay(btnNumber.Label);
        }

        private void num2_Click(object Sender, EventArgs e)
        {
            cBtn btnNumber = (cBtn)Sender;
            addToDisplay(btnNumber.Label);
        }

        private void num3_Click(object Sender, EventArgs e)
        {
            cBtn btnNumber = (cBtn)Sender;
            addToDisplay(btnNumber.Label);
        }

        private void num4_Click(object Sender, EventArgs e)
        {
            cBtn btnNumber = (cBtn)Sender;
            addToDisplay(btnNumber.Label);
        }

        private void num5_Click(object Sender, EventArgs e)
        {
            cBtn btnNumber = (cBtn)Sender;
            addToDisplay(btnNumber.Label);
        }

        private void num6_Click(object Sender, EventArgs e)
        {
            cBtn btnNumber = (cBtn)Sender;
            addToDisplay(btnNumber.Label);
        }

        private void num7_Click(object Sender, EventArgs e)
        {
            cBtn btnNumber = (cBtn)Sender;
            addToDisplay(btnNumber.Label);
        }

        private void num8_Click(object Sender, EventArgs e)
        {
            cBtn btnNumber = (cBtn)Sender;
            addToDisplay(btnNumber.Label);
        }

        private void num9_Click(object Sender, EventArgs e)
        {
            cBtn btnNumber = (cBtn)Sender;
            addToDisplay(btnNumber.Label);
        }

        private void numDot_Click(object Sender, EventArgs e)
        {
            cBtn btnNumber = (cBtn)Sender;
            char decimalDelimeter = Convert.ToChar(CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator);
            if (!display.Text.Contains(decimalDelimeter))
            {
                if (operatorUsed == true)
                {
                    display.Text = "0";
                    operatorUsed = false;
                }
                display.Text += decimalDelimeter;
            }
        }
        #endregion

        #region Math Operation Button Handlers
        private void opAdd_Click(object Sender, EventArgs e)
        {
            addOperatorToDisplay(((cBtn)Sender).Label);
        }

        private void opEquals_Click(object Sender, EventArgs e)
        {
            if (!operatorUsed) { 
                secondNumber = decimal.Parse(display.Text);
            }
            addEqualToDisplay();
        }
        private void opSubstract_Click(object Sender, EventArgs e)
        {
            addOperatorToDisplay(((cBtn)Sender).Label);
        }

        private void opMultiply_Click(object Sender, EventArgs e)
        {
            addOperatorToDisplay(((cBtn)Sender).Label);
        }

        private void opDevide_Click(object Sender, EventArgs e)
        {
            addOperatorToDisplay(((cBtn)Sender).Label);
        }
        #endregion

        #region Other Buttons Handler

        private void opC_Click(object Sender, EventArgs e)
        {
            firstNumber = null;
            secondNumber = null;
            operatorUsed = false;
            display.Text = "0";
        }

        private void opBackspace_Click(object Sender, EventArgs e)
        {
            if (display.Text.Length > 0)
            {
                if (operatorUsed == false)
                {
                    display.Text = display.Text.Remove(display.Text.Length - 1);
                }
            }

            if (display.Text.Length == 0)
            {
                display.Text = "0";
            }
        }
        #endregion

        #region Common Methods
        private void addOperatorToDisplay(string clickedOperator)
        {
            if (operatorUsed)
            {
                mathOperator = clickedOperator;
                return;
            }
            if (firstNumber == null)
            {
                firstNumber = decimal.Parse(display.Text);
            }
            else
            {
                secondNumber = decimal.Parse(display.Text);
                addEqualToDisplay();
            }

            operatorUsed = true;
            mathOperator = clickedOperator;
        }

        private void addToDisplay(string num)
        {
            if (operatorUsed == true)
            {
                display.Text = "0";
                operatorUsed = false;
            }
            if (display.Text.Length < 15)
            {
                string number = display.Text;
                number += num;
                display.Text = decimal.Parse(number).ToString();
            }
        }

        private void addEqualToDisplay()
        {
            if (firstNumber == null)
            {
                return;
            }
            decimal? total = null;
            switch (mathOperator)
            {
                case "+":
                    total = firstNumber + (secondNumber ?? 0);
                    break;
                case "-":
                    total = firstNumber - (secondNumber ?? 0);
                    break;
                case "*":
                    total = firstNumber * (secondNumber ?? 0);
                    break;
                case "/":
                    if (secondNumber == 0)
                    {
                        MessageBox.Show("Division by zero is not allowed", "Warning", MessageBoxButtons.OK);
                        secondNumber = 1;
                    }
                    total = firstNumber / (secondNumber ?? 1);
                    
                    break;
                default:
                    total = 0;
                    break;
            }

            firstNumber = total;
            secondNumber = null;
            operatorUsed = true;
            display.Text = firstNumber.ToString();
        }

        #endregion

    }
}
