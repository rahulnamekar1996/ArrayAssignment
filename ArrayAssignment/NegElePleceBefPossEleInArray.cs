using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayAssignment
{
    internal class NegElePleceBefPossEleInArray

    {
        static void Main(string[] args)
        {
            int[] arr = { 12, -3, 45, -29, 5, -61, 44, 7, -9 };

            Console.WriteLine("Original Array:");
            PrintArray(arr);

            ArrangeNegativesBeforePositives(arr);

            Console.WriteLine("\nModified Array:");
            PrintArray(arr);
        }


        static void ArrangeNegativesBeforePositives(int[] arr)
        {
            int left = 0;
            int right = arr.Length - 1;

            
            while (left <= right)
            {
                if (arr[left] < 0)
                {
                    left++;
                }
                else if (arr[right] >= 0)
                {
                    right--;
                }
                else
                {
                
                    int temp = arr[left];
                    arr[left] = arr[right];
                    arr[right] = temp;
                    left++;
                    right--;
                }
            }
        }

        static void PrintArray(int[] arr)
        {
            foreach (int num in arr)
            {
                Console.Write(num + " ");
            }
        }

    }
}
