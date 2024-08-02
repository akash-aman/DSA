package main

func main() {
}

func groupAnagrams(strs []string) [][]string {
	hashmap := map[[26]int][]string{}
	result := [][]string{}

	for _, str := range strs {
		key := [26]int{}

		for _, char := range str {
			key[char-'a']++
		}

		hashmap[key] = append(hashmap[key], str)
	}

	for _, val := range hashmap {
		result = append(result, val)
	}

	return result
}
