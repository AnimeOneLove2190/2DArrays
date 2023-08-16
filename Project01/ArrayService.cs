using System;
using System.Collections.Generic;
using System.Text;

namespace Project01
{
    class ArrayService
    {
        public int[,] Create2DArray(int countOfStrings, int countOfColums, int minValue, int maxValue)
        {
            Random godOfNumbers = new Random();
            int[,] array2D = new int[countOfStrings, countOfColums];
            for (int i = 0; i < countOfStrings; i++)
            {
                for (int j = 0; j < countOfColums; j++)
                {
                    array2D[i, j] = godOfNumbers.Next(minValue, maxValue);
                }
            }
            return array2D;
        }
    }
}
