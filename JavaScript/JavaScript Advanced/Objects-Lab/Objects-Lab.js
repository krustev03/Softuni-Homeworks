function townsToJSON(input) {
    let towns = [];
    let regex = /\s*\|\s*/;

    for(let line of input.splice(1)) {
        let tokens = line.split(regex);
        let townObj = { Town: tokens[1], Latitude: Number(tokens[2]), Longitude: Number(tokens[3])};
        towns.push(townObj);
    }

    console.log(JSON.stringify(towns));
}

function sumByTown(input) {
    let towns = {};

    for(let i=0; i<input.length; i+=2) {
        if(! towns.hasOwnProperty(input[i])) {
            towns[input[i]] = 0;
        }

        towns[input[i]] += Number(input[i+1]);
    }

    console.log(JSON.stringify(towns));
}

function countWordsInText(input) {

    let text = input.join('fuckyou');
    let regex=/[^A-Za-z0-9_]+/;  // започва със буква число или долна черта много пъти
    let words = text.split(regex).filter(w => w != ''); // премахни празните членове
    let wordsCount = {};
    for (let w of words)
        wordsCount[w] ? wordsCount[w]++ :
            wordsCount[w] = 1;
    return JSON.stringify(wordsCount);


}

function populationInTowns(input) {
    let total = new Map();
    for (let dataRow of input) {
        let [town, population] = dataRow.split(/\s*<->\s*/);
        population = Number(population);

        if (total.has(town)){
            total.set(town, total.get(town) + population);
        }
        else{
            total.set(town, population);
        }
    }
    for (let [town, sum] of total)
        console.log(town + " : " + sum);
}

function cityMarkets(input) {
    let towns = new Map();
    for (let sale of input) {// за всеки ред
        let [town, product, quantityPrice] = sale.split(/\s*->\s*/); //по -> разделяме на 3 части
        let [quantity, price] = quantityPrice.split(/\s*:\s*/);  // по две точки разделяме на две части

        let income = Number(quantity) * Number(price);

        if (!towns.has(town)) {
            towns.set(town, new Map());  // правим нов map
            towns.get(town).set(product, income)
        }
        else {
            if (!towns.get(town).has(product)) {
                towns.get(town).set(product, income);
            }
            else {
                towns.get(town).set(product, town.get(product) + income);
            }
        }
    }
    // console.log(towns);

    let print='';

    for (let [index, value] of towns){
        print+=(`Town - ${index}\n`);
        for (let [product, price] of towns.get(index)){
            print+=(`$$$${product} : ${price}\n`);
        }
    }
    return print;
}

function lowestPrices(input) {

    let products = new Map();
    let maxPrice = 0;
    let result = new Set();

    for (let obj of input){
        let [town, product, price] = obj.split(/\s+\|\s+/g);
        price = Number(price);

        if (maxPrice < price){
            maxPrice = price;
        }
        maxPrice++;

        if (!products.has(product)){
            products.set(product, new Map);
        }
        products.get(product).set(town, price);
    }

    for (let [pr, val] of products){
        let towns = products.get(pr);

        let minPrice = maxPrice;
        let town = '';
        for (let [t, p] of towns){
            if (p < minPrice){
                minPrice = p;
                town = t;
            }
        }
        result.add({product: pr, town:town, price: minPrice});
    }

    //console.log(result);
    for (let obj of result){
        console.log(`${obj.product} -> ${obj.price} (${obj.town})`);
    }

}

function extractUnique(text) {
    let uniqueWords = new Set();
    for (let sentence of text){
        let words = sentence
            .toLowerCase()
            .match(/\w+/g);

        for (let word of words){
            uniqueWords.add(word)
        }
    }
    console.log([...uniqueWords.values()].join(", "));
}