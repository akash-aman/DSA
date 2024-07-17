package main

import "fmt"


func getConcatenation(nums []int) []int {
	return append(nums,nums...)
}


func getConcatenation_II(nums []int) []int {

	var result = make([]int,2*len(nums))

	for index,num := range nums {
		result[index] = num;
		result[index+len(nums)] = num;
	}

	return result;
}

func main() {
	fmt.Println(getConcatenation([]int{1,2,3,1}))
}
