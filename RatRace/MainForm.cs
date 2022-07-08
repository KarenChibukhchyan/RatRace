using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace RatRace
{
    public partial class MainForm : Form
    {
        int initialX = 23;
        int step = 5;
        bool finished;

        public MainForm()
        {
            InitializeComponent();
        }

        private void Run(Button button, object lockObject)
        {
            int sleepInterval = new Random().Next(100, 500);
            while (!finished)
            {
                Thread.Sleep(sleepInterval);
                button.Location = new Point(button.Location.X + step, button.Location.Y);
                if (button.Location.X >= finishLabel.Location.X)
                {
                    lock (lockObject)
                    {
                        finished = true;
                    }
                }
            }

            button.Location = new Point(initialX, button.Location.Y);
        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            Thread t = new Thread(new ThreadStart(Run));

        }
    }
}