using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;


namespace count_string
{
    class Program
    {
        //Write a function that finds the total number of characters in a given string.

        //int NumberOfCharsInString(string myString)
        //{
            // function code goes here!
             

            //return 0;
       // }


        static void Main(string[] args)
        {
            string sentence = "Hello how are you"; 

            int numCount = 0;
            for(int i = 0; i < sentence.Length; i++)
            {
                numCount++;
                //Console.WriteLine("The number of Characters is" + numCount);
            }

            Console.WriteLine(numCount);
            Console.ReadKey();
            
        }
    }
}
