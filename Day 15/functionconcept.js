function sum(a, b) {
    return a + b;
}
var res = sum(10, 20);
console.log(res);
//Inferring function type
var result = function (a, b) {
    return a + b;
};
var sumval = result(10, 25);
console.log(sumval);
// optional parameter & default
function prod(x, y) {
    if (x === void 0) { x = 10; }
    if (typeof y !== 'undefined') {
        return x * y;
    }
    return x * x;
}
console.log(prod(40, 50));
console.log(prod(10));
console.log(prod());
//rest parameter - 0 to more arguments
function getsumofall() {
    var number = [];
    for (var _i = 0; _i < arguments.length; _i++) {
        number[_i] = arguments[_i];
    }
    var tot = 0;
    number.forEach(function (num) { return tot += num; });
    return tot;
}
console.log(getsumofall(10, 40, 60, 70, 70, 80));
console.log(getsumofall(20, 40));
console.log(getsumofall());
