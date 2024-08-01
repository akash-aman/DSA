package main

func main() {
	
}

func longestCommonPrefix(strs []string) string {
	
	for i,char := range strs[0] {
		for _,str := range strs[1:] {
			if i == len(str) || char != rune(str[i]) {
				return str[0:i];
			}
		}
	}

	return strs[0];
}