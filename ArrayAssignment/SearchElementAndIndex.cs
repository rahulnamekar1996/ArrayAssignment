using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayAssignment
{
    public class SearchElementAndIndex
    {
        static int Search(int[] arr, int num)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == num)
                {
                    return i;
                }
            }
            return -1; 
        }

        static void Main(string[] args)
        {
          
            int[] numbers = { 10, 20, 30, 40, 50 };

            Console.WriteLine("Enter a Number to Search");
            int num = Convert.ToInt32(Console.ReadLine());

           
            int index = Search(numbers, num);

       
            if (index != -1)
            {
                Console.WriteLine("Number found at index: " + index);
            }
            else
            {
                Console.WriteLine("Number not found in the array.");
            }
        }

        
    }

    
}
