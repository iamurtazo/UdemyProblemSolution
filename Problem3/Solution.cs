public class Solution
{
    public static void DisplayNumbers()
    {
        var numbers = new List<int>();
        var times = 5;
        while(times != 0)
        {
           Console.WriteLine("Enter a number: ");
           var input = Convert.ToInt32(Console.ReadLine());
           if(numbers.Contains(input))
            {
                Console.WriteLine("You have entered this number.");
                continue;
            }
            numbers.Add(input);
            times--;

        }

        numbers.Sort();

        Console.WriteLine("=====Result=====");
        foreach(var number in numbers)
        {
            Console.Write(number + " ");
        }
    }
}