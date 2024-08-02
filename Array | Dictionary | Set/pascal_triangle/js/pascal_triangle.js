var generate = function(numRows) {
    
    const result = [[1]];

    for ( let i = 1; i < numRows; i++ ) {

        const row = [1];

        for ( let j = 1; j < i ; j++) {
            row.push(result[i-1][j]+result[i-1][j-1]);
        }

        row.push(1);

        result.push(row);
    }

    return result;
};