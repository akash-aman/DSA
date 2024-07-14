// See https://aka.ms/new-console-template for more information
using System.Collections.Generic;


class Program {
    static void Main ( String[] args ) {
        Solutions solutions= new Solutions();
        Console.WriteLine(solutions.containDuplicates());
    }
}

public class Solutions {
    
    protected int[] nums; 

    public Solutions () {
       this.nums = new int[]{1,2,3,1};
    }

    public bool containDuplicates() {
        var set = new HashSet<int>();

        foreach ( int num in this.nums ) {
            if ( ! set.Contains(num) ) {
                set.Add(num);
            } else {
                return true;
            }
        }

        return false;
    }
}

