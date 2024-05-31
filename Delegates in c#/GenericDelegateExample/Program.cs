using System;

namespace GenericDelegateExample
{
    internal class Program
    {
        public delegate void PrintHandler<T, F>(T param, F param1);
        static void Main(string[] args)
        {
            PrintHandler<string, string> printHandler = Hello;
            printHandler += GoodBye;
            printHandler.Invoke("Md" ,"Faisal");
            Console.ReadKey();
        }
        public static void Hello(string firstName, string lastName)
        {
            Console.WriteLine(firstName);
        }
        public static void GoodBye(string fName, string lName)
        {
            Console.WriteLine(fName);
        }
    }
}
