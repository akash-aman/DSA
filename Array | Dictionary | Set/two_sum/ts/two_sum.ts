function twoSum(nums: number[], target: number): number[] {
    const hashmap = new Map();
    for (const [indx, val] of nums.entries()) {
        const difference = target - val;

        if (hashmap.has(difference)) {
            return [hashmap.get(difference), indx];
        }

        hashmap.set(val, indx);
    }

    return [0, 1];
};
