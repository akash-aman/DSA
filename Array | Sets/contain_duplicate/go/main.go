package main


func containsDuplicate(nums []int) bool {
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

func main() {
	nums := []int{1, 2, 3, 1}
	println(containsDuplicate(nums))
}