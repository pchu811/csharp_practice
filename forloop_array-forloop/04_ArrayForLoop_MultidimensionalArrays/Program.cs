using System;
using System.Collections.Generic;

namespace test_ArrayForLoop_MultidimensionalArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //multidimensional arrays
            creatGrid();

            Console.ReadKey();
        }

        public static void creatGrid()
        {
            int width = 20;
            int height = 20;

            int[,] grid = new int[width, height];
            //grid[2, 3] = 3;

            for (int x = 0; x < width; x++)
            {
                for (int y = 0; y < height; y++)
                {
                    grid[x, y] = x + y;
                    Console.Write(grid[x, y] + " ");
                }

                Console.WriteLine();
            }
        }
    }
}
