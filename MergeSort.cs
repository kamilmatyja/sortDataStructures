using System.Reflection;

namespace sortDataStructures
{
    public class MergeSort
    {
        static public void Sort(int[] arr)
        {
            Recursive(arr, 0, arr.Length - 1);
        }

        static private void Recursive(int[] arr, int left, int right)
        {
            if (left < right)
            {
                int mid = left + (right - left) / 2;

                Recursive(arr, left, mid);
                Recursive(arr, mid + 1, right);

                Merge(arr, left, mid, right);
            }
        }

        static private void Merge(int[] arr, int left, int mid, int right)
        {
            int leftArrayLength = mid - left + 1;
            int rightArrayLength = right - mid;
            int[] leftTempArray = new int[leftArrayLength];
            int[] rightTempArray = new int[rightArrayLength];
            int i, j;

            for (i = 0; i < leftArrayLength; ++i)
            {
                leftTempArray[i] = arr[left + i];
            }

            for (j = 0; j < rightArrayLength; ++j)
            {
                rightTempArray[j] = arr[mid + 1 + j];
            }

            i = 0;
            j = 0;
            int k = left;

            while (i < leftArrayLength && j < rightArrayLength)
            {
                if (leftTempArray[i] <= rightTempArray[j])
                {
                    arr[k++] = leftTempArray[i++];
                }
                else
                {
                    arr[k++] = rightTempArray[j++];
                }
            }

            while (i < leftArrayLength)
            {
                arr[k++] = leftTempArray[i++];
            }

            while (j < rightArrayLength)
            {
                arr[k++] = rightTempArray[j++];
            }
        }
    }
}
