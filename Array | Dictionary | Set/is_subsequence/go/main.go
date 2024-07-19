func isSubsequence(s string, t string) bool {
    
    sLen := len(s);
    indx := 0;

    for _,val := range t {
        if indx < sLen && rune(s[indx]) == val {
            indx++;
        }
    }

    if indx == sLen {
        return true;
    }

    return false;
}