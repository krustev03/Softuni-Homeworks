function fruit(fruit, weight, moneyPerKilo) {
    let neededMoney = (weight * moneyPerKilo) / 1000;

    console.log(`I need $${neededMoney.toFixed(2)} to buy ${(weight / 1000).toFixed(2)} kilograms ${fruit}.`);
}

function gcd(x, y) {
    while(y) {
        var t = y;
        y = x % y;
        x = t;
    }

    console.log(x);
}

function sameNumbers(num) {
    let number = num.toString().split('');
    let allTrue = true;
    let sum = 0;

    for (let i = 0; i < number.length; i++) {
        if(allTrue) {
            allTrue = number[i] == number[0];
        }
        sum = sum + Number(number[i]);
    }

    console.log(allTrue);
    console.log(sum);
}

function timeToWalk(numOfSteps, lengthOfFootprints, studentSpeed) {
    let length = numOfSteps * lengthOfFootprints;

    let totalRestInMinutes = Math.floor(length / 500);

    let totalTime = length / studentSpeed / 1000 * 60;

    let totalTimeInSeconds = Math.ceil((totalRestInMinutes + totalTime) * 60);

    let result = new Date(null, null, null, null, null, totalTimeInSeconds);

    return result.toTimeString().split(' ')[0];
}

function calorieObject(elements) {
    let result = {};

    for (let i = 0; i < elements.length; i+=2) {
        result[elements[i]] = parseInt(elements[i + 1]);
    }

    return result;
}

function roadRadar(elements) {
    let speed = parseInt(elements[0]);
    let place = elements[1];

    if(place == 'residential') {
        if(speed <= 20) {
            return;
        }
        else if(speed > 20 && speed <= 40) {
            console.log('speeding');
        }
        else if(speed > 40 && speed <= 60) {
            console.log('excessive speeding');
        }
        else {
            console.log('reckless driving');
        }
    }
    else if(place == 'city') {
        if(speed <= 50) {
            return;
        }
        else if(speed > 50 && speed <= 70) {
            console.log('speeding');
        }
        else if(speed > 70 && speed <= 90) {
            console.log('excessive speeding');
        }
        else {
            console.log('reckless driving');
        }
    }
    else if(place == 'interstate') {
        if(speed <= 90) {
            return;
        }
        else if(speed > 90 && speed <= 110) {
            console.log('speeding');
        }
        else if(speed > 110 && speed <= 130) {
            console.log('excessive speeding');
        }
        else {
            console.log('reckless driving');
        }
    }
    else if(place == 'motorway') {
        if(speed <= 130) {
            return;
        }
        else if(speed > 130 && speed <= 150) {
            console.log('speeding');
        }
        else if(speed > 150 && speed <= 170) {
            console.log('excessive speeding');
        }
        else {
            console.log('reckless driving');
        }
    }
}

function cookingByNumbers(elements) {
    let num = parseInt(elements[0]);

    for (i = 1; i < elements.length; i++) {
        switch(elements[i]) {
            case 'chop': num /= 2; console.log(num); break;
            case 'dice': num = Math.sqrt(num); console.log(num); break;
            case 'spice': num++; console.log(num); break;
            case 'bake': num *= 3; console.log(num); break;
            case 'fillet': num -= num * 0.20; console.log(num); break;
        }
    }
}

function solve(arr) {
    let x1 = Number(arr[0]);
    let y1 = Number(arr[1]);
    let x2 = Number(arr[2]);
    let y2 = Number(arr[3]);
 
    function distance(x1, y1, x2, y2) {
        let distH = x1 - x2;
        let distY = y1 - y2;
        return Math.sqrt(distH**2 + distY**2);
    }
 
    if (Number.isInteger(distance(x1, y1, 0, 0))) {
        console.log(`{${x1}, ${y1}} to {0, 0} is valid`);
    } else {
        console.log(`{${x1}, ${y1}} to {0, 0} is invalid`);
    }
 
    if (Number.isInteger(distance(x2, y2, 0, 0))) {
        console.log(`{${x2}, ${y2}} to {0, 0} is valid`);
    } else {
        console.log(`{${x2}, ${y2}} to {0, 0} is invalid`);
    }
 
    if (Number.isInteger(distance(x1, y1, x2, y2))) {
        console.log(`{${x1}, ${y1}} to {${x2}, ${y2}} is valid`);
    } else {
        console.log(`{${x1}, ${y1}} to {${x2}, ${y2}} is invalid`);
    }
}