using System;

namespace forloop_arrays4_foreach2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] grades = { 66, 88, 90, 95, 100 };

            foreach (int score in grades)
            {
                //score += 3; 不能在foreach的範圍裡加extra credit給所有數字 foreach只能 one by one

                //foreach loop just steps one by one inside of the array starts at a number
                //(66 then  88, 90, 95, 100) it goes right across that's the only thing it does
                
                //so anytime you need to just print maybe a value of an array out one by one 
                //in the order that in its normal order from 0 to the length whatever it is 
                //then you can use foreach loop

                Console.WriteLine(score);
            }
        }
    }
}
