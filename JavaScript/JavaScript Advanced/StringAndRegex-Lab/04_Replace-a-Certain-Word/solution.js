function solve(word, arr) {
    word = document.getElementById('word').value;
    arr = document.getElementById('text').value;
    let arrStr = JSON.parse(arr);
    let searchedWords = arrStr[0].toString().split(' ');
    let wordToBeReplaced = searchedWords[2].toLowerCase();
    let regex = new RegExp(wordToBeReplaced, "gi");
    for (let i = 0; i < arrStr.length; i++) {
        if(regex.test(arrStr[i])) {
            arrStr[i] = arrStr[i].replace(regex, word);
            let p = document.createElement('p');
            p.value = "ui";
            let result = document.getElementById('result');
            result.appendChild(p);
        }
    }
}
