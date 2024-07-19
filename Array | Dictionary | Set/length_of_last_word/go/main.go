package main

import "fmt"

func lengthOfLastWord(s string) int {
    var end rune = ' ';
	var flg bool = false;
	var cnt int = 0;
	for i := len(s) - 1; i >= 0; i-- {
		if rune(s[i]) != end && !flg {
			flg = true;
		}

		if rune(s[i]) == end && flg {
			break;
		}

		if flg {
			cnt++;
		}
	}

	return cnt;
}


func main() {
	fmt.Println(lengthOfLastWord("dfg hehl loew world "));
}