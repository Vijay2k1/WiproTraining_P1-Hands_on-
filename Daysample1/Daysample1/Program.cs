internal class Program
{
    private static void Main(string[] args)
    {
        //Console.WriteLine("Enter the training name:");
        //string name = Console.ReadLine();
        ////Console.Write("the training name is:"+name);
        //Console.WriteLine("Enter the name of the orginazation name:");
        //string orgname = Console.ReadLine();
        ////Console.WriteLine("the orgz name is:" + orgname);
        ////Console.WriteLine("the training name is" + name + "and the orgz is:" + orgname);
        //Console.WriteLine("enter the number of tr_days");
        //int tr_days =Convert.ToInt32( Console.ReadLine());
        //Console.WriteLine($"training is from:{name} \n orz is {orgname} \n and number of days are:{tr_days}");
        int? a = 100;
        int b = a ?? 10;
        Console.WriteLine("Value of a :"+a+"value of b:"+b);

    }
}



