using System;
using System.Windows.Forms;

namespace Watch
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void TickTimer(object sender, EventArgs e)
        {
            button1.Text = ZeroFunc(DateTime.Now.Hour.ToString()) + " : " + ZeroFunc(DateTime.Now.Minute.ToString()) + " : " + ZeroFunc(DateTime.Now.Second.ToString());
        }

        private string ZeroFunc(string inputString)
        {
            if (inputString.Length == 1)
                return "0" + inputString;
            return inputString;
        }
    }
}
