console.log('Contain Duplicates')

/**
 * @param {number[]} nums
 * @return {boolean}
 */
var containsDuplicate = function(nums) {
    const set = new Set();

    for ( num of nums ) {
        if ( ! set.has(num) ) {
            set.add(num)
        } else {
            return true;
        }
    }

    return false;
};

containsDuplicate([1,2,3,1]);