using System;
using System.Collections.Generic;
using System.Text;

namespace HelloCSharp.Domain
{
    public class Wrapping<TContent> : IItem, IEquatable<Wrapping<TContent>>, IEquatable<TContent>
    {
        private TContent _something;
        private SandwichLabel _label;

        public Wrapping(bool hermetic, bool multiuse)
        {
            Hermetic = hermetic;
            Multiuse = multiuse;
        }

        public bool Multiuse { get; private set; }

        public bool Hermetic { get; private set; }

        public DateTime ExpDate { get; }

        public bool HasContent => _something != null;

        public SandwichLabel Label => _label;

        public void Put(TContent item, SandwichLabel label = null)
        {
            if (Multiuse == false)
            {
                throw new InvalidOperationException("is not multi use, can not be used");
            }

            if (_something != null)
            {
                throw new InvalidOperationException("taken, sandwich is there");
            }

            _something = item;
            _label = label;
        }

        public TContent Takeout()
        {
            TContent something = _something;
            _something = default;
            _label = default;
            return something;
        }

        public bool Equals(Wrapping<object> other)
        {
            return Hermetic == other.Hermetic && Multiuse == other.Multiuse;
        }

        public override bool Equals(object? obj)
        {
            return obj is Wrapping<TContent> other && Equals(other);
        }

        public bool Equals(Wrapping<TContent> other)
        {
            return Label.Equals(other.Label);
        }

        public bool Equals(TContent other)
        {
            throw new NotImplementedException();
        }
    }

    public class Jar<TContent> : Wrapping<TContent> where TContent : IPowder, ISpice
    {
        public Jar() : base(false, true)
        {
        }
    }

    public interface ISpice
    {
    }

    public interface IPowder
    {
    }
}
