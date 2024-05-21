using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayAssignment
{
    public class MaxAndMinElementInArray
    {
        static void FindMinMax(int[] arr, int[] result)
        {
            if (arr == null || arr.Length == 0)
            {
             
                result[0] = int.MinValue;
                result[1] = int.MaxValue;
                return;
            }

            
            result[0] = arr[0]; 
            result[1] = arr[0]; 

       
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > result[0])
                {
                    result[0] = arr[i]; 
                }
                else if (arr[i] < result[1])
                {
                    result[1] = arr[i]; 
                }
            }
        }
        static void Main(string[] args)
        {
            
        
        int[] numbers = { 10, 5, 20, 15, 30 };

        int[] result = new int[2]; 

        FindMinMax(numbers, result);

        Console.WriteLine("Maximum value: " + result[0]);
        Console.WriteLine("Minimum value: " + result[1]);
        }


    }
}
