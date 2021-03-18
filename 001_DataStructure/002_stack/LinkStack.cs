using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002_棧
{
    class LinkStack<T> : IStackDS<T>
    {
        private Node<T> top;//棧頂元素節點
        private int count = 0;//棧中元素的個數
        public int Count //取得棧中元素的個數
        {
            get
            {
                return count;
            }
        }
        public int GetLength() //取得棧中元素的個數
        {
            return count;
        }

        public bool IsEmpty() //判斷棧中是否有數據
        {
            return count == 0;
        }
        public void Clear() //清空棧中所有的數據--1.讓count歸零2.讓top指針(棧頂指針)置空
        {
            count = 0;
            top = null;
        }
        public void Push(T item)//入棧
        {
            //把心添加的元素作為頭節點(棧頂)
            Node<T> newNode = new Node<T>(item);
            newNode.Next = top;
            top = newNode;//top更新
            count++;
        }
        public T Pop()//出棧---取得棧頂元素， 然後刪除
        {
            T data = top.Data;//top--棧頂元素 top.Data--棧頂當中的數據
            top = top.Next; //把top指向top的下一個元素，這樣的話原來的棧頂元素沒有元數去頂了，原來的棧頂元素會被銷毀掉
            count--;
            return data;
        }

        public T Peek()//取得棧頂中的數據，不刪除棧頂
        {
            return top.Data;
        }


    }
}
