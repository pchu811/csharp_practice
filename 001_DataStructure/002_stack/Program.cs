using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002_棧
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.使用BCL中的Stack
            //Stack<char> stack = new Stack<char>();
            //2.使用我們自己的棧
            //IStackDS<char> stack = new SeqStack<char>(30);
            //3.使用我們自己的鏈棧
            IStackDS<char> stack = new LinkStack<char>();

            stack.Push('a');
            stack.Push('b');
            stack.Push('c');//棧頂數據
            Console.WriteLine("push a b c之後的數據個數為："+stack.Count);
            char temp = stack.Pop();//取得棧頂數據，並把棧頂的數據刪除
            Console.WriteLine("pop 之後得到的數據是：" + temp);
            Console.WriteLine("pop之後棧中數據的個數：" + stack.Count);
            char temp2 = stack.Peek();//取得棧頂的數據，不刪除
            Console.WriteLine("peek 之後得到的數據是：" + temp2);
            Console.WriteLine("peek之後棧中數據的個數：" + stack.Count);

            stack.Clear();

            Console.WriteLine("clear之後棧中數據的個數：" + stack.Count);
            //Console.WriteLine("空戰的時候取得棧頂的值" + stack.Peek();//出現異常
            //當空棧的時候，不要進行peek或pop的操作，否則會出現異常

            Console.ReadKey();

        }
    }
}
