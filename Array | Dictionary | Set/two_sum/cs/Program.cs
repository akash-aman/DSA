
using System.Collections;

class Program {

    public static void Main(String[] args) {

    }
}

public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        var map = new Hashtable();

        for ( int i = 0 ; i < nums.Length ; i++ ) {
            var difference = target - nums[i];

            if (map.ContainsKey(nums[i])){
                return new int[]{
                    (int)map[nums[i]],
                    i
                };
            }

            map[difference] = i;
        }

        return [0,1];
    }
}