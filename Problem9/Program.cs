class Program
{
    static void Main(string[] args)
    {
        string input; 
        do
        {
            Console.WriteLine("Enter a few space-separated words: ");
            input = Console.ReadLine();
            if(!input.Contains(" "))
                Console.WriteLine("Please enter valid input!");
        } while(!input.Contains(" "));

        Console.WriteLine(PascalCaseMaker(input));
    }

    static string PascalCaseMaker(string input)
    {
        string finalOutput = "";
        var inputSplit = input.Split(" ");
        for(int i = 0; i < inputSplit.Length; i++)
        {
            finalOutput += char.ToUpper(inputSplit[i][0]) + inputSplit[i].Substring(1).ToLower();
        }
 
        return finalOutput;  
    }
}