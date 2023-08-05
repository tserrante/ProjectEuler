namespace ProjectEuler.Problem5;

public class Program
{
    static int startNumber = 1;
    static int endNumber = 20;
    public static void Main(string[] args)
    {
        int smallestDivisibleNumber = GetSmallestDivisibleNumber_BruteForce(startNumber,endNumber);
        System.Console.WriteLine($"Smallest Divisible Number by 1-20: {smallestDivisibleNumber}");
    }

    public static int GetSmallestDivisibleNumber_BruteForce(int start, int end)
    {
        int smallestDivisibleNumber = end;

        while(!isDivisibleByRange(start, end, smallestDivisibleNumber))
        {
            smallestDivisibleNumber++;
        }
        return smallestDivisibleNumber;
    }

    public static bool isDivisibleByRange(int start, int end, int dividend)
    {
        for(int i = start; i <= end; i++)
        {
            if(dividend % i != 0)
                return false;
        }
        return true;
    }
}