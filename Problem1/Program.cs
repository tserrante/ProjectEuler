using System.Collections.Generic;

namespace ProjectEuler.Problem1
{
    public class Program
    {
        // the ranges are non-inclusive in the resulting sum i.e. 1-999 is used
        const int RANGE_START = 0;
        const int RANGE_END = 1000;
        public static void Main(string[] args)
        {
            long sum = 0;
            for(int i = RANGE_START; i < RANGE_END; i++)
            {
                if(i % 3 == 0 || i % 5 == 0)
                {
                    sum += i;
                }
            }

            System.Console.WriteLine($"Sum:\t{sum}");
        }
    }
}