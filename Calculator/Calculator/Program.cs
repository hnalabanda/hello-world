using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Calculator!");
            Console.WriteLine("==========================");
            Console.WriteLine("Enter the operator");
            string operatorType= Console.ReadLine();
            Console.WriteLine("Enter first number");
            string firstNumber= Console.ReadLine();
            int fNum = int.Parse(firstNumber);
            Console.WriteLine("Enter second number");
            string secondNumber= Console.ReadLine();
            int sNum = int.Parse(secondNumber);
            int result = 0;
            if (operatorType == "+")
            {
                result = fNum + sNum;

            }
            else if (operatorType == "-")
            {
                result = fNum - sNum;
            }
            else if (operatorType == "*")
            {
                result = fNum * sNum;
            }
            else if (operatorType == "/")
            {
                result = fNum / sNum;
            }
           
            Console.WriteLine("The result of {0}  {1} {2} is : {3}",fNum,operatorType,secondNumber,result);
        }
    }
}