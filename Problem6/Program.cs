namespace ProjectEuler.Problem6;

public class Program
{
    public static int rangeEnd = 100;
    public static void Main(string[] args)
    {
        int sumOfSquares = GetSumOfSquares(rangeEnd);
        int squareOfSum = GetSquareOfSum(rangeEnd);

        System.Console.WriteLine($"{squareOfSum} - {sumOfSquares} = {squareOfSum - sumOfSquares}");

    }
    public static int GetSumOfSquares(int rangeEnd)
    {
        int sumOfSquares = 0;

        for(int i = 1; (i < rangeEnd+1); i++)
        {
            sumOfSquares += (i * i);
        }
        return sumOfSquares;
    }
    public static int GetSquareOfSum(int rangeEnd)
    {
        int squareOfSums = 0;

        for(int i = 1; (i < rangeEnd + 1); i++)
        {
            squareOfSums += i;
        }
        return squareOfSums * squareOfSums;
    }
}