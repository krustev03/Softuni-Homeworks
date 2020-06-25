function printArraywithGivenDelimiter(input) {
    let arr = [];
    arr = input;
    console.log(arr.join(arr.pop()));
}

function printEveryNthElementFromAnArray(input) {
    let arr = [];
    arr = input;
    let spliter = Number(arr.pop());

    for (let i = 0; i < arr.length; i++) {
        if (i % spliter == 0) console.log(arr[i]);
    }
}

function addOrRemove(input) {
    let arr = [];
    arr = input;
    let nums = [];
    let initialNum = 1;
    for (let i = 0; i < arr.length; i++) {
        if (arr[i] == 'add') {
            nums.push(initialNum);
        }
        else if(arr[i] == 'remove' && nums.length != 0) {
            nums.pop();
        }
        initialNum++;
    }
    
    if(nums.length == 0) {
        console.log('Empty');
        return;
    }
    
    for (let i = 0; i < nums.length; i++) {
        console.log(nums[i]);
    }
}

function rotateArray(input) {
    let arr = input;
    let times = Number(arr.pop());

    for (let i = 0; i < times % input.length; i++) {
        arr.unshift(arr.pop());
    }
    let result = '';
    for (let i = 0; i < arr.length; i++) {
        result += `${arr[i]} `;
    }
    return result;
}

function extractIncreasingSubsequenceFromArray(input) {
    let arr = input;
    let nums = [];
    for (let i = 0; i < arr.length; i++) {
        if(i == 0) {
            nums.push(arr[0]);
            console.log(arr[i]);
        }
        else {
            if(arr[i] >= nums[nums.length - 1]) {
                nums.push(arr[i]);
                console.log(arr[i]);
            }
        }
    }
}

function sortArray(input) {
    let arr = input;
    arr.sort(compare);
    function compare(a, b) {
        if(a.length < b.length) {
            return -1;
        }
        else if (a.length > b.length) {
            return 1;
        }
        else {
            return a.localeCompare(b);
        }
    }

    for (let i = 0; i < arr.length; i++) {
        console.log(arr[i]);
    }
}

function magicMatrices(arr) {
    let matrix = arr;
    let sum = 0;
    matrix[0].forEach(x => sum += x);

    for (let row = 1; row < matrix.length; row++) {
        let rowSum = 0;
        matrix[row].forEach(x => rowSum += x);
        if (rowSum != sum)	return false;
    }

    for (let col = 0; col < matrix[0].length; col++) {
        let colSum = 0;
        for (let row = 0; row < matrix.length; row++)
            colSum += matrix[row][col];
        if (colSum != sum)	return false;
    }
    return true;
}

function solve(input) {
    let arr = [
        [false, false, false],
        [false, false, false],
        [false, false, false]
    ];
    let player = 'X';
 
    for (let line of input) {
        [currRow, currCol] = line.split(' ').map(Number);
 
        if (arr[currRow][currCol] !== false) {
            console.log('This place is already taken. Please choose another!');
            continue;
        }
 
        arr[currRow][currCol] = player;
 
        //check horizontal and vertical
        for (let i = 0; i < 3; i++) {
            if (
                arr[i][0] === player &&
                arr[i][1] === player &&
                arr[i][2] === player
            ) {
                console.log(`Player ${player} wins!`);
                printMatrix();
                return;
            } else if (
                arr[0][i] === player &&
                arr[1][i] === player &&
                arr[2][i] === player
            ) {
                console.log(`Player ${player} wins!`);
                printMatrix();
                return;
            }
        }
 
        //check left to right
        if (
            arr[0][0] === player &&
            arr[1][1] === player &&
            arr[2][2] === player
        ) {
            console.log(`Player ${player} wins!`);
            printMatrix();
            return;
        }
 
        //check right to left
        else if (
            arr[0][2] === player &&
            arr[1][1] === player &&
            arr[2][0] === player
        ) {
            console.log(`Player ${player} wins!`);
            printMatrix();
            return;
        }
 
        let theresFalse = false;
 
        for (let row = 0; row < arr.length; row++) {
            if (arr[row].includes(false)) {
                theresFalse = true;
            }
        }
 
        if (!theresFalse) {
            console.log('The game ended! Nobody wins :(');
            printMatrix();
            return;
        }
 
        player = player === 'X' ? 'O' : 'X';
    }
 
    function printMatrix() {
        for (let row = 0; row < arr.length; row++) {
            console.log(arr[row].join('\t'));
        }
    }
}

function diagonalsAttack(matrixRows) {
    let matrix = matrixRows.map(
        row => row.split(' ').map(Number));
 
    let sumFirstDiagonal = 0;
    for (var i = 0; i < matrix.length; i++) {
        sumFirstDiagonal = sumFirstDiagonal + matrix[i][i];
    }
    let sumSecondDiagonal = 0;
    for (var j = 0; j < matrix.length; j++) {
        sumSecondDiagonal = sumSecondDiagonal + matrix[j][matrix.length-1-j];
    }
 
    if (sumFirstDiagonal == sumSecondDiagonal){
        for (var q = 0; q < matrix.length; q++) {
            for (var z = 0; z < matrix.length; z++) {
                if( q != z && q != matrix.length-1-z)  {
                    matrix[q][z] = sumFirstDiagonal;
                }
            }
        }
        printMatrix(matrix);
    }
    else
    {
        printMatrix(matrix);
    }
 
    function printMatrix(matrix) {
        for (var i = 0; i < matrix.length; i++) {
            console.log(matrix[i].join(' '))
        }
    }
}

function orbit(input) {
    let rows = input[0];
    let cols = input[1];
    let starRow = input[2];
    let starCol = input[3];
 
    let matrix = [];
    for(let i=0; i<rows; i++) {
        matrix.push([]);
    }
 
    for(let row = 0; row< rows; row++) {
        for(let col=0; col<cols; col++) {
            matrix[row][col] = Math.max(Math.abs(row - starRow), Math.abs(col - starCol)) + 1;
        }
    }
 
    console.log(matrix.map(row => row.join(" ")).join("\n"));
}

function generateMatrix(n) {
    var total = n*n;
    var result= [];

    for(var i=0;i<n;i++) {
        var rs = [];
        for(var j=0;j<n;j++) {
            rs.push(0);
        }
        result.push(rs);
    }

    var x=0;
    var y=0;
    var step = 0;
    for(var i=0;i<total;){
        while(y+step<n){
            i++;
            result[x][y]=i;
            y++;

        }
        y--;
        x++;

        while(x+step<n){
            i++;
            result[x][y]=i;
            x++;
        }
        x--;
        y--;

        while(y>=step){
            i++;
            result[x][y]=i;
            y--;
        }
        y++;
        x--;
        step++;

        while(x>=step){
            i++;
            result[x][y]=i;
            x--;
        }
        x++;
        y++;
    }
    return result.map(row => row.join(" ")).join("\n");
}