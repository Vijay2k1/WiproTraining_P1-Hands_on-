using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {
        string userinput = Console.ReadLine();
        Console.WriteLine(userinput);
        Console.WriteLine("enter the string to append");
        string appendedstr = Console.ReadLine();
        userinput += appendedstr;
        Console.WriteLine(userinput);

        Console.WriteLine("enter the string for stringbuilder");
        string strsb = Console.ReadLine();
        Console.WriteLine("enter the string to string builder");
        StringBuilder sb = new StringBuilder(Console.ReadLine());
        strsb += sb;
        Console.WriteLine(strsb);
    }
}