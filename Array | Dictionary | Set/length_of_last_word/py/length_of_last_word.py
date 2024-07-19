class Solution:
    def lengthOfLastWord(self, s: str) -> int:
        flg = False
        cnt = 0
        end = ' '

        for i in range(len(s)-1,-1,-1):

            if s[i] != end and not flg:
                flg = True
            
            if s[i] == end and flg:
                flg = False
                break

            if flg:
                cnt=cnt+1

        return cnt