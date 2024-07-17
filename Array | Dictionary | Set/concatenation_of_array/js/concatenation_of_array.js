/**
 * @param {number[]} nums
 * @return {number[]}
 */
var getConcatenation = function(nums) {
    return nums.concat(nums);
};

var getConcatenation_II = function(nums) {

    let len = nums.length;

    for ( let i = 0 ; i < len ; i++ ) {
        nums[i + len] = nums[i];
        // nums.push(nums[i]);
    }

    return nums;
};