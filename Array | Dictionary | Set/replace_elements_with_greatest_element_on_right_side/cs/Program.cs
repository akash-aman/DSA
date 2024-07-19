class Program {
    public static void Main(string[] args) {
        var sol = new Solution();
        Console.WriteLine(sol.ReplaceElements([1,2,3,4,5,6]));
    }
}

public class Solution {
    public int[] ReplaceElements(int[] arr) {
        var len = arr.Length;
        var max = -1;
        var result = new int[len];

        for ( int i = len - 2 ; i >= 0 ; i-- ) {
            max = Math.Max(max,nums[i+1])
            result[i] = max;
        }

        result[len-1] = -1;
        return result;
    }
}