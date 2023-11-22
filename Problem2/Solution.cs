public class Solution
{
    public static string ReverseString(string s)
    {
        var reversedName = s.ToCharArray();
        Array.Reverse(reversedName);
        return string.Join("", reversedName);
    }
}