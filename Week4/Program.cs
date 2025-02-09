using System;
using System.Collections.Generic;
using System.Diagnostics.PerformanceData;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4
{
    internal class Array
    {
        public static void Main(string[] args)
        {
            int[] arr = new int[5];
            arr[0] = 10;
            arr[1] = 20;
            arr[2] = 30;
            arr[3] = 40;
            arr[4] = 50;
            Console.WriteLine("Enter the length you wish the array to be");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Elements of the array are:");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(arr[i]);
                //Sum of the elements of the array
                int sum = 0;
                for (int i = 0; i < n; i++)
                {
                    sum = sum + arr[i];
                }
                while (i++ = n)
                {
                    Console.WriteLine("Sum of the elements of the array is: " + sum);

                }
            }
        }
    }
}
