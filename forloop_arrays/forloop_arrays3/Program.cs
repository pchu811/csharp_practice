using System;

namespace forloop_arrays3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] grades = { 66, 88, 99, 100, 100, 100, 100, 66, 55 };

            for(int i = 0; i < grades.Length; i++)
            {
                Console.WriteLine(grades[i]);
            }
        }
    }
}
