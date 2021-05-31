using System;
using System.Collections;
using System.Collections.Generic;

namespace Average
{
    class Program
    {
        //Write a function that finds the average value of a given list of integers.

        static int FindAverage(List<int> myList)
        {
            int result = 0;


            //求總和
            int sum = 0;

            for(int i = 0; i< myList.Count; i++)
            {
                sum = sum + myList[i];
            }

            //求個數
            int Length = myList.Count;

            if (Length == 0)
            {
                Console.WriteLine("myList can not be 0");
                return 0;
            }

            //平均值 --- 總和 / 個數
            result = sum / Length;

           return result;

        }


       
        static void Main(string[] args)
        {

            List<int> myList = new List<int>();
            myList.Add(1);
            myList.Add(2);
            myList.Add(3);
            myList.Add(50);
            myList.Add(50);
            myList.Add(50);

            for(int i =0; i < myList.Count; i++)
            {
                
                Console.WriteLine("myList第" + i + "個位置:" + myList[i]);
            }

            //Console.WriteLine(myList.ToString());

            int myNum = FindAverage(myList); //=賦值 存起來


            Console.WriteLine("Average:" + myNum);

        }
    }
}
