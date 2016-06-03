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
        private Button previosButton = null;

        /// <summary>
        /// variable for operation definition
        /// </summary>
        private Button operation;

        public Calculator()
        {
            InitializeComponent();
            buttonArray = new Button[15];
            calculateResult = 0;
            operation = null;
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
        private void Calculating(Button button)
        {
            
            if (Convert.ToInt32(button.Text) >= 0 && Convert.ToInt32(button.Text) <= 10 && (previosButton == null || previosButton.Text != "="))
            {
                if (operation == null)
                {
                    if (calculateResult != 0)
                    {
                        calculateResult *= 10;
                    }
                    calculateResult += Convert.ToInt32(button.Text);
                    textBox1.Text = Convert.ToString(calculateResult);
                }
                else
                {
                    textBox1.Text = button.Text;
                    switch (operation.Text)
                    {
                        case "+":
                            calculateResult += Convert.ToInt32(button.Text);
                            break;
                        case "-":
                            calculateResult -= Convert.ToInt32(button.Text);
                            break;
                        case "*":
                            calculateResult *= Convert.ToInt32(button.Text);
                            break;
                        case "/":
                            calculateResult /= Convert.ToInt32(button.Text);
                            break;
                              
                    }
                    operation = null;
                }
            }
            else
            {
                calculateResult = Convert.ToInt32(button.Text);
            }
            previosButton = button;
        }

        private void OnNumberClick(object sender, EventArgs e)
        {
            Button thisButton = (Button)sender;
            Calculating(thisButton);
        }
        
        private void OnOperationClick(object sender, EventArgs e)
        {
            Button thisButton = (Button)sender;
            if (thisButton.Text == "=")
            {
                textBox1.Text = Convert.ToString(calculateResult);
                previosButton = thisButton;
                return;
            }
            if (thisButton.Text == "+" || thisButton.Text == "-" || thisButton.Text == "*" || thisButton.Text == "/")
            {
                textBox1.Text = Convert.ToString(calculateResult);
                operation = thisButton;
                previosButton = thisButton;
                return;
            }
        }
    }
}
