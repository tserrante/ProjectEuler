
using System.Reflection.Metadata;
using System.Security.Cryptography;

namespace ProjectEuler.Problem9;

/*
    a^2 + b^2 = c^2, a < b < c

    1. Generate pythagorean triplet
        1a. Satisfy above conditions
    2. Test a + b + c = 1000
    3. Return a*b*c
*/

public class Program
{
    static void Main(string[] args)
    {
        const int SUM = 1000;
        int productOfPythagoreanTriplet = GetProduct_BruteForce(SUM);
        System.Console.WriteLine(productOfPythagoreanTriplet);
    }

    static int GetProduct_BruteForce(int sum = 1000)
    {
        int a = 1, 
        b = 1;

        double c;
        
        bool productIsFound = false;

        while(!productIsFound || a >= sum)
        {
            // number is perfect square, but error prone
            //https://stackoverflow.com/questions/4885925/shortest-way-to-check-perfect-square
            c = Math.Sqrt(a*a + b*b);
            if(c % 1 == 0) 
            {
                if((a + b + c) == sum)
                {
                    return a * b * (int)c;
                }
            }
            if(b == 1000)
            {
                a++;
                b = a + 1;
            }
            else
            {
                b++;
            }
        }
        return default;
    }
}