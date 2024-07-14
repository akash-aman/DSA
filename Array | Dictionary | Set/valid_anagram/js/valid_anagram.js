console.log("Is_Anagram")


class Solution {
    isAnagram(s, t) {
        if (s.length != t.length) {
            return false;
        }

        const dict = new Map();

        for ( let i = 0 ; i < s.length ; i++ ) {
    
            if ( ! dict.has(s[i]) ) {
                dict.set(s[i], 1)
            } else {
                dict.set(s[i], dict.get(s[i]) + 1) 
            }
    
            if ( ! dict.has(t[i]) ) {
                dict.set(t[i], -1)
            } else {
                dict.set(t[i], dict.get(t[i]) - 1) 
            }
        }

        for ( let [key,val] of dict ) {
            if (val != 0 ) {
                return false;
            }
        }
    
        return true;
    };
}

var isAnagram = function(s, t) {
    if (s.length !== t.length) {
        return false;
    }

    const dict = new Map();

    for (let i = 0; i < s.length; i++) {

        dict.set(s[i], (dict.get(s[i]) || 0) + 1);

        dict.set(t[i], (dict.get(t[i]) || 0) - 1);
    }

    for ( let [key, value] of dict) {
        if (value !== 0) {
            return false;
        }
    }

    return true; 
};