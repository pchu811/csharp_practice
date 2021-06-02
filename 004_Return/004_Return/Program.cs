using System;

namespace _004_Return
{
    class Program
    {
        //return example
        static double Ratio(int numerator, int denominator)
        {
            if (denominator == 0)
            {
                Console.WriteLine("denominator can not be 0");
                return 0.0;
            }

            return numerator / (double)denominator;
            //因為()中type是整數，理應出來的數值是整數
            //在最前面加type, (double) -- 整數可以強行轉換成小數
            //也可以 (double)numerator / (double)denominator 或 (double)numerator / denominator
            // -- 呈現出來都是一樣的值
        }


        static int AddNumber(int num1, int num2)
        {
            return num1 + num2;
        }

        static double MinusNumber(double x, double y)
        {
            return x - y;
        }

        static int MultiplicationNumber(int mul1, int mul2)
        {
            return mul1 * mul2;
        }

        static string MyString(string firstName, string lastName)
        {
            return firstName + lastName;
        }



        static void Main(string[] args)
        {
            //-----double / -----
            double xx1 = Ratio(1, 5);
            double xx2 = Ratio(0, 100);
            double xx3 = Ratio(100, 0); //除法分母不能為0

            Console.WriteLine(xx1);
            Console.WriteLine(xx2);
            Console.WriteLine(xx3);

            //-----int + -----

            int num1 = 10;
            int num2 = 15;

            //AddNumber(num1, num2);
            Console.WriteLine(AddNumber(num1, num2));

            //-----double - -----

            double x = 5.2;
            double y = 3.2;

            MinusNumber(x, y);

            //double z = new double(); //放到Heap上
            //一般可以不用new,當定義一個class時才需要, list要
            double z; //stack
            z = MinusNumber(x, y);

            Console.WriteLine(z);

            //----- string-----

            //string s = "catttt"; //type
            //String t = "dogggg"; //class來的 //new List set dictionary

            //----- double - -----
            double w1 = MinusNumber(15, 10);
            double w2 = MinusNumber(10, 15);
            double w3 = MinusNumber(0, 0);
            Console.WriteLine(w1);
            Console.WriteLine(w2);
            Console.WriteLine(w3);


            //----- int * -----
            //MultiplicationNumber(int mul1, int mul2)
            int m1 = MultiplicationNumber(0, 50000);
            Console.WriteLine(m1);

            //----- string -----
            string s1 = MyString("Pom", "Chu");
            Console.WriteLine(s1);
            Console.WriteLine(s1[0]);
            Console.WriteLine(s1[3]);

            int charPos = s1.IndexOf("C"); //location of the letter C
            Console.WriteLine(charPos);
            string lastname = s1.Substring(charPos); //find the lastname
            Console.WriteLine(lastname);



        }






    }
}
