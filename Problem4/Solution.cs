public class Solution
{
    public static void DisplayNumbers()
    {
        var numbers = new List<int>();
        while(true)
        {
            Console.WriteLine("Enter a number or Quit to stop: ");
            var input = Console.ReadLine();
            if (input.ToLower() == "quit")
            {
                break;
            }
            else
            {
                var inputNumber = Convert.ToInt32(input);
                if (!numbers.Contains(inputNumber))
                {
                    numbers.Add(inputNumber);
                }
            }
        }

        foreach(var i in numbers)
            System.Console.Write(i + " ");
    }
}