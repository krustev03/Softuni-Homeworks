function solve() {
	let str = document.getElementById('input').value;

	//Find sum 
	let sum = 0;
    for (let i = 0; i < str.length; i++) {
		sum += Number(str.charAt(i))
	}

    //Find how many chars to cut
	let sumAsStr = sum.toString();
	let charsToCut = 0;
	do 
	{
        for (let i = 0; i < sumAsStr.length; i++) {
			charsToCut += Number(sumAsStr.charAt(i));
		}
		if (charsToCut > 9) {
			sumAsStr = charsToCut.toString();
			charsToCut = 0;
		}
		else {
            sumAsStr = charsToCut.toString();
		}
	}
	while(Number(sumAsStr) > 9);

    //Remove chars from original string
	let parsedString = str.slice(charsToCut, -charsToCut);
	

	// Split into groups
	let groups = parsedString.match(/.{1,8}/g);

	//Convert binary to decimal
	let decimalNums = [];
	for (let i = 0; i < groups.length; i++) {
		decimalNums[i] = parseInt(groups[i], 2);
	}
	
	//Convert decimal to ASCII
	let ascii = [];
	let regex = /[a-zA-Z\s]/;
	for (let i = 0; i < decimalNums.length; i++) {
		if(regex.test(String.fromCharCode(decimalNums[i]))) {
            ascii[i] = String.fromCharCode(decimalNums[i]);
		}
	}
	
	//Print message
	let message = ascii.join('');
	let parent = document.getElementById('resultOutput');
	parent.innerHTML = message;
}