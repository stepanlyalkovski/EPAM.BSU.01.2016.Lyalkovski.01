using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1;
using Task2;
namespace ConsoleUI
{
    class Program
    {
        static void SqrtTesting()
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
        static void MatrixSortTestring()
        {
            int[][] matrix = new int[4][]
           {
                new int[5],
                new int[2],
                new int[8],
                new int[3]
           };
            Random rand = new Random();
            for (int i = 0; i < matrix.Length; i++)
                for (int j = 0; j < matrix[i].Length; j++)
                    matrix[i][j] = rand.Next(0, 20);
            matrix[1][0] = 21; // testing Max Value
            Console.WriteLine("Initial array: ");
            foreach (var singleArray in matrix)
            {
                foreach (var item in singleArray)
                {
                    Console.Write(item + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("\nSorting by Sum");
            matrix.MatrixSort(Matrix.CompareByRowSum);
            foreach (var singleArray in matrix)
            {
                foreach (var item in singleArray)
                {
                    Console.Write(item + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("\nSorting by max row element:");
            matrix.MatrixSort(Matrix.CompareByMaxElem);
            foreach (var singleArray in matrix)
            {
                foreach (var item in singleArray)
                {
                    Console.Write(item + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("\nSorting by min row element:");
            matrix.MatrixSort(Matrix.CompareByMinElem);
            foreach (var singleArray in matrix)
            {
                foreach (var item in singleArray)
                {
                    Console.Write(item + " ");
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            
            while (true)
            {
                Console.WriteLine("m - for Matrix sort\ns - for Sqrt");
                char c = Console.ReadKey().KeyChar;
                Console.Clear();
                switch (c)
                {
                    case 'm': MatrixSortTestring();break;
                    case 's': SqrtTesting(); break;
                    default: return;
                }
            }           
        }
    }
}
