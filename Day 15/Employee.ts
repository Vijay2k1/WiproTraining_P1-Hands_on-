interface Employee{
    id?:number,//optional
    name:string,
    dept:string
}

function getEmployee(emp:Employee)
{
    return `${emp.id} ${emp.name} ${emp.dept}`
}

let emp1 = {
    id:111,
    name:'AAA',
    dept:'HR'
}
console.log(getEmployee(emp1))

//object destructuring

function getEmployeeobjdestruc({name,dept}:Employee)
{
    return `${name} ${dept}`
}

let emp2 = {
    name:'Anu',
    dept:'HR'
}

console.log(getEmployeeobjdestruc(emp2));