using System;
using System.Threading;

namespace HelloCSharp.Domain
{
    public class Sandwich : IItem
    {
        private DateTime _expDate = DateTime.Now.AddDays(10);
        
        public Sandwich(int grams)
        {
            Size = ComputeSize(grams);
            ExpDate = DateTime.Now.AddDays(10); 
        }

        public string Size { get; }

        public DateTime ExpDate { get; private set; }

        private string ComputeSize(in int grams)
        {
            throw new System.NotImplementedException();
        }
    }
}