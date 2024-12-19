using System.Collections;
using System.Linq;

namespace ExtendedDictionary;

public class ExtendedDictionary<T, U, V> : IEnumerable<ExtendedDictionaryElement<T, U, V>>
{
    private Dictionary<T, ExtendedDictionaryElement<T, U, V>> _dictionary;

    public ExtendedDictionary()
    {
        _dictionary = new Dictionary<T, ExtendedDictionaryElement<T, U, V>>();
    }

    public void Add(T key, U value1, V value2)
    {
        if (_dictionary.ContainsKey(key))
            throw new ArgumentException($"Key '{key}' already exists in the dictionary.");

        _dictionary[key] = new ExtendedDictionaryElement<T, U, V>(key, value1, value2);
    }

    public bool Remove(T key)
    {
        return _dictionary.Remove(key);
    }

    public bool ContainsKey(T key)
    {
        return _dictionary.ContainsKey(key);
    }

    public bool ContainsValue(U value1, V value2)
    {
        return _dictionary.Values.Any(elem => EqualityComparer<U>.Default.Equals(elem.Value1, value1) &&
                                                EqualityComparer<V>.Default.Equals(elem.Value2, value2));
    }

    public ExtendedDictionaryElement<T, U, V> this[T key]
    {
        get
        {
            if (!_dictionary.TryGetValue(key, out var element))
                throw new KeyNotFoundException($"Key '{key}' not found in the dictionary.");
            return element;
        }
    }

    public int Count => _dictionary.Count;

    public IEnumerator<ExtendedDictionaryElement<T, U, V>> GetEnumerator()
    {
        return _dictionary.Values.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}
