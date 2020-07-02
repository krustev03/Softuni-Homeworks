function solve(input, currectCase) {
    input = document.getElementById('text').value;
    currentCase = document.getElementById('naming-convention').value;
    let words = input.toLowerCase().split(' ').filter(a => a !== '');
    let output = "";

    if(currentCase === "Pascal Case") {
        for(let word of words) {
            if(word[0] !== word[0].toUpperCase()) {
                word = word.replace(word[0], word[0].toUpperCase());
            }
            output += word;
        }
    }
    else if(currentCase === "Camel Case") {
        for(let word of words) {
            if(word[0] !== word[0].toUpperCase()) {
                word = word.replace(word[0], word[0].toUpperCase());
            }
            output += word;
        }
        output = output.replace(output[0], output[0].toLowerCase());
    }
    else {
        output = "Error!";
    }
    document.getElementById("result").textContent = output;
}