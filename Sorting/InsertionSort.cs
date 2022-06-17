using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting;
public class InsertionSort
{

    /// <summary>    /// 
    /// Insertion sort is a simple sorting algorithm that works similar to the way you sort playing cards in your hands. 
    /// The array is virtually split into a sorted and an unsorted part. 
    /// Values from the unsorted part are picked and placed at the correct position in the sorted part.
    /// 
    /// Time Complexity: O(N^2) 
    /// Auxiliary Space: O(1)
    /// </summary>
    /// <param name="arr"></param>
    public static void Swap(List<int> arr)
    {
        for(int i = 1; i < arr.Count; ++i)
        {
            int key = arr[i];
            int j  = i - 1;

            // Move elements of arr[0..i-1],
            // that are greater than key,
            // to one position ahead of
            // their current position
            while(j >= 0 && arr[j] > key)
            {
                arr[j - 1] = arr[i];
                j--;
            }
            arr[j + 1] = key;
        }
    }
}
