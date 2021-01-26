using System;
using HelloCSharp.Tools.Physics;

namespace HelloCSharp.Domain
{
    public interface ISomething
    {
        Weight Weight { get; }

        int Age { get; }
    }
}