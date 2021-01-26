using System;

namespace HelloCSharp.Domain
{
    [Flags]
    public enum Allergens : byte
    {
        Milk = 1,
        Sesame = 1 << 1,
        Nuts = 1 << 2,
        Fish = 1 << 3,
        Egs = 1 << 4,
    }
}