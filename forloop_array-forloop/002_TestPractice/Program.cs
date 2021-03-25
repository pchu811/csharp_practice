using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Solution
{

    //試題1

    /*
     * Complete the simpleArraySum function below.
     */
    static int simpleArraySum(int[] ar)
    {
        /*
         * Write your code here.
         */
        //i(index 編號) = 1, i是 ar[1] =
        //一個數組電腦裡面編號從0開始
        int sum = 0;
        for (int i = 0; i < ar.Length; i++)
        //i的起始直,i的區間(i的範圍,i遞增到哪裡停),i的變化
        //i=0當i小於array的長度時，i遞增
        {
            sum = ar[i] + sum;
            //x = 0
            //x = 10 + x
            //x = 10(新的數值)
            //x = 5 + x(=10--舊的數值)
            //x = 15
            //sum += arr[i];
            //+=
        }
        return sum;
    }

    static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int arCount = Convert.ToInt32(Console.ReadLine());

        int[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt32(arTemp))
        ;
        int result = simpleArraySum(ar);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
