using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;

namespace Sorts
{
    class Sort
    {
        public static void BubbleSort(int[] array, out int compare, out int swaps, out long time) 
        {
            compare = 0;
            swaps = 0;           
            int tmp;
            Stopwatch stopw = Stopwatch.StartNew();

            for (int i = 0; i < array.Length; i++)
            {
                for (int  j = 0;  j < array.Length-1;  j++)
                {
                    compare++;
                    if (array[j] > array[j+1])
                    {
                        tmp = array[j+1];
                        array[j + 1] = array[j];
                        array[j] = tmp;
                        swaps++;
                    }
                }
            }

            stopw.Stop();
            time = stopw.ElapsedTicks;
        }

        public static void CombSort(int[] array, out int compare, out int swaps, out long time)
        {          
            compare = 0;
            swaps = 0;
            int tmp;
            int interval = array.Length;
            Stopwatch stopw = Stopwatch.StartNew();

            while (interval > 1)
            {
                interval = (int)(interval / 1.3);
                if (interval < 1)
                {
                    interval = 1;
                }

                for (int i = 0; i < array.Length - interval; i++)
                {
                    compare++;
                    if (array[i] > array[i + interval])
                    {
                        tmp = array[i];
                        array[i] = array[i + interval];
                        array[i + interval] = tmp;
                        swaps++;
                    }
                }
            }

            stopw.Stop();
            time = stopw.ElapsedTicks;
        }

        public static void PrintSortStats(int compare, int swaps, long time)
        {
            Console.WriteLine("Number of compares: " + compare);
            Console.WriteLine("Number of swaps: " + swaps);
            Console.WriteLine("Time: " + time + " ticks");
        }
    }
}
