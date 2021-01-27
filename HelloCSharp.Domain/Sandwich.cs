using System;
using System.Threading;

namespace HelloCSharp.Domain
{
    public class Sandwich : Object, IItem
    {
        private DateTime _expDate = DateTime.Now.AddDays(10);
        
        public Sandwich(int grams)
        {
            Size = ComputeSize(grams);
            ExpDate = DateTime.Now.AddDays(10); 
        }

        public SandwichSize Size { get; }

        public DateTime ExpDate { get; private set; }

        public override string ToString()
        {
            return base.ToString() + " " + Size + " size";
        }

        private SandwichSize ComputeSize(in int grams)
        {
            return SandwichSize.Small;
        }
    }
}