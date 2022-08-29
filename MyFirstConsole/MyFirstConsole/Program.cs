
using System;

namespace MyFirstConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String name = "Alex";

            System.Collections.Generic.List<string> navne;

            System.Console.WriteLine("Navnet er: " + name);
            
            Console.Write("Indtast venligst Deres fornavn: ");
            String firstName = System.Console.ReadLine();
            Console.Write("Indtast venligst Deres skonummer: ");
            int skoNummer = Convert.ToInt32(System.Console.ReadLine());
            Console.WriteLine("Hej " + firstName + " De bruger skonummer " + skoNummer);

            //int tal = int.Parse("123");

            double tal2 = 2.2d;
            float tal3 = 3.2f;
            decimal tal4 = 3.123m;
            decimal tal5 = (decimal)3.124;
            int tal6 = (int)3.124;
            double tal7 = 7;

            char ch = 'a';
            char ch2 = (char)0x30;

            bool sand = true;

            //ch2++;
            Console.WriteLine(ch + " " + ch2);


            Console.ReadLine();

        }
    }
}
