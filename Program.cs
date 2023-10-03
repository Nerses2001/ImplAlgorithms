using ImplAlgorithms.Sorting;

int[] arr1 = { 5, 3, 1, 4, 2 };
BoobleSort.Sort(arr1);

for (int i = 0; i < arr1.Length; ++i)
{
    Console.Write($"{arr1[i]} ");
}