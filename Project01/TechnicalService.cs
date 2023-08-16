using System;
using System.Collections.Generic;
using System.Text;

namespace Project01
{
    class TechnicalService
    {
        public void CountRowsAndColums(int[,] array2D, out int rows, out int columns)
        {
            rows = array2D.GetUpperBound(0) + 1;
            columns = array2D.Length / rows;
        }
        public void Write2DArray(int[,] array2D)
        {
            if (array2D == null || array2D.Length == 0)
            {
                Console.WriteLine("Массив пуст, милорд");
                return;
            }
            int rows;
            int columns;
            CountRowsAndColums(array2D, out rows, out columns);
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"{array2D[i, j]} ");
                }
                Console.WriteLine();
            }
        }
        public void WriteArray(int[] array)
        {
            if (array == null || array.Length == 0)
            {
                Console.WriteLine("Массив пуст, милорд");
                return;
            }
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]} ");
            }
        }
    }
}
