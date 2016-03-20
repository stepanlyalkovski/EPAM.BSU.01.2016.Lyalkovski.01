using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    /// <summary>
    /// Предоставляет расширяющий метод для сортировки строк матрицы, а так же методы упорядочивания 
    /// </summary>
    public static class Matrix
    {
        /// <summary>
        /// Adapter for using Sort method with IComparer and Comparison
        /// </summary>
        internal sealed class ComparerAdapter : IComparer<int[]>
        {
            private Comparison<int[]> comparison;

            public ComparerAdapter(Comparison<int[]> comparison)
            {
                this.comparison = comparison;
            }

            public int Compare(int[] x, int[] y) => comparison(x, y);

        }

        /// <summary>
        /// Сортирует строки матрицы по заданному методу упорядочивания
        /// </summary>
        /// <param name="matrix">Исходная матрица(jagged массив)</param>
        /// <param name="Compare">Метод сравнения строк матрицы</param>
        public static void MatrixSort(this int[][] matrix, Comparison<int[]> Compare)
        {
            ComparerAdapter comparer = new ComparerAdapter(Compare);
            MatrixSort(matrix, comparer);
        }

        public static void MatrixSort(this int[][] matrix, IComparer<int[]> comparer)
        {
            int[] temp;

            for (int i = 0; i < matrix.Length; i++)
            {
                for (int sort = 0; sort < matrix.Length - 1; sort++)
                {
                    if (comparer.Compare(matrix[sort], matrix[sort + 1]) > 0)
                        SwapRows(ref matrix[sort], ref matrix[sort + 1]);
                }
            }
        }

        private static void SwapRows(ref int[] row1, ref  int[] row2)
        {
            int[] temp = row1;
            row1 = row2;
            row2 = temp;
        }
    }
}
