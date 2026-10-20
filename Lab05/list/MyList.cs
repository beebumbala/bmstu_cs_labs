using System.Collections;

namespace Lab05.list;

public class MyList<T> : IEnumerable<T>
{
    private T[] items = new T[4];
    private int count;

    public int Count => count;

    public T this[int index]
    {
        get
        {
            if (index < 0 || index >= count)
                throw new Exception("index out of range");
            return items[index];
        }
        set
        {
            if (index < 0 || index >= count)
                throw new Exception("index out of range");
            items[index] = value;
        }
    }

    public void Add(T item)
    {
        if (count == items.Length)
            Array.Resize(ref items, items.Length * 2);

        items[count] = item;
        count++;
    }

    public IEnumerator<T> GetEnumerator()
    {
        for (int i = 0; i < count; i++)
            yield return items[i];
    }

    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
}