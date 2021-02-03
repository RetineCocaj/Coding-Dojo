//1. Biggie Size
function makeItBig(arr){
    for(let i = 0; i < arr.length; i++){
        if(arr[i] > 0) arr[i] = 'big';
    }
    return arr;
}
//2. Print Low, Return High
function printLow_returnHigh(arr){
    var high = arr[0];
    var low = arr[0];

    for(let i = 1; i < arr.length; i++){
        if(high < arr[i]) high = arr[i];
        if(low > arr[i]) low = arr[i];
    }
    console.log("Low", low);
    return high;
}
//3. Print One, Return Another
function print2ndLast_return1stOdd(arr){
    console.log(arr[arr.length - 2]);
    for(let i = 0; i < arr.length; i++){
        if(arr[i]%2 == 1) return arr[i];
    }
}
//4. Double Vision
function doubleVision(arr){
    for(let i = 0; i <arr.length; i++){
        arr[i] *= 2;
    }
    return arr;
}
//5. Count Positives
function countPositives(arr){
    var count = 0;
    for(var i = 0; i < arr.length; i++){
        if(arr[i] > 0) count++;
        if(i == arr.length-1) arr[i] = count;
    }
    return arr;
}
//6. Evens and Odds
function evens_odds(arr){
    var odds = 0;
    var evens = 0;
    for(var i = 0; i < arr.length; i++){
        if(arr[i]%2 == 1){
            odds++; evens = 0;
            if(odds == 3){
                console.log("That's an odd!");
                odds = 0;
            }
        }
        else if(arr[i]%2 == 0){
            evens++; odds = 0;
            if(evens == 3){
                console.log("Even more so!");
                evens = 0;
            }
        }
    }
}
//7. Increment the Seconds
function incrementSeconds(arr){
    for(var i = 1; i < arr.length; i+=2){
        arr[i] += 1;
    }
    console.log(arr);
    return arr;
}
//8. Previous Lengths
function previousLengths(arr){
    for(var i = arr.length-1; i > 0; i--){
        arr[i] = arr[i-1].length;
    }
    return arr;
}
//9. Add Seven
function addSeven(arr){
    var newArr = [];
    for(var i = 0; i < arr.length; i++){
        newArr[i] = arr[i] + 7;
    }
    return newArr;
}
//10. Reverese Array
function reverse(arr){
    var temp;
    for(var i = 0; i < arr.length/2; i++){
        temp = arr[i];
        arr[i] = arr[arr.length-1-i];
        arr[arr.length-1-i] = temp;
    }
    return arr;
}
//11. Outlook: Negative
function negativeArr(arr){
    var newArr = [];
    for(var i = 0; i < arr.length; i++){
        if(arr[i] > 0) newArr[i] = arr[i] * (-1);
        else newArr[i] = arr[i];
    }
    return newArr;
}
//12. Always Hungry
function alwaysHungry(arr){
    var gotFood = false;
    for(var i = 0; i < arr.length; i++){
        if(arr[i] == "food") {
            console.log("yummy");
            gotFood = true;
        }
    }
    if(gotFood == false) console.log("I'm hungry");
}
//13. Swap Toward Center
function swapTowardCenter(arr){
    var temp;
    for(var i = 0 ; i < arr.length/2; i+=2){
        temp = arr[i];
        arr[i] = arr[arr.length-1-i];
        arr[arr.length-1-i] = temp;
    }
    return arr;
}
//14. Scale the Array 
function scaleArr(arr, num){
    for(var i = 0; i < arr.length; i++)
        arr[i] *= num;
    return arr;
}