
# Golang

## Solution I

```golang
func ContainsDuplicate(nums []int) bool {
    var set = map[int]int{};

    for _, value := range nums {

        if set[value] == 0 {
            set[value] = 1
        } else {
            return true;
        }
    }

    return false;
}

```

## Solution II
- Utilising map`s ok return value.

```golang
func containsDuplicate(nums []int) bool {
    var set = map[int]int{};

    for _,value := range nums {
        if _, ok := set[value]; !ok  {
            set[value] = 1
        } else {
            return true;
        }
    }

    return false;
}

```


# Python3

```py
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
```