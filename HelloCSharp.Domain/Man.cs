namespace HelloCSharp.Domain
{
    public class Man : Human
    {
        public override string Gender => "man";
    }

    public abstract class Human : Being
    {
        public abstract string Gender { get; }
        public float Weight { get; }
        public int Age { get; }
        public int HeartRate { get; }
        public void Eat(Sandwich sandwich)
        {
            throw new System.NotImplementedException();
        }
    }
}