//1. Get 1 to 255
function get255Nums(){
    var arr = [];
    for(let i = 1; i <= 255; i++)
        arr.push(i);
    return arr;
}
//2. Get even 1000
function getSumOfEven1000(){
    var sum = 0;
    for(let i = 1; i <= 1000; i++){
        if(i%2 == 0) sum += i
    }
    return sum;
}
//3. Sum odd 5000
function getSumOfOdd5000(){
    var sum = 0;
    for(let i = 1; i <= 5000; i++){
        if(i%2 == 1) sum += i
    }
    return sum;
}
//4. Iterate an array
function sumArr(arr){
    var sum = 0;
    for(let i = 0; i < arr.length; i++){
        sum += arr[i];
    }
    return sum;
}
//5. Find max
function findMax(arr){
    let max = arr[0];
    for(let i = 1; i < arr.length; i++){
        if(arr[i] > max) max = arr[i]
    }
    return max;
}
//6. Find average
function findAvg(arr){
    var sum = 0;
    for(let i = 0; i < arr.length; i++){
        sum += arr[i];
    }
    var avg = sum / arr.length;
    return avg;
}
//7. Array odd
function oddElementsOfArr(){
    var newArr = [];
    for(let i = 1; i <= 50; i++){
        if(i%2 == 1){
            newArr.push(i);
        }
    }
    return newArr;
}
// 8. Greater than Y
function greaterThanY(arr, y){
    var count = 0;
    for(let i = 0; i < arr.length; i++){
        if(arr[i] > y) count++;
    }
    return count;
}
//9. Squares
function squares(arr){
    for(let i = 0; i < arr.length; i++){
        arr[i] = Math.pow(arr[i], 2);
    }
    return arr;
}
//10. Negatives
function replaceNegativesWithZero(arr){
    for(let i = 0; i < arr.length; i++){
        if(arr[i] < 0) arr[i] = 0;
    }
    return arr;
}
//11. Max/Min/Avg
function max_min_avg(arr){
    var max = arr[0];
    var min = arr[0];
    var sum = arr[0];
    for(let i = 1; i < arr.length; i++){
        if(max < arr[i]) max = arr[i];
        if(min > arr[i]) min = arr[i];
        sum += arr[i];
    }
    sum /= arr.length;
    return [max, min, sum];
}
//12. Swap Values
function swapFirstandLast(arr){
    if(arr.length >= 2){
        var temp = arr[0];
        arr[0] = arr[arr.length-1];
        arr[arr.length-1] = temp;
    }
    return arr;
}
//13. Number to String
function replaceNegetivesWithStr(arr){
    for(let i = 1; i < arr.length; i++){
        if(arr[i] < 0) arr[i] = 'Dojo';
    }
    return arr;
}