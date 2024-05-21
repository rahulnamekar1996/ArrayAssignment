using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayAssignment
{
    public class UniqueElementInArray

    {
        static void PrintUniqueElements(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                bool isUnique = true;
                for (int j = 0; j < arr.Length; j++)
                {
                    if (i != j && arr[i] == arr[j])
                    {
                        isUnique = false;
                        break;
                    }
                }
                if (isUnique)
                {
                    Console.WriteLine(arr[i]);
                }
            }
        }
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 3, 4, 5, 2, 3, 6, 7, 8, 9, 1, 4 };

         
            Console.WriteLine("Unique elements in the array:");
            PrintUniqueElements(array);
        }

       

    }
}
