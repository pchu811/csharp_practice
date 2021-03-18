using System;
using System.Collections.Generic;
using System.Text;

namespace _002_棧
{
    interface IStackDS<T>
    {
        int Count { get; } //get data number
        int GetLength();
        bool IsEmpty();
        void Clear();
        void Push(T item);
        T Pop();
        T Peek();

    }
}
