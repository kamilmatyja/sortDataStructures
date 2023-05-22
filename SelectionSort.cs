namespace sortDataStructures
{
    public class SelectionSort
    {
        static public void Sort(int[] arr)
        {
            int size = arr.Length;

            for (int i = 0; i < size - 1; i++)
            {
                int min = i;

                for (int j = i + 1; j < size; j++)
                {
                    if (arr[j] < arr[min])
                    {
                        min = j;
                    }
                }

                (arr[i], arr[min]) = (arr[min], arr[i]);
            }
        }
    }
}
