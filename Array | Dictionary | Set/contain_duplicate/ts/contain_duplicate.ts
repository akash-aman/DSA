function containsDuplicate(nums: number[]): boolean {
    const set = new Set();

    for ( let num of nums) {
        if ( ! set.has(num) ) {
            set.add(num)
        } else {
            return true;
        }
    }

    return false
};

containsDuplicate([1,2,3,1]);