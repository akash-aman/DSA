// See https://aka.ms/new-console-template for more information
class Program
{
    public static void Main(string[] args)
    {
        var sol = new Solution();
        int[] arr = [1, 2, 3, 3, 4];
        Console.WriteLine(sol.GetConcatenation(arr));
    }
}

public class Solution
{
    public int[] GetConcatenation(int[] nums)
    {
        return nums.Concat(nums).ToArray();
    }
}

public class Solution_II
{
    public int[] GetConcatenation(int[] nums)
    {

        int i = 0;

        var result = new int[2 * nums.Length];

        foreach (int num in nums)
        {
            result[i] = num;
            result[i + nums.Length] = num;
            i++;
        }

        return result;
    }
}