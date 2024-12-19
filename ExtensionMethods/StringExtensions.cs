namespace Extensions;

public static class StringExtensions
{
    public static string Reverse(this string str)
    {
        return new(str.ToCharArray().Reverse().ToArray());
    }

    public static int CountOccurrences(this string str, char ch)
    {
        return str.Count(c => c == ch);
    }
}
