using System;

namespace forloop_arrays4_foreach
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] grades = {66, 88, 90, 95, 100, 100};

            //foreach sample
            foreach(int score in grades)
            {
                Console.WriteLine(score);
            }
        }
    }
}
