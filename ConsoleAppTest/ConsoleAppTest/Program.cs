using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hejsan World");
            List<String> names = new List<String>(new String[] {"Jan", "Stern", "Johansen"});
            names.AddRange(new String[] { "Hans", "Peter" });
            foreach(string name in names)
                {
                Console.WriteLine(name);

            }

            Console.ReadLine();
        }
    }
}
