using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayAssignment
{
    public class MergedTwoArrayInThirdArray
    {
        static int[] MergeArrays(int[] array1, int[] array2)
        {
        
            int length1 = array1.Length;
            int length2 = array2.Length;

        
            int[] mergedArray = new int[length1 + length2];

          
            for (int i = 0; i < length1; i++)
            {
                mergedArray[i] = array1[i];
            }

           
            for (int i = 0; i < length2; i++)
            {
            
                bool found = false;
                for (int j = 0; j < length1 + i; j++)
                {
                    if (array2[i] == mergedArray[j])
                    {
                        found = true;
                        break;
                    }
                }

            
                if (!found)
                {
                    mergedArray[length1 + i] = array2[i];
                }
            }

            return mergedArray;
        }
        static void Main(string[] args)
        {
            int[] array1 = { 1, 2, 3, 4, 5 };
            int[] array2 = { 4, 5, 6, 7, 8 };

            int[] mergedArray = MergeArrays(array1, array2);

            Console.WriteLine("Merged Array:");
            foreach (int num in mergedArray)
            {
                Console.Write(num + " ");
            }
        }


    }
}
