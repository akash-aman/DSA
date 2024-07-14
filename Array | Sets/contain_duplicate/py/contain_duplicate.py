from typing import List

class Solution:
    def containsDuplicate(self, nums: List[int]) -> bool:
        set = {}
        for num in nums:
            if not set.get(num):
                set[num] = 1
                # set.update({num:1})
            else:
                return True
        return False

sol = Solution()
print(sol.containsDuplicate([1,2,3,1]))
