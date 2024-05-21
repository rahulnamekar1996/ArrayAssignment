using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayAssignment
{
    public class SecondSmallestElement
    {

        static int FindSecondSmallest(int[] arr)
        {
            if (arr.Length < 2)
            {
                throw new ArgumentException("Array must have at least two elements");
            }

            int smallest = arr[0];
            int secondSmallest = int.MaxValue;

            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] < smallest)
                {
                    secondSmallest = smallest;
                    smallest = arr[i];
                }
                else if (arr[i] < secondSmallest && arr[i] != smallest)
                {
                    secondSmallest = arr[i];
                }
            }

            return secondSmallest;
        }
        static void Main(string[] args)
        {
            int[] array = { 10, 5, 7, 3, 9, 2, 8 };

            int secondSmallest = FindSecondSmallest(array);

            Console.WriteLine("Second smallest element in the array: " + secondSmallest);
        }

    }

}
    

