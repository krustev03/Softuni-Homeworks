// class Person
// {
//     constructor(fn, ln) 
//     {
//         this.firstName = fn;
//         this.lastName = ln;
//         this.fullName = fn + ' ' + ln;
//     }

//     set(firstName) 
//     {
//         this.firstName = firstName;
//     }

//     set(lastName) 
//     {
//         this.lastName = lastName;
//     }

//     set(fullName) 
//     {
//         fullName = this.firstName + this.lastName;
//         this.fullName = fullName;
//     }
// }

function Person(first, last) 
{
    this.firstName = first;
    this.lastName = last;
    Object.defineProperty(this, "fullName", 
    {
    
        set: function(value) 
        {
            var regex = /^[a-zA-Z]{1,}\s[a-zA-Z]{1,}/;
            if(regex.test(value)) 
            {
                var parts = value.split(' ');
                this.firstName = parts[0];
                this.lastName = parts[1];
            }
        },
    
        get: function() 
        {
            return this.firstName + " " + this.lastName;
        }
    }
    );    
}

let person = new Person("Peter", "Ivanov");
console.log(person.fullName);//Peter Ivanov
person.firstName = "George";
console.log(person.fullName);//George Ivanov
person.lastName = "Peterson";
console.log(person.fullName);//George Peterson
person.fullName = "Nikola Tesla";
console.log(person.firstName)//Nikola
console.log(person.lastName)//Tesla

