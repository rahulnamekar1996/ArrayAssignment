using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayAssignment
{
    public class SortArrayInAssending
    {
        static void SortArrayAscending(int[] array)
        {
            int n = array.Length;

         
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                      
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }
        }

        static void PrintArray(int[] array)
        {
            foreach (int num in array)
            {
                Console.Write(num + " ");
            }
        }
      
        static void Main(string[] args)
        {
            int[] array = { 5, 2, 7, 3, 9, 1 };

            Console.WriteLine("Original Array:");
            PrintArray(array);

            SortArrayAscending(array);

            Console.WriteLine("\nSorted Array in Ascending Order:");
            PrintArray(array);
        }



    }
}
