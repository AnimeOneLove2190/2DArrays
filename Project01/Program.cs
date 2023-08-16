using System;

namespace Project01
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayService arrayService = new ArrayService();
            TechnicalService techService = new TechnicalService();
            int[,] random2DArray = arrayService.Create2DArray(3, 4, 0, 10);
            techService.Write2DArray(random2DArray);
        }
    }
}
