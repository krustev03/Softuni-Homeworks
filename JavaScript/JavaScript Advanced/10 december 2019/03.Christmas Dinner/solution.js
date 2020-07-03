class ChristmasDinner 
{
    constructor(budget)
    {
        if(budget < 0)
        {
            throw new Error("The budget cannot be a negative number");
        }

        this.budget = budget;
        this.dishes = [];
        this.products = [];
        this.guests = {};
    }
    
    shopping(product) 
    {
        var type = product[0];
        var price = Number(product[1]);

        if(this.budget < price) 
        {
            throw new Error("Not enough money to buy this product");
        }
        else 
        {
            this.products.push(type);
            this.budget -= price;
            return `You have successfully bought ${type}!`;
        }
    }

    recipes(recipe) 
    {
        var recipeName = recipe.recipeName;
        var productsList = recipe.productsList;
        var missingProducts = productsList.filter(product => !this.products.includes(product));

        if(missingProducts.length === 0) 
        {
            let obj = 
            {
                recipeName,
                productsList
            }
            this.dishes.push(obj);
            return `${recipeName} has been successfully cooked!`;
        }
        else 
        {
            throw new Error("We do not have this product");
        }
    }

    inviteGuests(name, dish) 
    {
        if(!this.dishes.find(obj => obj.recipeName === dish)) 
        {
            throw new Error("We do not have this dish");
        }
        else if(this.guests.hasOwnProperty(name)) 
        {
            throw new Error("This guest has already been invited");
        }
        else 
        {
            this.guests[`${name}`] = dish;
            return `You have successfully invited ${name}!`;
        }
    }

    showAttendance() 
    {
        var names = Object.keys(this.guests);
        let result = [];
        for(let name of names) 
        {
            var dish = this.guests[name];
            var products = this.dishes.find(obj => obj.recipeName === dish);
            result.push(`${name} will eat ${dish}, which consists of ${products.productsList.join(', ')}`);
        }
        return result.join('\n');
    }
}