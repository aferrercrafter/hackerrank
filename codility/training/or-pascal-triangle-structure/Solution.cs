using System;

class Solution {
    public int solution(bool[] P) {
        
        ulong size = Sum(Convert.ToUInt64(P.Length));
        ulong falseSeq = 0;
        ulong falseCount = 0;
        bool last = true;
        
        for(int i = 0; i < P.Length; i++){
            if(P[i]){
                if(!last){
                    falseCount += Sum(Convert.ToUInt64(falseSeq));    
                }
                falseSeq = 0;
            }
            else{
                falseSeq++;
                if(i == P.Length - 1){
                    falseCount += Sum(Convert.ToUInt64(falseSeq));
                }
            }
            last = P[i];
        }
        
        ulong res = size - falseCount;
        return (res >= 1000000000)? 1000000000 : (int)res;
    }
    
    ulong Sum (ulong n) {
        return (n * (n +1))/2;
    }
}
