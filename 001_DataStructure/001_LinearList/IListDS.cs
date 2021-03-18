using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001_線性表
{
    interface IListDS<T>
    {
        int GetLength();
        //求長度

        void Clear();
        //清空操作

        bool IsEmpty();
        //判斷線性表是否為空

        void Add(T item);
        //附加操作

        void Insert(T item, int index);
        //插入操作

        T Delete(int index);
        //刪除操作

        T GetElem(int index);
        //取表元

        T this[int index] { get; }
        //定義一個索引器 獲取元素

        int Locate(T value);
        //按值查找

       
    }
}
