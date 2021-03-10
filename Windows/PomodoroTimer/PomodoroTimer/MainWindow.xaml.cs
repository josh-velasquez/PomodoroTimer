using System;
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
        private SoundPlayer player = null;
        public MainWindow()
        {
            InitializeComponent();

            Timer = new DispatcherTimer(DispatcherPriority.Send);
            Timer.Interval = new TimeSpan(0, 0, 1);
            Timer.Tick += TimerTick;
        }

        private void TimerTick(object sender, EventArgs e)
        {
            if (time > 0)
            {
                time--;
                UpdateTime();
            }
            else
            {
                if (WindowState == WindowState.Minimized)
                {
                    WindowState = WindowState.Normal;
                }
                Activate();
                Timer.Stop();
                // POPUP THAT SAYS DONE!... BUTTON THAT STOPS PLAYING THE SOUND
                player = new SoundPlayer(Properties.Resources.alarm);
                player.PlayLooping();
            }
        }

        private void UpdateTime()
        {
            TimerTextBlock.Text = string.Format("{0:00}:{1:00}", time / 60, time % 60);
        }

        private void OnWorkClick(object sender, RoutedEventArgs e)
        {
            Timer.Stop();
            time = 1500;
            UpdateTime();
        }

        private void OnSmallBreakClick(object sender, RoutedEventArgs e)
        {
            Timer.Stop();
            time = 300;
            UpdateTime();
        }

        private void OnBigBreakClick(object sender, RoutedEventArgs e)
        {
            Timer.Stop();
            time = 1800;
            UpdateTime();
        }

        private void OnStartClick(object sender, RoutedEventArgs e)
        {
            Timer.Stop();
            Timer.Start();
        }

        private void OnPauseClick(object sender, RoutedEventArgs e)
        {
            Timer.Stop();
            if (player != null)
            {
                player.Stop();
            }
            
        }

        private void OnCustomClick(object sender, RoutedEventArgs e)
        {
            Timer.Stop();
            time = 15;
            UpdateTime();
        }
    }
}