using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Security.Cryptography;
class Program {
    public static void Main( string[] args) {

    }
}


public class Solution {
    public bool IsAnagram(string s, string t) {

        var dict = new Dictionary<char,int>();

        //char[] s = s.ToCharArray();
        //char[] t = t.ToCharArray();

        if ( s.Length != t.Length ) {
            return false;
        }

        for ( int x = 0; x < s.Length; x++ ) {
            if ( !dict.ContainsKey(s[x]) ) {
                dict[s[x]] = 1;
            } else {
                dict[s[x]] = dict[s[x]] + 1;
            }

            if ( !dict.ContainsKey(t[x]) ) {
                dict[t[x]] = -1;
            } else {
                dict[t[x]] = dict[t[x]] - 1;
            }
        }

        foreach ( char c in dict.Keys ) {
            if ( dict.ContainsKey(c) && dict[c] != 0 ) {
                return false;
            }
        }

        return true;
    }
}