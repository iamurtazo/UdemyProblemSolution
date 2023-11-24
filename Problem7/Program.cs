using System.Drawing;

class Program
{
    static void Main(string[] args)
    {
        string input;
        
        do
        {
            input = Console.ReadLine();
            if(string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Exit");
                return;
            }   
            else if (!input.Contains("-"))
                Console.WriteLine("Please hyphen-separated input");
            
        } while (!input.Contains("-"));

        DuplicateExit(input);
        
    }
    static void DuplicateExit(string input)
    {
       bool containsDuplicate = false;

        var intStrArr = input.Split("-");
        var intArr = intStrArr.Select(x => int.Parse(x)).ToArray();

        for(int i = 0; i < intArr.Length - 1; i++)
        {
            int occ = 0;
            for (int j = i + 1; j < intArr.Length; j++)
            {
                if(intArr[i] == intArr[j])
                    occ++;
            }
            if(occ == 1)
            {
                containsDuplicate = true;
                break;
            }    
        }
        if(containsDuplicate) Console.WriteLine("Duplicate");
        else Console.WriteLine("No duplicate");
    }
}