function solve() 
{
    class Figure 
    {
        constructor() 
        {
            this.units = 'cm';
        }

        changeUnits(unit) 
        {
            this.units = unit;
        }

        get area() 
        {
            return undefined;
        }
    }

    class Circle extends Figure
    {
        constructor(radius) 
        {
            super();
            this.radius = radius;
        }

        get area() 
        {
            return Math.PI * this.radius * this.radius;
        }

        toString() 
        {
            return `Figures units: ${this.units} Area: ${this.area} - radius: ${this.radius}`;
        }
    }

    class Rectangle extends Figure
    {
        constructor(width, height) 
        {
            super();
            this.width = width;
            this.height = height;
        }

        get area() 
        {
            return this.width * this.height;
        }

        toString() 
        {
            return `Figures units: ${this.units} Area: ${this.area} - width: ${this.width}, height: ${this.height}`;
        }
    }
}
