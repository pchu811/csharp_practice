using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _003_隊列
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. 使用BCL中的隊列
            Queue<int> queue = new Queue<int>();

            //入隊(添加數據)
            queue.Enqueue(23);//先入隊--隊首
            queue.Enqueue(45);
            queue.Enqueue(67);
            queue.Enqueue(89);
            Console.WriteLine("添加23 45 67 89之後隊列的大小為：" + queue.Count);

            //出隊--取得隊首的數據並刪除
            int i = queue.Dequeue();
            Console.WriteLine("取得隊首的數據為：" + i);
            Console.WriteLine("出隊之後，隊列大小為：" + queue.Count);
            int j = queue.Peek();
            Console.WriteLine("Peek得到的結過是：" + j);
            Console.WriteLine("Peek之後隊列的大小為：" + queue.Count);
            queue.Clear();

            Console.WriteLine("clear 之後的隊列大小為：" + queue.Count);
            Console.ReadKey();



        }
    }
}
