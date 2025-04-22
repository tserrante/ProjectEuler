namespace ProjectEuler.Problem11;

public class Program
{
    public static void Main(string[] args)
    {
        LargestProduct lp = new LargestProduct("./grid.txt");
        Console.WriteLine(lp.GetLargestProduct());
        Console.ReadLine();
    }
}