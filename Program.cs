using System;

namespace Homework_sorting
{
    internal class Program
    {
        /// <summary>
        /// Main entry point of the program.
        /// Creates two arrays, prints them before and after sorting.
        /// First array uses a handmade bubble sort.
        /// Second array uses C# built-in Array.Sort.
        /// </summary>
        static void Main(string[] args)
        {
            // Create and populate two int arrays with the same contents
            int[] firstArray = { -11, 12, -42, 0, 1, 90, 68, 6, -9 };
            int[] secondArray = { -11, 12, -42, 0, 1, 90, 68, 6, -9 };

            // Print the contents of the first array BEFORE bubble sort
            Console.WriteLine("First array BEFORE bubble sort:");
            PrintArray(firstArray);

            // Sort the first array using our handmade bubble sort
            StudentBubbleSort(firstArray);

            // Print the contents of the first array AFTER bubble sort
            Console.WriteLine("\nFirst array AFTER bubble sort:");
            PrintArray(firstArray);

            // Print the contents of the second array BEFORE built-in sort
            Console.WriteLine("\nSecond array BEFORE built-in sort:");
            PrintArray(secondArray);

            // Sort using the built-in C# sort method
            Array.Sort(secondArray);

            // Print the contents of the second array AFTER built-in sort
            Console.WriteLine("\nSecond array AFTER built-in (Array.Sort) sort:");
            PrintArray(secondArray);

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }

        /// <summary>
        /// Handmade bubble sort implementation.
        /// Sorts the given int array in ascending order.
        /// </summary>
        /// <param name="data">Array of ints to sort.</param>
        static void StudentBubbleSort(int[] data)
        {
            int n = data.Length;

            // Outer loop: repeat passes over the array
            for (int i = 0; i < n - 1; i++)
            {
                bool swapped = false; // Track if we swapped on this pass

                // Inner loop: compare adjacent values and swap if needed
                for (int j = 0; j < n - 1 - i; j++)
                {
                    if (data[j] > data[j + 1])
                    {
                        int temp = data[j];
                        data[j] = data[j + 1];
                        data[j + 1] = temp;

                        swapped = true;
                    }
                }

                // Optimization: stop early if no swaps were made
                if (!swapped)
                    break;
            }
        }

        /// <summary>
        /// Prints all values in an int array on one line.
        /// </summary>
        /// <param name="data">Array of ints to print.</param>
        static void PrintArray(int[] data)
        {
            for (int i = 0; i < data.Length; i++)
            {
                Console.Write($"{data[i]} ");
            }
            Console.WriteLine();
        }
    }
}
