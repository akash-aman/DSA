function isSubsequence(s: string, t: string): boolean {
    let indx = 0;

    for ( let i = 0 ; i < t.length; i++ ) {
        if ( indx < s.length && s[indx] == t[i] ) {
            indx = indx+1;
        }
    }

    if (indx == s.length) {
        return true;
    }

    return false;
};