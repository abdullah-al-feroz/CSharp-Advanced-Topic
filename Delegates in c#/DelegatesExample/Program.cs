using System;

namespace DelegatesExample
{
    internal class Program
    {
        public delegate int CalculatorHandeler(int FN, int LN);
          
        static void Main(string[] args)
        {
            //CalculatorHandeler calculator = Add; // attach method using reference create
            CalculatorHandeler calculator = new CalculatorHandeler(Add); // another style to attach method
            int result = calculator.Invoke(10, 20); //call method using invoke
            //int result = calculator(10, 20); //call method without invoke
            Console.WriteLine($"Summation is: {result}");
        }

        static int Add(int firstNumber, int secondNumber)
        {
            return firstNumber + secondNumber;
        }
    }
}
