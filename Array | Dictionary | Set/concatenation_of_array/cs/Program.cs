// See https://aka.ms/new-console-template for more information
class Program {
    public static void Main( string[] args ) {

    }
}

public class Solution {
    public int[] GetConcatenation(int[] nums) {
        return nums.Concat(nums).ToArray();
    }
}