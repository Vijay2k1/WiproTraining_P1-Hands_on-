using wiproday4;


internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Enter the type of Employee 1.Pernment 2.Temporary");
        string? type = Console.ReadLine();

        if (type.ToLower().Contains("per"))
        {
            PermanentEmployee employee = new PermanentEmployee() { empid = 111, empname = "AAA", salary = 70000 };
            employee.BasicDetails();
            employee.SalaryDetails();
            employee.AttendMeeting();
        }
        else if (type.ToLower().Contains("temp"))
        {
            IEmployee tmp = new TemporaryEmployee() { empid = 222, empname = "BBB", salaryperday = 8000 };
            tmp.BasicDetails();
            tmp.SalaryDetails();
          
            
            
        }
    }
}