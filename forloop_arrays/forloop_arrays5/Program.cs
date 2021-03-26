using System;

namespace forloop_arrays5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Array backwards
            int[] grades = {66, 88, 90, 95, 100};

            for (int i = grades.Length -1; i > 0; i--)
            {
                grades += 3;
                Console.WriteLine(grades[i]);
            }
        }
    }
}
