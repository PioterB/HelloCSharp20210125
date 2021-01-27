namespace HelloCSharp.Tools.Time
{
    public struct Time
    {
        public Time(int year, int day)
        {
            Year = year;
            Day = day;
        }

        public int Year { get; }
        public int Day { get; }
    }
}