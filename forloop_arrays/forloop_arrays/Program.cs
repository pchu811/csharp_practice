using System;

namespace forloop_arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] grades = { 66, 88, 90, 95, 100};
            grades[0] += 3;
            grades[1] += 3;
            grades[2] += 3;
            grades[3] += 3;
            grades[4] += 3;

            for ( int i = 0; i < 5; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
