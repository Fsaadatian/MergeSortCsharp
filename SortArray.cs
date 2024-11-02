using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MergeSortSaadatian
{
    internal class SortArray
    {
        public static void MergeSort(int[] array)
        {
            if (array.Length <=1)
                return;
            int middle = array.Length / 2;
            int[] part1Array = new int[middle];
            int[] part2Array = new int[array.Length - middle];
            for (int i = 0; i < middle; i++) part1Array[i] = array[i];
            for (int i = middle; i<array.Length; i++) part2Array[i-middle] = array[i];
            MergeSort(part1Array);
            MergeSort(part2Array);
            Merge (array, part1Array, part2Array);
            
        }
        private static void Merge(int[] array, int[] part1Array, int[] part2Array)
        {
            int i = 0;
            int j = 0;
            int k = 0;
            while (i < part1Array.Length && j < part2Array.Length)
            {
                if (part1Array[i] <= part2Array[j])
                    array[k++] = part1Array[i++];
                else array[k++] = part2Array[j++];
            }
            while (i < part1Array.Length)
            {
                array[k++] = part1Array[i++];
            }
            while (j < part2Array.Length)
            {
                array[k++] = part2Array[j++];
            }
        }
        public static void ShowSortArray(int[] array)
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("*********************");
            Console.WriteLine("   Sorted array is:  ");
            Console.WriteLine("*********************");
            for (int i = 0;i < array.Length;i++)
                Console.WriteLine(array[i]);
            Console.ResetColor();
            return;
        }
    }
}
