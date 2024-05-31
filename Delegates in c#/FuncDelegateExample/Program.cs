using System;

namespace FuncDelegateExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Func<int, int, int> CalculatorHandler = Add;
            Func<int, int, int>CalculatorHandler =(int firstNumber, int secondNumber) => firstNumber + secondNumber;
            int result = CalculatorHandler.Invoke(10, 20);
            Console.WriteLine(result);
            Console.ReadKey();
        }

        static int Add(int firstNumber, int secondNumber)
        {
            return firstNumber + secondNumber;
        }
    }
}
