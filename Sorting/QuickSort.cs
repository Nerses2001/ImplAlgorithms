/*
   Complexity O(n log n)
   worst case, QuickSort's time complexity can be O(n^2), 
   
   [7, 2, 1, 6, 8, 5, 3, 4]
   | 
   Pivot: 4
   |
   [2, 1, 3]       [7, 6, 8, 5]
   |               |
   Pivot: 3        Pivot: 5
   |               |
   [1, 2]          [5]        [7, 6, 8]
   |               |          |
   Pivot: 2        Pivot: 7
   |               |
   [1]   [2]       [6]   [8, 7]
   |               |     |
Sorted:[1, 2, 3, 4, 5, 6, 7, 8]
                     Sorted: [5, 6, 7, 8]
*/

namespace ImplAlgorithms.Sorting
{
    internal class QuickSort
    {
        public static void Sort(int[] input) 
        {
            SortImp(input, 0, input.Length - 1);
        }
        private static void SortImp(int[] input, int l, int r)
        {
            if (l < r) 
            {
                int pivot = Partition(input, l, r); 
                SortImp(input, l, pivot - 1); 
                SortImp(input, pivot + 1, r); 
            }
        }

        private static int Partition(int[] input, int l, int r)
        {
            int pivot = input[r];
            int pivotIndex = l - 1;

            for (int j = l; j < r; ++j)
            {
                if (input[j] < pivot)
                {
                    ++pivotIndex;
                    (input[pivotIndex], input[j]) = (input[j], input[pivotIndex]);
                }
            }

            (input[pivotIndex + 1], input[r]) = (input[r], input[pivotIndex + 1]);
            return pivotIndex + 1;
        }

    }
}
