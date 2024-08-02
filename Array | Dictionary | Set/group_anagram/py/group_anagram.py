from collections import defaultdict
from typing import List


class Solution:
    def groupAnagrams(self, strs: List[str]) -> List[List[str]]:
        hashmap = defaultdict(list)
        for str in strs:
            keys = [0] * 26
            for char in str:
                keys[ord(char) - ord('a')] += 1
            
            hashmap[tuple(keys)].append(str)

        return list(hashmap.values())

sol = Solution()

sol.groupAnagrams(["eat","tea","tan","ate","nat","bat"])