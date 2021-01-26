using System;
using System.Collections.Generic;
using System.Text;

namespace HelloCSharp.Domain
{
    public class Wrapping : IItem
    {
        private object _something;
        private SandwichLabel _label;

        public Wrapping(bool hermetic, bool multiuse)
        {
            Hermetic = hermetic;
            Multiuse = multiuse;
        }

        public bool Multiuse { get; private set; }

        public bool Hermetic { get; private set; }

        public DateTime ExpDate { get; }

        public void Put(object item, SandwichLabel label = null)
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

        public object Takeout()
        {
            object something = _something;
            _something = default;
            _label = default;
            return something;
        }
    }

    public class Jar : Wrapping
    {
        public Jar() : base(false, true)
        {
        }
    }
}
