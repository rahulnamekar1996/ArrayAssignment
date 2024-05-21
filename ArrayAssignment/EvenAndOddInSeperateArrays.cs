using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayAssignment
{
    public class EvenAndOddInSeperateArrays
    {
        static int[] GetEvenNumbers(int[] arr)
        {
          
            int evenCount = 0;
            foreach (int num in arr)
            {
                if (num % 2 == 0)
                {
                    evenCount++;
                }
            }

      
            int[] evenArray = new int[evenCount];

           
            int index = 0;
            foreach (int num in arr)
            {
                if (num % 2 == 0)
                {
                    evenArray[index++] = num;
                }
            }

            return evenArray;
        }
        static int[] GetOddNumbers(int[] arr)
        {
            
            int oddCount = 0;
            foreach (int num in arr)
            {
                if (num % 2 != 0)
                {
                    oddCount++;
                }
            }

            
            int[] oddArray = new int[oddCount];

           
            int index = 0;
            foreach (int num in arr)
            {
                if (num % 2 != 0)
                {
                    oddArray[index++] = num;
                }
            }

            return oddArray;
        }
        static void Main(string[] args)
        {


            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            int[] evenNumbers = GetEvenNumbers(numbers);
            int[] oddNumbers = GetOddNumbers(numbers);

            Console.WriteLine("Even numbers:");
            foreach (int num in evenNumbers)
            {
                Console.WriteLine(num);
            }

            Console.WriteLine("Odd numbers:");
            foreach (int num in oddNumbers)
            {
                Console.WriteLine(num);
            }
        }

    }

}
