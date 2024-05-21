using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayAssignment
{
    public class CountFrequancy
    {
        static void CountFrequency(int[] arr)
        {
            int n = arr.Length;

         
            bool[] visited = new bool[n];

           
            for (int i = 0; i < n; i++)
            {
            
                if (visited[i])
                    continue;

           
                int count = 1;
                for (int j = i + 1; j < n; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        visited[j] = true;
                        count++;
                    }
                }

            
                Console.WriteLine("Element: " + arr[i] + ", Frequency: " + count);
            }
        }


        static void Main(string[] args)
        {
            int[] array = { 1, 2, 3, 4, 5, 2, 3, 6, 7, 8, 9, 1, 4 };

          
            Console.WriteLine("Frequency of each element in the array:");
            CountFrequency(array);
        }

    }

}


        

    



