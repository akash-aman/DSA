﻿class Program {
    public static void Main( String[] args) {

    }
}

public class Solution {
    public string LongestCommonPrefix(string[] strs) {

        for ( int i = 0 ; i < strs[0].Length; i++ ) {
            for ( int j = 1; j < strs.Length ; j++ ) {
                if ( i == strs[j].Length || strs[0][i] != strs[j][i] ) {
                    return strs[0].Substring(0, i);
                }
            }
        }

        return strs[0];
    }
}