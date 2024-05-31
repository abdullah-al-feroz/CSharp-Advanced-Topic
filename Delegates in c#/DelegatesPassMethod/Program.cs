
using System;

namespace DelegatesExample
{
    internal class Program
    {
        public delegate int CalculatorHandeler(int FN, int LN);

        static void Main(string[] args)
        {
            CalculatorHandeler calculatorHandeler = Add;
            //int result = calculatorHandeler.Invoke(12, 40);
            //Console.WriteLine($"Summation is: {result}");
            /*InvokeDelegates(calculatorHandeler);*///pass method as parameter in another method
            InvokeDelegates(calculatorHandeler,12,40);
            CalculatorHandeler calculatorHandeler1 = Sub;
            InvokeDelegates(calculatorHandeler1, 12, 40);

            Console.ReadKey();

        }
        static int Add(int firstNumber, int secondNumber)
        {
            return firstNumber + secondNumber;
        }
        static int Sub(int firstNumber, int secondNumber)
        {
            return firstNumber - secondNumber;
        }
        public static void InvokeDelegates(CalculatorHandeler calculatorHandeler, int fNumber, int lNUmber)
        {
            //int result = calculatorHandeler.Invoke(12, 40);
            int result = calculatorHandeler.Invoke(fNumber, lNUmber);
            Console.WriteLine($"Result is: {result}");
        }

    }
}