using System;
using HelloCSharp.Domain;
using HelloCSharp.Tools.Physics;

namespace HelloCSharp.AppCL
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var sandwich = new Sandwich(50);

            var paper = new Wrapping(false, false); 
            var plasticBag = new Wrapping(false, true); 

            var jar = new Jar();

            var man = new Man();
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

        private void NamedConstructors()
        {
            var g100 = Weight.FromGrams(100);
            var oneKg = Weight.FromKilograms(1);
        }

        private void EnumerationSamples()
        {
            var box = new Jar();
            var food = new Sandwich(300);
            var label = new SandwichLabel("double burger", SandwichSize.Small, 
                Allergens.Milk | Allergens.Sesame);
            box.Put(food, label);
        }
    }
}
