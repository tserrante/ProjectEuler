
using System.Collections;
using System.IO;

public class LargestProduct
{
    private  List<List<int>> grid;
    private int product;
    public int Product { get => product; set => product = value; }
    public LargestProduct(string path)
    {
        product = 0;
        grid = new List<List<int>>();
        LoadGrid(path);
    }
    private void LoadGrid(string path)
    {
        string[] lines = File.ReadAllLines(path);
        
        for(int i = 0; i < lines.Length; i++)
        {
            grid[i] = new List<int>();
            grid[i].AddRange(lines[i]);
        }
    }
}