public static class Solution
{
    public static void ShowNames(string names)
    {
        var splittedNames = names.Split(' ');

        switch(splittedNames.Length)
        {
            case 1: 
                Console.WriteLine($"{splittedNames[0]} likes your post"); 
                break;
            case 2: 
                Console.WriteLine($"{splittedNames[0]} and {splittedNames[1]} like your post"); 
                break;
            default:
                Console.WriteLine($"{splittedNames[0]}, {splittedNames[1]} and {splittedNames.Length - 2} others like your post");
                break;
         }
    }
}
