using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public static class Matrix
    {
        // Ascending order
        public static void MatrixSort(this int[][] matrix, Comparison<int[]> Compare)
        {
            int[] temp;

            for (int i = 0; i < matrix.Length; i++)
            {
                for (int sort = 0; sort < matrix.Length - 1; sort++)
                {
                    if (Compare(matrix[sort], matrix[sort + 1]) > 0)
                    {
                        temp = matrix[sort];
                        matrix[sort] = matrix[sort + 1];
                        matrix[sort + 1] = temp;
                    }
                }
            }
        }

        public static int CompareByRowSum(int[] row1, int[] row2)
        {
            return row1.Sum().CompareTo(row2.Sum());
        }

        public static int CompareByMaxElem(int[] row1, int[] row2)
        {
            return row1.Max().CompareTo(row2.Max());
        }

        public static int CompareByMinElem(int[] row1, int[] row2)
        {
            return row1.Min().CompareTo(row2.Min());
        }

    }
}
