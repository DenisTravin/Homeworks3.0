using System;
using System.Windows.Forms;

namespace CrossApp
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// button array
        /// </summary>
        public Button[,] buttonArray;
        
        /// <summary>
        /// check who musе make move
        /// </summary>
        private bool isX = true;

        /// <summary>
        /// field size
        /// </summary>
        private const int fieldSize = 3;
 
        public Form1()
        {
            InitializeComponent();
            buttonArray = new Button[fieldSize, fieldSize];
            buttonArray[0, 0] = button1;
            buttonArray[0, 1] = button2;
            buttonArray[0, 2] = button3;
            buttonArray[1, 0] = button4;
            buttonArray[1, 1] = button5;
            buttonArray[1, 2] = button6;
            buttonArray[2, 0] = button7;
            buttonArray[2, 1] = button8;
            buttonArray[2, 2] = button9;
        }

        /// <summary>
        /// main app logic
        /// </summary>
        /// <param name="i">column number</param>
        /// <param name="j">row naumber</param>
        private void CheckButton(int i, int j)
        {
            if (buttonArray[i, j].Text == "")
            {
                if (isX)
                {
                    buttonArray[i, j].Text = "X";
                    isX = false;
                }
                else
                {
                    buttonArray[i, j].Text = "0";
                    isX = true;
                }
            }
            if (outputBox.Text == "")
            {
                switch (CheckWin())
                {
                    case 1:
                        outputBox.Text = "X wins!";
                        break;
                    case 2:
                        outputBox.Text = "0 wins!";
                        break;
                    case 3:
                        outputBox.Text = "nobody wins!";
                        break;
                }
            }
        }

        /// <summary>
        /// check win condition
        /// </summary>
        /// <returns>0 - nobody win, 1 - win X, 2 - win 0, 3- nobody wins</returns>
        private int CheckWin()
        {
            for (var i = 0; i < fieldSize; i++)
            {
                if (buttonArray[i, 0].Text == "X" && buttonArray[i, 1].Text == "X" && buttonArray[i, 2].Text == "X")
                {
                    return 1;
                }
                if (buttonArray[0, i].Text == "X" && buttonArray[1, i].Text == "X" && buttonArray[2, i].Text == "X")
                {
                    return 1;
                }
                if (buttonArray[i, 0].Text == "0" && buttonArray[i, 1].Text == "0" && buttonArray[i, 2].Text == "0")
                {
                    return 2;
                }
                if (buttonArray[0, i].Text == "0" && buttonArray[1, i].Text == "0" && buttonArray[2, i].Text == "0")
                {
                    return 2;
                }
            }
            if (buttonArray[0, 0].Text == "X" && buttonArray[1, 1].Text == "X" && buttonArray[2, 2].Text == "X")
            {
                return 1;
            }
            if (buttonArray[2, 0].Text == "X" && buttonArray[1, 1].Text == "X" && buttonArray[2, 0].Text == "X")
            {
                return 1;
            }
            if (buttonArray[0, 0].Text == "0" && buttonArray[1, 1].Text == "0" && buttonArray[2, 2].Text == "0")
            {
                return 2;
            }
            if (buttonArray[2, 0].Text == "0" && buttonArray[1, 1].Text == "0" && buttonArray[2, 0].Text == "0")
            {
                return 2;
            }
            for (var i = 0; i < fieldSize; i++)
            {
                for (var j = 0; j < fieldSize; j++)
                {
                    if (buttonArray[i,j].Text == "")
                    {
                        return 0;
                    }
                }
            }
            return 3;
        }

        private void OnButton1Click(object sender, EventArgs e)
        {
            CheckButton(0, 0);
        }

        private void OnButton2Click(object sender, EventArgs e)
        {
            CheckButton(0, 1);
        }

        private void OnButton3Click(object sender, EventArgs e)
        {
            CheckButton(0, 2);
        }

        private void OnButton4Click(object sender, EventArgs e)
        {
            CheckButton(1, 0);
        }

        private void OnButton5Click(object sender, EventArgs e)
        {
            CheckButton(1, 1);
        }

        private void OnButton6Click(object sender, EventArgs e)
        {
            CheckButton(1, 2);
        }

        private void OnButton7Click(object sender, EventArgs e)
        {
            CheckButton(2, 0);
        }

        private void OnButton8Click(object sender, EventArgs e)
        {
            CheckButton(2, 1);
        }

        private void OnButton9Click(object sender, EventArgs e)
        {
            CheckButton(2, 2);
        }
    }
}
