console.log('Contain Duplicates')

const sol = {
    /**
     * @param nums Array<number> | number[]
     * @returns 
     */
    containDuplicates( nums : Array<number> = [] ) : boolean {
        const set = new Set();

        for ( let num of nums ) {
            if ( ! set.has(num) ) {
                set.add(num);
            } else {
                return true;
            }

        }

        return false
    },

    init: function() : void {
        console.log(this.containDuplicates([1,2,3,1]));
    }
}


sol.init()