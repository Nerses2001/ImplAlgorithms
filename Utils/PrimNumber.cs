
namespace ImplAlgorithms.Utils
{
    //// Complexity O(n * log(log n))
    internal class PrimNumber
    {

        public static List<int> GetPrimNumbers(int n)
        {
            bool[] isPrime = new bool[n + 1];
            isPrime[0] = true;
            isPrime[1] = true;
            for (int i = 2; i < n; ++i)
            {
                if (!isPrime[i])
                {
                    for (int j = i * i; j < isPrime.Length; j += i)
                    {
                        isPrime[j] = true;
                    }
                }
            }
            List<int> result = new ();
            for (int i = 0; i < isPrime.Length; ++i)
            {
                if (!isPrime[i])
                    result.Add(i);

            }
            return result;
        }
    }
}
