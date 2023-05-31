namespace sortDataStructures
{
    public class QuickSort
    {
        static public void Sort(int[] arr)
        {
            Recursive(arr, 0, arr.Length - 1);
        }

        static private void Recursive(int[] arr, int left, int right)
        {
            int i = left;
            int j = right;
            int pivot = arr[left];

            while (i <= j)
            {
                while (arr[i] < pivot)
                {
                    i++;
                }

                while (arr[j] > pivot)
                {
                    j--;
                }

                if (i <= j)
                {
                    (arr[j], arr[i]) = (arr[i], arr[j]);
                    i++;
                    j--;
                }
            }

            if (left < j)
            {
                Recursive(arr, left, j);
            }

            if (i < right)
            {
                Recursive(arr, i, right);
            }
        }
    }
}
