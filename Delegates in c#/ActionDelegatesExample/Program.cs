using System;

namespace ActionDelegatesExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Action<int, int> CalculatorHandler = Add;
            Action<int, int> CalculatorHandler = (int firstNumber, int secondNumber) => Console.WriteLine(firstNumber + secondNumber);
            CalculatorHandler.Invoke(10, 20);
        }
        static void Add(int firstNumber, int secondNumber)
        {
            int result = firstNumber + secondNumber;
            Console.WriteLine(result);
        }
        static void Sub(int firstNumber, int secondNumber)
        {
            int result = firstNumber - secondNumber;
            Console.WriteLine(result);
        }
        
    }
}
