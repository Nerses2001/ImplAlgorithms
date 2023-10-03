
namespace ImplAlgorithms.Sorting
{
    // Complexity  O(n^2)
    internal class BubbleSort
    {
        public static void Sort(int[] input)
        {
            for (int i = 0; i < input.Length - 1; ++i)
            {
                bool isSorted = true;

                for (int j = 0; j < input.Length - i - 1; ++j)
                {
                    if (input[j] > input[j + 1])
                    {
                        Swap(ref input[j], ref input[j + 1]);
                        isSorted = false;
                    }
                }
                if (isSorted)
                    break;
                
            }
        }
        private static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
    }
}
