using System.Diagnostics;

namespace ProjectEuler.Problem3
{
    public class Program
    {
        const long NUMBER = 600851475143L;
        static long largestPrime;
        public static void Main(string[] args)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            largestPrime = GetLargestPrime(NUMBER);
            stopwatch.Stop();
            Console.WriteLine("Run Time: " + stopwatch.ElapsedMilliseconds/1000.0 + "s");
            System.Console.WriteLine($"Largest Prime of 600,851,475,143 is {largestPrime}");
        }
        public static long GetLargestPrime(long NUMBER)
        {
            long divisor = 3;
            long primeNumber = 0;
            while(divisor < NUMBER/2)
            {
                if(NUMBER % divisor == 0)
                {
                    System.Console.WriteLine($"Testing Primality of {divisor}");
                    if(IsPrime(divisor))
                    {
                        primeNumber = divisor;
                    }
                }
                divisor += 2;
            }
            return primeNumber;
        }
        public static bool IsPrime(long factor)
        {
            long  sqrtOfFactor = (long)Math.Floor(Math.Sqrt(factor));

            if(factor == 0 || factor == 1) return false;
            if(factor == 2 || factor == 3 || factor ==5) return true;
            if(factor % 2 == 0)  return false;

            long i = 3;

            while(i <= sqrtOfFactor)
            {
                if(factor % i == 0)
                    return false;

                i += 2;    
            }

            return true;
        }
    }
}