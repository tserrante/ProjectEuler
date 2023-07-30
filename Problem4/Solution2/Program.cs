namespace ProjectEuler.Problem4.Solution2;

public class Program
{
    /*
        
        Consider the palindrome (100a + 10b + c)(100d + 10e + f)
        Factoring out, 
        (100a + 10b + c)(100d + 10e + f) = 10000ad + 100ae + 100af + 1000bd + 100be + 10bf + 100cd + 10ce + cf
        Reorganizing by value

        10000ad + 1000bd + 100ae 
                         + 100af 
                         + 100be 
                         + 100cd + 10bf 
                                 + 10ce + cf

        OR

        Since the largest product of two 3-digit numbers is a six digit number, we can write the palindrome as abccba

        Factored out this palindrome is

        100000a + 10000b + 1000c + 100c +10b + a

        When adding like factors we get

        100001a + 10010b + 1100c

        We can then factor out the gcf of these numbers, which is 11

        11(9091a + 910b + 100c)

        So the largest palindrome of two 3-digit numbers is divisible by 11

    */
    public static void Main(string[] args)
    {

    }
}