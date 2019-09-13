using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace Shutdown
{
    public partial class ShutdownWindow : Form
    {
        readonly Timer Timer = new Timer()
        {
            Interval = 1000,
            Enabled = false,
        };

        protected int TotalSeconds
        {
            get
            {
                return Hours.Value * 3600 + Minutes.Value * 60 + Seconds.Value;
            }
            set
            {
                Hours.Value = value / 3600;
                Minutes.Value = (value - Hours.Value * 3600) / 60;
                Seconds.Value = value - Hours.Value * 3600 - Minutes.Value * 60;
            }
        }

        public ShutdownWindow()
        {
            InitializeComponent();
            Timer.Tick += Timer_Tick;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            TotalSeconds--;
        }

        private void ShutdownButton_Click(object sender, EventArgs e)
        {
            StartCmd($"/C shutdown /s /t {TotalSeconds}");
            Hours.Enabled = Minutes.Enabled = Seconds.Enabled = false;
            Timer.Start();
        }

        private void RestartButton_Click(object sender, EventArgs e)
        {
            StartCmd($"/C shutdown /r /t {TotalSeconds}");
            Hours.Enabled = Minutes.Enabled = Seconds.Enabled = false;
            Timer.Start();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            StartCmd("/C shutdown /a");
            Hours.Enabled = Minutes.Enabled = Seconds.Enabled = true;
            Timer.Stop();
        }

        private void StartCmd(string arguments)
        {
            var process = new Process();
            var startInfo = new ProcessStartInfo();
            startInfo.WindowStyle = ProcessWindowStyle.Hidden;
            startInfo.FileName = "cmd.exe";
            startInfo.Arguments = arguments;

            process.StartInfo = startInfo;
            process.Start();
        }
    }
}
