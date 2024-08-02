function groupAnagrams(strs: string[]): string[][] {
    const hasmap = new Map<string,string[]>();
    const result: string[][] = [];

    for ( let str of strs ) {
        const keys = new Array(26).fill(0);

        for ( let char of str ) {
            keys[char.charCodeAt(0) - 'a'.charCodeAt(0)]++;
        }
        
        const keyString = keys.join('-');

        if ( hasmap.has(keyString) ) {
            hasmap.get(keyString)?.push(str)
        } else {
            hasmap.set( keyString, [str] );
        }
    }

    for ( let value of hasmap.values() ) {
        result.push(value)
    }

    return result;
};