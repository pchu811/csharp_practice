using System;

namespace _004_Return
{
    class Program
    {
        //return example
        double ratio(int numerator, int denominator)
        {
            return numerator / (double)denominator;
            //因為()中type是整數，理應出來的數值是整數
            //在最前面加type, (double) -- 整數可以強行轉換成小數
            //也可以 (double)numerator / (double)denominator 或 (double)numerator / denominator
            // -- 呈現出來都是一樣的值
        }


        int Number(int num1, int num2)
        {
            return num1 + num2;
        }

        static void Main(string[] args)
        {
            int num1 = 10;
            int num2 = 15;

            Console.WriteLine(Number);
        }

       
        



    }
}
