using System;
using System.Globalization;

namespace Mat
{
    class Program
    {
        static void Main(string[] args)
        {
            int m = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());

            int[,] mat = new int[m, n];

            for(int i = 0; i < m; i++)
            {
                string[] values = Console.ReadLine().Split(' ');

                for(int j = 0; j < n; j++)
                {
                    mat[i,j] = int.Parse(values[j]);
                }
            }

            int x = int.Parse(Console.ReadLine());

            for(int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (mat[i,j] == x)
                    {
                        Console.Write("Position: " + i + "," + j + "\n\r");
                        if (j - 1 >=  n && j - 1 > 0)
                            Console.Write("Left: " + mat[i,j - 1] + "\n\r");
                        if(j + 1 <= n)
                            Console.Write("Right: " + mat[i, j + 1] + "\n\r");
                        if(i - 1 >= m && i - 1 > 0)
                            Console.Write("Up: " + mat[i - 1, j] + "\n\r");
                        if(i + 1 <= m)
                            Console.Write("Down: " + mat[i + 1, j] + "\n\r");
                    }
                    
                } 
            }
        }
    }
}