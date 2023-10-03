
namespace ImplAlgorithms.Sorting
{
    // CountingSort O(n + k) k = maxElement - minElement
    internal class CountingSort
    {
        public static void Sort(ref int[] input)
        {
            if(input.Length < 2) return;

            int max = input.Max();
            int min = input.Min();

            int[] countsArr = new int[max - min + 1];
            int[] result = new int[input.Length];

            for(int i = 0; i < input.Length; ++i)
            {
                ++countsArr[input[i] - min];
            }

            int k = 0;
            for(int i = 0; i < countsArr.Length; ++i)
            {
                while (countsArr[i] != 0)
                {
                    result[k++] = i + min;
                    --countsArr[i];
                }
            }

            input = result;

        }
    }
}
