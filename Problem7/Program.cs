namespace ProjectEuler.Problem7;

public class Program
{
    public static int primeRange = 10001;
    public static void Main(string[] args)
    {
        int primeAtRange = GetPrimeAtRange(primeRange);
        System.Console.WriteLine($"{primeAtRange} is the {primeRange} prime number");
    }

    public static int GetPrimeAtRange(int range)
    {
        int primeAtRange = 0;
        int number = 0;
        int primeCount = 1;
        
        while(primeCount < range+1)
        {
            if(IsPrime(number))
            {
                System.Console.WriteLine($"Prime #{primeCount} found: {number}");
                primeAtRange = number;
                primeCount++;
            }
            number++;
        }

        return primeAtRange;
    }

    public static bool IsPrime(long factor)
        {

            if(factor == 0 || factor == 1) return false;
            if(factor == 2 || factor == 3 || factor ==5) return true;
            if(factor % 2 == 0)  return false;

            long  sqrtOfFactor = (long)Math.Floor(Math.Sqrt(factor));

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