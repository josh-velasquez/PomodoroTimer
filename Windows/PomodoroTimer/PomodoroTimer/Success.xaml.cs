using System;
using System.Media;
using System.Windows;

namespace PomodoroTimer
{
    /// <summary>
    /// Interaction logic for Success.xaml
    /// </summary>
    public partial class Success : Window
    {
        private SoundPlayer player = null;

        public event Action<int> NewTime;

        public Success(SoundPlayer player)
        {
            InitializeComponent();
            Topmost = true;
            this.player = player;
        }

        private void OnTakeABreakClick(object sender, RoutedEventArgs e)
        {
            if (NewTime != null)
            {
                NewTime(300);
                CloseWindow();
            }
        }

        private void OnMoreMinutesClick(object sender, RoutedEventArgs e)
        {
            if (NewTime != null)
            {
                NewTime(300);
                CloseWindow();
            }
        }

        private void OnStopAlarmClick(object sender, RoutedEventArgs e)
        {
            StopPlayer();
        }

        private void OnTakeALongBreakClick(object sender, RoutedEventArgs e)
        {
            if (NewTime != null)
            {
                NewTime(1800);
                CloseWindow();
            }
        }

        private void CloseWindow()
        {
            StopPlayer();
            //Environment.Exit(0);
        }

        private void OnCloseWindow(object sender, System.ComponentModel.CancelEventArgs e)
        {
            CloseWindow();
        }

        private void StopPlayer()
        {
            if (player != null)
            {
                player.Stop();
            }
        }
    }
}