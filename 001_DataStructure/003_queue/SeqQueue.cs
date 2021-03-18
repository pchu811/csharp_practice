using System;
using System.Collections.Generic;
using System.Text;

namespace _003_隊列
{
    class SeqQueue<T> : IQueue<T>
    {
        //創建數組 這個數組存放我們的數據
        private T[] data;
        //聲明int 的變量 用它來代表當前有說少個元素 
        private int count; //count表示當前有多少個元素
        //還需要隊首隊尾的指標
        private int front; //隊首(隊首元數索引-1)
        private int rear;  //隊尾(隊尾元數索引)

        //給他一個構造方法--通過構造方法可以去初始化容量
        public SeqQueue(int size)
        {
            data = new T[size];
            count = 0;
            //默認front和rear都是等於空的(-1)
            front = -1;
            rear = -1;
        }
        //再提供一個默認的構造函數 當他去調用默認的構造函數時 我們給他一個初始的大小：10
        public SeqQueue() : this(10)
        {

        }

        public int Count
        {
            get{
                return count;
            }
        }

        public int GetLength()
        {
            return count;
        }
        public bool IsEmpty()//判斷裡面元數個數是否等於0
        {
            return count == 0;
        }
        public void Clear() //清空
        {
            count = 0; //個數視為0
            front = rear = -1; //將front 和 rear 這兩個指標指向-1
        }
        public void Enqueu(T item)//入隊
        {
           //之前要先檢查這個隊列有沒有滿--判斷當前元素個數跟數組大小是否一樣
           if(count == data.Length) //說明滿了
            {
                Console.WriteLine("隊列已滿，不可再添加新的數據");
            }
            else //當不相等時，說明裡面還是有空間的，有空間的話我們就要把數據添加到隊尾了
            {
                //添加到隊尾分兩種情況：
                //1.如果rear處於數組末尾的位置，那我們要添加到新的鏈的位置
                //2.如果rear不處於數組末尾的位置，則直接添加的rear末尾的一個元數就好
                if (rear == data.Length - 1) //如果rear等於數組最後一個元素的索引，就是他數組的扛度-1
                    //就是數組裡最後一個位置的索引
                {
                    //說明現在要添加到數組的0號位置 形成一個循環
                    data[0] = item;
                    rear = 0;
                }
                else //rear不是位於最後一個索引，直接將新的元素添加到rear後面即可
                {
                    data[rear + 1] = item;
                    rear++;//更新rear的值
                }
            }

        }

        public T Dequeue()
        {
            throw new NotImplementedException();
        }

        public T Peek()
        {
            throw new NotImplementedException();
        }
    }
}
