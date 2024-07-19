class Solution:
    def isSubsequence(self, s: str, t: str) -> bool:
        indx = 0

        for i in range(len(t)):
            if indx < len(s) and s[indx] == t[i]:
                indx = indx+1
        
        if indx == len(s):
            return True
        
        return False