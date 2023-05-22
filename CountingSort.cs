namespace sortDataStructures
{
    public class CountingSort
    {
        static public void Sort(int[] arr)
        {
            int size = arr.Length;
            int max = arr[0];

            for (int i = 1; i < size; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
            }

            int[] occurrences = new int[max + 1];

            for (int i = 0; i < max + 1; i++)
            {
                occurrences[i] = 0;
            }

            for (int i = 0; i < size; i++)
            {
                occurrences[arr[i]]++;
            }

            for (int i = 0, j = 0; i <= max; i++)
            {
                while (occurrences[i] > 0)
                {
                    arr[j] = i;
                    j++;
                    occurrences[i]--;
                }
            }
        }
    }
}
