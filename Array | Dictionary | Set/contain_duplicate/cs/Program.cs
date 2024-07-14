// See https://aka.ms/new-console-template for more information
using System.Collections.Generic;


class Program {
    public static void Main ( String[] args ) {
        Solution solution = new Solution();
        Console.WriteLine(solution.ContainsDuplicate([1,2,3,1]));
    }
}

public class Solution {
    public bool ContainsDuplicate(int[] nums) {
        var set = new HashSet<int>();

        foreach ( int num in nums ) {
            if ( ! set.Contains(num) ) {
                set.Add(num);
            } else {
                return true;
            }
        }

        return false;
    }
}