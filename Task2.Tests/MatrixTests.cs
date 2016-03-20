using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Task2;
namespace Task2.Tests
{
    [TestFixture]
    public class MatrixTests
    {
        int[][] matrix =
            {
                new int[] {1, 2, 3},
                new int[] {1, 2, 3, 4},
                new int[] {25, 5},
                new int[] {0, 1, 2, 3, 4, 5, 6, 7, 8},
                new int[] {31}
            };

        int[][] ExpectedMatrix =
        {
                new int[] {0, 1, 2, 3, 4, 5, 6, 7, 8},
                new int[] {31},
                new int[] {25, 5},
                new int[] {1, 2, 3, 4},
                new int[] {1, 2, 3}
        };

        internal class MaxElemReverseComparer : IComparer<int[]> 
        {
            public int Compare(int[] x, int[] y)
            {
                return y.Max().CompareTo(x.Max());
            }
        }

        [Test]
        public void MatrixSort_MatrixWithComparisonRowSum()
        {
            
            matrix.MatrixSort((r1, r2) => r1.Sum().CompareTo(r2.Sum()));
            foreach (int[] row in matrix)
            {
                Debug.WriteLine("\nrow: ");
                foreach (var elem in row)
                {
                    Debug.Write(elem + " ");
                }
                
            }
        }
        [Test]
        public void MatrixSort_MatrixWithReverseComparer()
        {
            IComparer<int[]> comparer = new MaxElemReverseComparer();
            matrix.MatrixSort(comparer);
            foreach (int[] row in matrix)
            {
                Debug.WriteLine("\nrow: ");
                foreach (var elem in row)
                {
                    Debug.Write(elem + " ");
                }

            }
            Assert.AreEqual(31, matrix[0][0]);
        }

    }
}
