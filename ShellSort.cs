namespace sortDataStructures
{
    public class ShellSort
    {
        static public void Sort(int[] arr)
        {
            Recursive(arr, arr.Length);
        }

        static private void Recursive(int[] arr, int size)
        {
            for (int interval = size / 2; interval > 0; interval /= 2)
            {
                for (int i = interval; i < size; i++)
                {
                    var currentKey = arr[i];
                    var k = i;

                    while (k >= interval && arr[k - interval] > currentKey)
                    {
                        arr[k] = arr[k - interval];
                        k -= interval;
                    }

                    arr[k] = currentKey;
                }
            }
        }
    }
}
