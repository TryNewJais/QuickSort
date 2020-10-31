using System;

namespace Sorting
{
    public class Quicksort
    {
        public void  QuickSort(int[] arr, int p, int r)
        {
            if(p<=r)
            {
                int q = Partition(arr, p, r);
                QuickSort(arr, p, q-1);
                QuickSort(arr, q + 1, r);
            }
        }

        private int Partition(int[] arr, int p, int r)
        {
            int temp;
            int x = arr[r];
            int i = p - 1;
            for (int j = p; j < r; j++)
            {
                if (arr[j] <= x)
                {
                    i++;
                    temp = arr[j];
                    arr[j] = arr[i];
                    arr[i] = temp;

                }
            }
            temp = arr[i + 1];
            arr[i + 1] = arr[r];
            arr[r] = temp;
            return i + 1;
        }
        
        public void CallerMain()
        {
            int[] arr = new int[] { 2, 8, 7, 1, 3, 5, 6, 4 };
            QuickSort(arr, 0, (arr.Length-1));

            foreach(int i in arr)
            {
                Console.Write(i+" ");
            }
            Console.WriteLine();

        }

    }
}
