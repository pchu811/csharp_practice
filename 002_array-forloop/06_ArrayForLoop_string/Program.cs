using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_ArrayForLoop_string
{
    class Program
    {
        static void Main(string[] args) //this is a method called "Main". It is a called when the program starts.
        {
            string[] names = new string[3]
            {
                "Thom", "Mark", "Matt"
            };

            foreach (string name in names)
            {
                Console.Write(names + ",");
            }

            Console.ReadKey();
        }
    }
}
