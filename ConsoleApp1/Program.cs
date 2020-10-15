using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
       
        static void Main(string[] args)
        {
            double result = 0.0;

            Console.WriteLine("Welcome to the Calculator App!");
            Console.Write("Enter Your First Number: ");
            double a = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter which operator you want to use: ");
            string op = Console.ReadLine();

            Console.WriteLine("Enter your Last Number: ");
            double b = double.Parse(Console.ReadLine());


            switch (op)
            {
                case "+":
                    result = a + b;
                    break;
                case "-":
                    result = a - b;
                    break;
                case "*":
                    result = a * b;
                    break;
                case "/":
                    result =a / b;
                    break;
                default:
                    Console.WriteLine("INCORRECT INPUT!");
                    break;
            }
            
            Console.WriteLine("Your Answer is: "+result);
            Console.ReadLine();

        }
    }
}
