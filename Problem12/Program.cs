

namespace Problem12;

public class Program
{
    public static int largestNumDivisor = 0;
    public static int counter;
    public static void Main(string[] args)
    {
        int count = 0;
        int sum = 0;
        Console.WriteLine("Calculating...");
        
        while(GetNumberOfDivisors(sum) < 500)
        //while(true)
        {
            Turn();
            sum += count;
            count++;
        }
        Console.ReadLine();
    }
    public static int GetNumberOfDivisors(int number)
    {
        int numDivisor = 0;
        Console.Write($"Current Number {number}");
        Console.WriteLine();

        for(int i = 1; i < number / 2; i++)
        {
            if(number % i == 0)
                numDivisor++;
        }
        Console.Write($"# of Divisors {numDivisor}");
        Console.WriteLine();

        if(largestNumDivisor < numDivisor)
            largestNumDivisor = numDivisor;
        
        Console.Write($"Current Largest # of Divisors: {largestNumDivisor}");
        Console.WriteLine();

        //Console.Clear();
        return numDivisor;
    }
    public static void Turn()
    {
        counter++;        
        switch (counter % 4)
        {
            case 0: Console.Write("/"); counter = 0; break;
            case 1: Console.Write("-"); break;
            case 2: Console.Write("\\"); break;
            case 3: Console.Write("|"); break;
        }
        Thread.Sleep(10);
        Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
    }
}