using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//節點類
namespace _001_線性表
{
    class Node<T>
    {
        private T data;//存儲數據
        private Node<T> next; //指針 用來指向下一個元素

        public Node() //空的構造方法
        {
            data = default(T); //default-- 系統內製的方法(可以說是關鍵字)，通過他去取得一個類型的默認值
            next = null; //next的值可以等於空
        }

        public Node(T value)
        {
            data = value;
            next = null; //null=空
        }

        public Node(T value, Node<T> next)
        {
            this.data = value;
            this.next = next;
        }

        public Node(Node<T> next)
        {
            this.next = next;
        }


        public T Data
        {
            get { return data; }
            set { data = value; }
        }

        public Node<T> Next
        {
            get { return next; }
            set { next = value; }
        }

    }
}
