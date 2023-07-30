namespace ProjectEuler.Problem4.Solution1
{
    public class Program
    {
        static int startingNumber = 999;
        public static void Main(string[] args)
        {
            int largestPalindromicNumber = GetLargestPalindromicNumber(startingNumber);
            System.Console.WriteLine("Largest Palindromic Number From The Product of two 3-digit numbers is");
            System.Console.WriteLine(largestPalindromicNumber);
        }
        
        public static int GetLargestPalindromicNumber(int startingNumber) 
        {
            int largestPalindromicNumber = 0;
            
            int firstFactor = startingNumber;
            int secondFactor = startingNumber;
            
            while(firstFactor > 899 && secondFactor > 899)
            {
                secondFactor -= 1;
                int product = firstFactor * secondFactor;
                if(isPalindromicNumber(product) && product > largestPalindromicNumber)
                {
                    System.Console.WriteLine($"{firstFactor} * {secondFactor} = {product}");
                    largestPalindromicNumber = product;
                }
                if(secondFactor < 900)
                {
                    firstFactor -= 1;
                    secondFactor = startingNumber;
                }
            }

            return largestPalindromicNumber;
        }

        public static bool isPalindromicNumber(int number)
        {
            int reversedNumber = 0;
            int tempNumber = number;

            while(tempNumber > 0)
            {
                reversedNumber = reversedNumber * 10 + (tempNumber % 10);
                tempNumber /= 10;
            }

            if(number == reversedNumber)
                return true;
            else
                return false;
        }
    }
}