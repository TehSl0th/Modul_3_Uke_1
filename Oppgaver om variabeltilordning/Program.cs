using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oppgaver_om_variabeltilordning
{
    internal class Program
    {
        int myInt = 0;
        long myLong = 0;
        float myFloat = 0.0f;
        decimal myDecimal = 0;
        double myDouble = 0;
        string myString = "This is my string, there are many like it, but this one is mine.";
        char myChar = 'B';
        bool myBool = false;




        static void Main(string[] args)
        {
            int a = 5;
            decimal b = 3.0M;
            float sum = (float)(a + b);
            Console.WriteLine(sum);
            Console.ReadLine();
        }
    }
}
