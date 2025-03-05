using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wiproday4
{
    internal interface IEmployee
    {
        void BasicDetails();
        void SalaryDetails();
    }
    //Interface segregation principal
    interface IMeeting
    {
        void AttendMeetings();
    }
    class PermanentEmployee : IEmployee, IMeeting //Multiple Inheritance
    {
        public int empid { get; set; }
        public string? empname { get; set; }
        public decimal salary { get; set; }

        public static string OrgName = "wipro"; //shared among all instance of the class

        public void AttendMeeting()
        {
            Console.WriteLine("attend meetings");
        }

        public void BasicDetails()
        {
            Console.WriteLine(empid + " " + empname + " " + OrgName);
        }

        public void SalaryDetails()
        {
            Console.WriteLine(salary);
        }

        public void AttendMeetings()
        {
            Console.WriteLine("Attend Meetings");
        }
    }
    class TemporaryEmployee : IEmployee
    {
        public int empid { get; set; }
        public string? empname { get; set; }
        public decimal salaryperday { get; set; }
        public void BasicDetails()
        {
            Console.WriteLine(empid + " " + empname);
        }
        public void SalaryDetails()
        {
            Console.WriteLine(salaryperday);
        }
    }


}
