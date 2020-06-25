function sumFirstLast(arr) {
    let result = Number(arr[0]) + Number(arr[arr.length - 1]);
    console.log(result);
}

function evenNums(arr) {
    let result = '';
    for (let i = 0; i < arr.length; i++) {
        if(i % 2 == 0) {
            result += arr[i] + ' ';
        }
    }

    console.log(result);
}

function negativePositiveNumbers(arr) {
    for (let i = arr.length - 1; i >= 0; i--) {
        if (arr[i] < 0) {
            console.log(arr[i]);
        }
    }
    
    for (let i = 0; i < arr.length; i++) {
        if (arr[i] >= 0) {
            console.log(arr[i]);
        }
    }
}

function lastKNumberSequence(n, k) {
    let arr = [];
    arr[0] = 1;

    for (let indexInSeq = 1; indexInSeq < n; indexInSeq++){
        let result = 0;
        for (let prevIndexOfSeq = indexInSeq - 1; prevIndexOfSeq >= 0 && prevIndexOfSeq >= indexInSeq - k; prevIndexOfSeq--) {
            result = result + arr[prevIndexOfSeq];
        }
        arr[indexInSeq] = result;
    }
    let str = '';

    for (let i = 0; i < arr.length; i++) {
        str += `${arr[i]} `; 
    }

    console.log(str);
}

function processOddNumbers(arr) {
    let nums = [];
    for (let i = 0; i < arr.length; i++) {
        if(i % 2 == 1) {
            nums.push(arr[i] * 2);
        }
    }

    nums = nums.reverse();
    let result = '';    
    for (let i = 0; i < nums.length; i++) {
        result += `${nums[i]} `;
    }

    console.log(result);
}

function smallestTwo(arr) {
    arr.sort((a, b) => a-b);
    let result = arr.slice(0, 2);
    return result.join(' ');
}

function biggestElement(arr) {
    let max = Number.MIN_SAFE_INTEGER;
    arr.forEach(printRow);

    function printRow(row){
    row.forEach(printNumber);
    }

    function printNumber(num){
        if(num > max) {
            max = num;
        }
    };
    
    console.log(max);
} 

function diagonalSums(input) {
    let firstDiagonal = 0;
    let secondDiagonal = 0;
    let firstIndex = 0;
    let secondIndex = input[0].length - 1;
    
    input.forEach(array => {
    firstDiagonal += array[firstIndex++];
    secondDiagonal += array[secondIndex--];
    });
    
    console.log(firstDiagonal + ' ' + secondDiagonal);
}

function equalNeighbors(arr) {
    
}