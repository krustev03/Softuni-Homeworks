class Request {
    constructor(method, uri, version, message) {
        this.method = method;
        this.uri = uri;
        this.version = version;
        this.message = message;
        this.response = undefined;
        this.fulfilled = false;
    }
}

function sortTickets(tickets, critetia) {
    class Ticket {
        constructor(destination, price, status) {
            this.destination = destination;
            this.price = price;
            this.status = status;
        }
    }

    let unsortedArrOfTickets = [];
    for(let ticket of tickets) {
        let[destination, price, status] = ticket.split('|');
        price = Number(price);
        unsortedArrOfTickets.push(new Ticket(destination, price, status));
    }

    let sortedTickets;
    switch(critetia) {
        case "destination": 
            sortedTickets = unsortedArrOfTickets.sort((a, b) => a.destination.localeCompare(b.destination));
            break;
        case "price":
            sortedTickets = unsortedArrOfTickets.sort((a, b) => a.price - b.price);
            break;
        case "status":
            sortedTickets = unsortedArrOfTickets.sort((a, b) => a.status.localeCompare(b.status));
            break;
    }

    return sortedTickets;
}

class Rat{
    constructor(name){
        this.name = name;
        this.unitedRats = [];
    }

    unite(otherRat){
        if(otherRat instanceof Rat) {
            this.unitedRats.push(otherRat);
        }
    }

    getRats(){
        return this.unitedRats;
    }

    toString(){
        let string = `${this.name}\n`;
        for (let rat of this.unitedRats){
            string += `##${rat.name}\n`;
        }

        return string;
    }
}

class Stringer{
    constructor(string, length){
        this.innerString = string;
        this.innerLength = length;
    }

    increase(length){
        this.innerLength += length;
        if(this.innerLength < 3){
            this.innerLength = 0;
        }
    }

    decrease(length){
        this.innerLength -= length;
        if(this.innerLength < 3){
            this.innerLength = 0;
        }
    }

    toString(){
        if(this.innerLength == 0){
            return "...";
        }

        if(this.innerString.length > this.innerLength){
            this.innerString = this.innerString.substr(0, this.innerLength) + "...";
        }
        return this.innerString;
    }
}

(() => {
    let counter = 0;
    return class Extensible{
        constructor(){
            this.id = counter;
            counter++;
        }
        extend(template){
            for(let parentProp of Object.keys(template)){
                if(typeof(template[parentProp]) == "function"){
                    Object.getPrototypeOf(this)[parentProp] = template[parentProp];
                } else {
                    this[parentProp] = template[parentProp];
                }
            }
        }
    }
}
)();

class List {
    constructor() {
        this.numbers = [];
        this.size = 0;
        this.numbers.sort((a, b) => a - b);
    }

    add(num) {
        this.numbers.push(num);
        this.numbers.sort((a, b) => a - b);
        this.size++;
    }

    remove(index) {
        if(index >= 0 && index < this.numbers.length) {
            this.numbers.splice(index, 1);
            this.numbers.sort((a, b) => a - b);
            this.size--;
        }
    }

    get(index) {
        if(index >= 0 && index < this.numbers.length) {
            return this.numbers[index];
        } 
    }
}

class CheckingAccount {
    constructor(clientId,email,firstName,lastName){
        this.clientId=clientId
        this.email=email
        this.firstName=firstName
        this.lastName=lastName
    }
    set clientId(clientId){
        if(!/^\d{6}$/g.test(clientId)){
            throw new TypeError("Client ID must be a 6-digit number")
        }
        return this._clientId=clientId
        
    }
    get clientId(){
        return this._clientId()
    }
    set email(email){
        let emailPatern = /^[a-zA-Z0-9]+@[a-zA-Z.]+$/g
        if(!emailPatern.test(email)){
            throw new TypeError("Invalid e-mail")
        }
        return this._email=email
    }
    get email(){
        return this._email
    }
    set firstName(firstName){
        if(!(firstName.length>=3&&firstName.length<=20)){
            throw new TypeError("First name must be between 3 and 20 characters long")
        }
        let pattern =/[a-zA-Z]/g
        if(!pattern.test(firstName)){
            throw new TypeError("First name must contain only Latin characters")
        }
        return this._firstName=firstName
    }
    get firstname(){
        return this._firstName
    }
    set lastName(lastName){
        if(!(lastName.length>=3&&lastName.length<=20)){
            throw new TypeError("Last name must be between 3 and 20 characters long")
        }
        let pattern =/[a-zA-Z]/g
        if(!pattern.test(lastName)){
            throw new TypeError("Last name must contain only Latin characters")
        }
        return this._lastName=lastName
    }
    get lastName(){
        return this._lastName
    }
}

class Kitchen {
    constructor(budget) {
        this.budget = +budget;
        this.menu = {};
        this.productsInStock = {}
        this.actionsHistory = []
    }
    loadProducts(products) {  //["product quantity price", ...
        let messageLog = []
        for (let entry of products) {
            entry = entry.split(' ')
            //let [product, quantity, price] = entry.split(' ')
            let price = +entry.pop()
            let quantity = +entry.pop()
            let product = entry.join(' ')
            if (this.budget - price >= 0) {
                if (this.productsInStock[product]) this.productsInStock[product] += quantity
                else this.productsInStock[product] = quantity
                this.budget -= price
                messageLog.push( `Successfully loaded ${quantity} ${product}`) //test 3
            } else {
                messageLog.push(`There was not enough money to load ${quantity} ${product}`)//test 4
            }
        }
        //this.actionsHistory.push(messageLog.join('\n'))
        this.actionsHistory = [...this.actionsHistory, ...messageLog]
        return this.actionsHistory.join('\n')  //test 5 pass
       
    }
    addToMenu(meal, neededIngs, price) {  //neededIngs = ['product quantity', ...
        if (!this.menu[meal]) {
            // this.menu[meal] = [neededIngs, +price]
            this.menu[meal] = {
                products: neededIngs,
                price: +price
            }
            return `Great idea! Now with the ${meal} we have ${Object.keys(this.menu).length} meals on the menu, other ideas?` //? no effect //TEST 6 ERROR
        } else return `The ${meal} is already in our menu, try something different.` //test 7 - pass
 
    }
    showTheMenu() {
        let toPrint = []
        for (let key of Object.keys(this.menu)) {
            toPrint.push(`${key} - $ ${this.menu[key].price}`)
        }
        if (!toPrint.length) return ('Our menu is not ready yet, please come later...') //test 8 pass
        else {return toPrint.join('\n') + '\n'} // // TEST 9 ERROR
 
    }
    makeTheOrder(meal) {
        if (!this.menu[meal]) return (`There is not ${meal} yet in our menu, do you want to order something else?`)
        //check for products          
        let ingredientsNeeded = this.menu[meal].products
        for (let item of ingredientsNeeded) {  //item = 'product quantity'
            item = item.split(' ')
            let quantity = +item.pop()
            let product = item.join(' ')
            //let [product, quantity] = item.split(' ')
            if (this.productsInStock[product] < quantity || !this.productsInStock[product]) {
                return (`For the time being, we cannot complete your order (${meal}), we are very sorry...`) // test 15
            }
        }
 
        for (let item of ingredientsNeeded) {
            item = item.split(' ')
            let quantity = +item.pop()
            let product = item.join(' ')
            this.productsInStock[product] -= quantity
        } this.budget += this.menu[meal].price
        return (`Your order (${meal}) will be completed in the next 30 minutes and will cost you ${this.menu[meal].price}.`) //test 13 pass
    }
}