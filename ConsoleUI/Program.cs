using System;
using TimerLogic;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Timer = TimerLogic.Timer;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            var timer = new Timer();
            var alarm = new Alarm();
            var calendar = new Calendar();
            timer.Interval = 5000;
            alarm.Register(timer);
            calendar.Register(timer);
            timer.Start("Hey!", "Get up!");
            //alarm.Unregister(timer);
            //calendar.Unregister(timer);

            Console.ReadKey();
        }
    }

    class Alarm
    {
        public void Register(Timer timer) => timer.TimePassed += AlarmMsg;
        public void Unregister(Timer timer) => timer.TimePassed -= AlarmMsg;

        private void AlarmMsg(object sender, TimePassedEventArgs eventArgs)
        {
            Console.WriteLine("Time passed!");
            Console.WriteLine($"{eventArgs.Title}{Environment.NewLine}{eventArgs.Subject}");
            PlayMusic();
        }

        private void PlayMusic()
        {
            Console.Beep(659, 300);
            Console.Beep(659, 300);
            Console.Beep(659, 300);
            Thread.Sleep(300);
            Console.Beep(659, 300);
            Console.Beep(659, 300);
            Console.Beep(659, 300);
            Thread.Sleep(300);
            Console.Beep(659, 300);
            Console.Beep(783, 300);
            Console.Beep(523, 300);
            Console.Beep(587, 300);
            Console.Beep(659, 300);
            Console.Beep(261, 300);
            Console.Beep(293, 300);
            Console.Beep(329, 300);
            Console.Beep(698, 300);
            Console.Beep(698, 300);
            Console.Beep(698, 300);
            Thread.Sleep(300);
            Console.Beep(698, 300);
            Console.Beep(659, 300);
            Console.Beep(659, 300);
            Thread.Sleep(300);
            Console.Beep(659, 300);
            Console.Beep(587, 300);
            Console.Beep(587, 300);
            Console.Beep(659, 300);
            Console.Beep(587, 300);
            Thread.Sleep(300);
            Console.Beep(783, 300);
            Thread.Sleep(300);
            Console.Beep(659, 300);
            Console.Beep(659, 300);
            Console.Beep(659, 300);
            Thread.Sleep(300);
            Console.Beep(659, 300);
            Console.Beep(659, 300);
            Console.Beep(659, 300);
            Thread.Sleep(300);
            Console.Beep(659, 300);
            Console.Beep(783, 300);
            Console.Beep(523, 300);
            Console.Beep(587, 300);
            Console.Beep(659, 300);
            Console.Beep(261, 300);
            Console.Beep(293, 300);
            Console.Beep(329, 300);
            Console.Beep(698, 300);
            Console.Beep(698, 300);
            Console.Beep(698, 300);
            Thread.Sleep(300);
            Console.Beep(698, 300);
            Console.Beep(659, 300);
            Console.Beep(659, 300);
            Thread.Sleep(300);
            Console.Beep(783, 300);
            Console.Beep(783, 300);
            Console.Beep(698, 300);
            Console.Beep(587, 300);
            Console.Beep(523, 600);
            Thread.Sleep(600);
        }
    }

    class Calendar
    {
        public void Register(Timer timer) => timer.TimePassed += CalendarMsg;
        public void Unregister(Timer timer) => timer.TimePassed -= CalendarMsg;

        private void CalendarMsg(object sender, TimePassedEventArgs eventArgs)
        {
            Console.WriteLine("It's calendar!");
            Console.WriteLine($"{eventArgs.Title}{Environment.NewLine}{eventArgs.Subject}");
            PlayMusic();
        }

        private void PlayMusic()
        {
            Console.Beep(784, 150);
            Thread.Sleep(300);
            Console.Beep(784, 150);
            Thread.Sleep(300);
            Console.Beep(932, 150);
            Thread.Sleep(150);
            Console.Beep(1047, 150);
            Thread.Sleep(150);
            Console.Beep(784, 150);
            Thread.Sleep(300);
            Console.Beep(784, 150);
            Thread.Sleep(300);
            Console.Beep(699, 150);
            Thread.Sleep(150);
            Console.Beep(740, 150);
            Thread.Sleep(150);
            Console.Beep(784, 150);
            Thread.Sleep(300);
            Console.Beep(784, 150);
            Thread.Sleep(300);
            Console.Beep(932, 150);
            Thread.Sleep(150);
            Console.Beep(1047, 150);
            Thread.Sleep(150);
            Console.Beep(784, 150);
            Thread.Sleep(300);
            Console.Beep(784, 150);
            Thread.Sleep(300);
            Console.Beep(699, 150);
            Thread.Sleep(150);
            Console.Beep(740, 150);
            Thread.Sleep(150);
            Console.Beep(932, 150);
            Console.Beep(784, 150);
            Console.Beep(587, 1200);
            Thread.Sleep(75);
            Console.Beep(932, 150);
            Console.Beep(784, 150);
            Console.Beep(554, 1200);
            Thread.Sleep(75);
            Console.Beep(932, 150);
            Console.Beep(784, 150);
            Console.Beep(523, 1200);
            Thread.Sleep(150);
            Console.Beep(466, 150);
            Console.Beep(523, 150);
        }
    }
}
