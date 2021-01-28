using System;
using System.Runtime.Remoting;
using System.Threading;

namespace HelloCSharp.Domain
{
    public class Sandwich : Object, IItem, IEquatable<Sandwich>, IEquatable<Wrapping<Sandwich>>, IComparable<Sandwich>, IComparable<Wrapping<Sandwich>>
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

        public bool Equals(Sandwich other)
        {
            return Size == other.Size;
        }

        public bool Equals(Wrapping<Sandwich> other)
        {
            return Size == other.Label.Size;
        }

        public int CompareTo(Sandwich other)
        {
            return (int)Size.CompareTo((int)(other.Size));
        }

        public int CompareTo(Wrapping<Sandwich> other)
        {
            return Size.CompareTo(other.Label.Size);
        }

        public override bool Equals(object? obj)
        {
            var other = obj as Sandwich;
            if (other == null)
            {
                return false;
            }

            return Equals(other);
        }

        private SandwichSize ComputeSize(in int grams)
        {
            return SandwichSize.Small;
        }
    }
}