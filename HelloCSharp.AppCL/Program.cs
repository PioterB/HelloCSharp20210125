using System;
using HelloCSharp.Domain;

namespace HelloCSharp.AppCL
{
    class Program
    {
        protected static int _fieldInClass;
        private int _myValue;

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var sandwich = new Sandwich(50);

            var paper = new Wrapping(false, false); 
            var plasticBag = new Wrapping(false, true); 

            var jar = new Jar();

            var man = new Man();
            man.Gender;

            Man.MinManAge;
        }

        private void BuildInTypes()
        {
            int numeric = 5;
            Int32 sameAsInt = 5;
            float withFactalValue = 1.5f;
            decimal money = 34.45m;
            string text = "my text";
            byte bits8 = 0x1F;
            Int64 bigNumer;
            uint noNegative = 1;
            short bits16 = 128;
        }
    }
}
