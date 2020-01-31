using System;

namespace Console_Calculator
{
    class Program
    {
    
        static void Main(string[] args)
        {
            Console.Write("Please input a number: ");
            double inputOne = Convert.ToDouble(Console.ReadLine());

            Console.Write("Please input an operator: ");
            string function = Console.ReadLine();

            Console.Write("Please input a number: ");
            double inputTwo = Convert.ToDouble(Console.ReadLine());

            if(function == "+")
            {
                Console.WriteLine(inputOne + inputTwo);
            } 
            
            else if(function == "-")
            {
                Console.WriteLine(inputOne - inputTwo);
            }

            else if (function == "/")
            {
                Console.WriteLine(inputOne / inputTwo);
            }

            else if (function == "*")
            {
                Console.WriteLine(inputOne * inputTwo);
            }

            else
            {
                Console.WriteLine("Invalid Operator");
            }

            Console.ReadLine();
        }
    }
}
