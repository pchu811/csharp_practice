using System;

namespace forloop_arrays4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] grades = {66, 88, 90, 95, 100, 100};

            for (int i = 0; i < grades.Length; i++)
            {
                grades[i] += 3;
                Console.WriteLine(grades[i]);
            }

        }
    }
}
