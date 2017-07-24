using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchLogic
{
    public static class GenericBinarySearch
    {
        public static int BinarySearch<T>(T[] arr, T value)
        {
            return BinarySearch(0, arr.Length, arr, value);
        }

        private static int BinarySearch(int bottom, int top, dynamic arr, dynamic value)
        {
            if (bottom > top)
                return -1;

            int mid_index = (top + bottom) / 2;

            if (value.CompareTo(arr[mid_index]) < 0)
                return BinarySearch(bottom, mid_index - 1, arr, value);
            if (value.CompareTo(arr[mid_index]) > 0)
                return BinarySearch(mid_index + 1, top, arr, value);
            return mid_index;
        }
    }
}
