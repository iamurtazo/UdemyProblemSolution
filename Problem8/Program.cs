class Program
{
    static void Main(string[] args)
    {
        string? timeValue = Console.ReadLine();
        
    }
    static void IsValidTime(string timeValue)
    {
        var timeSplit = timeValue.Split(":");

        foreach(var chalk in timeSplit)
            Console.Write(chalk + " ");
        Console.WriteLine();

        var intTimeArr = timeSplit.Select(x => int.Parse(x)).ToArray();
        if(intTimeArr[0] >= 00 && intTimeArr[0] <= 23 && intTimeArr[1] >= 01 && intTimeArr[1] <= 59)
            Console.WriteLine("Valid");
        else Console.WriteLine("Not valid");
    }



}