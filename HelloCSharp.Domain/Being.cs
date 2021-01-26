namespace HelloCSharp.Domain
{
    public class Being : ISomething
    {
        public int HeartRate { get; }

        public void Eat(Sandwich sandwich)
        {
            /*
             * logic for eating
             */
        }

        public float Weight { get; }

        public int Age { get; }
    }
}