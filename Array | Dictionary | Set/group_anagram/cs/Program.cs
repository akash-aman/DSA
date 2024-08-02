using System.Collections;
class Program
{
    public static void Main(string[] args)
    {
        var solution = new Solution();
        solution.GroupAnagrams(["eat","tea","tan","ate","nat","bat"]);
    }
}

public class Solution
{
    public IList<IList<string>> GroupAnagrams(string[] strs)
    {
        var result = new List<IList<string>>();
        var hashmap = new Dictionary<string,IList<string>>();

        foreach ( var str in strs ) {
            var key = new int[26];

            foreach ( var ch in str ) {
                key[ch-'a']++;
            }
            
            var keyString = string.Join('-',key);

            if ( hashmap.ContainsKey(keyString) ) {
                hashmap[keyString].Add(str);
            } else {
                hashmap.Add(keyString,new List<string>{str});
            }
        }

        foreach ( var arr in hashmap.Values ) {
            result.Add(arr);
        }

        return result;
    }
}