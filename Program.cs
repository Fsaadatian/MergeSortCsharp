using System;

namespace MergeSortSaadatian
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool crit = false;
            do
            {
                Console.WriteLine("Please, enter element number of the array:");
                string? arrayLen = Console.ReadLine();
                if (!string.IsNullOrEmpty(arrayLen) )
                {
                    int arrayLenInt = int.Parse(arrayLen);
                    crit = true;
                    if (arrayLenInt != 0)
                    {
                        Console.WriteLine("Please, enter elements of the array:");
                        int count = 0;
                        int[] array = new int[arrayLenInt];
                        do
                        {
                            try
                            {
                                array[count] = int.Parse(Console.ReadLine()??"");
                                count++;
                            }
                            catch
                            {
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.WriteLine("Sorry, element is invalid. Try again!");
                                Console.ResetColor();
                            }
                        } while (count < arrayLenInt);
                        SortArray.MergeSort(array);
                        SortArray.ShowSortArray(array);
                    }
                    else
                        Console.WriteLine("Your array has no elements! ");


                }
            } while (crit == false);

            

        }
    }
}
