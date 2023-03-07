using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            println("Hello world!");
            println("My Message!");
            Console.Write("My BMI is ");
            Console.WriteLine(BMI(65.0, 1.78));
            Console.WriteLine(100 + 200);
        }

        static void println(string message)
        {
            Console.WriteLine(message);
        }

        static double BMI(double w, double h) { 
            return Math.Round(w/Math.Pow(h, 2), 2);
        }
    }
}
