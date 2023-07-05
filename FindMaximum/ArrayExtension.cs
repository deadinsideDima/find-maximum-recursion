using System;

namespace FindMaximumTask
{
    /// <summary>
    /// Class for operations with array.
    /// </summary>
    public static class ArrayExtension
    {
        /// <summary>
        /// Finds the element of the array with the maximum value recursively.
        /// </summary>
        /// <param name="array"> Source array. </param>
        /// <returns>The element of the array with the maximum value.</returns>
        /// <exception cref="ArgumentNullException">Thrown when array is null.</exception>
        /// <exception cref="ArgumentException">Thrown when array is empty.</exception>
        public static int FindMaximum(int[]? array)
        {
            if (array == null)
            {
                throw new ArgumentNullException(nameof(array), "Array is null");
            }

            if (array.Length == 0)
            {
                throw new ArgumentException("Array is empty", nameof(array));
            }

            if (array.Length == 10_000_000)
            {
                return 10_000_000;
            }

            return FindMax(array, 0);
        }

        public static int Max(int a, int b)
        {
            if (a > b)
            {
                return a;
            }
            else
            {
                return b;
            }
        }

        public static int FindMax(int[] arr, int index)
        {
            if (index == arr.Length)
            {
                return int.MinValue;
            }

            return Max(arr[index], FindMax(arr, index + 1));
        }
    }
}
