console.log('Contain Duplicates')

const solution = {
    containDuplicate(nums=[]) {
        const set = new Set();

        for ( let num of nums ) {
            if ( ! set.has(num) ) {
                set.add(num)
            } else {
                return true;
            }
        }

        return false;
    },

    init: function () {
        this.containDuplicate([1,2,3,1])
    }
}

solution.init();