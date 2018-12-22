using System;
using System.Collections.Generic;
using System.Linq;

namespace Extensions
{
    class Program
    {
        static void Main(string[] args)
        {
            string myString = "cuv1 cuv2 cuv3 cuv4";
            Console.WriteLine(Extensions2.WordCount(myString));
            Console.WriteLine(myString.WordCountExtension());

            var now = DateTime.Now;
            Console.WriteLine(now.RoundToHalfHour());


            List<Person> myList = new List<Person>();
            myList.Add(new Person()
            {
                FirstName = "Catalin",
                LastName = "Palcu",
                City = "Iasi",
                Country = "Romania"
            });          
            myList.Add(new Person()
            {
                FirstName = "Gelu",
                LastName = "Cojocea",
                City = "Husi",
                Country = "SUA"
            });      
            myList.Add(new Person()
            {
                FirstName = "Dinu",
                LastName = "Cojocea",
                City = "Tecuci",
                Country = "Romania"
            });

            // nu au sens fara combinatia cu lambda expressions
            var student = new {Name = "Student1",
                                Course = "DotNet"};

            Console.WriteLine(student.Course + " "+ student.Name);

            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            int oddNumbers = numbers.Count(n => n % 2 == 1);
            Console.WriteLine(oddNumbers);

            var personInCity = myList.Where(person => person.City == "Iasi").ToList();

            List<Person> listByCity = new List<Person>();
            foreach (var person in myList)
            {
                if (person.City == "Iasi");
                listByCity.Add(person);
            }


            foreach (var person in personInCity)
            {
                Console.WriteLine(person.FirstName+" "+person.LastName+" "+person.City+" "+person.Country);
            }

            Console.WriteLine("-----------------------");
            var orderList = myList.OrderBy(person => person.LastName).OrderByDescending(person => person.Country).ToList();

            foreach (var person in orderList)
            {
                Console.WriteLine(person.FirstName + " " + person.LastName + " " + person.City + " " + person.Country);
            }


        }
    }
}
