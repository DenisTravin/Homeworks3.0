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
            button1.Text = DateTime.Now.Hour.ToString() + " : " + DateTime.Now.Minute.ToString() + " : " + DateTime.Now.Second.ToString();
        }
    }
}
