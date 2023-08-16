using System;
using System.Collections.Generic;
using System.Text;

namespace Project01
{
    class TechnicalService
    {
        public void Write2DArray(int[,] array2D, int countOfStrings, int countOfColums)
        {
            for (int i = 0; i < countOfStrings; i++)
            {
                for (int j = 0; j < countOfColums; j++)
                {
                    Console.Write($"{array2D[i, j]} ");
                }
                Console.WriteLine();
            }
        }
    }
}
