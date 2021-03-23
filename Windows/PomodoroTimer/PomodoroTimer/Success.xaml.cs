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

        public event EventHandler UpdateNewTime;

        public int NewTime = 0;

        public Success(SoundPlayer player, TimerType timerType)
        {
            InitializeComponent();
            Topmost = true;
            this.player = player;
            switch (timerType)
            {
                case TimerType.LongBreak:
                    MessageBox.Text = "Long break time is over. Time to get back to work!";
                    break;

                case TimerType.ShortBreak:
                    MessageBox.Text = "Short break time is over. Time to get back to work!";
                    break;

                case TimerType.Work:
                    MessageBox.Text = "Work time is over. Take a break!";
                    break;

                default:
                    MessageBox.Text = "Done!";
                    break;
            }
        }

        private void OnMoreMinutesClick(object sender, RoutedEventArgs e)
        {
            NewTime = 300;
            CloseWindow(e);
        }

        private void OnStopAlarmClick(object sender, RoutedEventArgs e)
        {
            StopPlayer();
            CloseWindow(e);
        }

        private void CloseWindow(EventArgs e)
        {
            StopPlayer();
            UpdateNewTime.Invoke(this, e);
            Hide();
        }

        private void OnCloseWindow(object sender, System.ComponentModel.CancelEventArgs e)
        {
            CloseWindow(e);
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