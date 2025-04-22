
using System.Collections;
using System.IO;
using System.Text;

public class LargestProduct
{
    private  List<List<int>> numGrid;
    public LargestProduct(string path)
    {
        numGrid = new List<List<int>>();
        LoadNumbersGrid(path);
    }
    private void LoadNumbersGrid(string path)
    {
        string[] lines = File.ReadAllLines(path);
        
        StringBuilder temp = new StringBuilder();
        
        foreach(string str in lines)
        {
            numGrid.Add(new List<int>());

            int index = 0;

            while(index < str.Length)
            {
                if(!str[index].Equals(' '))
                {
                    temp.Append(str[index]);
                }
                else
                {
                    numGrid[numGrid.Count - 1].Add(int.Parse(temp.ToString()));
                    temp.Clear();
                }
                index++;
            }
            if(temp.Length > 0)
            {
                numGrid[numGrid.Count - 1].Add(int.Parse(temp.ToString()));
                temp.Clear();
            }
        }
    }

    public int GetLargestProduct()
    {
        int largestProduct = 0;

        for(int i = 0; i < numGrid.Count; i++)
        {
            for(int j = 0; j < numGrid[i].Count; j++)
            {
                int rowProduct = 0;
                int colProduct = 0;
                int leftToRightDiagProduct = 0;
                int rightToLeftDiagProduct = 0;
                
                // row product
                if(j + 3 < numGrid[i].Count)
                {
                    rowProduct = numGrid[i][j] * numGrid[i][j + 1] * numGrid[i][j + 2] * numGrid[i][j + 3];
                }
                // column product
                if(i + 3 < numGrid.Count)
                {
                    colProduct = numGrid[i][j] * numGrid[i + 1][j] * numGrid[i + 2][j] * numGrid[i + 3][j];
                }
                // left to right diagonal product
                if(i + 3 < numGrid.Count && j + 3 < numGrid[i].Count)
                {
                    leftToRightDiagProduct = numGrid[i][j] * numGrid[i + 1][j + 1] * numGrid[i + 2][j + 2] * numGrid[i + 3][j + 3];
                }
                // right to left diagonal product
                if(i + 3 < numGrid.Count && j - 3 >= 0)
                {
                    rightToLeftDiagProduct = numGrid[i][j] * numGrid[i + 1][j - 1] * numGrid[i + 2][j - 2] * numGrid[i + 3][j - 3];
                }

                int[] products = new int[] {rowProduct, colProduct, leftToRightDiagProduct, rightToLeftDiagProduct};
                Array.Sort(products);

                if(largestProduct < products[products.Length - 1])
                    largestProduct = products[products.Length - 1];
            }
        }

        return largestProduct;
    }
}