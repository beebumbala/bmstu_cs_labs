using System.Collections;

namespace Lab05.dictionary;

public class MyDictionary<TKey, TValue> : IEnumerable<KeyValuePair<TKey, TValue>>
{
    private TKey[] keys = new TKey[4];
    private TValue[] values = new TValue[4];
    private int count;

    public int Count => count;

    public TValue this[TKey key]
    {
        get
        {
            int index = IndexOf(key);
            if (index == -1)
                throw new Exception("key not found.");
            return values[index];
        }
        set
        {
            int index = IndexOf(key);
            if (index == -1)
                Add(key, value);
            else
                values[index] = value;
        }
    }
    public void Add(TKey key, TValue value)
    {
        if (IndexOf(key) != -1)
            throw new Exception("key already exists.");

        if (count == keys.Length)
        {
            Array.Resize(ref keys, keys.Length * 2);
            Array.Resize(ref values, values.Length * 2);
        }

        keys[count] = key;
        values[count] = value;
        count++;
    }

    private int IndexOf(TKey key)
    {
        for (int i = 0; i < count; i++)
            if (Equals(keys[i], key))
                return i;
        return -1;
    }

    public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator()
    {
        for (int i = 0; i < count; i++)
            yield return new KeyValuePair<TKey, TValue>(keys[i], values[i]);
    }

    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
}