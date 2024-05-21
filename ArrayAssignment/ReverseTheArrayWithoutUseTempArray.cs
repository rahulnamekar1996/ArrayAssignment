using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayAssignment
{
    public class ReverseTheArrayWithoutUseTempArray
    {
        static void ReverseArray(int[] array)
        {
            int start = 0;
            int end = array.Length - 1;

         
            while (start < end)
            {
                
                int temp = array[start];
                array[start] = array[end];
                array[end] = temp;

             
                start++;
                end--;
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
            int[] array = { 3, 90, 45, 29, 37, 78 };

            Console.WriteLine("Original Array:");
            PrintArray(array);

            ReverseArray(array);

            Console.WriteLine("\nReversed Array:");
            PrintArray(array);
        }


    }
}
