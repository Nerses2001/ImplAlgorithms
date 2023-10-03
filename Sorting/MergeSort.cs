
namespace ImplAlgorithms.Sorting
{
    // Complaxity  O(n*log n)

    internal class MergeSort
    {

        public static void Sort(int[] input)
        {
            if(input.Length < 2) return;

            int mid = input.Length / 2;

            int[] left = new int[mid];
            Array.Copy(input, 0, left, 0, mid);
            
            int[] right = new int[input.Length - mid];
            Array.Copy(input, mid, right, 0, input.Length - mid);

            Sort(left);
            Sort(right);
            Marge(input, left,right);
        }

        private static void Marge(int[] input, int[] left, int[] right)
        {
            int leftLength = left.Length;
            int rightLength = right.Length;
            int i = 0, j = 0, k = 0;

            while (i < leftLength && j < rightLength)
            {
                if (left[i] < right[j]) input[k++] = left[i++];
                else input[k++] = right[j++];
            }

            while (i < leftLength)
                input[k++] = left[i++];

            while (j < rightLength)
                input[k++] = right[j++];
        }
    }
}
