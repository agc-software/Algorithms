/*
 * 
 * Objective: Given an array of integers, write an algorithm to find the three smallest elements in the array.
 * 
 */

using System;

namespace Algorithms.Array
{
    static class SmallestElementInArray
    {
        public static void GetArray(int[] array)
        {
            var tVal = int.MaxValue;
            for (int x = 0; x < array.Length; x++)
            {
                if (array[x] < tVal)
                {
                    tVal = array[x];
                    Console.WriteLine(tVal);
                }
            }
        }
    }
}
