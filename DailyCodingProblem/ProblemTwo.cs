using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
 * Good morning! Here's your coding interview problem for today.

This problem was asked by Uber.

Given an array of integers, return a new array such that each element at index i of the new array is the product of all the numbers in the original array except the one at i.

For example, if our input was [1, 2, 3, 4, 5], the expected output would be [120, 60, 40, 30, 24]. If our input was [3, 2, 1], the expected output would be [2, 3, 6].

Follow-up: what if you can't use division? */

namespace Algorithms.DailyCodingProblem
{
    public static class ProblemTwo
    {
        public static void ReturnArray(int[] array)
        {
            double sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += Math.Log10(array[i]);
            }
            for (int j = 0; j < array.Length; j++)
            {
                Console.WriteLine((int)(1e-9 + Math.Pow(10.00, sum - Math.Log10(array[j]))));
            }
        }
    }
}
