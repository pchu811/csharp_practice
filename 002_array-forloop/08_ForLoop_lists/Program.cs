using System;
using System.Collections.Generic;

namespace test_ForLoop_lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();

            numbers.Add(13);
            numbers.Add(4);
            numbers.Add(8);

            for (int i = 0; i < numbers.Count; i++)
            {
                Console.Write(numbers[i] + ",");
            }

            Console.WriteLine();

            //numbers.RemoveAt(1);
            numbers.Remove(4);

            for (int i = 0; i < numbers.Count; i++)
            {
                Console.Write(numbers[i] + ",");
            }

            Console.ReadKey();

        }
    }
}
