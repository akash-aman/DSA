
class Program {
    public static void Main(string[] args) {
        var sol = new Solution();
        Console.WriteLine(sol.LengthOfLastWord("aadasdasdwbqws"));
    }
}

public class Solution {
    public int LengthOfLastWord(string s) {
        char end = ' ';
        int count = 0;
        bool flag = false;

        for ( int i = s.Length - 1; i >=0 ; i--  ) {
            if ( s[i] != end && !flag ) {
                flag = true;
            }

            if ( s[i] == end && flag ) {
                break;
            }

            if (flag) {
                count++;
            }
        }

        return count;
    }
}