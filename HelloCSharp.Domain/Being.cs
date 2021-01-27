using HelloCSharp.Tools.Physics;

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

        public Weight Weight { get; }

        public int Age { get; }

        public virtual string GiveVoice()
        {
            return "aaaaaaa";
        }
    }
}