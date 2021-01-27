namespace HelloCSharp.Domain
{
    public class Man : Human
    {
        public static int MinManAge = 19;

        public Man(string name)
        {
            Name = name;
        }

        public string Name { get; }

        public override string Gender => "man";

        public override string GiveVoice()
        {
            return "I'm The Man";
        }
    }
}