using System;
using System.Windows;
using System.Windows.Threading;

namespace PomodoroTimer
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int time = 20;
        private DispatcherTimer Timer;
        public MainWindow()
        {
            InitializeComponent();
            Timer = new DispatcherTimer();
            Timer.Interval = new TimeSpan(0, 0, 1);
            Timer.Tick += TimerTick;
            Timer.Start();
        }

        private void TimerTick(object sender, EventArgs e)
        {
            if (time > 0)
            {
                time--;
                TimerTextBlock.Text = string.Format("00:0{0}:0{1}", time / 60, time % 60);
            } else
            {
                Timer.Stop();
            }
        }
    }
}
