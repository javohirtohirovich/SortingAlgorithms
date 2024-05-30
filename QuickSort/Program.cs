namespace QuickSort;

public class Program
{
    static void Main(string[] args)
    {

        int[] arr = { 3, 5, 12, 1, 4, 2, 2, 0, -1, 10, 3, 6 };
        ////1)
        //foreach (int i in QuickSortFirstFunction(arr))
        //{
        //    Console.WriteLine(i);
        //}


        ////2)
        //QuickSortSecondFunction(arr,0,arr.Length-1);
        //foreach (int i in arr)
        //{
        //    Console.WriteLine(i);
        //}
    }

    //1-Quick Sort Function (Bu kodni tushunish oson lekin xotirani ko'p talab qiladi sababi Concat() metodi har doim yangi Array yaratadi)

    public static int[] QuickSortFirstFunction(int[] nums)
    {
        if (nums.Length < 2)
        {
            return nums;
        }
        else
        {
            Random random = new Random();
            int pivot = nums[random.Next(0, nums.Length)];
            int[] left = nums.Where(x => x < pivot).ToArray();
            int[] middle = nums.Where(x => x == pivot).ToArray();
            int[] right = nums.Where(x => x > pivot).ToArray();

            return QuickSortFirstFunction(left).Concat(middle).Concat(QuickSortFirstFunction(right)).ToArray();
        }
    }

    //2-Quick Sort Function (Bu kodni tushunish qiyin lekin tezroq va xotirani tejaydi)
    public static void QuickSortSecondFunction(int[] array, int low, int high)
    {
        if (low < high)
        {
            int pi = Partition(array, low, high);

            // Recursively sort elements before and after partition
            QuickSortSecondFunction(array, low, pi - 1);
            QuickSortSecondFunction(array, pi + 1, high);
        }
    }

    public static int Partition(int[] array, int low, int high)
    {
        int pivot = array[high];
        int i = (low - 1);

        for (int j = low; j < high; j++)
        {
            if (array[j] < pivot)
            {
                i++;
                Swap(array, i, j);
            }
        }

        Swap(array, i + 1, high);
        return i + 1;
    }

    public static void Swap(int[] array, int i, int j)
    {
        int temp = array[i];
        array[i] = array[j];
        array[j] = temp;
    }
}
