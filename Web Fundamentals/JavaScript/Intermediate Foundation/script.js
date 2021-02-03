function sigma(num){
    var sum = 0;
    for(var i = 1; i <= num; i++){
        sum += i;
    }
    return sum;
}
console.log("sum of 5:", sigma(5));

function factorial(num){
    var factorial = 1;
    for(var i = 1; i <= num; i++){
        factorial *= i;
    }
    return factorial;
}
console.log("5! =", factorial(5));

function fibonacci(num){
    if(num == 0) return 0;
    if(num == 1) return 1;
    return fibonacci(num-1) + fibonacci(num-2);
}
console.log("Fibonacci(6) =", fibonacci(6));

function scndToLast(arr){
    if(arr.length > 1) return arr[arr.length-2];
    else return null;
}
var arr =  [42, true, 4, "Liam", 7];
console.log("Second-to-last of",  arr, "is", scndToLast(arr));

function nthToLast(arr, n){
    if(arr.length > (n-1)) return arr[arr.length-n];
    else return null;
}
arr = [5,2,3,6,4,9,7];
var n = 3;
console.log(n+"th-to-last of",  arr, "is", nthToLast(arr, n));

function scndLargest(arr){
    var temp;
    for(var i = 0; i < arr.length-1; i++){
        if(arr[i] > arr[i+1]){
            temp = arr[i];
            arr[i] = arr[i+1];
            arr[i+1] = temp;
        }
    }
    return arr[arr.length-2];
}
arr =  [42,1,4,3.14,7];
console.log("Second-Largest of", arr, "is", scndLargest(arr));

function doubleElements(arr){
    var newArr = [];
    for(var i = 0; i < arr.length*2; i++){
        newArr[i] = arr[Math.floor(i/2)];
    }
    return newArr;
}
arr = [4, "Ulysses", 42, false];
console.log("Double of ", arr, "is", doubleElements(arr));