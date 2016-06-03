using System;
using System.Drawing;
using System.Windows.Forms;

namespace TestTask
{
    public partial class Form1 : Form
    {
        private const int n = 5;
        private const int windowHeight = 600;
        private const int windowWidth = 500;
        private const int OKButtonHeight = 100;
        private Button[,] buts;

        public Form1()
        {
            //button size parametrs
            int buttonWidth = windowWidth / n;
            int buttonHeight = (windowHeight - OKButtonHeight) / n;
            //button array
            buts = new Button[n, n];

            //button array init
            for (var i = 0; i < n; i++)
            {
                for (var j = 0; j < n; j++)
                {
                    var b = new Button();
                    b.Text = "";
                    b.Location = new System.Drawing.Point(j * buttonWidth, i * buttonHeight);
                    b.Size = new System.Drawing.Size(buttonWidth, buttonHeight);
                    buts[j, i] = b;
                    Controls.Add(this.buts[j, i]);
                }
            }

            //OKButton init
            var OKButton = new Button();
            OKButton.Text = "Go";
            OKButton.Location = new Point(0, windowHeight - OKButtonHeight);
            OKButton.Size = new Size(windowWidth, OKButtonHeight);
            OKButton.Click += new EventHandler(OnGoClick);
            Controls.Add(OKButton);
            SuspendLayout();
            InitializeComponent(windowHeight, windowWidth);
        }

        /// <summary>
        /// timer for app
        /// </summary>
        static Timer myTimer = new Timer();

        /// <summary>
        /// Go button click method
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnGoClick(object sender, EventArgs e)
        {
            myTimer.Interval = 500;
            myTimer.Tick += new EventHandler(MyTimerTick);
            myTimer.Enabled = true;
        }

        /// <summary>
        /// Timer arguments
        /// </summary>
        private int ni = 0;
        private int nj = 0;
        private int vec = 1;

        /// <summary>
        /// timer tick method
        /// </summary>
        /// <param name="Sender"></param>
        /// <param name="e"></param>
        private void MyTimerTick(object Sender, EventArgs e)
        {
            if (ni < n)
            {
                if (nj >= 0 && nj < n)
                {
                    int addNumber = 0;
                    if (vec == 1)
                    {
                        addNumber = ni * n + nj * vec + 1 * vec;
                    }
                    else
                    {
                        addNumber = (ni+1) * n + nj * vec;
                    }

                    buts[nj, ni].Text = (addNumber).ToString();
                    nj += vec;
                    return;
                }
                nj -= vec;
                vec = -vec;
                ni++;
                int addNumbers = 0;
                if (vec == 1)
                {
                    addNumbers = ni * n + nj * vec + 1 * vec;
                }
                else
                {
                    addNumbers = (ni + 1) * n + nj * vec;
                }

                buts[nj, ni].Text = (addNumbers).ToString();
                nj += vec;
                return;
            }
            ni = 0;
            nj = 0;
            vec = 1;
            myTimer.Enabled = false;
        }
    }
}
