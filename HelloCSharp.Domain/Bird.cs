namespace HelloCSharp.Domain
{
    public class Bird : Being, IAnimal
    {
        public Bird()
        {
            Domestic = false;
        }

        public bool Domestic { get; private set; }

        public void Domesticate()
        {
            Domestic = true;
        }
    }
}