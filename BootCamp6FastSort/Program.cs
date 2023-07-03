/*
Быстрая сортировка
*/

int[] QuickSort (int[] arr)
{
    if ((arr.Length) <= 1) return arr;
    else
    {
        int pivot = arr[0];
        /*
        int countLeft = 0;
        int countRight = 0;
        
        for (int i = 1; i < arr.Length; i++)
        {
            if (arr[i] < pivot) countLeft++;
            else countRight++;
        }

        int [] left = new int [countLeft];
        int [] right = new int [countRight];

        int numLeft = 0;
        int numRight = 0;        
        
        for (int i = 1; i < arr.Length; i++)
        {
            if (arr[i] < pivot)
            {
                left[numLeft] = arr[i];
                numLeft++;
            }
            else
            {
                right[numRight] = arr[i];
                numRight++;
            }
        }
        */

        
        int[] left = arr.Skip(1).Where(x => x < pivot).ToArray();
        int[] right = arr.Skip(1).Where(x => x >= pivot).ToArray();
        
        int result_size = left.Length +  1 + right.Length;
        int[] result_arr = new int[result_size];
        /*
        for (int i = 0; i < result_size; i++)
        {
            result_arr[i];
        }
        */
        
        return QuickSort(left).Concat(new int[] {pivot}).Concat(QuickSort(right)).ToArray();
    }
}

int[] arr = {3, 1, 4, 1, 5, 9, 2, 6, 5, 3, 5};
int[] arrResult = QuickSort(arr);

foreach (var item in arrResult)
{
    Console.Write($"{item} ");
}





/*
﻿using static Sorting;

int size = 10;
int size = 100;
var arr = size.CreateArray()
            .Show()
            .SortQuick(0, size - 1)
            .Show();
            .Show();
@@ -19,9 +19,9 @@public static int[] SortQuick(this int[] collection, int left, int right)
        i++;
        j--;
      }
      if (i < right) SortQuick(collection, i, right);
      if (left < j) SortQuick(collection, left, j);
    }
    if (i < right) SortQuick(collection, i, right);
    if (left < j) SortQuick(collection, left, j);
    return collection;
  }
}
*/
