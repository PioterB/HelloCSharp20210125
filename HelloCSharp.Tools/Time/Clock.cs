using System;
using System.Threading;

namespace HelloCSharp.Tools.Time
{
    public class Clock
    {
        private static readonly Thread ElapsingTime;
        private static readonly object Locker = new object();
        private static int _year;
        private static int _day;
        private static bool _isRunning = false;

        static Clock()
        {
            ElapsingTime = new Thread(EvaluateTime);
            ElapsingTime.IsBackground = true;
        }

        private Clock()
        {
        }

        public static Time Time
        {
            get
            {
                lock (Locker)
                {
                    return new Time(_year, _day);
                }
            }
        }

        public static void Start()
        {
            _isRunning = true;
            ElapsingTime.Start();
        }

        public static void Stop()
        {
            _isRunning = false;
            ElapsingTime.Join();
        }

        private static void EvaluateTime()
        {
            while (_isRunning)
            {
                lock (Locker)
                {
                    _day++;
                }

                ReportDayChange(_day, _year);

                Thread.Sleep(240); // 240 msec, 1d elapsed

                lock (Locker)
                {
                    if (_day == 365)
                    {
                        _year++;
                        _day = 0;
                    }
                }

                if (_day == 0)
                {
                    ReportYearChange(_year);
                }
            }
        }

        public void Method(Time t, NewDateDelegate x)
        {
            x(t);
        }

    private static void ReportYearChange(int year)
        {
            var handler = NewYear;
            if (handler == null)
            {
                return;
            }

            handler.Invoke(year);
        }

        public static event NewYearDelegate NewYear;
        public static event NewDateDelegate NewDay;

        private static void ReportDayChange(int day, int year)
        {
            var handler = NewDay;
            if (handler == null)
            {
                return;
            }

            handler.Invoke(new Time(year, day));
        }
    }

    public delegate void NewDateDelegate(Time time);

    public delegate void NewYearDelegate(int year);
}