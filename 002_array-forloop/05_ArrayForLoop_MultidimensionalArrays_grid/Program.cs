using System;
using System.Collections.Generic;

namespace test_ArrayForLoop_MultidimensionalArrays_grid
{
    class Program
    {
        static void Main(string[] args)
        {
            //MultidimensionalArrays
            CreateGrid();

            Console.ReadKey();

        }

        public static void CreateGrid()
        {
            int width = 20;
            int height = 20;

            int[][] grid = new int[width][height];
        }
    }
}
