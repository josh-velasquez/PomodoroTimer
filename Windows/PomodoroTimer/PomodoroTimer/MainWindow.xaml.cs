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
        private Success success = null;

        private TimerType timerType;

        public MainWindow()
        {
            InitializeComponent();
            Topmost = true;
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
                TimerFinished();
            }
        }

        private void TimerFinished()
        {
            if (WindowState == WindowState.Minimized)
            {
                WindowState = WindowState.Normal;
            }
            Activate();
            Timer.Stop();
            player = new SoundPlayer(Properties.Resources.alarm);
            player.PlayLooping();
            success = new Success(player, timerType);
            success.Show();
            success.UpdateNewTime += UpdateNewTime;
            StartButton.IsEnabled = true;
        }

        private void UpdateNewTime(object sender, EventArgs e)
        {
            time = success.NewTime;
            UpdateTime();
            StartTimer();
        }

        private void UpdateTime()
        {
            TimerTextBlock.Text = string.Format("{0:00}:{1:00}", time / 60, time % 60);
        }

        private void OnWorkClick(object sender, RoutedEventArgs e)
        {
            Timer.Stop();
            time = 1500;
            SetTimerType(TimerType.Work);
            UpdateTime();
        }

        private void OnStartClick(object sender, RoutedEventArgs e)
        {
            StartTimer();
        }

        private void StartTimer()
        {
            if (time != 0)
            {
                StartButton.IsEnabled = false;
                Timer.Start();
            }
        }

        private void OnPauseClick(object sender, RoutedEventArgs e)
        {
            if (time > 0)
            {
                Timer.Stop();
                StartButton.IsEnabled = true;
            }
        }

        private void OnCustomClick(object sender, RoutedEventArgs e)
        {
            Timer.Stop();
            time = 5;
            SetTimerType(TimerType.Custom);
            UpdateTime();
        }

        private void SetTimerType(TimerType type)
        {
            timerType = type;
        }

        private void OnCloseParentWindow(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void OnLongBreakClick(object sender, RoutedEventArgs e)
        {
            Timer.Stop();
            time = 1800;
            SetTimerType(TimerType.LongBreak);
            UpdateTime();
        }

        private void OnShortBreakClick(object sender, RoutedEventArgs e)
        {
            Timer.Stop();
            time = 300;
            SetTimerType(TimerType.ShortBreak);
            UpdateTime();
        }
    }
}