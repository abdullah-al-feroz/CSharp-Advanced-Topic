using System;

namespace DelegatesExample
{
    internal class Program
    {
        public delegate int CalculatorHandeler(int FN, int LN);

        static void Main(string[] args)
        {
            //CalculatorHandeler calculatorHandeler = delegate (int firstNumber, int secondNumber)
            //                                        {
            //                                            return firstNumber + secondNumber;
            //                                        };//anonimous delegete

            //Or
            CalculatorHandeler calculatorHandeler = 
                             (int firstNumber, int secondNumber) => firstNumber + secondNumber;
                                                  

            InvokeDelegates(calculatorHandeler, 12, 40);
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
            int result = calculatorHandeler.Invoke(fNumber, lNUmber);
            Console.WriteLine($"Result is: {result}");
        }

    }
}