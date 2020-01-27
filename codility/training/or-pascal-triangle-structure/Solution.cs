using System;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution {
    public int solution(bool[] P) {
        // write your code in C# 6.0 with .NET 4.5 (Mono)
        int pascal_size = factorial(P.Length);
        int false_seq = 0;
        int not_true = 0;
        
        for(int i = 0; i < P.Length - 1; i++){
            
            if(!P[i] && !P[i + 1])
                false_seq ++;
            else if(!P[i] && false_seq > 0)
                not_true += factorial (false_seq + 1);
            else if (!P[i] && false_seq == 0)
                not_true ++;
            else
                false_seq = 0;
        }
        
        not_true += (!P[P.Length - 1] && P[P.Length - 2])? 1 : 0;
        
        return pascal_size - not_true;
    }
    
    int factorial (int i) {
        if(i == 1)
            return 1;
        return i + factorial(i - 1);
    }
}
