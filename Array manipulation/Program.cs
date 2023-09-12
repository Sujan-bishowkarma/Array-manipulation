using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_manipulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create an array to store the numbers
            int[] numbers = new int[10];

            // Ask the user to enter 10 numbers
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write("Enter number {0}: ", i + 1);
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }
            //Store the value in array
            Console.Write("Elements in the array are: ");
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write("{0},", numbers[i]);
            }
           
                // Modify the values of the array to the value divided by the index of the array plus one
                for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = numbers[i] / (i + 1);
            }

            // Print the new values of the array
            Console.Write("\nThe new values of the array are:");
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write("{0},",numbers[i]);
            }
                Console.ReadKey();
        }
    }
}
