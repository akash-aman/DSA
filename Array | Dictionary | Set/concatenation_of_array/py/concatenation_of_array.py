from typing import List

class Solution:
    def getConcatenation(self, nums: List[int]) -> List[int]:
        nums.extend(nums)
        return nums
    
class Solution_II:
    def getConcatenation(self, nums: List[int]) -> List[int]:

        length = len(nums)

        for i in range(length):

            nums.append(nums[i])

        return nums
