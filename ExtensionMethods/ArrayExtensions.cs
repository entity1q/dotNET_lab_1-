namespace Extensions;

public static class ArrayExtensions
{
    public static int CountOccurrences<T>(this T[] array, T value) where T : IEquatable<T>
    {
        return array.Count(element => element.Equals(value));
    }

    public static T[] GetUniqueElements<T>(this T[] array) where T : IEquatable<T>
    {
        return array.Distinct().ToArray();
    }
}
