namespace HelloCSharp.Domain
{
    public class Bird : Being, IAnimal
    {
        public Bird()
        {
            Domestic = false;
        }

        public void Domesticate()
        {
            Domestic = true;
        }

        public bool Domestic { get; private set; }
    }
}