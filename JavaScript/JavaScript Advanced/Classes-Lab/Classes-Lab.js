class Rectangle {
    constructor(width, height, color) {
        this.width = width;
        this.height = height;
        this.color = color;
    }

    calcArea() {
        return this.width * this.height;
    }
}

function getPersons() {

    class Person {
        constructor(fName, lName, age, email) {
            this.firstName = fName;
            this.lastName = lName;
            this.age = age;
            this.email = email;
        }
    
        toString() {
            return `${this.firstName} ${this.lastName} (age: ${this.age}, email: ${this.email})`;
        }
    }

    return [new Person('Anna', 'Simpson', 22, 'anna@yahoo.com'),
        new Person('SoftUni'),
        new Person('Stephan', 'Johnson', 25),
        new Person('Gabriel', 'Peterson', 24, 'g.p@gmail.com')];
}

class Point {
    constructor(x, y) {
        this.x = x;
        this.y = y;
    }

    static distance(p1, p2) {
        let dx = p1.x - p2.x;
        let dy = p1.y - p2.y;

        return Math.sqrt(Math.pow(dx, 2) + Math.pow(dy, 2));
    }
}

class Circle {
    constructor(radius) {
        this.radius = radius;
    }

    get diameter() {
        return this.radius * 2;
    }

    set diameter(diameter) {
        this.radius = diameter / 2;
    }

    get area() {
        return this.radius * this.radius * Math.PI;
    }
}

(function(){
    const faces = ['2', '3', '4', '5', '6', '7', '8', '9', '10', 'J', 'Q', 'K', 'A'];
    const Suits = {
        SPADES: '♠',
        HEARTS: '♥',
        DIAMONDS: '♦',
        CLUBS: '♣'
    };

    class Card {
        constructor(face, suit) {
            this.face = face;
            this.suit = suit;
        }

        get face() {
            return this.innerFace;
        }

        get suit() {
            return this.innerSuit;
        }

        set face(f) {
            if(faces.includes(f.toString())) {
                this.innerFace = f;
            }
            else {
                throw new Error('No such face');
            }
        }

        set suit(s) {
            if(Object.values(Suits).includes(s)) {
                this.innerSuit = s;
            }
            else {
                throw new Error('No such suit');
            }
        }
    }

    return {
        Suits:Suits,
        Card:Card
    }
}())