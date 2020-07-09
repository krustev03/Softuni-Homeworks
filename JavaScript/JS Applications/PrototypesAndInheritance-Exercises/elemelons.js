function solution() 
{
    class Melon 
    {
        constructor(weight, melonSort) 
        {
            if (new.target === Melon) 
            {
                throw new TypeError("Abstract class cannot be instantiated directly");
            }
    
            this.weight = weight;
            this.melonSort = melonSort;
        }
    }

    class Watermelon extends Melon 
    {
        constructor(weight, melonSort) 
        {
            super(weight, melonSort);
            this.element = "Water";
        }

        get elementIndex() 
        {
            return this.weight * this.melonSort.length;
        }

        toString() 
        {
            let result = `Element: ${this.element}\n`;
            result += `Sort: ${this.melonSort}\n`;
            result += `Element Index: ${this.elementIndex}`;
            return result;
        }
    }

    class Firemelon extends Melon 
    {
        constructor(weight, melonSort) 
        {
            super(weight, melonSort);
            this.element = "Fire";
        }

        get elementIndex() 
        {
            return this.weight * this.melonSort.length;
        }

        toString() 
        {
            let result = `Element: ${this.element}\n`;
            result += `Sort: ${this.melonSort}\n`;
            result += `Element Index: ${this.elementIndex}`;
            return result;
        }
    }

    class Earthmelon extends Melon 
    {
        constructor(weight, melonSort) 
        {
            super(weight, melonSort);
            this.element = "Earth";
        }

        get elementIndex() 
        {
            return this.weight * this.melonSort.length;
        }

        toString() 
        {
            let result = `Element: ${this.element}\n`;
            result += `Sort: ${this.melonSort}\n`;
            result += `Element Index: ${this.elementIndex}`;
            return result;
        }
    }

    class Airmelon extends Melon 
    {
        constructor(weight, melonSort) 
        {
            super(weight, melonSort);
            this.element = "Air";
        }

        get elementIndex() 
        {
            return this.weight * this.melonSort.length;
        }

        toString() 
        {
            let result = `Element: ${this.element}\n`;
            result += `Sort: ${this.melonSort}\n`;
            result += `Element Index: ${this.elementIndex}`;
            return result;
        }
    }

    class Melolemonmelon extends Watermelon
    {
        constructor(weight, melonSort)
        {
            super(weight, melonSort);
        }

        morph()
        {
            if(this.element == "Water")
            {
                this.element = "Fire";
            } 
            else if (this.element == "Fire")
            {
                this.element = "Earth";
            } 
            else if(this.element == "Earth")
            {
                this.element = "Air";
            } 
            else 
            {
                this.element = "Water";
            }
        }
    }
    
    return {Melon, Watermelon, Firemelon, Earthmelon, Airmelon, Melolemonmelon};
}