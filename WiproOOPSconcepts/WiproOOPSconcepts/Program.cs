using System.Transactions;

namespace WiproOOPSconcepts;

class Program
{
    static void Main(string[] args)
    {
        Employee emp = new Employee();
        //emp.EmpName = "AAA";
        //emp.Empid = 001;

        //emp.Display();

        Department dpt = new Department(); //creating instance for derived class
                                           //dpt.DeptName = "developer";
                                           //dpt.Deptno = 245;
                                           //dpt.salary = 50000;

        //dpt.Display();
        //dpt.show()


        //Manager mgr = new Manager();
        //mgr.EmpName = "BBB";
        //mgr.Empid = 123;
        //mgr.DeptName = "web";
        //mgr.Deptno = 004;
        //mgr.salary = 78000;
        //mgr.ManagerName = "Rahul";

        //mgr.Display();
       
        int id = Convert.ToInt32 (Console.ReadLine());
        string name = Console.ReadLine ();
        string dname = Console.ReadLine ();
        int dno = Convert.ToInt32 (Console.ReadLine ());
        decimal sal = Convert.ToDecimal (Console.ReadLine ());
        string mname = Console.ReadLine ();
        Manager mgrcon = new Manager(id,name,dname,dno,sal,mname);
        mgrcon.Display();

        

    }
}