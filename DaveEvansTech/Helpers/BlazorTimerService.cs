using System;
using System.Timers;

namespace DaveEvansTech.Helpers
{
    public class BlazorTimerService
    {
        private Timer _timer;

        public void SetTimer(double intervalMilliseconds, bool repeat)
        {
            _timer = new Timer(intervalMilliseconds);
            _timer.Elapsed += NotifyTimerElapsed;
            _timer.AutoReset = repeat;
            _timer.Enabled = true;
        }

        public void StopTimer()
        {
            _timer.Stop();
            _timer.Dispose();
            _timer = null;
        }

        public event Action OnElapsed;

        private void NotifyTimerElapsed(object source, ElapsedEventArgs e)
        {
            OnElapsed?.Invoke();
            if (!_timer.AutoReset)
            {
                _timer.Stop();
                _timer.Dispose();
                _timer = null;
            }
        }
    }
}