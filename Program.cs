﻿using ImplAlgorithms.Sorting;
using ImplAlgorithms.Utils;

int[] arr1 = { 5, 3, 1, 4, 2 };
BubbleSort.Sort(arr1);

for (int i = 0; i < arr1.Length; ++i)
{
    Console.Write($"{arr1[i]}, ");
}

Console.WriteLine("\n");

List<int> list = PrimNumber.GetPrimNumbers(11);

foreach (int i in list)
{
    Console.Write($"{i}, ");
}

Console.WriteLine("\n");

int[] arr2 = { 12, 11, 13, 5, 6, 7 };
MergeSort.Sort(arr2);
foreach (int i in arr2)
{
    Console.Write($"{i}, ");
}

