using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting;
public class Util
{
    public static void swap(List<int> arr, int i, int j)
    {
        int holder = arr[j];
        arr[j] = arr[i];
        arr[i] = holder;
    }
}
