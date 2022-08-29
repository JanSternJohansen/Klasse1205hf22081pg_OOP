using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person(); // Default constructor
            
            //p1.age = 68;
            //p1.name = "Jan";
            //Console.WriteLine("Name: " + p1.name + " Age: " + p1.age);

            p1.setName("Peter");
            //p1.setAge(37);
            p1.Age = 37;
            Console.WriteLine("Name: " + p1.getName() + " Age: " + p1.Age);

            Person p2 = new Person("Lars", 60); // Oprettet constructor






            Console.ReadKey();
        }
    }
}
