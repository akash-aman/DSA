// Go example to convert a string to an array of characters (runes)
package main

import (
    "fmt"
)

func main() {
	fmt.Print(isAnagram("anagram","nagaram"));
}

func isAnagram(s string, t string) bool {
    set := map[rune]int{};

    if len(s) != len(t) {
        return false;
    }

    tRune := []rune(t);
    for index,sChar := range []rune(s) {
        if _,ok := set[sChar]; !ok {
            set[sChar] = 1;
        } else {
            set[sChar] = set[sChar] + 1; 
        }

        if _, ok := set[tRune[index]]; !ok {
            set[tRune[index]] = -1;
        } else {
            set[tRune[index]] = set[tRune[index]] - 1; 
        }
    }

    for _,val := range set {
        if val != 0 {
            return false;
        }
    }

    return true;
}