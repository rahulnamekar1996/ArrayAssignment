using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayAssignment
{
    public class PrintNegativeAndCountOFnegativeNum
    {
        static void PrintNegativeElementsAndCount(int[] arr)
        {
            int count = 0;
            Console.WriteLine("Negative elements in the array:");
            foreach (int num in arr)
            {
                if (num < 0)
                {
                    count++;
                    Console.WriteLine(num);
                }
            }
            Console.WriteLine("Total number of negative elements: " + count);
        }

        static void Main(string[] args)
        {
            int[] numbers = { 10, -5, 20, -15, -30, 25 };

            PrintNegativeElementsAndCount(numbers);
        }

    }
}
