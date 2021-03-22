using System;

namespace for_loop__if_else_
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 0;
            for (int i = 1; i <= 100; i++)
            {
                //當i是246810時，加入number---2個動作

                //if (i == 2 || i==4 || i==6 || i == 8 || i == 10)
                if (i % 2 == 1) //整除0(==0 偶數),餘數1(==1 奇數)
                {
                    Console.WriteLine("i的值是:" + i);
                    number = number + i;
                }                

            }
            Console.WriteLine(number);

            //2+4+6+8+10
            //當i是246810時，加入number---2個動作
            
        }
    }
}
