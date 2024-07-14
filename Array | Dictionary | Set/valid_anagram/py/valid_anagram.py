class Solution:
    def isAnagram(self, s: str, t: str) -> bool:
        dictionary = {}

        if len(s) != len(t):
            return False

        for i in range(len(s)):

            if not dictionary.get(s[i]):
                dictionary[s[i]] = 1
            else:
                dictionary[s[i]] = dictionary[s[i]] + 1 
        
            if not dictionary.get(t[i]):
                dictionary[t[i]] = -1
            else:
                dictionary[t[i]] = dictionary[t[i]] - 1
        
        for val in dictionary.values():
            if val != 0:
                return False
            
        return True

