using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oppgaver_om_returverdier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, please give me a number:");
            int firstNumber = GetInputNumber();
            Console.WriteLine("You wrote: " + firstNumber + "\nNow give me another number:");
            int secondNumber = GetInputNumber();
            Console.WriteLine("You wrote: " + secondNumber + "\nNow I will do some addition!");
            int sum = firstNumber+ secondNumber;
            Console.WriteLine(firstNumber + " + " + secondNumber + " = " + sum + "\nThank you!");
            Console.ReadLine();
        }

        static int GetInputNumber()
        {
            int input = int.Parse(Console.ReadLine());
            return input;
        }
    }
}
