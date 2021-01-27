namespace HelloCSharp.Domain
{
    public abstract class Human : Being
    {
        public abstract string Gender { get; }

        public override string GiveVoice()
        {
            return "human being";
        }
    }
}