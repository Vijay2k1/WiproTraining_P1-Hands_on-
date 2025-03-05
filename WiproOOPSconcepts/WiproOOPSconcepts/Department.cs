using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WiproOOPSconcepts
{
    internal class Department : Employee // inheritance 
    {
        public string DeptName { get; set; }
        public int Deptno { get; set; }
        public decimal salary { get; set; }

        public Department(int id, string name, string dname, int dno, decimal salary) :base(id,name)
        {
            DeptName = name;
            Deptno = dno;
            salary = salary;
        }

        public override void Display()
        {
            base.Display(); //control goes to base class(Employee) display method
            Console.WriteLine(DeptName + " " + Deptno + " " + salary );
        }

    }
}
