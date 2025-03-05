var product = /** @class */ (function () {
    function product(id, proname, proprice) {
        this.id = id;
        this.proname = proname;
        this.proprice = proprice;
    }
    product.prototype.Display = function () {
        return "$(this.id) $(this.proname) $(this.proprice)";
    };
    return product;
}());
var produ = new product(123, 'iphone', 90000);
console.log(produ);
