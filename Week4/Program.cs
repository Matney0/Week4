using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            //Create an array of integers
            int value = { 1, 2, 4, 8, 16, 32, 64, 128, 256, 512 };
            //Ask user for amount of integers wanted for the array
            Console.WriteLine("Enter the amount of integers you want in the array(Max input is 10): ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The amount of integers you want in the array is: " + n);
            if (n == 10) {
                (i = 0; i < n; i++)
                {
                    Console.WriteLine("All elements in the array are: " + value[i]);
                }
            }
                //Print all elements in the array

            //Calculate and print the sum of all elements in the array
            //Print maximum and minimum values in the array

            //Reversing the array
        }
    }
}
