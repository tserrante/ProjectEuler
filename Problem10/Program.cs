namespace ProjectEuler.Problem10;

public class Program
{
    static void Main()
    {
        System.Console.WriteLine("Sum of all primes below 2 million is... ");
        System.Console.WriteLine(SumOfAllPrimes());
    }

    static long SumOfAllPrimes(long number = 2000000)
    {
        long total = default;

        for(long i = 0; i < number; i++)
        {
            if(IsPrimeByTrial(i))
            {
                total += i;
            }
        }

        return total;
    }

    static bool IsPrimeByTrial(long n)
    {
        if(n == 2)  return true;
        
        if(n == 0 || n == 1 || n % 2 == 0)  return false;
        

        long boundary = (long)Math.Floor(Math.Sqrt(n)) + 1;

        for(long i = 3; i < boundary; i += 2)
        {
            if(n % i == 0)
                return false;
        }

        return true;
    }
}