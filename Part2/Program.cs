/// Lab 5
/// File Name: reverse array
/// @author: Dakota Durst
/// Date: October 5, 2020
///
/// Problem Statement: make a series of methods that reverse the values inside an array
/// 
///
///
/// Overall Plan:
/// 1) create generate numbers method which creates an array (numbers) and sets its internal values to numbers 1-10
/// 2) create reverse numbers method which takes numbers array and reverses it
/// 3) take numbers array and create temp array, evalutate temp array and create numbers 2 array
/// 4) gradually take last index of numbers and set numbers 2 array to that index, repeat until numbers array is reverse of it original setting
/// 5) print out all of the index's (numbers) in the numbers array

using System;

namespace part2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = GenerateNumbers();
            Reverse(numbers);
            PrintNumbers(numbers);
        }

        /// Generates an array of 10 numbers.
        static int[] GenerateNumbers()
        {
            int[] numbers = new int[10];

            for (int index = 0; index < 10; index++)
            {
                // We add 1 here, because the index starts
                // at 0, but we want to start with 1, we add
                // 1 here.
                numbers[index] = index + 1;
            }
            return numbers;
        }//end of generate numbers


        /// Reverses the contents of an array that is passed in.
        static void Reverse(int[] numbers)
        {
            // Initialize one index at the start of the array, and another
            // at the end of the array. The index of the last item in the
            // array is the length of the array - 1.
            int firstIndex = 0;
            int secondIndex = numbers.Length - 1;

            while (firstIndex < secondIndex)
            {
                // To swap two numbers, we need to copy one value out
                // to a safe place so that it doesn't get overwritten.
                int temp = numbers[firstIndex];
                numbers[firstIndex] = numbers[secondIndex];
                numbers[secondIndex] = temp;

                // Move on to the next pair.
                firstIndex++;
                secondIndex--;
            }
        }//end of reverse int


        /// Prints any array of numbers in order.
        static void PrintNumbers(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write(numbers[i] + " ");
            }

            Console.WriteLine();
        }//end of print numbers


    }
}
