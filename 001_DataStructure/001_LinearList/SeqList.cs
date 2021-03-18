using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001_線性表
{
    class SeqList<T> : IListDS<T>
    {
        private T[] data; //用來存儲數據 
        private int count = 0; //表示存了多少數據 
        public SeqList(int size)//size就是最大容量 
        {
            data = new T[size];
            count = 0;
        }
        public SeqList() : this(10)//默認構造函數 容量是10 
        {
        }
        ///<summary> 
        ///得數據的個數 
        ///</summary> 
        ///<returns></returns> 
        public int GetLength()
        {
            return count;
        }
        public void Clear() //清空 
        {
            count = 0;//清除時只需要將count歸0就行，這樣的話之後我們在取數據時，會索引不存在 
        }
        public bool IsEmpty()
        {
            return count == 0; //如果我們當前數據等於0，那就是為空的 
        }
        public void Add(T item) //添加方法 
        {
            if (count == data.Length) //當前數組已存滿 
            {
                Console.WriteLine("當前順序表已存滿, 不允許再存入");
            }
            else
            {
                data[count] = item;
                count++;
            }
        }
        public void Insert(T item, int index) //插入 
        {
            for (int i = count - 1; i >= index; i--) //從後想前進行編譯 
                                                     //一個元素插入時，後面的元素應自動往後退一格，但如果是用i++從前往後編譯的話會出現元素被覆蓋的問題 
                                                     //因此我們從後往前去編譯，然後把後面的元素向後移動 
            {
                data[i + 1] = data[i]; //把後面的元素向後移動一個，i位置的元素放到i+1的位置 
            }
            //移動之後就可以把item元素放進去了 
            data[index] = item; //index---我們要插入的位子 
            count++; // 插入一個元素實際上也就增加了一個元素 
        }
        public T Delete(int index) //刪除--跟插入一樣也要做元素的移動，由後往前移動 
        {
            T temp = data[index];//刪除時應該把index元素返回，所以先取得index這個位置的元素 
            for (int i = index + 1; i < count; i++)
            {
                data[i - 1] = data[i];//把數據向前移動 
            }
            count--; //移動後數據減少 
            return temp;//取得index元素，然後將index元素返回 
        }
        //兩種訪問方式 
        public T this[int index]//根據index去得到一個數據 //1.通過索引器 
        {
            get { return GetEle(index); }
        }
        public T GetEle(int index) //2.通過方法 
        {
            if (index >= 0 && index <= count - 1)//索引存在 
            {
                return data[index];
            }
            else
            {
                Console.WriteLine("索引不存在");
                return default(T);//也需要返回值，替代掉默認值，可以透過default的方法可以取得一個類型的默認值 
            }
        }
        public int Locate(T value) //根據value去計算所在的值所在的位置 
        {
            for (int i = 0; i < count; i++)
            {
                if (data[i].Equals(value)) //調用equals看看是否相等 
                {
                    return i; //如果相等，表示這個i的位置即是索引 
                }
                return -1;//如果條件不滿足，表示這個值不存在 
            }
        }
    }
}
