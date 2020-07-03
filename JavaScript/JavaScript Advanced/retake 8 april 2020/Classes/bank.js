class Bank 
{
    constructor(bankName) 
    {
        this._bankName = bankName;
        this.allCustomers = [];
    }

    newCustomer(customer) 
    {
        if(this.allCustomers.find(obj => obj.personalId === customer.personalId)) 
        {
            throw new Error(`${customer.firstName} ${customer.lastName} is already our customer!`);
        }
        else 
        {
            this.allCustomers.push(customer);
            return customer;
        }
    }

    depositMoney(personalId, amount) 
    {
        if(!this.allCustomers.find(obj => obj.personalId === personalId)) 
        {
            throw new Error('We have no customer with this ID!');
        }
        else 
        {
            let customer = this.allCustomers.find(obj => obj.personalId === personalId);
            if(!customer.hasOwnProperty('totalMoney')) 
            {
                customer.totalMoney = 0;
            }
            customer.totalMoney += Number(amount);
            if(!customer.hasOwnProperty('transactions')) 
            {
                customer.transactions = [];
            }
            customer.transactions.push(`${customer.firstName} ${customer.lastName} made deposit of ${amount}$!`);
            return `${customer.totalMoney}$`;
        }
    }

    withdrawMoney(personalId, amount) 
    {
        if(!this.allCustomers.find(obj => obj.personalId === personalId)) 
        {
            throw new Error('We have no customer with this ID!');
        }
        else 
        {
            let customer = this.allCustomers.find(obj => obj.personalId === personalId);
            if(!customer.hasOwnProperty('totalMoney')) 
            {
                customer.totalMoney = 0;
            }
            if (customer.totalMoney >= amount) 
            {
                customer.totalMoney -= amount;
                if (!customer.hasOwnProperty('transactions')) 
                {
                    customer.transactions = [];
                }
                customer.transactions.push(`${customer.firstName} ${customer.lastName} withdrew ${amount}$!`);
                return `${customer.totalMoney}$`;
            }
            else 
            {
                throw new Error(`${customer.firstName} ${customer.lastName} does not have enough money to withdraw that amount!`);
            }
        }
    }

    customerInfo(personalId) 
    {
        if(!this.allCustomers.find(obj => obj.personalId === personalId)) 
        {
            throw new Error('We have no customer with this ID!');
        }
        else 
        {
            var result = "";
            var customer = this.allCustomers.find(obj => obj.personalId === personalId);
            var bank = this._bankName;
            result += `Bank name: ${this._bankName}\n`;
            result += `Customer name: ${customer.firstName} ${customer.lastName}\n`;
            result += `Customer ID: ${personalId}\n`;
            if(!customer.hasOwnProperty('totalMoney')) 
            {
                customer.totalMoney = 0;
            }
            result += `Total Money: ${customer.totalMoney}$\n`;
            result += `Transactions:\n`;
            if(customer.hasOwnProperty('transactions')) 
            {
                for (let i = customer.transactions.length - 1; i > -1; i--) 
                {
                    if(i == 0) 
                    {
                        result += `${i + 1}. ${customer.transactions[i]}`;
                    }
                    else 
                    {
                        result += `${i + 1}. ${customer.transactions[i]}\n`;
                    }
                }
            }
            
            return result;
        }
    }
}

let bank = new Bank('SoftUni Bank');

console.log(bank.newCustomer({firstName: 'Svetlin', lastName: 'Nakov', personalId: 6233267}));
console.log(bank.newCustomer({firstName: 'Mihaela', lastName: 'Mileva', personalId: 4151596}));

bank.depositMoney(6233267, 250);
console.log(bank.depositMoney(6233267, 250));
bank.depositMoney(4151596,555);

console.log(bank.withdrawMoney(6233267, 125));
console.log(bank.customerInfo(6233267));
