namespace ImplAlgorithms.Searching
{
    // Complexity O(log n)
    internal class BinarySearch
    {
        public static (bool, int) Search(int[] inputSorted, int targetElement)
        {
            if(inputSorted.Length == 0) return (false, -1);
            return SearchImp(inputSorted, 0, inputSorted.Length - 1, targetElement);

        }

        private static (bool, int) SearchImp(int[] input, int l, int r, int t)
        {
            if(l > r) return (false, -1);

            int m = l + (r - l) / 2;
            
            if(t == input[m]) return (true, m);
            else if(t < input[m]) return SearchImp(input, l,m -1, t);
            else return SearchImp(input, m + 1, r, t);
        }

    }
}
