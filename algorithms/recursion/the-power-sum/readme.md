https://www.hackerrank.com/challenges/the-power-sum/problem

Need to think as there are to path in the recursiveness, 
1 path, is that the current number is one of the sum,
other path is that it didn't form part.

```
return path1 + path2;
return Path(X - Pow(CurrentNumber), NextNumber) + Path(X, NextNumber)
return Path(X - Pow(num), num + 1) + Path(X, num + 1))
```

And there are two kind of return.

If the number pow is greater than X, there is no need to follow that Path

``` C#
  if(Pow(num) > X)
    return 0
```  
And the case of success

``` C#
  if(Pow(num) == X)
    return 0;
```

So it will end

``` C#
PowerSum(X, N, num) {
  if(Math.Pow(num) > X)
    return 0;
    
  if(Math.Pow(num) == X)
    return 0;
    
  return PowerSum(X - Math.Pow(N), N , num + 1) + PowerSum(X, N , num + 1);
}
```
