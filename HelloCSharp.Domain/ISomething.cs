using System;

namespace HelloCSharp.Domain
{
    public interface ISomething
    {
        float Weight { get; }

        int Age { get; }
    }

    public interface Being : ISomething
    {
        int HeartRate { get; }

        void Eat(Sandwich sandwich);
    }

    public interface IAnimal : IBeing
    {
        bool Domestic { get; }
    }

    public class Bird : IAnimal
    {
        public Bird()
        {
            Domestic = false;
        }

        public int HeartRate { get; }

        public void Eat(Sandwich sandwich)
        {
            throw new System.NotImplementedException();
        }

        public void Domesticate()
        {
            Domestic = true;
        }

        public bool Domestic { get; private set; }

        public float Weight { get; }

        public int Age { get; }
    }

    public class Dog : IAnimal
    {
        public int HeartRate { get; }

        public void Eat(Sandwich sandwich)
        {
            throw new System.NotImplementedException();
        }

        public bool Domestic => true;

        public float Weight { get; }

        public int Age { get; }
    }
}