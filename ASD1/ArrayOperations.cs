using System;
using System.Collections.Generic;
using System.Text;

namespace ArrayOper
{
    class ArrayOperations
    {
        public static int[] GenerateArray(int minLim, int maxLim, int n)
        {
            int[] array = new int[n];            
            Random rand = new Random();
            for (int i = 0; i < n; i++)
            {
                array[i] = rand.Next(minLim, maxLim + 1);
            }
            return array;
        }

        public static void PrintArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(String.Format("{0, 5}", array[i]));
            }
            Console.WriteLine();
        }
        
        public static int[] GenArraySequence(int minLim, int maxLim, bool seqDirection)
        {
            int[] array = new int[maxLim - minLim];

            if (seqDirection)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    array[i] = minLim + i;
                }
            }
            else
            {
                for (int i = 0; i < array.Length; i++)
                {
                    array[i] = maxLim - i;
                }
            }
            return array;
        }
    }
}
