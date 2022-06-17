// See https://aka.ms/new-console-template for more information
using System.Collections.Generic;
using Sorting;

Console.WriteLine("Hello, World!");

List<int> arr = new List<int>{ 56, 1, 99, 67, 89, 23, 44, 12, 78, 34 };
List<int> selectSortArr = arr.ToList();
List<int> insertionSortArr = arr.ToList();


PrintConsole.PrintListing(arr, "Initial list");
BubbleSort.Sort(arr);
PrintConsole.PrintListing(arr, "Bubble sort");

Console.WriteLine();

PrintConsole.PrintListing(selectSortArr, "Unsorted list");
SelectionSort.Sort(selectSortArr);
PrintConsole.PrintListing(selectSortArr, "Selection sort");

Console.WriteLine();

PrintConsole.PrintListing(insertionSortArr, "Unsorted list");
SelectionSort.Sort(insertionSortArr);
PrintConsole.PrintListing(insertionSortArr, "Insertion sort");