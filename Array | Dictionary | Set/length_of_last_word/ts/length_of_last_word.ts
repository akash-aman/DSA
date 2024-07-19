function lengthOfLastWord(s: string): number {
    let count = 0;
    let end = " ";
    let flag = false;

    for (let i = s.length - 1; i >= 0; i--) {
        if (s[i] != end && !flag) {
            flag = true;
        }

        if (s[i] == end && flag) {
            break;
        }

        if (flag) {
            count++;
        }
    }

    return count;  
};