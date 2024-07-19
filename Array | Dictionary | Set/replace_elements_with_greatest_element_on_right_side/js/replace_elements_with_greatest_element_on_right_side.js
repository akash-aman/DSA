/**
 * @param {number[]} arr
 * @return {number[]}
 */
var replaceElements = function(arr) {
    let result = [];
    let length = arr.length;
    let maxnum = -1;

    for ( let i = length - 2; i >=0 ; i-- ) {
        maxnum = Math.max(maxnum,arr[i+1]);
        result[i] = maxnum
    }

    result[length-1] = -1;
    return result;
};