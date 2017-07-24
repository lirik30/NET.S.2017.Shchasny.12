using System;
using System.Diagnostics;
using System.Threading;

namespace TimerLogic
{
    /// <summary>
    /// Imitation of timer
    /// </summary>
    public class Timer
    {
        private long _interval;

        /// <summary>
        /// Time in milliseconds
        /// </summary>
        public long Interval
        {
            get => _interval;
            set => _interval = value >= 0 ? value : throw new ArgumentOutOfRangeException();
        }

        /// <summary>
        /// Contains events that will happen when time will passed
        /// </summary>
        public event EventHandler<TimePassedEventArgs> TimePassed = delegate { };

        #region ctors

        public Timer() : this(0) {}

        public Timer(long interval) => Interval = interval;
        #endregion
        

        protected virtual void OnTimePassed(TimePassedEventArgs eventArgs)
        {
            EventHandler<TimePassedEventArgs> temp = TimePassed;
            temp?.Invoke(this, eventArgs);
        }


        /// <summary>
        /// Start the timer
        /// </summary>
        /// <param name="title">Title of message</param>
        /// <param name="subject">Subject of message</param>
        public void Start(string title, string subject)
        {
            var s = Stopwatch.StartNew();//??????
            Thread thread = new Thread(() =>
            {
                while (s.ElapsedMilliseconds != Interval) { }
                OnTimePassed(new TimePassedEventArgs(title, subject));
            });  
            thread.Start();

            
        }
    }

    #region TimePassedEventArgs
    /// <summary>
    /// Keep information about the TimePassed event
    /// </summary>
    public class TimePassedEventArgs : EventArgs
    {
        public string Title { get; }
        public string Subject { get; }

        public TimePassedEventArgs(string title, string subject)
        {
            Title = title;
            Subject = subject;
        }
    }
    #endregion
}
