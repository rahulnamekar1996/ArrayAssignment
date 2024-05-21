using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayAssignment
{
    public class DuplicatesElementInAnArray
    {
        static int CountDuplicateElements(int[] arr)
        {
            int duplicateCount = 0;

         
            for (int i = 0; i < arr.Length; i++)
            {
            
                bool isDuplicate = false;
                for (int j = 0; j < i; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        isDuplicate = true;
                        break;
                    }
                }

             
                if (!isDuplicate)
                {
                    for (int k = i + 1; k < arr.Length; k++)
                    {
                        if (arr[i] == arr[k])
                        {
                            duplicateCount++;
                            break;
                        }
                    }
                }
            }

            return duplicateCount;
        }

        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5, 2, 3, 4, 6, 7, 7, 8, 8 };

            int duplicateCount = CountDuplicateElements(numbers);

            Console.WriteLine("Total number of duplicate elements: " + duplicateCount);
        }

    }
}
