using System.IO;
using System;

class Program
{
    static void Main(string[] args)
    {
        int[] numbers = new int[5];//new-- create a data
        numbers[0] = 12;//fitst number
        numbers[1] = 3;//second one
        numbers[2] = 5;//third one

        for (int i = 0; i < numbers.Length; i++)
        {
            Console.Write(numbers[i] + ",");
        }

        //another way--foreach
        //foreach (int number in numbers) 
        //numbers array will create an INT called number and we can 
        //{
        //   Console.Write(numbers + ","); //then use that number(numbers) down here
        //so we are basically makeing a variable here that is that element
        //}

        Console.ReadKey();
    }
}