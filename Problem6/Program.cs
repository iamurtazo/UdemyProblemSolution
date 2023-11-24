class Program
{
    static void Main(string[] args)
    {
        string input;
        do
        {
            Console.WriteLine("Enter hyphen-separated numbers: ");
            input = Console.ReadLine();
            if(!input.Contains("-"))
                Console.WriteLine("Please enter hyphen-separated numbers!");
            

        } while(!input.Contains("-"));

        var result = IsConsecutive(input);
        Console.WriteLine(result);

        
    }
    static string IsConsecutive(string input)
    {
        string isConsecutive = "Consecutive";

        var inputSplitted = input.Split("-");
        var intArray = inputSplitted.Select(x => int.Parse(x)).ToArray();

        for(int i = 0; i < intArray.Length - 1; i++)
        {
            if(intArray[i] > intArray[i+1])
            {
                isConsecutive = "Not consecutive";
            }

        }
        return isConsecutive;
    }


}