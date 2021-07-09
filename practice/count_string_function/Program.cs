using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace count_string_function
{
    class Program
    {
        //Write a function that finds the total number of characters in a given string.
        //求字串中字母的總數
        //字母加起來的總和

        int NumberOfCharsInString(string myString)
        {
            int result = 0;

            //設一個字串
            String word = myString;

            //計算有幾個letter
            int count = 0;

            for (int i = 0; i < myString.Length; i++)
            {
                count++;
            }

            result = count;

            return result;

        }

        static void Main(string[] args)
        {
            //Console.WriteLine("The number of Characters is" + count);
        }
    }
}
