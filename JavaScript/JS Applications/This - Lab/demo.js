const x = 42;

const getX = function () 
{
    return this.x;
}

const mod = {x , getX };

const unboundGetX = mod.getX;
console.log(unboundGetX()); // undefined
const boundGetX = unboundGetX.bind(mod);
console.log(boundGetX()); // 42
var mod1 = {x: 54}
console.log(boundGetX.call(mod1));
var boundF = unboundGetX.bind(mod1);
console.log(boundF());