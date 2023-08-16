using System;

namespace Project01
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayService arrayService = new ArrayService();
            TechnicalService techService = new TechnicalService();
            //Quest01
            int[,] random2DArray = arrayService.Create2DArray(4, 5, 0, 10);
            techService.Write2DArray(random2DArray);
            //Quest02
            int minIndexInSelectedRow = arrayService.GetMinIndexInRow(random2DArray, 2);
            Console.WriteLine(minIndexInSelectedRow);
            int maxIndexInSelectedRow = arrayService.GetMaxIndexInRow(random2DArray, 2);
            Console.WriteLine(maxIndexInSelectedRow);
            //Quest03
            int minIndexInSelectedColumn = arrayService.GetMinIndexInColumn(random2DArray, 2);
            Console.WriteLine(minIndexInSelectedColumn);
            int maxIndexInSelectedColumn = arrayService.GetMaxIndexInColumn(random2DArray, 2);
            Console.WriteLine(maxIndexInSelectedColumn);
            //Quest04
            int searchIndexInSelectedRow = arrayService.GetSearchIndexInRow(random2DArray, 2, 7);
            Console.WriteLine(searchIndexInSelectedRow);
            int searchIndexInSelectedColumn = arrayService.GetSearchIndexInColumn(random2DArray, 2, 7);
            Console.WriteLine(searchIndexInSelectedColumn);
            //Quest05
            int sumOfArrayElements = arrayService.GetSumOfElements(random2DArray);
            Console.WriteLine(sumOfArrayElements);
            //Quest06
            int sumOfElementsInRow = arrayService.GetSumOfElementsInRow(random2DArray, 2);
            Console.WriteLine(sumOfElementsInRow);
            int sumOfElementsInColumn = arrayService.GetSumOfElementsInColumn(random2DArray, 2);
            Console.WriteLine(sumOfElementsInColumn);
            //Quest08
            int[] pulledRow = arrayService.PullOutRowFromArray(random2DArray, 2);
            techService.WriteArray(pulledRow);
            int[] pulledColumn = arrayService.PullOutColumnFromArray(random2DArray, 2);
            techService.WriteArray(pulledColumn);
            //Quest09
            bool searchValueInColumn = arrayService.GetSearchIndexInColumnBool(random2DArray, 2, 7);
            Console.WriteLine(searchValueInColumn);
            bool searchValueInRow = arrayService.GetSearchIndexInRowBool(random2DArray, 2, 7);
            Console.WriteLine(searchValueInRow);
            //Quest10
            int[,] array2DWithAddedColumn = arrayService.AddColumnIn2DArray(random2DArray);
            techService.Write2DArray(array2DWithAddedColumn);
            int[,] array2DWithAddedRow = arrayService.AddRowIn2DArray(random2DArray);
            techService.Write2DArray(array2DWithAddedRow);
        }
    }
}
