namespace sortDataStructures
{
    public class BubbleSort
    {
        static public void Sort(int[] arr)
        {
            int size = arr.Length;

            for (int i = 0; i < size - 1; i++)
            {
                for (int j = 0; j < size - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        (arr[j + 1], arr[j]) = (arr[j], arr[j + 1]);
                    }
                }
            }
        }
    }
}
