using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting;
public class SelectionSort
{
    /// <summary>
    ///  In this method the array is divided into 2 halfs he left is sorted and the right is unsorted.
    /// </summary>
    /// <param name="arr"></param>
    public static void Sort(List<int> arr)
    {
        for (int i = 0; i < arr.Count - 1; i++)
        {
            // It is assumed that the current index is the smallest
            int smallest = i;

            // The position where the comparism happens keeps moving to the right by using j = i + 1
            for (int j = i + 1; j < arr.Count; j++)            
                // If j has a smaller value than i
                if (arr[j] < arr[smallest])                
                    // if true, holde the value of j and use continue to test
                    smallest = j;
                
            Util.swap(arr, i, smallest);
            
        }
    }
}
