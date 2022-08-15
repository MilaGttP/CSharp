
using System;
using System.Linq;

namespace LINQToObject
{
    public static class Operations
    {
        public static int[] FirstPositiveLastNegative(this int[] sequency)
        {
            var result = from number in sequency
                         group number by number > 0 into posRes
                         group number by number < 0 into negRes
                         from pos in posRes select pos.First();
                         from neg in negRes select neg.Last();
            return result;
        }
    }
}
