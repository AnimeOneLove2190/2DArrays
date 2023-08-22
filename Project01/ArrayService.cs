using System;
using System.Collections.Generic;
using System.Text;

namespace Project01
{
    class ArrayService
    {
        public void CountRowsAndColums(int[,] array2D, out int rows, out int columns)
        {
            rows = array2D.GetUpperBound(0) + 1;
            columns = array2D.Length / rows;
        }
        //Quest01
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
        //Quest02
        public int GetMinIndexInRow(int[,] array2D, int numberOfRow)
        {
            if (array2D == null)
            {
                Console.WriteLine("Сработала защита");
                return -1;
            }
            int rows;
            int columns;
            CountRowsAndColums(array2D, out rows, out columns);
            if (numberOfRow >= rows || numberOfRow < 0)
            {
                return -1;
            }
            int minValue = array2D[numberOfRow, 0];
            for (int i = 0; i < columns; i++)
            {
                if (minValue > array2D[numberOfRow, i])
                {
                    minValue = array2D[numberOfRow, i];
                }
            }
            for (int i = 0; i < columns; i++)
            {
                if (array2D[numberOfRow, i] == minValue)
                {
                    return i;
                }
            }
            return 0;
        }
        public int GetMaxIndexInRow(int[,] array2D, int numberOfRow)
        {
            if (array2D == null)
            {
                Console.WriteLine("Сработала защита");
                return -1;
            }
            int rows;
            int columns;
            CountRowsAndColums(array2D, out rows, out columns);
            if (numberOfRow >= rows || numberOfRow < 0)
            {
                return -1;
            }
            int maxValue = array2D[numberOfRow, 0];
            for (int i = 0; i < columns; i++)
            {
                if (maxValue < array2D[numberOfRow, i])
                {
                    maxValue = array2D[numberOfRow, i];
                }
            }
            for (int i = 0; i < columns; i++)
            {
                if (array2D[numberOfRow, i] == maxValue)
                {
                    return i;
                }
            }
            return 0;
        }
        //Quest03
        public int GetMinIndexInColumn(int[,] array2D, int numberOfColumn)
        {
            if (array2D == null)
            {
                Console.WriteLine("Сработала защита");
                return -1;
            }
            int rows;
            int columns;
            CountRowsAndColums(array2D, out rows, out columns);
            if (numberOfColumn >= columns || numberOfColumn < 0)
            {
                return -1;
            }
            int minValue = array2D[0, numberOfColumn];
            for (int i = 0; i < rows; i++)
            {
                if (minValue > array2D[i, numberOfColumn])
                {
                    minValue = array2D[i, numberOfColumn];
                }
            }
            for (int i = 0; i < columns; i++)
            {
                if (array2D[i, numberOfColumn] == minValue)
                {
                    return i;
                }
            }
            return 0;
        }
        public int GetMaxIndexInColumn(int[,] array2D, int numberOfColumn)
        {
            if (array2D == null)
            {
                Console.WriteLine("Сработала защита");
                return -1;
            }
            int rows;
            int columns;
            CountRowsAndColums(array2D, out rows, out columns);
            if (numberOfColumn >= columns || numberOfColumn < 0)
            {
                return -1;
            }
            int maxValue = array2D[0, numberOfColumn];
            for (int i = 0; i < rows; i++)
            {
                if (maxValue < array2D[i, numberOfColumn])
                {
                    maxValue = array2D[i, numberOfColumn];
                }
            }
            for (int i = 0; i < columns; i++)
            {
                if (array2D[i, numberOfColumn] == maxValue)
                {
                    return i;
                }
            }
            return 0;
        }
        //Quest04
        public int GetSearchIndexInRow(int[,] array2D, int numberOfRow, int searchValue)
        {
            if (array2D == null)
            {
                Console.WriteLine("Сработала защита");
                return -1;
            }
            int rows;
            int columns;
            CountRowsAndColums(array2D, out rows, out columns);
            for (int i = 0; i < columns; i++)
            {
                if (array2D[numberOfRow, i] == searchValue)
                {
                    return i;
                }
            }
            return -1;
        }
        public int GetSearchIndexInColumn(int[,] array2D, int numberOfColumn, int searchValue)
        {
            if (array2D == null)
            {
                Console.WriteLine("Сработала защита");
                return -1;
            }
            int rows;
            int columns;
            CountRowsAndColums(array2D, out rows, out columns);
            for (int i = 0; i < rows; i++)
            {
                if (array2D[i, numberOfColumn] == searchValue)
                {
                    return i;
                }
            }
            return -1;
        }
        //Quest05
        public int GetSumOfElements(int[,] array2D)
        {
            if (array2D == null)
            {
                Console.WriteLine("Сработала защита");
                return 0;
            }
            int rows;
            int columns;
            CountRowsAndColums(array2D, out rows, out columns);
            int sum = 0;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    sum += array2D[i, j];
                }
            }
            return sum;
        }
        //Quest06
        public int GetSumOfElementsInRow(int[,] array2D, int numberOfRow)
        {
            if (array2D == null)
            {
                Console.WriteLine("Сработала защита");
                return 0;
            }
            int rows;
            int columns;
            CountRowsAndColums(array2D, out rows, out columns);
            int sum = 0;
            for (int i = 0; i < columns; i++)
            {
                sum += array2D[numberOfRow, i];
            }
            return sum;
        }
        public int GetSumOfElementsInColumn(int[,] array2D, int numberOfColumn)
        {
            if (array2D == null)
            {
                Console.WriteLine("Сработала защита");
                return 0;
            }
            int rows;
            int columns;
            CountRowsAndColums(array2D, out rows, out columns);
            int sum = 0;
            for (int i = 0; i < rows; i++)
            {
                sum += array2D[i, numberOfColumn];
            }
            return sum;
        }
        //Quest08
        public int[] PullOutRowFromArray(int[,] array2D, int numberOfRow)
        {
            if (array2D == null)
            {
                Console.WriteLine("Сработала защита");
                return null;
            }
            int rows;
            int columns;
            CountRowsAndColums(array2D, out rows, out columns);
            int[] pulledRow = new int[columns];
            for (int i = 0; i < columns; i++)
            {
                pulledRow[i] = array2D[numberOfRow, i];
            }
            return pulledRow;
        }
        public int[] PullOutColumnFromArray(int[,] array2D, int numberOfColumn)
        {
            if (array2D == null)
            {
                Console.WriteLine("Сработала защита");
                return null;
            }
            int rows;
            int columns;
            CountRowsAndColums(array2D, out rows, out columns);
            int[] pulledColumn = new int[rows];
            for (int i = 0; i < rows; i++)
            {
                pulledColumn[i] = array2D[i, numberOfColumn];
            }
            return pulledColumn;
        }
        //Quest09
        public bool GetSearchIndexInColumnBool(int[,] array2D, int numberOfColumn, int searchValue)
        {
            if (array2D == null)
            {
                Console.WriteLine("Сработала защита");
                return false;
            }
            int rows;
            int columns;
            CountRowsAndColums(array2D, out rows, out columns);
            for (int i = 0; i < rows; i++)
            {
                if (array2D[i, numberOfColumn] == searchValue)
                {
                    return true;
                }
            }
            return false;
        }
        public bool GetSearchIndexInRowBool(int[,] array2D, int numberOfRow, int searchValue)
        {
            if (array2D == null)
            {
                Console.WriteLine("Сработала защита");
                return false;
            }
            int rows;
            int columns;
            CountRowsAndColums(array2D, out rows, out columns);
            for (int i = 0; i < columns; i++)
            {
                if (array2D[numberOfRow, i] == searchValue)
                {
                    return true;
                }
            }
            return false;
        }
        //Quest10
        public int[,] AddColumnIn2DArray(int[,] array2D)
        {
            if (array2D == null)
            {
                Console.WriteLine("Сработала защита");
                return null;
            }
            int rows;
            int columns;
            CountRowsAndColums(array2D, out rows, out columns);
            int newColumns = columns + 1;
            int[,] array2DWithAddedColumn = new int[rows, newColumns];
            int[] addedColumn = new int[rows];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    array2DWithAddedColumn[i, j] = array2D[i, j];
                }
            }
            for (int i = 0; i < rows; i++)
            {
                array2DWithAddedColumn[i, newColumns - 1] = addedColumn[i];
            }
            return array2DWithAddedColumn;
        }
        public int[,] AddRowIn2DArray(int[,] array2D)
        {
            if (array2D == null)
            {
                Console.WriteLine("Сработала защита");
                return null;
            }
            int rows;
            int columns;
            CountRowsAndColums(array2D, out rows, out columns);
            int newRows = rows + 1;
            int[,] array2DWithAddedRow = new int[newRows, columns];
            int[] addedRow = new int[columns];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    array2DWithAddedRow[i, j] = array2D[i, j];
                }
            }
            for (int i = 0; i < columns; i++)
            {
                array2DWithAddedRow[newRows - 1, i] = addedRow[i];
            }
            return array2DWithAddedRow;
        }
        //Quest11
        public int[,] Change2DArray(int[,] array2D, int newCountOfRows, int newCountOfColums)
        {
            if (array2D == null)
            {
                Console.WriteLine("Сработала защита");
                return null;
            }
            int rows;
            int columns;
            CountRowsAndColums(array2D, out rows, out columns);
            int[,] array2DWithNewLength = new int[newCountOfRows, newCountOfColums];
            for (int i = 0; i < newCountOfRows - 1; i++)
            {
                for (int j = 0; j < newCountOfColums - 1; j++)
                {
                    array2DWithNewLength[i, j] = array2D[i, j];
                }
            }
            return array2DWithNewLength;
        }
        //Quest12
        public int[,] SwapRowsIn2DArray(int[,] array2D, int numberOfRowOne, int numberOfRowTwo)
        {
            if (array2D == null)
            {
                Console.WriteLine("Сработала защита");
                return null;
            }
            int rows;
            int columns;
            CountRowsAndColums(array2D, out rows, out columns);
            if ((numberOfRowOne >= columns || numberOfRowTwo >= columns) || (numberOfRowOne < 0 || numberOfRowTwo < 0))
            {
                return null;
            }
            int[,] array2DSwapRows = new int[rows, columns];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    array2DSwapRows[i, j] = array2D[i, j];
                }
            }
            for (int i = 0; i < columns; i++)
            {
                array2DSwapRows[numberOfRowOne, i] = array2D[numberOfRowTwo, i];
                array2DSwapRows[numberOfRowTwo, i] = array2D[numberOfRowOne, i];
            }
            return array2DSwapRows;
        }
        public int[,] SwapColumsIn2DArray(int[,] array2D, int numberOfColumOne, int numberOfColumTwo)
        {
            if (array2D == null)
            {
                Console.WriteLine("Сработала защита");
                return null;
            }
            int rows;
            int columns;
            CountRowsAndColums(array2D, out rows, out columns);
            if ((numberOfColumOne >= rows || numberOfColumTwo >= rows) || (numberOfColumOne < 0 || numberOfColumTwo < 0))
            {
                return null;
            }
            int[,] array2DSwapColumns = new int[rows, columns];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    array2DSwapColumns[i, j] = array2D[i, j];
                }
            }
            for (int i = 0; i < rows; i++)
            {
                array2DSwapColumns[i, numberOfColumOne] = array2D[i, numberOfColumTwo];
                array2DSwapColumns[i, numberOfColumTwo] = array2D[i, numberOfColumOne];
            }
            return array2DSwapColumns;
        }
        //Quest13
        public int[] GetArrayOfSumInRows(int[,] array2D)
        {
            if (array2D == null)
            {
                Console.WriteLine("Сработала защита");
                return null;
            }
            int rows;
            int columns;
            CountRowsAndColums(array2D, out rows, out columns);
            int[] sumInRows = new int[rows];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    sumInRows[i] += array2D[i, j];
                }
            }
            return sumInRows;
        }
        public int[] GetArrayOfSumInColumns(int[,] array2D)
        {
            if (array2D == null)
            {
                Console.WriteLine("Сработала защита");
                return null;
            }
            int rows;
            int columns;
            CountRowsAndColums(array2D, out rows, out columns);
            int[] sumInColumns = new int[columns];
            for (int i = 0; i < columns; i++)
            {
                for (int j = 0; j < rows; j++)
                {
                    sumInColumns[i] += array2D[j, i];
                }
            }
            return sumInColumns;
        }
        //Quest15
        public int[,] DeleteRow(int[,] array2D, int numberOfRow)
        {
            if (array2D == null)
            {
                Console.WriteLine("Сработала защита");
                return null;
            }
            int rows;
            int columns;
            CountRowsAndColums(array2D, out rows, out columns);
            if (numberOfRow >= rows || numberOfRow < 0)
            {
                return null;
            }
            int newRows = rows - 1;
            int[,] array2DWithoutRow = new int[newRows, columns];
            for (int i = 0, z = 0; i < rows; i++)
            {
                if (i == numberOfRow)
                {
                    continue;
                }
                for (int j = 0; j < columns; j++)
                {
                    array2DWithoutRow[z, j] = array2D[i, j];
                }
                z++;
            }
            return array2DWithoutRow;
        }
        public int[,] DeleteColumn(int[,] array2D, int numberOfColumn)
        {
            if (array2D == null)
            {
                Console.WriteLine("Сработала защита");
                return null;
            }
            int rows;
            int columns;
            CountRowsAndColums(array2D, out rows, out columns);
            if (numberOfColumn >= columns || numberOfColumn < 0)
            {
                return null;
            }
            int newColumns = columns - 1;
            int[,] array2DWithoutColumn = new int[rows, newColumns];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0, z = 0; j < columns; j++)
                {
                    if (j == numberOfColumn)
                    {
                        continue;
                    }
                    array2DWithoutColumn[i, z] = array2D[i, j];
                    z++;
                }
            }
            return array2DWithoutColumn;
        }
        //Quest16
        public int[] CreateChimera(int[,] array2D)
        {
            if (array2D == null)
            {
                Console.WriteLine("Сработала защита");
                return null;
            }
            int rows;
            int columns;
            CountRowsAndColums(array2D, out rows, out columns);
            int[] chimera = new int[array2D.Length];
            for (int z = 0; z < chimera.Length;)
            {
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < columns; j++)
                    {
                        chimera[z] = array2D[i, j];
                        z++;
                    }
                }
            }
            return chimera;
        }
    }
}
