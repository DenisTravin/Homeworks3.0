using System;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Calculator : Form
    {
        /// <summary>
        /// array of all calculate buttons
        /// </summary>
        private Button[] buttonArray;

        /// <summary>
        /// variable for calculating result
        /// </summary>
        private int calculateResult;

        /// <summary>
        /// previos button number
        /// </summary>
        private int previosButton = -1;

        /// <summary>
        /// variable for operation definition
        /// </summary>
        private int operation;

        public Calculator()
        {
            InitializeComponent();
            buttonArray = new Button[15];
            calculateResult = 0;
            operation = 0;
            buttonArray[0] = button14;
            buttonArray[1] = button1;
            buttonArray[2] = button2;
            buttonArray[3] = button3;
            buttonArray[4] = button4;
            buttonArray[5] = button5;
            buttonArray[6] = button6;
            buttonArray[7] = button7;
            buttonArray[8] = button8;
            buttonArray[9] = button9;
            buttonArray[10] = button10;
            buttonArray[11] = button11;
            buttonArray[12] = button12;
            buttonArray[13] = button13;
            buttonArray[14] = button15;

        }

        /// <summary>
        /// function for calculating 
        /// </summary>
        /// <param name="buttonNubmer">button number</param>
        private void Calculating(int buttonNubmer)
        {
            if (buttonNubmer == 15)
            {
                textBox1.Text = Convert.ToString(calculateResult);
                previosButton = buttonNubmer;
                return;
            }
            if (buttonNubmer >= 11 && buttonNubmer <= 14)
            {
                textBox1.Text = Convert.ToString(calculateResult);
                operation = buttonNubmer;
                previosButton = buttonNubmer;
                return;
            }
            if (buttonNubmer >= 0 && buttonNubmer <= 10 && previosButton != 15)
            {
                if (operation == 0)
                {
                    if (calculateResult != 0)
                    {
                        calculateResult *= 10;
                    }
                    calculateResult += buttonNubmer;
                    textBox1.Text = Convert.ToString(calculateResult);
                }
                else
                {
                    textBox1.Text = Convert.ToString(buttonNubmer);
                    switch (operation)
                    {
                        case 14:
                            calculateResult += buttonNubmer;
                            break;
                        case 11:
                            calculateResult -= buttonNubmer;
                            break;
                        case 12:
                            calculateResult *= buttonNubmer;
                            break;
                        case 13:
                            calculateResult /= buttonNubmer;
                            break;
                              
                    }
                    operation = 0;
                }
            }
            else
            {
                calculateResult = buttonNubmer;
            }
            previosButton = buttonNubmer;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Calculating(1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Calculating(2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Calculating(3);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Calculating(4);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Calculating(5);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Calculating(6);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Calculating(7);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Calculating(8);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Calculating(9);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Calculating(0);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Calculating(11);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Calculating(12);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Calculating(13);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Calculating(14);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Calculating(15);
        }
    }
}
