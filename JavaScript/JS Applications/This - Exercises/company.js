class Company 
{
    constructor() 
    {
        this.departments = [];
        this.realDepartments = {};
    }

    addEmployee(username, salary, position, department) 
    {
        if(!username || !salary || !position || !department) 
        {
            throw new Error('Invalid input!');
        }
        if(salary < 0) 
        {
            throw new Error('Invalid input!');
        }
        if(!this.realDepartments[department]) 
        {
            this.realDepartments[department] = 
            [{
                username,
                salary,
                position
            }]
        }
        else 
        {
            this.realDepartments[department].push(
                {
                    username, 
                    salary,
                    position
                })
        }
       
        return `New employee is hired. Name: ${username}. Position: ${position}`;
    }

    bestDepartment() 
    {
        let highestAvgSalaryDepartment = Object.keys(this.realDepartments)
        .sort((a, b) => 
        {
            let avgADepartment = this.realDepartments[a].reduce((acc, e) => acc + Number(e.salary), 0) / this.realDepartments[a].length;
            let avgBDepartment = this.realDepartments[b].reduce((acc, e) => acc + Number(e.salary), 0) / this.realDepartments[b].length;

            return avgBDepartment - avgADepartment;
        })[0];

        var highestAvgSalary = this.realDepartments[highestAvgSalaryDepartment].reduce((acc, e) => 
        acc + Number(e.salary), 0) / this.realDepartments[highestAvgSalaryDepartment].length;

        var result = '';
        result += `Best Department is: ${highestAvgSalaryDepartment}\n`;
        result += `Average salary: ${highestAvgSalary.toFixed(2)}\n`;
        result += this.realDepartments[highestAvgSalaryDepartment].sort((a, b) => 
        {
            return b.salary - a.salary || a.username.localeCompare(b.username);
        })
        .map(element => 
        {
            return `${element.username} ${element.salary} ${element.position}`;
        }).join('\n');

        return result;
    }
}

let c = new Company();
c.addEmployee("Stanimir", 2000, "engineer", "Construction");
c.addEmployee("Pesho", 1500, "electrical engineer", "Construction");
c.addEmployee("Slavi", 500, "dyer", "Construction");
c.addEmployee("Stan", 2000, "architect", "Construction");
c.addEmployee("Stanimir", 1200, "digital marketing manager", "Marketing");
c.addEmployee("Pesho", 1000, "graphical designer", "Marketing");
c.addEmployee("Gosho", 1350, "HR", "Human resources");
console.log(c.bestDepartment());
