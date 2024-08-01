class Solution:
    def twoSum(self, nums: List[int], target: int) -> List[int]:
        hashmap = {}

        for indx,num in enumerate(nums):
            difference = target - num

            val = hashmap.get(num)
            if val != None:
                return [val,indx] 

            hashmap[difference] = indx

        return [0,1]