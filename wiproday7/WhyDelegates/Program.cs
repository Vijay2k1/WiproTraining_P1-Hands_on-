﻿using WhyDelegatesDemo;

namespace WhyDelegatesDemo
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>()
            {
            new Employee(){Empid = 1,Name="Lekha",experienceinyears=2,salary=50000 },
             new Employee(){Empid = 2,Name="Reena",experienceinyears=6,salary=80000 },
              new Employee(){Empid = 3,Name="Lucky",experienceinyears=5,salary=50000 },
               new Employee(){Empid = 4,Name="Madhav",experienceinyears=7,salary=80000 },
                new Employee(){Empid = 5,Name="Lokesh",experienceinyears=3,salary=50000 },
                 new Employee(){Empid = 6,Name="SriRam",experienceinyears=8,salary=90000 }
             };
            DelPromote delpromote = new DelPromote(IsPromote);//created instance for delegate ,set the target method

            Employee.PromoteEMployee(employees, delpromote);//calling the method Promote Employee
        }

        static bool IsPromote(Employee emp)
        {
            if (emp.salary > 70000)
            {
                return true;
            }
            return false;
        }
    }
}