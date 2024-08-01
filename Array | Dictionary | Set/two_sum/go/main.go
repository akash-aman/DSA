package main


func twoSum(nums []int, target int) []int {
    hashmap := map[int]int{};

    for index,val := range nums {
		difference := target - val;

		if  indx,ok := hashmap[val]; ok  {
			return []int {
				indx,
				index,
			};
		}

		hashmap[difference] = index;
    }

	return []int {
		0,
		1,
	}
}