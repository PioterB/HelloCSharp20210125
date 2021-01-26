namespace HelloCSharp.Domain
{
    public class Man : Human
    {
        public static int MinManAge = 19;

        public override string Gender => "man";
    }
}