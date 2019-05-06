using System;

namespace Algorithms.Array
{
    static class RotateAndDelete
    {
        public static void GetRotation(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                int tVal = array[0];
                array[0] = array.GetUpperBound(0);
                array[array.GetUpperBound(0)] = tVal;
                System.Array.Resize(ref array, array.Length - 1);
            }
            Console.WriteLine(array[0]);
        }
    }
}

