using System;
using System.Reflection;

namespace Exercises
{
    public class Exercise004
    {
        const double GIGASECOND = 1E9;

        //Adding gigaseconds -> 10^9 -> (1,000,000,000) seconds to the given date
        public static DateTime AddGigaSecond(DateTime dateTime)
        
            => dateTime.AddSeconds(GIGASECOND);
                   
    }
}
