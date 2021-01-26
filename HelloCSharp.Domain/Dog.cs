namespace HelloCSharp.Domain
{
    public class Dog : Being, IAnimal
    {
        public bool Domestic => true;
    }
}