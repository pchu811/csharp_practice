using System;
using System.Collections.Generic;

namespace List2
{
    class Program
    {
        static void Main(string[] args) { 
        
            // how to create list and add elements 
            
            //adding elements using add() method
            var primeNumber = new List<int>(); //creates a list of int type.
            primeNumber.Add(1);
            primeNumber.Add(3);
            primeNumber.Add(5);
            primeNumber.Add(7);
            primeNumber.Add(9);

            Console.WriteLine("No of elements:" + primeNumber.Count);


            var cities = new List<string>(); //create string type list.
            cities.Add("New York");
            cities.Add("London");
            cities.Add("Munbai");
            cities.Add("Chicago");
            cities.Add(null);

            //adding elements using collection-initializer syntax
            var bigCities = new List<string>() //bigCities is string type list.
            {
                "New York",
                "London",
                "Mumbai",
                "Chicago"

            };




            //The following adds objects of the Student class in the List<Student>.
            //var stedents = new List<Stedent>()
            //{
            //    new Student(){ ID = 1, Name = "Bill"},
            //};


            //-----------------------------------------

            //Adding an Array in a List
            //AddRange() signature: void AddRange(IEnumerable<T> collection)
            string[] cities2 = new string[3] { "New York", "London", "Seattle" };

            var popularCities = new List<string>();

            //Adding an Array in a List
            popularCities.AddRange(cities2);

            var favoriteCities = new List<string>();
            //Add a List
            favoriteCities.AddRange(popularCities);


            //-----------------------------------------

            //Accessing a List
            List<int> numbers = new List<int>() { 1, 2, 5, 7, 8, 10 };
            Console.WriteLine(numbers[0]); //prints 1
            Console.WriteLine(numbers[1]); //prints 2
            Console.WriteLine(numbers[2]); //prints 3
            Console.WriteLine(numbers[3]); //prints 4

            //Using foreach LINQ method
            numbers.ForEach(num => Console.WriteLine(num + ",")); //prints 1, 2, 5, 7

            //using for loop
            for(int i = 0; i < numbers.Count; i++)
            {
                Console.WriteLine(numbers[i]);
            }

            //--------------------------------------------

            //Accessing a List using LINQ
            //var students2 = new List<Student>()
            //{
            //   new Student(){ID = 1, name = "Bill"},
            //   new Student(){ID = 2, nameof = "Steve"}
            //};

            //get all students whose name is Bill
            // var result = from s in students
            //              where s.Name == "Bill"
            //             select s;

            //  foreach (var student in result)
            //     Console.WriteLine(student.Id + ", " + student.Name);



            //-----------------------------------------------
            //Insert Elements in List
            var numbers2 = new List<int>() { 10, 20, 30, 40 };
            numbers2.Insert(1, 11); //insert 11 at 1st index: after 10

            foreach (var num in numbers)
                Console.Write(num);

            //Remove Elements from List
            var number3 = new List<int>() { 10, 20, 30, 40 };
            number3.Remove(100); //remove the first 10 from the list
            number3.RemoveAt(2); //remove the 3rd element(index start from 0)


            //Check Elements in List
            //Use the Contains() method to determine whether an element is in the List<T> or no
            List<int> numbers4 = new List<int>() { 10, 20, 30, 40 };
            numbers4.Contains(10); // return true
            bool true11 = numbers4.Contains(11); // return faulse
            //把一個結果賦值給一個變量
            //=永遠都是賦值
            numbers4.Contains(20); // return trueb


        }

    }
}