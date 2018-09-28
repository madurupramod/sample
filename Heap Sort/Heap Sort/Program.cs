using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heap_Sort
{
    class Program
    {
        public void sort(int[] arr)
        {
            int n = arr.Length;

            for (int i = n / 2 - 1; i >= 0; i--)
            {
                heapify(arr, n, i);
            }

            for (int i = n - 1; i >= 0; i--)
            {
                // Move current root to end
                int temp = arr[0];
                arr[0] = arr[i];
                arr[i] = temp;
                heapify(arr, i, 0);
            }
        }

        void heapify(int[] arr, int n, int i)
        {
            int largest = i; 
            int l = 2 * i + 1;
            int r = 2 * i + 2;

            // If left child is larger than root
            if (l < n && arr[l] > arr[largest])
            { 
                largest = l;
            }

            // If right child is larger than largest so far
            if (r < n && arr[r] > arr[largest])
            { 
                largest = r;
            }
            if (largest != i)
            {
                int swap = arr[i];
                arr[i] = arr[largest];
                arr[largest] = swap;

                heapify(arr, n, largest);
            }
        }

        static void printArray(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n; ++i)
            { 
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }
    
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter array size");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];
            Console.WriteLine("Enter values into array:");
            for (int i = 0; i < n; i++)
            {
                arr[i]= Convert.ToInt32(Console.ReadLine());
            }
            Program ob = new Program();
            Console.WriteLine("Input array");
            printArray(arr);
            ob.sort(arr);
            Console.WriteLine("Sorted array is");
            printArray(arr);
            Console.Read();
        }

    }
}
