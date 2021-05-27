using System;

namespace forloop_arrays7
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] students = { "Bob", "Ted", "Tom", "Fred" };

            Console.WriteLine("Enter students name to search for");
            string studentsName = Console.ReadLine();
            //how do I actually figure out if it contains this name

            //so logic here
            //how do would you figure out if whatever they type didn't exists in this array
            //the only you can do is the first integer or is the first string whatever typed in
            //to check every single one I've to check every single string inside the array
            //to see if it was whatever was typed in

            bool contains = false; //Create some kind of rule but keep track of if it contains or not
            //to check every single one what do I need to do I need to use a loop
            for(int i = 0; i < students.Length; i++)
            {
                if (studentsName == students[i])
                {
                    contains = true;
                }
            }

            if(contains == true)
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
