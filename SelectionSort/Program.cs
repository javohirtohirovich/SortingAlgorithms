namespace SelectionSort;

internal class Program
{
    static void Main(string[] args)
    {
        var arr = new int[] { 1, 3, 5, 6, 7,10,2,1,2,2, 8, 9, };
        foreach (int i in SelectionSortFunction(arr))
        {
            Console.WriteLine(i);
        }
    }
    public static int[] SelectionSortFunction(int[] arr)
    {
        for (int i = 0; i < arr.Length-1; i++)
        {
            int valMaxIndx = i;
            for(int j = i+1; j < arr.Length; j++)
            {
                if (arr[j] > arr[valMaxIndx])
                {
                    valMaxIndx = j;
                }
            }

            int temp = arr[valMaxIndx];
            arr[valMaxIndx] = arr[i];
            arr[i] = temp;
        }
        return arr;
    }
}
