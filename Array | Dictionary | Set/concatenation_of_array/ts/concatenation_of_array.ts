function getConcatenation(nums: number[]): number[] {
    return nums.concat(nums);
};

function getConcatenation_II(nums: number[]): number[] {

    let len = nums.length;

    for ( let i = 0 ; i < len ; i++ ) {
        nums[i + len] = nums[i];
        // nums.push(nums[i]);
    }

    return nums;
};