using sortDataStructures;
using System;

internal class Program
{
    static void Main()
    {
        DateTime start = DateTime.Now;

        int[] arr = RandomArray(20);

        int[] arr1 = (int[])arr.Clone();
        int[] arr2 = (int[])arr.Clone();
        int[] arr3 = (int[])arr.Clone();
        int[] arr4 = (int[])arr.Clone();
        int[] arr5 = (int[])arr.Clone();
        int[] arr6 = (int[])arr.Clone();

        Console.WriteLine("Original array: ");
        PrintArray(arr1);

        BubbleSort.Sort(arr1);
        Console.WriteLine("Bubble sorted array: ");
        PrintArray(arr1);

        CountingSort.Sort(arr2);
        Console.WriteLine("Counting sorted array: ");
        PrintArray(arr2);

        MergeSort.Sort(arr3);
        Console.WriteLine("Merge sorted array: ");
        PrintArray(arr3);

        QuickSort.Sort(arr4);
        Console.WriteLine("Quick sorted array: ");
        PrintArray(arr4);

        SelectionSort.Sort(arr5);
        Console.WriteLine("Selection sorted array: ");
        PrintArray(arr5);

        ShellSort.Sort(arr6);
        Console.WriteLine("Shell sorted array: ");
        PrintArray(arr6);

        Console.WriteLine("ilość;typ;czas bubble;czas counting;czas merge;czas quick;czas selection;czas shell;");
        Results();
        Results("const");
        Results("asc");
        Results("desc");

        DateTime end = DateTime.Now;
        TimeSpan ts = (end - start);
        Console.WriteLine("All time: {0}", ts.TotalMilliseconds);

        Console.ReadLine();
    }

    static private void PrintArray(int[] arr)
    {
        int n = arr.Length;
        for (int i = 0; i < n; ++i)
        {
            Console.Write(arr[i] + " ");
        }
        Console.WriteLine();
    }

    static private int[] RandomArray(int size, string type = "")
    {
        int[] arr = new int[size];
        Random random = new Random();
        int randomInt = random.Next(101);

        for (int i = 0; i < size; i++)
        {
            if (type == "const")
            {
                arr[i] = randomInt;
            }
            else
            {
                arr[i] = random.Next(101);
            }
        }

        if (type == "asc" || type == "desc")
        {
            Array.Sort(arr);
        }

        if (type == "desc")
        {
            Array.Reverse(arr);
        }

        return arr;
    }

    static private void Results(string type = "random")
    {
        for (int i = 1; i <= 100; i++)
        {
            int[] arr = RandomArray(i, type);

            int[] arr1 = (int[])arr.Clone();
            int[] arr2 = (int[])arr.Clone();
            int[] arr3 = (int[])arr.Clone();
            int[] arr4 = (int[])arr.Clone();
            int[] arr5 = (int[])arr.Clone();
            int[] arr6 = (int[])arr.Clone();

            DateTime start1 = DateTime.Now;
            BubbleSort.Sort(arr1);
            DateTime end1 = DateTime.Now;
            TimeSpan ts1 = (end1 - start1);

            DateTime start2 = DateTime.Now;
            CountingSort.Sort(arr2);
            DateTime end2 = DateTime.Now;
            TimeSpan ts2 = (end2 - start2);

            DateTime start3 = DateTime.Now;
            MergeSort.Sort(arr3);
            DateTime end3 = DateTime.Now;
            TimeSpan ts3 = (end3 - start3);

            DateTime start4 = DateTime.Now;
            QuickSort.Sort(arr4);
            DateTime end4 = DateTime.Now;
            TimeSpan ts4 = (end4 - start4);

            DateTime start5 = DateTime.Now;
            SelectionSort.Sort(arr5);
            DateTime end5 = DateTime.Now;
            TimeSpan ts5 = (end5 - start5);

            DateTime start6 = DateTime.Now;
            ShellSort.Sort(arr6);
            DateTime end6 = DateTime.Now;
            TimeSpan ts6 = (end6 - start6);

            Console.WriteLine("{0};{1};{2};{3};{4};{5};{6};{7};", i, type, ts1.TotalMilliseconds, ts2.TotalMilliseconds, ts3.TotalMilliseconds, ts4.TotalMilliseconds, ts5.TotalMilliseconds, ts6.TotalMilliseconds);
        }
    }
}