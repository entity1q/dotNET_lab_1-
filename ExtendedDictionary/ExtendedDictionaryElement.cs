namespace ExtendedDictionary;

public class ExtendedDictionaryElement<T, U, V>(T key, U value1, V value2)
{
    public T Key { get; } = key;
    public U Value1 { get; } = value1;
    public V Value2 { get; } = value2;
}