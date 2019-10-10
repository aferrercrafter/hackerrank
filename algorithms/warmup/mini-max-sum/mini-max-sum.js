/*
Complete the miniMaxSum function in the editor below. It should print two space-separated integers on one line: the minimum sum and the maximum sum of  of  elements.
miniMaxSum has the following parameter(s):
arr: an array of  integers
*/

'use strict';

process.stdin.resume();
process.stdin.setEncoding('utf-8');

let inputString = '';
let currentLine = 0;

process.stdin.on('data', inputStdin => {
    inputString += inputStdin;
});

process.stdin.on('end', _ => {
    inputString = inputString.replace(/\s*$/, '')
        .split('\n')
        .map(str => str.replace(/\s*$/, ''));

    main();
});

function readLine() {
    return inputString[currentLine++];
}

// Complete the miniMaxSum function below.
function miniMaxSum(arr) {
    let max = arr[0];
    let min = arr[0];
    let sum = arr[0];
    for(let i = 1;i < 5; i++){
        max = arr[i] > max? arr[i]:max
        min = arr[i] < min? arr[i]:min
        sum += arr[i] 
    }
    console.log((sum - max) + ' ' + (sum - min))
}

function main() {
    const arr = readLine().split(' ').map(arrTemp => parseInt(arrTemp, 10));

    miniMaxSum(arr);
}
