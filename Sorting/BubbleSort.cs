using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sorting
{

    public class BubbleSort
    {
        /// <summary> 
        /// Bubble Sort is the simplest sorting algorithm that works by repeatedly swapping the adjacent elements if they are in the wrong order. 
        /// This algorithm is not suitable for large data sets as its average and worst case time complexity is quite high.
        /// 
        /// The above function always runs O(n^2) time even if the array is sorted.
        /// It can be optimized by stopping the algorithm if the inner loop didn’t cause any swap.
        /// 
        /// </summary>
        public static void Sort(List<int> arr)
        {

            // This will count from 1st to the second to last
            for (int i = 0; i < arr.Count - 1; i++)
            {
                for (int j = i + 1; j < arr.Count; j++)
                {
                    if (arr[j] < arr[i])
                        Util.swap(arr, i, j);

                }
            }
        }
    }
}