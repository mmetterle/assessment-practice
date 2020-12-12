using System;
using System.Collections.Generic;
using System.Text;

namespace problems
{
    public static class Extensions
    {
        public static T[] SubArray<T>(this T[] array, int offset, int length)
        {
            return new List<T>(array)
                .GetRange(offset, length)
                .ToArray();
        }
    }
}
