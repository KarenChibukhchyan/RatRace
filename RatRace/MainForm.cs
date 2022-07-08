using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace RatRace
{
    public partial class MainForm : Form
    {
        int initialX = 23;
        int step = 20;
        bool _finished;
        readonly object _lock = new object();

        public MainForm()
        {
            InitializeComponent();
        }

        private void Run(object objButton)
        {
            var button = (Button) objButton;
            int sleepInterval = new Random().Next(10, 1000);
            while (!_finished)
            {
                Thread.Sleep(sleepInterval);
                lock (_lock)
                {
                    button.Location = new Point(button.Location.X + step, button.Location.Y);
                    if (button.Location.X + button.Size.Width >= finishLabel.Location.X)
                    {
                        {
                            _finished = true;
                        }
                    }
                }
            }

            button.Location = new Point(initialX, button.Location.Y);
        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            _finished = false;
            new Thread(new ParameterizedThreadStart(Run)).Start(nikolikBtn);
            new Thread(new ParameterizedThreadStart(Run)).Start(serjikBtn);
            new Thread(new ParameterizedThreadStart(Run)).Start(robikBtn);
        }
    }
}