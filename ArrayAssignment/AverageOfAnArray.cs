using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayAssignment
{
    public class AverageOfAnArray
    {
        public static int Average(int[] array)
        {
            int sum = 0;
            foreach (int num in array)
            {
                sum += num;
            }
            return sum / array.Length;
        }

        public static double Average(double[] array)
        {
            double sum = 0;
            foreach (double num in array)
            {
                sum += num;
            }
            return sum / array.Length;
        }

        static void Main(string[] args)
        {
            int[] intArray = { 1, 2, 3, 4, 5 };
            double[] doubleArray = { 1.5, 2.5, 3.5, 4.5, 5.5 };

            int intAvg = Average(intArray);
            double doubleAvg = Average(doubleArray);

            Console.WriteLine("Average of integer array: " + intAvg);
            Console.WriteLine("Average of double array: " + doubleAvg);
        }

    }
}
