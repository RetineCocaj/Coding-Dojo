var testArr = [6,3,5,1,2,4];

//Print Values and Sum
var sum = 0;
for(let num = 0; num < testArr.length; num++){
    sum += testArr[num];
    console.log("Num " + testArr[num] + ", Sum " + sum);
}

//Value * Position
for(let i = 0; i < testArr.length; i++){
    testArr[i] *= i;
}
console.log(testArr);