class Program
{
    static void Main(string[] args)
    {
        var input = Console.ReadLine();
        Console.WriteLine(Vowels(input));
    }
    static int Vowels(string input)
    {
        int count = 0;
        foreach(char l in input)
        {
            if (l=='a' || l=='e' || l == 'o'|| l=='u' || l == 'i')
                count++;
        }
        return count;
    }

}