using System;
using ArrayOper;
using Sorts;

namespace ASD1
{
    class Program
    {
        static void Main(string[] args)
        {
            int bubbleCompare;
            int combCompare;
            int bubbleSwaps;
            int combSwaps;

            long bubbleTime;
            long combTime;
            int n = 5;

            //int[] array = ArrayOperations.GenerateArray(-n, n, n+n);
            int[] array = ArrayOperations.GenArraySequence(-n, n, true);
            ArrayOperations.PrintArray(array);
            Console.WriteLine();
            Sort.BubbleSort(array, out bubbleCompare, out bubbleSwaps, out bubbleTime);
            ArrayOperations.PrintArray(array);
            Sort.PrintSortStats(bubbleCompare, bubbleSwaps, bubbleTime);
            Console.WriteLine();
            //array = ArrayOperations.GenerateArray(-n, n, n+n);
            array = ArrayOperations.GenArraySequence(-n, n, true);
            ArrayOperations.PrintArray(array);
            Console.WriteLine();
            Sort.CombSort(array, out combCompare, out combSwaps, out combTime);
            ArrayOperations.PrintArray(array);
            Sort.PrintSortStats(combCompare, combSwaps, combTime);
        }
    }
}
