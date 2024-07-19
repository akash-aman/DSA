func replaceElements(arr []int) []int {
    
    len := len(arr);
    var max int = -1;

    result := make([]int,len)

    for i := len - 1 ; i >= 0 ; i-- {
        if i == len - 1 {
            result[i] = -1;
        } else {
            max = Max(max,arr[i+1])
            result[i] = max;
        }
    }
    return result;
}


func Min(a int, b int) int {
    if a > b {
        return b;
    }
    return b;
}


func Max(a int, b int) int {
    if a < b {
        return b;
    }

    return a;
}
