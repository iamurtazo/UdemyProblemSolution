class Program
{
    static void Main(string[] args)
    {
        //problem 2
        Console.WriteLine("Enter your name: ");
        var userName = Console.ReadLine();
        var result = Solution.ReverseString(userName);
        Console.WriteLine($"Result: {result}");   
    }
}