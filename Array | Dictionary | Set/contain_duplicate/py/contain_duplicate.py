from typing import List

class Solution:
    def containsDuplicate(self, nums: List[int]) -> bool:
        dict = {}
        for num in nums:
            if not dict.get(num):
                dict[num] = 1
                # set.update({num:1})
            else:
                return True
        return False

sol = Solution()
print(sol.containsDuplicate([1,2,3,1]))
