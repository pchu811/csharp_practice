using System;
using System.Collections.Generic;
using System.Text;

namespace _09_ClassDemo
{
    class Student
    {
        //定義property
        public int StudentID;
        public string name;
        public int Grade;

        //Method
        public string Say() //定義這個學生有說話能力
        {
            return "我叫 " + name + "， 我是" + Grade + "年級的學生";
        }



    }
}
