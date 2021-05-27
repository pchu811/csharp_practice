using System;

namespace forloop_arrays6_string2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] students = {"Tom", "Marry", "Bob", "Fred" };

            Console.WriteLine("Enter students name to search for:");
            string studentsName = Console.ReadLine();

            for(int i = 0; i < students.Length; i++)
            {
                if(studentsName == students[i])
                {
                    Console.WriteLine("FOUNT");
                }
                else
                {
                    Console.WriteLine("NOT FOUND");
                }
            }

            //int i = 0;
            //Console.WriteLine(++i);
            //Console.WriteLine(i);
            //Console.WriteLine(++i);
            //Console.WriteLine(i);
        }
    }
}
