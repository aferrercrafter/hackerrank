using System;

class Solution {
    public int solution(bool[] P) {
        
        int size = Sum(P.Length);
        int falseSeq = 0;
        int falseCount = 0;
        bool last = true;
        
        for(int i = 0; i < P.Length; i++){
            if(P[i]){
                if(!last){
                    falseCount += Sum(falseSeq);    
                }
                falseSeq = 0;
            }
            else{
                falseSeq++;
                if(i == P.Length - 1){
                    falseCount += Sum(falseSeq);
                }
            }
            last = P[i];
        }
        
        return size - falseCount;
    }
    
    int Sum (int i) {
        if (i == 1)
            return 1;
        return i + Sum(i - 1);
    }
}
