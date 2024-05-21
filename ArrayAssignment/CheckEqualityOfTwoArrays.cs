using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayAssignment
{
    public class CheckEqualityOfTwoArrays
    {
        static bool AreArraysEqual(int[] arr1, int[] arr2)
        {
          
            if (arr1.Length != arr2.Length)
            {
                return false;
            }

       
            SortArray(arr1);
            SortArray(arr2);

            
            for (int i = 0; i < arr1.Length; i++)
            {
                if (arr1[i] != arr2[i])
                {
                    return false;
                }
            }

            return true;
        }

        static void SortArray(int[] arr)
        {
          
            int n = arr.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                     
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }

                }
            }
        }
        static void Main(string[] args)
        {
            int[] arr1 = { 12, 22, 32, 42, 52, 62 };
            int[] arr2 = { 52, 22, 62, 12, 42, 32 };

            bool areEqual = AreArraysEqual(arr1, arr2);

            if (areEqual)
            {
                Console.WriteLine("Arrays are equal.");
            }
            else
            {
                Console.WriteLine("Arrays are not equal.");
            }
        }

    }
}
