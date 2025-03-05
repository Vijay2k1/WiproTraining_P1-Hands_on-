
function sum(a:number, b:number):number
{
    return a+b;
}
let res=sum(10,20);
console.log(res);

//Inferring function type

let result = function(a:number,b:number):number
{
    return a+b;
}
let sumval = result(10,25);
console.log(sumval);

// optional parameter & default

function prod(x:number=10,y?:number):number
{
    if(typeof y!=='undefined')
    {
        return x*y;
    }
    return x*x;

}
console.log(prod(40,50));
console.log(prod(10));
console.log(prod());

//rest parameter - 0 to more arguments

function getsumofall(...number:number[]):number
{
    let tot = 0;
    number.forEach((num) => tot+=num);
    return tot;
        
}

console.log(getsumofall(10,40,60,70,70,80));
console.log(getsumofall(20,40));
console.log(getsumofall());
