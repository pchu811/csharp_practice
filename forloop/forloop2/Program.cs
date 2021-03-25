using System;

namespace forloop2
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine(i);
            }

            for ( int x = 10; x >= 0; x--)
            {
                Console.WriteLine(x);
            }

            for (; ; )
            {
                Console.WriteLine("Forever Love to 啾啾");
            }
            

            Console.Read();
        }
    }
}
