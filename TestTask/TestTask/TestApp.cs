using System;
using System.Drawing;
using System.Windows.Forms;

namespace TestTask
{
    /// <summary>
    /// test app main class
    /// </summary>
    public partial class TestApp : Form
    {
        private const int n = 1;
        private const int windowHeight = 600;
        private const int windowWidth = 500;
        private const int OKButtonHeight = 100;
        private Button[,] buttons;

        public TestApp()
        {
            //button size parametrs
            int buttonWidth = windowWidth / n;
            int buttonHeight = (windowHeight - OKButtonHeight) / n;
            //button array
            buttons = new Button[n, n];

            //button array init
            for (var i = 0; i < n; i++)
            {
                for (var j = 0; j < n; j++)
                {
                    var b = new Button();
                    b.Text = "";
                    b.Location = new System.Drawing.Point(j * buttonWidth, i * buttonHeight);
                    b.Size = new System.Drawing.Size(buttonWidth, buttonHeight);
                    buttons[j, i] = b;
                    Controls.Add(this.buttons[j, i]);
                }
            }

            //OkButton init
            var OkButton = new Button();
            OkButton.Text = "Go";
            OkButton.Location = new Point(0, windowHeight - OKButtonHeight);
            OkButton.Size = new Size(windowWidth, OKButtonHeight);
            OkButton.Click += new EventHandler(OnGoClick);
            Controls.Add(OkButton);
            SuspendLayout();
            InitializeComponent(windowHeight, windowWidth);
        }

        /// <summary>
        /// timer for app
        /// </summary>
        private static Timer myTimer = new Timer();

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
        private int timerI = 0;
        private int timerJ = 0;
        private int timerVector = 1;

        /// <summary>
        /// timer tick method
        /// </summary>
        /// <param name="Sender"></param>
        /// <param name="e"></param>
        private void MyTimerTick(object Sender, EventArgs e)
        {
            if (timerI < n)
            {
                if (timerJ >= 0 && timerJ < n)
                {
                    if (timerVector == 1)
                    {
                        buttons[timerJ, timerI].Text = (timerI * n + timerJ * timerVector + 1 * timerVector).ToString();
                    }
                    else
                    {
                        buttons[timerJ, timerI].Text = ((timerI + 1) * n + timerJ * timerVector).ToString();
                    }
                    timerJ += timerVector;
                    return;
                }
                if (timerI != n - 1)
                {
                    timerJ -= timerVector;
                    timerVector = -timerVector;
                    timerI++;
                    if (timerVector == 1)
                    {
                        buttons[timerJ, timerI].Text = (timerI * n + timerJ * timerVector + 1 * timerVector).ToString();
                    }
                    else
                    {
                        buttons[timerJ, timerI].Text = ((timerI + 1) * n + timerJ * timerVector).ToString();
                    }
                    timerJ += timerVector;
                    return;
                }
            }
            timerI = 0;
            timerJ = 0;
            timerVector = 1;
            myTimer.Enabled = false;
        }
    }
}
