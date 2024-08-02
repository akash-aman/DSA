class Program {
    public static void Main( string[] args ) {

    }
}


public class Solution {
    public IList<IList<int>> Generate(int numRows) {
        var result = new List<IList<int>>();

        result.Add(new List<int>{1});

        for( int i = 1; i < numRows; i++ ) {
            var row = new List<int>{1};

            for ( int j = 1; j < i ; j++ ) {
                row.Add(result[i-1][j]+result[i-1][j-1]);
            }

            row.Add(1);

            result.Add(row);
        }

        return result;
    }
}