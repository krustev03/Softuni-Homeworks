function extendClass(className) 
{
    className.prototype.species = "Human";
    className.prototype.toSpeciesString = function () 
    {
        return `I am a ${this.species}. ${this.toString()}`;
    }
}