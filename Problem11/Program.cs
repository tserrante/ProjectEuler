
using System.ComponentModel;

namespace ProjectEuler.Problem11;

public class Program
{
    static void Main()
    {
        GetMultiDimensionalListFromTextFile("input");
    }

    // static List<List<int>> GetMultiDimensionalListFromTextFile(string filename)
    static void GetMultiDimensionalListFromTextFile(string filename)
    {
        string line;
        try
        {
            StreamReader sr = new StreamReader(string.Concat(filename, ".txt"));

            line = sr.ReadLine();
            
            List<int> row = new List<int>();
            
            while(line != null)
            {
                string numberInRow;
                for(int i = 0; i < line.Length; i++)
                {
                    if(!char.IsWhiteSpace(line[i]))
                    {
                        row.Add(Convert.ToInt32(line[i]));

                    }
                }

                line = sr.ReadLine();
            }
        }
        catch(Exception e)
        {
            Console.WriteLine("Exception: " + e.Message);
        }
        finally
        {
            Console.WriteLine("Executing finally block.");
        }
    }
}