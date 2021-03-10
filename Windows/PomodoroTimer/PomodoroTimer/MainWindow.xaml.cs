using System;
using System.IO;
using System.Media;
using System.Windows;
using System.Windows.Threading;

namespace PomodoroTimer
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int time = 0;
        private DispatcherTimer Timer;
        public MainWindow()
        {
            InitializeComponent();

            Timer = new DispatcherTimer();
            Timer.Interval = new TimeSpan(0, 0, 1);
            Timer.Tick += TimerTick;
        }

        private void TimerTick(object sender, EventArgs e)
        {
            if (time > 0)
            {
                time--;
                TimerTextBlock.Text = string.Format("0{0}:0{1}", time / 60, time % 60);
            }
            else
            {
                Timer.Stop();
                // POPUP THAT SAYS DONE!... BUTTON THAT STOPS PLAYING THE SOUND
                SoundPlayer player = new SoundPlayer(Properties.Resources.alarm);
                player.PlayLooping();
            }
        }

        private void OnWorkClick(object sender, RoutedEventArgs e)
        {
            Timer.Stop();
            time = 1500;
            TimerTextBlock.Text = "25:00";
        }

        private void OnSmallBreakClick(object sender, RoutedEventArgs e)
        {
            Timer.Stop();
            time = 300;
            TimerTextBlock.Text = "05:00";
        }

        private void OnBigBreakClick(object sender, RoutedEventArgs e)
        {
            Timer.Stop();
            time = 1800;
            TimerTextBlock.Text = "30:00";
        }

        private void OnStartClick(object sender, RoutedEventArgs e)
        {
            Timer.Start();
        }

        private void OnPauseClick(object sender, RoutedEventArgs e)
        {
            Timer.Stop();
        }

        private void OnCustomClick(object sender, RoutedEventArgs e)
        {
            Timer.Stop();
            time = 2;
            TimerTextBlock.Text = "00:02";
        }
    }
}
