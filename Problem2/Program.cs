
namespace ProjectEuler.Problem2
{
    public class Program
    {
        /*
            Calculate the Fibonacci sequence up to NUMBER_LIMIT
            While calculating, store each even number in a list
            Get the sum of the numbers in the list
        */
        public static void Main(string[] args)
        {
            const long NUMBER_LIMIT = 4000000L;
            long evenSum = default;
            long fibSum = default;
            long n = 0;
            
            while(fibSum <= NUMBER_LIMIT)
            {
                fibSum = nThFibonacciSum(n);

                if(fibSum % 2 == 0)
                {
                    evenSum += fibSum;
                }

                n++;
            }

            System.Console.WriteLine($"The sum is {evenSum}");
        }

        public static long nThFibonacciSum(long n)
        {
            if(n == 0 || n == 1) 
            {
                return n;
            }
            else
            {
                return nThFibonacciSum(n - 1) + nThFibonacciSum(n -2);
            }
        }
    }
}