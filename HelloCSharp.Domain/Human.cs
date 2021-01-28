using System;
using HelloCSharp.Tools.Time;

namespace HelloCSharp.Domain
{
    public abstract class Human : Being, IDisposable
    {
        private int _dob;

        public Human()
        {
            _dob = Clock.Time.Day;
            Clock.NewDay += OnDayChange;
        }

        ~Human()
        {
            ReleaseUnmanagedResources();
        }

        private void OnDayChange(Time time)
        {
            if (_dob != time.Day)
            {
                return;
            }

            IncrementAge();
        }

        public abstract string Gender { get; }

        public override string GiveVoice()
        {
            return "human being";
        }

        private void ReleaseUnmanagedResources()
        {
            Clock.NewDay -= OnDayChange;
        }

        public void Dispose()
        {
            ReleaseUnmanagedResources();
            GC.SuppressFinalize(this);
        }
    }
}