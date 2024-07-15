public class Solution
{
    public int FindSingle(int[] arr)
    {
        int low = 0;
        int high = arr.Length - 1;

        while (low < high)
        {
            int mid = low + (high - low) / 2;

            // Check if mid is even or odd, and compare with the next or previous element accordingly
            if (mid % 2 == 0)
            {
                if (arr[mid] == arr[mid + 1])
                {
                    low = mid + 2;
                }
                else
                {
                    high = mid;
                }
            }
            else
            {
                if (arr[mid] == arr[mid - 1])
                {
                    low = mid + 1;
                }
                else
                {
                    high = mid - 1;
                }
            }
        }

        return arr[low];
    }
}

public class Program
{
    public static void Main()
    {
        Solution solution = new Solution();

        // Test array
        int[] arr = { 1, 1, 2, 2, 3, 3, 4, 4, 5, 5, 6, 6, 7, 8, 8, 9, 9, 10, 10, 11, 11, 12, 12, 13, 13, 14, 14 };
        Console.WriteLine(solution.FindSingle(arr));  // Output: 7
    }
}
