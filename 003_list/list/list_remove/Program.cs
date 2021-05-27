using System;
using System.Collections.Generic;

namespace list_remove
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> number3 = new List<int>() { 10, 20, 30, 40 };
            bool removeSucceed = number3.Remove(100); 
            //remove the first 10 from the list //返回一個結果到一個變量                                          
            //number3.RemoveAt(2); //remove the 3rd element(index start from 0)



            for (int i = 0; i < number3.Count; i++)
            {

                Console.WriteLine(removeSucceed);
            }
        }
    }
}
