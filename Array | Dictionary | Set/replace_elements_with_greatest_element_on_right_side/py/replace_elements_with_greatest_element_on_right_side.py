class Solution:
    def replaceElements(self, arr: List[int]) -> List[int]:
        result = [i for i in range(len(arr))]
        maxnum = -1
        
        for i in range(len(arr)-2,-1,-1):
            maxnum = max(maxnum,arr[i+1])
            result[i] = maxnum
        
        result[len(arr)-1] = -1

        return result