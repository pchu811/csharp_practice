using System;

namespace forloop_arrays6_string
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] students = {"Bob", "John", "Ted", "Tom" };

            Console.WriteLine("Enter students name to search for");
            string studentsName = Console.ReadLine();

            bool contains = false;
            for(int i = 0; i < students.Length; i++)
            {
                if (studentsName == students[i])
                {
                    contains = true;
                }
            }

            if (contains == true)
            {
                Console.WriteLine("The student is in the class");
            }
            else
            {
                Console.WriteLine("The student is NOT in the class");
            }
        }
    }
}
