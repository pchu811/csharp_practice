using System;
using System.Collections;
using System.Collections.Generic;



namespace practice
{
    class Program
    {
        static int FindAverage(List<int> myList) // [5, 10, 20]
		{
			int result = 0;

			// 1. 找到总和
			int sum = 0;


			for (int i = 0; i < myList.Count; i++) // i 代表 位置 一個座標 index.
			{
				// 一个一个加起来.
				sum = sum + myList[i];
				// How to access an item in a C# List.
			}
			// 跑完以后，sum是35.

			// 2. 找到 整数 列里的个数.
			int length = myList.Count; // myList.length()

			// 3. 总和 除以 整数 列里的个数.
			result = sum / length;

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

			for (int i = 0; i < myList.Count; i++)
			{

				Console.WriteLine("myList第" + i + "個位置:" + myList[i]);
			}

			//Console.WriteLine(myList.ToString());

			int myNum = FindAverage(myList); //=賦值 存起來


			Console.WriteLine("Average:" + myNum);

		}
	}
}
