using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1;
namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("==== Sqrt testing ====");
            Console.Write("number: ");
            double number = double.Parse(Console.ReadLine());
            Console.Write("n: ");
            double n = double.Parse(Console.ReadLine());
            Console.Write("precision: ");
            double eps = double.Parse(Console.ReadLine());
            double result = MathOperations.Sqrt(number, n, 0.0000001);
            double test = Math.Pow(result, n);
            Console.WriteLine("Sqrt result: " + result);
            Console.WriteLine($"Comparing to Math.Pow:\n Number: {number}\n sqrt result after Math.Pow: {test}");
        }
    }
}
