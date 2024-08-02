package main


func main() {

}

func generate(numRows int) [][]int {
	
	arrs := [][]int{};

	arrs = append(arrs, []int{1});

	for i := 1 ; i < numRows; i++ {

		arr := []int{1};

		arr = append(arr, 1);

		for j := 1; j < i; j++ {
			arr = append(arr, arrs[i-1][j]+ arrs[i-1][j-1])
		}

		arr = append(arr, 1)

		arrs = append(arrs, arr)
	}

	return arrs
}