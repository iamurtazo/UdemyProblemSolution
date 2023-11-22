public class Solution
{
    public static void DisplayNumbers(string numbers)
    {
        var splittedNumbers = numbers.Split(", ");
        var intNum = splittedNumbers.Select(x => int.Parse(x)).ToArray();

        Array.Sort(intNum);

        if (intNum.Length <= 3)
            Console.WriteLine("Invalid input");
        else
            {
                for(var i = 0; i < 3; i++)
                    Console.Write(intNum[i] + " ");
            }
        Console.WriteLine();
    }
}