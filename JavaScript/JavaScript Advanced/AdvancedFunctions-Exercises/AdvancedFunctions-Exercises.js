function sortArray(array, method) {
    let ascendingComparator = (a, b) => a-b;
    let descendingComparator = (a, b) => b-a;

    let sortingStrategies = {
        asc: ascendingComparator,
        desc: descendingComparator
    };

    return array.sort(sortingStrategies[method]);
}
  
function argumentInfo() {
    let typeCounts = {};
    for(let arg of arguments){
        console.log(`${typeof(arg)}: ${arg}`);
        if(! typeCounts[typeof(arg)]){
            typeCounts[typeof(arg)] = 1;
        } else {
            typeCounts[typeof(arg)]++;
        }
    }

    Object.keys(typeCounts).sort((a, b) => typeCounts[b] - typeCounts[a]).forEach(k => console.log(`${k} = ${typeCounts[k]}`))
}

function personalBMI(name, age, weight, height) {
    let obj = {
        name: name,
        personalInfo: {
            age: age,
            weight: weight,
            height: height
        },
        BMI: Math.round(weight /(height * height / 10000))
    };

    obj.status = obj.BMI < 18.5 ? "underweight" : obj.BMI < 25 ? "normal" : obj.BMI < 30 ? "overweight" : "obese";

    if(obj.status == "obese"){
        obj.recommendation = "admission required";
    }

    return obj;
}

(() => {
    let add = (vec1, vec2) => [vec1[0]+vec2[0], vec1[1]+vec2[1]];
    let multiply = (vec1, scalar) => [vec1[0] * scalar, vec1[1] * scalar];
    let length = (vec1) => Math.sqrt(Math.pow(vec1[0], 2) + Math.pow(vec1[1], 2));
    let dot = (vec1, vec2) => vec1[0] * vec2[0] + vec1[1] * vec2[1];
    let cross = (vec1, vec2) => vec1[0] * vec2[1] - vec1[1] * vec2[0];

    return {add, multiply, length, dot, cross};
})();

(function functionalSum() {
    let sum = 0;

    function add(num) {
        sum += num;
        return add;
    }

    add.toString = () => sum;
    return add;
}());

function monkeyPatcher(action) {
    let that = this;
    let obj = (() => {
        function upvote() { that.upvotes++}
        function  downvote() {that.downvotes++}
        function score() {
            let obfuscated = that.upvotes + that.downvotes > 50;
            let votesToAdd = Math.ceil(0.25 * Math.max(that.upvotes, that.downvotes));
            let rating;
            if(that.upvotes/(that.upvotes+that.downvotes) > 0.66){
                rating = "hot";
            } else if((that.upvotes > 100 || that.downvotes > 100) && that.upvotes >= that.downvotes){
                rating = "controversial";
            } else if(that.downvotes > that.upvotes){
                rating = "unpopular";
            } else {
                rating = "new";
            }

            if(that.upvotes + that.downvotes < 10){
                rating = "new";
            }

            if(obfuscated){
                return [that.upvotes + votesToAdd, that.downvotes + votesToAdd, that.upvotes - that.downvotes, rating];
            } else {
                return [that.upvotes, that.downvotes, that.upvotes - that.downvotes, rating];
            }
        }
        return {upvote, downvote, score};
    })();

    return obj[action]();
}