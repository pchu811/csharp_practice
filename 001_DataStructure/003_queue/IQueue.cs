using System;
using System.Collections.Generic;
using System.Text;

namespace _003_隊列
{
    interface IQueue<T>
    {
        int Count { get; }
        int GetLength();
        bool IsEmpty();
        void Clear();
        void Enqueu(T item);
        T Dequeue();
        T Peek();
    }
}
