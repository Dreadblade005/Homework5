/// Lab 5
/// File Name: Copy array
/// @author: Dakota Durst
/// Date: October 2, 2020
///
/// Problem Statement: 
/// create 2 arrays one being numbers and one being copy and set the copy array equal to the numbers array
///
///
/// Overall Plan:
/// 1) inititalize arrays 
/// 2) set length of copy equal to numbers array length
/// 3) for each number in numbers array set index of copy array to that number
/// 4) print out index of both arrays to confirm they are equal
/// 5) 

using System;

namespace part_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int lengthofnumbers = numbers.Length;
            int[] copy = new int[lengthofnumbers];
            for (int i = 0; i < numbers.Length; i++)
            {
                copy[i] = numbers[i];
                Console.WriteLine("This is the number in array number: " + numbers[i] + " and this is the number in the copy: " + copy[i]);
            }

        }
    }
}
