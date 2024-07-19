
class Program {
    public static void Main(string[] args) {
        var sol = new Solution();
        Console.WriteLine(sol.IsSubsequence("abs","aadasdasdwbqws"));
    }
}

public class Solution {
    public bool IsSubsequence(string s, string t) {
        var index = 0;
        
        foreach ( char i in t ) {
            if ( index < s.Length && s[index] == i ) {
                index++;
            }
        }

        if (index==s.Length) {
            return true;
        }

        return false;
    }
}