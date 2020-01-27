https://app.codility.com/c/run/trainingN5ZTRJ-BGD/

On the sequence of logical values (true or false) we can build up an OR-Pascal-triangle structure. Instead of summing the values, as in a standard Pascal-triangle, we will combine them using the OR function. That means that the lowest row is simply the input sequence, and every entry in each subsequent row is the OR of the two elements below it. For example, the OR-Pascal-triangle built on the array [true, false, false, true, false] is as follows

Your job is to count the number of nodes in the OR-Pascal-triangle that contain the value true (this number is 11 for the animation above).
