namespace HelloCSharp.Domain
{
    public class Being : ISomething
    {

        public void Eat(Sandwich sandwich)
        {
            /*
             * logic for eating
             */
        }
        public int HeartRate { get; }

        public float Weight { get; }

        public int Age { get; }
    }
}