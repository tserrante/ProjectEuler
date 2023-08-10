using System.Diagnostics.Metrics;
using System.Globalization;

namespace ProjectEuler.Problem7;

public class Program
{
    public static void Main(string[] args)
    {
        long largestProduct;
        int[] IntArray = GetIntArrayFromFile();
        if(IntArray != null)
        {
            largestProduct = FindLargestProduct(IntArray, 13);
            System.Console.WriteLine(largestProduct);
        }
    }

    public static int[] GetIntArrayFromFile()
    {
        try
        {
            using(StreamReader sr = new StreamReader("input.txt"))
            {
                string line;

                if((line = sr.ReadLine()) != null)
                {
                    int[] returnArray = new int[line.Length];

                    for(int i = 0; i < returnArray.Length; i++)
                    {
                        returnArray[i] = (int)char.GetNumericValue(line[i]);
                    }
                    return returnArray;
                }
            }
        }
        catch(Exception e)
        {
            System.Console.WriteLine("File input.txt not found: " + e.Message);
        }

        return null;
    }
    public static long FindLargestProduct(int[] numbers, int adjacentSubsetSize)
    {
        long largestProduct = 0;

        int subsetStart = 0;
        int subsetEnd = adjacentSubsetSize;

        while(subsetEnd < numbers.Length)
        {
            long tempProduct = 1;
            for(int i = subsetStart; i < subsetEnd; i++)
            {
                tempProduct *= numbers[i];
            }
            if(tempProduct > largestProduct)
            {
                System.Console.WriteLine($"found: {tempProduct}");
                largestProduct = tempProduct;
            }
            subsetStart++;
            subsetEnd++;
        }

        return largestProduct;
    }
}