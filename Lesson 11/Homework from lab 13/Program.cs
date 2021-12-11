using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_from_lab_13
{
    class Program
    {
        public static void ShellSort(int[] Array)
        {
            int step = Array.Length / 2;
            while (step > 0)
            {
                int i, j;
                for (i = step; i < Array.Length; i++)
                {
                    int value = Array[i];
                    for (j = i - step; (j >= 0) && (Array[j] > value); j -= step)
                        Array[j + step] = Array[j];
                    Array[j + step] = value;
                }
                step /= 2;
            }
            for (int i = 0; i < Array.Length; i++)
                Console.Write(Array[i] + " ");
        }
        public static void BubbleSort(int[] arr)
        {
            int temp = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        temp = arr[j + 1];
                        arr[j + 1] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
            for (int i = 0; i < arr.Length; i++)
                Console.Write(arr[i] + " ");
        }
        public static int Partition(int[] Array, int start, int end)
        {
            int temp;
            int marker = start;
            for (int i = start; i <= end; i++)
            {
                if (Array[i] < Array[end])
                {
                    temp = Array[marker];
                    Array[marker] = Array[i];
                    Array[i] = temp;
                    marker += 1;
                }
            }
            temp = Array[marker];
            Array[marker] = Array[end];
            Array[end] = temp;

            return marker;

        }

        public static void QuickSort(int[] Array, int start, int end)
        {
            if (start >= end)
            {
                return;
            }
            int pivot = Partition(Array, start, end);
            QuickSort(Array, start, pivot - 1);
            QuickSort(Array, pivot + 1, end);

        }
        public static void InsertionSort(int[] array)
        {
            for (int i = 1; i < array.Length; i++)
            {
                int cur = array[i];
                int j = i;
                while (j > 0 && cur < array[j - 1])
                {
                    array[j] = array[j - 1];
                    j--;
                }
                array[j] = cur;
            }
            for (int i = 0; i < array.Length; i++)
                Console.Write(array[i] + " ");
        }
        public static void SelectionSort(int[] Array)
        {
            for (int i = 0; i < Array.Length - 1; i++)
            {
                int min = i;
                for (int j = i + 1; j < Array.Length; j++)
                {
                    if (Array[j] < Array[min])
                    {
                        min = j;
                    }
                }
                int dummy = Array[i];
                Array[i] = Array[min];
                Array[min] = dummy;
                min = i;
            }
            for (int i = 0; i < Array.Length; i++)
                Console.Write(Array[i] + " ");
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            //Упражнение 13.1
            Building build = new Building();
            build.number = 1;
            build.height = 5;
            build.floors = 5;
            build.apartments = 20;
            build.entrances = 25;
            //Упражнение 13.2
            Builds b = new Builds();
            Building build_1 = new Building(5, 5, 20, 25);
            Building build_2 = new Building(10, 10, 100, 120);
            Building build_3 = new Building(8, 5, 50, 100);
            b.builds[0] = build_1;
            b.builds[1] = build_1;
            b.builds[2] = build_1;
            //Сортировки
            int[] arr = { 800, 11, 50, 771, 649, 770, 240, 9 };
            Console.WriteLine("BubbleSort:");
            BubbleSort(arr);
            Console.WriteLine();
            Console.WriteLine("Shell sort :");
            ShellSort(arr);
            Console.WriteLine();
            Console.WriteLine("quick sort: ");
            QuickSort(arr, 0, arr.Length - 1);
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"{arr[i]} ");
            }
            Console.WriteLine();
            Console.WriteLine("selection sort :");
            SelectionSort(arr);
            Console.WriteLine();
            Console.WriteLine("insertion sort");
            InsertionSort(arr);
        }
    }
}
