class product
{
    id:number;
    proname:string;
    proprice:number;
    readonly qty:number;

    constructor(id:number,proname:string,proprice:number,quantity:number)
    {
        this.id=id;
        this.proname=proname;
        this.proprice=proprice;
        this.qty=quantity;
    }

    Display()
    {
        return `$(this.id) $(this.proname) $(this.proprice)`;
    }
}
let produ = new product(123,'iphone',90000,1);
console.log(produ);

//compile error - readonly property cannot be reinitialized
//produ.qty=2; 

