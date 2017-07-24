namespace BinarySearchLogic
{
    /// <summary>
    /// Provide us with generic algorithm of binary search
    /// </summary>
    public static class GenericBinarySearch
    {
        /// <summary>
        /// Generic algorithm of binary search without type limit
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="arr">Sorted array of values</param>
        /// <param name="value">Value to search</param>
        /// <returns>Index of element if possible, otherwise -1</returns>
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
