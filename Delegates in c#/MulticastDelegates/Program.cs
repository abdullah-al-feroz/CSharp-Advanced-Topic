using System;

namespace DelegatesExample
{
    internal class Program
    {
        public delegate void PrintHandler(string name);


        static void Main(string[] args)
        {
            PrintHandler printHandler = Hello;
            PrintHandler printHandler1 = GoodBye;
            PrintHandler printHandler2 = printHandler + printHandler1;
            printHandler2.Invoke("Rahat");
            Console.WriteLine("----------------");
            Console.WriteLine("----------------");

            printHandler2 -= printHandler;
            printHandler2.Invoke("Rahat");
            //printHandler += GoodBye;
            //printHandler("Rahat");
            
        }

        static void Hello(string name)
        {
            Console.WriteLine($"Hello: {name}");
        }
        static void GoodBye(string name)
        {
            Console.WriteLine($"Goodbye: {name}");
        }
        

    }
}