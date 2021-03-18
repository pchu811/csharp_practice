using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002_棧
{
    class SeqStack<T> : IStackDS<T>
    {
        private T[] data;
        private int top; //棧頂索引，從零開始  top=-1 + 1(return top+1) =0

        //構造方法
        public SeqStack(int size)
        {
            data = new T[size];
            top = -1;
        }
        public SeqStack() : this(10)
        {
        }
        public int Count
        {
            get
            {
                return top + 1; //棧頂索引+1 就是我們元素當中的個數 
            }
        }


        public int GetLength() //跟count是一樣的
        {
            return Count;
        }

        public bool IsEmpty() //判斷是否=0
        {
            return Count = 0; //=0為空 不等於零就不是空的
        }

        public void Clear()
        {
            top = -1; //讓棧頂指標指向-1，指向-1的話就是清空
        }
        public void Push(T item) //入棧，需要把它放在棧的新的位置，放在棧頂上方 
            //棧頂現在位於top的位置，要放在top的上方，相當於top+1的位置
        {
            data[top + 1] = item;
            top++;//自增，因為棧頂來了一個新的元素
        }
        public T Pop()
        {
            //首先要先取得棧頂的數據 
            T temp = data[top];//因為top指向的就是棧頂
            top--;//因為要出棧，所以要讓棧頂減一個
            return temp;
        }
        public T Peek()//只取得棧的元素
        {
            return data[top];//只取得數據元素，top的元素就是我們棧的元素
        }


    }
}
